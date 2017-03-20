how to do validation :
----------------------

	- what you get from Controller->New Scaffolded item :
		- @Html.ValidationSummary(true, "", new { @class = "text-danger" }) 
			- one in view
			- if first arguemnt is false then all validation error will appear also here
		
		- @Html.ValidationMessageFor
			- one per model property in view
			- e.g. for Name property : @Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }) 

		- ModelState.AddModelError
			- in controller action
			- e.g. ModelState.AddModelError(string.Empty, "Student Name already exists."); will add
				error in @Html.ValidationSummary
			- ModelState.AddModelError("CustomError", "some custom error"); will add error in
				@Html.ValidationMessage("CustomError", new { @class = "text-danger" })

		- Model has e.g. [Required] attribute

		remarks :
			- validation is checked first on client then on server using ModelState.IsValid

			- Html.ValidationSummary is translated into data-val* HTML attribute. looking 
			  at jquery.validate.unobtrusive.js for data-val and you will see that it relate
			  to parseElement(element, skipAttach) -> validationInfo(form) -> onError(error, inputElement) 
			  which issue validation errors


How to issue validation errors :
------------------------------
- run the application and navigate to http://localhost:62190/Books/Create
- click Create button with empty text box and this will issue the error "The Name field is required" 
- click Create button with 1 text box and this will issue the error "Book name must start with capital letter" 
- click Create button with A text box and this will issue no error (it will navigate to Books\Index)


reference :
----------------------
	- http://rachelappel.com/2015/03/15/asp-net-mvchow-data-annotations-for-asp-net-mvc-validation-work/