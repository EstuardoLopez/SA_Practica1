`Practica #1`
=================

### Que es?
Herramienta `Cliente SOAP` utilizado para consumir [servicio web](https://api.softwareavanzado.world/index.php?webserviceClient=administrator&webserviceVersion=1.0.0&option=contact&api=hal&format=doc). Los metodos implementados son:

* [`Create`](https://api.softwareavanzado.world/index.php?webserviceClient=administrator&webserviceVersion=1.0.0&option=contact&api=hal&format=doc#create)
* [`Read list`](https://api.softwareavanzado.world/index.php?webserviceClient=administrator&webserviceVersion=1.0.0&option=contact&api=hal&format=doc#read-list)

### Como utilizarlo
* `ClienteSOAP.cs`
```C#

public ClientSOAP()
{
    client = new SoftwareAvanzadoAuth.administratorcontact100Client();
    //Usuario 
    client.ClientCredentials.UserName.UserName = "sa";
    //Contraseña
    client.ClientCredentials.UserName.Password = "usac";
}
        
public List<ContactoModel> GetContacts(ContactoModel filter)
{
    List<ContactoModel> result = new List<ContactoModel>();
    using (new OperationContextScope(client.InnerChannel))
    {
        // Agregamos un HTTP Header a la peticion donde especificamos el tipo de autenticacion
        string auth = "Basic " + Convert.ToBase64String(System.Text.Encoding.Default
        .GetBytes(client.ClientCredentials.UserName.UserName + ":" + client.ClientCredentials.UserName.Password));
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
```

* `Form1.cs`
```C#

private void BuscarDatos(ContactoModel filter)
{
    TxtResult.Clear();
    List<ContactoModel> lista = clientSoap.GetContacts(filter);
}
