using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ClientSoap.Client
{
    public class ClientSOAP
    {
        SoftwareAvanzadoAuth.administratorcontact100Client client = null;
        
        //private string ClientSecret = null;

        public ClientSOAP()
        {
            client = new SoftwareAvanzadoAuth.administratorcontact100Client();
            client.ClientCredentials.UserName.UserName = "sa";
            client.ClientCredentials.UserName.Password = "usac";
        }

        /// <summary>
        /// Obtiene los contactos que se encuentren por el filtro aplicado
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>List con los contactos encontrados</returns>
        public List<ContactoModel> GetContacts(ContactoModel filter)
        {
            List<ContactoModel> result = new List<ContactoModel>();
            using (new OperationContextScope(client.InnerChannel))
            {
                // Add a HTTP Header to an outgoing request
                string auth = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(client.ClientCredentials.UserName.UserName + ":" + client.ClientCredentials.UserName.Password));
                HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                requestMessage.Headers["Authorization"] = auth;
                OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
               // client.GetCampaignIds(out campaignRecords);

                SoftwareAvanzadoAuth.readListResponse_list_item[] resultWS = null;
                resultWS = client.readList(0, 50, filter.Nombre, null, null, null, null);

                if (resultWS != null && resultWS.Length >= 0)
                {
                    for (int i = 0; i < resultWS.Length; i++)
                    {
                        result.Add(new ContactoModel()
                        {
                            Id = resultWS[i].id,
                            Nombre = resultWS[i].name
                        });
                    }
                }
            }
            
            return result;
        }

        /// <summary>
        /// Envia un set de contactos nuevos
        /// </summary>
        /// <param name="data">...</param>
        /// <returns>List con los contactos encontrados</returns>
        public ResponseWS SentContacts(ContactoModel data)
        {
            ResponseWS result = new ResponseWS()
            {
                status = false,
                message = ""
            };

            int CantidadEnviados = 0;
            for(int i=0; i<data.Cantidad; i++)
            {
                using (new OperationContextScope(client.InnerChannel))
                {
                    string auth = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(client.ClientCredentials.UserName.UserName + ":" + client.ClientCredentials.UserName.Password));
                    HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                    requestMessage.Headers["Authorization"] = auth;
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
                    // client.GetCampaignIds(out campaignRecords);

                    SoftwareAvanzadoAuth.readListResponse_list_item[] resultWS = null;
                    result.status = client.create(data.Nombre + "__" + i, 0, "", 0);
                    if (result.status) CantidadEnviados++;
                }
            }

            if (data.Cantidad == CantidadEnviados)
            {
                result.message = string.Format("Se crearon {0} contatos con exito", CantidadEnviados);
                result.status = true;
            }
            else
            {
                result.message = string.Format("Unicamente se pudieron crear {0} contatos con exito", CantidadEnviados);
                result.status = false;
            }
            return result;
        }
    }
}
