Functionality :
-------------
server has UsersController with Register and Login both return Token but it is half baked
	
client has two components :
	- both are shown when user is not logged 
	- one is shown if user is logged in


Model : 
-----
User :  Id , Name , Password , Name




Architecture :
------------
Server : ASP.Net Web API + Entity Framework Code first on MS SQL Server
Client : Angular 2


Remarks :
-------


ToDO :
-------
- i have model for roles but did not implemented it
- use JWT as token