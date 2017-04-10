Functionality :
-----------------
This is currently mostly client side , it support automatic test.
Test is composed of few questions with few answers per question(one of them is correct) 
Test results appears in terms of number of correct answers and pass \ failed test


Technical :
-------------
Point of interest :
The list from server is consumed in client java script code via @Html.Raw(Json.Encode(Model))

Server is very primitive :
	- Index controller is used
	- list of question and answers is "hard code" in action Index()



Technologies :
	- client : css , javascript , html , a bit of jquery
	- server : asp.net mvc


Future improvments :
---------------------
server :
	- dedicated controller : AutoTest with matching CRUD  actions and views using scafolded
	- use entity framework code first
	- support AutoTest enrollment (for user\password authentication)


client :
	- indication for correct \ not correct answer in result
	- put qa in bootstrap panel
	- do not allow radio button selection change
	- collapsable bootstrap result
	- use ajax to get questions on start and ajax to get answers on end (so it will not be in html) 
		this will require also server side code 


