
//Chain Of Responsibility Design Pattern:

// Authenticator   ->     logger  -> Compressor

using design_patterns.ChainOfResponsibility;


var compressor = new Compressor(null);
var logger =  new Logger(compressor);
var authenticator = new Authenticator(logger);
var server = new WebServer(authenticator);
server.Handle(new HttpRequest("admin", "1234"));


//Console Result 

//Authentication
//Logging
//Compress



