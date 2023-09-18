using design_patterns.Decorator;

namespace design_patterns.Decorator
{
    public interface Stream
    {
        void Write(string stream);
    }
}


//Decorator Design Pattern
//We can add addition behavior to an existing object.

//using design_patterns.Decorator;

//void StoreCreditCard(design_patterns.Decorator.Stream stream)
//{
//    stream.Write("1234-5455-54545");
//}

//StoreCreditCard(new CloudStream());

//Console Result     

//Data: 1234 - 5455 - 54545      //Data is in plain text 


//StoreCreditCard(new EncryptedCloudStream(new CloudStream()));

//Console Result 

//Data: @$%^&*((($%                     // A new behavior has been added to this implementation 



//StoreCreditCard(new CompressCloudStream(new CloudStream()));

//Console Result 

//Data: 1234-                         //A different behavior of compression has been added to the implentation




//StoreCreditCard(new CompressCloudStream(new EncryptedCloudStream(new CloudStream())));


//Console Result 

//Data: @$% ^&*((($%                 // Two diffrent behavior was added to the data // Encryption and then compression.