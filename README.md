`Practica #1`
=================

### Que es?
Herramienta `Cliente SOAP` utilizado para consumir [servicio web](https://api.softwareavanzado.world/index.php?webserviceClient=administrator&webserviceVersion=1.0.0&option=contact&api=hal&format=doc). Los metodos implementados son:

* [`Create`](https://api.softwareavanzado.world/index.php?webserviceClient=administrator&webserviceVersion=1.0.0&option=contact&api=hal&format=doc#create)
* [`Read list`](https://api.softwareavanzado.world/index.php?webserviceClient=administrator&webserviceVersion=1.0.0&option=contact&api=hal&format=doc#read-list)

### Como utilizarlo
* `ClienteSOAP.cs`
```C#
public List<ContactoModel> GetContacts(ContactoModel filter)
{
    List<ContactoModel> result = new List<ContactoModel>();
    SoftwareAvanzado.readListResponse_list_item[] resultWS = null;            
    resultWS = client.readList(0, 50, filter.Nombre,null,null,null,null);

    if (resultWS != null && resultWS.Length >= 0)
    {
        for(int i=0;  i < resultWS.Length; i++)
        {
            result.Add(new ContactoModel()
            {
                Id = resultWS[i].id,
                Nombre = resultWS[i].name
            });
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
