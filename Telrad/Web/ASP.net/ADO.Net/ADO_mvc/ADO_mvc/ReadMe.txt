﻿small MVC project with data base as storage

data base is SQL Server

MVC uses ADO.Net to read\write vs the database

data base Database1 resides under App_Data as Database1.mdf
Database1 has one table - Table1 with 3 coulmns :
	- Id which is primery key auto incremented
	- FirstName
	- LastName

Database should be created under App_Data :
	- Mark this directory inside the visual studio project
	- right click Add New
	- Installed->Visual C#->Data->SQL Server Database
	- change name below to Database1.mdf

View Index :
	- show the table Table1 as table element
	- provide form to add new user to the data base


