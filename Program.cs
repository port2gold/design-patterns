//Facade design pattern 
//Use to provide simple interface to a complex system.

//it reduces coupling

using design_patterns.Facade;
using System.ComponentModel.DataAnnotations;

//var server = new NotificationServer();
//var connection = server.Connect("ip");
//var authToken = server.Authenticate("appId", "key");
//var message = new Message("Hello World");
//server.Send(authToken, message, "target");




//Facade implementation wraps and on call is made
var notification = new NotificationService();
notification.Send("Hello World", "target");
