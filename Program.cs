
//Mediator design Pattern
using design_patterns.Mediator;

var dialog = new ArticlesDialogBox();
dialog.SimulateUserInteraction();

//Console Result When textbox is not empty and the button knows about it.
//TextBox: Article 2
//Button: True


//Console Result when text box is empty Button knonws and it is disabled
//TextBox:
//Button: False