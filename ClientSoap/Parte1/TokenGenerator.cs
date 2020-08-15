using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace ClientSoap.Parte1
{
    public class TokenGenerator
    {
        public string WebServiceBaseUrl { get; set; }
        private string Tuser { get; set; }
        private string Tpass { get; set; }
        byte[] byteArray { get; set; }


        public TokenGenerator()
        {
            this.WebServiceBaseUrl = "";
            this.Tuser = "sa";
            this.Tpass = "usac";
            this.byteArray = new UTF8Encoding().GetBytes(Tuser + ":" + Tpass);
        }

        public async Task<Tout> PostWS<Tin, Tout>(string urlMetodo, Tin datosPorEnviar)
        {
            Tout respuesta = default(Tout);
            //using (var client = new HttpClient())
            //{

            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            //    HttpResponseMessage response;
            //    try
            //    {

            //        response = await client.PostAsync(WebServiceBaseUrl + urlMetodo);
            //        if (response.IsSuccessStatusCode)
            //        {
            //            respuesta = await response.Content.ReadAsAsync<Tout>();
            //        }
            //        else
            //        {
            //            var error = await response.Content.ReadAsStringAsync();
            //            throw new HttpRequestException(error);
            //        }

            //        var a = client
            //    }
            //    catch (HttpRequestException e)
            //    {
            //        // Handle exception.                    

            //        throw;
            //    }
            //    catch (Exception ex)
            //    {
            //        // Handle exception.

            //        throw;
            //    }
            //}

            return respuesta;
        }

    }
}
