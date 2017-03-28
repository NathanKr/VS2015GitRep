CAUTION : this might can help you to auotomate what you do as client not as merchant. 
for merchant one need BuyNow. so currently i do not complate the code because you have samples at 
reference 1) below


steps :

1) install SDK : PM> Install-Package PayPal (https://github.com/paypal/PayPal-NET-SDK/wiki/Installation-NuGet)

2) To integrate our application with PayPal, we need to navigate to 
	https://developer.paypal.com/ then click Dashboard then under "REST API apps" you will see a button "Create App"
	so click on it. and you will see there :
		- client id
		- secret

3) configure the SDK (https://github.com/paypal/PayPal-NET-SDK/wiki/Configuration) this requires 
	change in web.config + replacement of 
	__CLIENT_ID__ with 2) client id (which you got above)
	__CLIENT_SECRET__ with 2) secret (which you got above)

	notice that <paypal>-><settings><add name="mode" value="sandbox" /> is sandbox
	 but in production this should be changed to <add name="mode" value="live" />  !!!!!!

	---------> how to do it autmatically ???

4) make API call
	a. authenticate :

	using PayPal.Api;

	// Get a reference to the config
	var config = ConfigManager.Instance.GetProperties();

	// Use OAuthTokenCredential to request an access token from PayPal
	var accessToken = new OAuthTokenCredential(config).GetAccessToken();

	b. Configure an APIContext Object :

	var apiContext = new APIContext(accessToken);

	// Initialize the apiContext's configuration with the default configuration for this application.
	apiContext.Config = ConfigManager.Instance.GetProperties();

	// Define any custom configuration settings for calls that will use this object.
	apiContext.Config["connectionTimeout"] = "1000"; // Quick timeout for testing purposes

	// Define any HTTP headers to be used in HTTP requests made with this APIContext object
	if(apiContext.HTTPHeaders == null)
	{
	  apiContext.HTTPHeaders = new Dictionary<string, string>();
	}
	apiContext.HTTPHeaders["some-header-name"] = "some-value";


	c. Make an SDK Call
	var payment = Payment.Get(apiContext, "PAY-0XL713371A312273YKE2GCNI");


--------------------------------------------

references :
	1) PayPal source code sample is under https://github.com/paypal/PayPal-PHP-SDK
	2) code sample of some developer https://www.codeproject.com/articles/870870/using-paypal-rest-api-with-asp-net-mvc



