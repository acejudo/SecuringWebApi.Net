# SecuritingWebApi.Net

This solution shows how apply in a WebApi:

  - APIKey
  - APIKey + Authorize
  - APIKey + Authorize + IpAuthorize

You can also:
  - Use a SoapUi proyect. Xml in SoapUi -> Securiting-WebApi-soapui-project.xml

### APIKey
APIKey in the header.
Code in MessageHandlers -> APIKEYHandler
### Auhtorize
With ASCII. username and password.
Code in MessageHandlers -> AuthHandler
#### IpAuthorize
Verify Ip
Code in CustomAttribute -> RestrictIpsAttribute








See [Reference](http://code.tutsplus.com/tutorials/securing-aspnet-web-api--cms-26012)
