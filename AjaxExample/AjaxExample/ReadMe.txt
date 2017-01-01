Purpose :
1. show simple ajax (based on https://www.youtube.com/watch?v=qqRiDlm-SnY) consumed by controller

	Controller\Action -> Test\AjaxRawJS which retuen _GetScorePartial.cshtml with random scrores
	View -> Index.cshtml there you have button "Get scores from server using AJAX" which access Test\AjaxRawJS
	getScores() -> java script which is invoked by button onclick and use XMLHttpRequest :
		- open
		- send
		- readyState
		- status
		- onreadystatechange
		- responseText

2. send form using ajax with text inputs which is consumed by controller
3. add form validation as done in asp.net mvc
4. add file upload to the form
5. add ajax response - partial view to insert in current view