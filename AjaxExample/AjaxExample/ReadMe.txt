Invoke Index.cshtml inside Views\Test

Purpose :
1. show simple ajax (based on https://www.youtube.com/watch?v=qqRiDlm-SnY) consumed by controller

	GET Controller\Action -> Test\AjaxRawJs which retuen _GetScorePartial.cshtml with 3 random scrores

	View -> Index.cshtml there you have button "Get scores using AJAX" which access Test\AjaxRawJs using ajax

	getScores() -> java script which is invoked by "Get scores using AJAX" onclick and use XMLHttpRequest :
		- open("GET", "/Test/AjaxRawJs");
		- send()
		- readyState
		- status
		- onreadystatechange
		- responseText

		Notice that raw url is used as follows "/Test/AjaxRawJs"

2. same as 1) but here we have form with number of requested scores as input - ScoresNum, also here we use POST

	POST Controller\Action -> Test\AjaxRawJsInForm which retuen _GetScorePartial with ScoresNum random scrores

	View -> Index.cshtml there you have button "Get scores using form & AJAX" which access Test\AjaxRawJsInForm using ajax

	submitFormAjax -> java script which is invoked by "Get scores using form & AJAX" overide 
						the form onsubmit and use XMLHttpRequest :

		- open(form.method, form.action)
		- send(new FormData(form))
		- readyState
		- status
		- onreadystatechange
		- responseText

		and we have here also
		e.preventDefault()
		e.stopImmediatePropagation()



3. add form validation as done in BeginForm

	same as 2) but here i use Html.BeginForm with validation . ajax is used as in 1),2) but here i add also :
	loading indication and sucess \ failure alert (bootstrap)

	BeginForm is easy with respect to following :
	- no need to provide url , instead give action and controller

	validation requires :
		- add @Scripts.Render("~/bundles/jqueryval") in Viewa\Shared\_Layout.cshtml
		- Install-Package  Microsoft.jQuery.Unobtrusive.Ajax  (in Package Manager Console)
		  Add  <script src="~/Scripts/jquery.unobtrusive-ajax.min.js"></script> to _Layout.cshtml 
		  (may be do it in more elegant way) as follows

	PROBLEM - click "Get scores using BeginForm & AJAX" after form load while "Number of scores" is empty. 
				problem is that you do NOT see validation error even when you have
				@Html.ValidationMessageFor(m => m.ScoresNum, "", new { @class = "text-danger" })

	SOLUTION - add $(form).valid() to the submit method - submitFormAjax


Remarks
	Ajax.BeginForm does not work properly with file upload , this is why i need to use XMLHttpRequest.

	to upload file you need :
	- input tag with type file
	- add attribute enctype = "multipart/form-data"


4. same as 3) but here i use Ajax.BeginForm
