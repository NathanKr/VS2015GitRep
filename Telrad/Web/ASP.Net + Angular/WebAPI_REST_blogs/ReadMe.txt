Functionality :
-------------
client allow adding blogs , show list of blogs and ability to delete or edit each per row


Model : 
-----
Blog : Title , Description , Id
Post : Title , Content , BlogId , Id



Architecture :
------------
Server : ASP.Net Web API + Entity Framework Code first on MS SQL Server
Client : Angular 2


Remarks :
- i have used  the following to allow access from client to server on the same machine
	var cors = new EnableCorsAttribute("*", "*", "*");
        config.EnableCors(cors);

ToDO :
-----
- doing same as to Posts -> left as an excersize
- errors are written to console but this lack visual indication -> left as an excersize