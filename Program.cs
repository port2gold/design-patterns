
using design_patterns.Observer;
//Observer Design pattern
//The push style of communication
//The pull style of communcation
var dataSource = new DataSource();
var sheet1 = new SpreadSheet(dataSource);
var sheet2 = new SpreadSheet(dataSource);
var chart1 = new Chart(dataSource);
var chart2 = new Chart(dataSource);

dataSource.AddObserver(sheet1);
dataSource.AddObserver(sheet2);
dataSource.AddObserver(chart1);
dataSource.AddObserver(chart2);


dataSource.SetValue(2);

//Console Result 
//Spread sheet was updated with value of 2
//Spread sheet was updated with value of 2
//Chart was updated with value of 2
//Chart was updated with value of 2