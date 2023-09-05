
using design_patterns.Template;

//Template design pattern 
//Mixture of concrete and abstract class
// The concrete class stands as the template while the abstract class can be overidden.

var transfer = new TransferMoneyTask();
transfer.Execute();

//Result from console
//Audit
//Transfer money

var generateReport = new GenerateReportTask();
generateReport.Execute();

//Result from console
//Audit
//Generate Report