//Singleton Design Pattern 
//Used where you want to have a single instance of a class

using design_patterns.Singleton;

//ConfigManager manager = new ConfigManager();
//manager.Set("name", "kabir");

//ConfigManager other = new ConfigManager();
//Console.WriteLine(other.Get("name"));

//Null is returned in this case


ConfigManager manager =  ConfigManager.GetInstance();
manager.Set("name", "kabir");

ConfigManager other = ConfigManager.GetInstance();
Console.WriteLine(other.Get("name"));

//Console Result 

//kabir