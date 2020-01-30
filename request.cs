var header = new WebserviceNL.HeaderLoginType();
header.username = "xxx";
header.password = "xxx";

var binding = new BasicHttpBinding();
binding.Security.Mode = BasicHttpSecurityMode.Transport;

var auth = new WebserviceNL.HeaderAuthenticateType();
var client = new WebserviceNL.WebservicesnlPortTypeClient(binding, new EndpointAddress("https://ws1.webservices.nl:443/soap_doclit.php"));

WebserviceNL.DutchBusinessEstablishmentReferencePagedResult result = client.dutchBusinessSearch(header, ref auth, null, null, "city", "street", null, 1, null, null, null, true, 0);
