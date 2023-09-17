using design_patterns.Adapter;
using design_patterns.Adapter.ThirdPartyFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
    public class CaramelAdapter : Caramel, Filter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}
//Adapter design Pattern
//Used in situation where interface of a class does not match the interface we expect


//using design_patterns.Adapter;
//using design_patterns.Adapter.ThirdPartyFilter;

//var imageView = new ImageView(new Image());
//imageView.Apply(new VividFilter());

//Console Result 
//Applying Vivid Filter

//imageView.Apply(new Caramel() ) This does not match the interface so throws an error
//imageView.Apply(new CaramelFilter()); // CaramelFilter converts the interface to the expected interface  // Composition is used here

//Console Result 
//Applying Caramel Filter


//imageView.Apply(new CaramelAdapter()); //Inheritance is used for the adapter here but Composition is better

//Console Result 
//Applying Caramel Filter
