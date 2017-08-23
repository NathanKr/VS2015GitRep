This is an MVC project with Entitiy Framework as ORM using Code First approach

Models is composed of Blog.cs and Post.cs with relation to each other

The purpose is to show how tables and classes are created automatically follwing :
	- Add-Migration
	- Update-Database

I have implemented Create\Read actions for one controller to show how one can access 
	tables and perform operations on them


I have done BlogController with Index and Create Actions and matching Views 
	(although view are not the issue here because EF is Backhand issue not Fronthand)

Blogs list are accessible via Home/Index 
Add Blog is possible from Blogs/Index


Remarks :
- i have used "User Authentication" on project creation not because i need but because it give 
	smoother setup for Entity Framework
- i did not pay attension to styling because this is not the point in this project
- i did not pay attension to Html Helper because this is not the point in this project