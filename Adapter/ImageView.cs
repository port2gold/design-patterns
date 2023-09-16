using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
    public class ImageView
    {
        private Image image;


        public ImageView(Image image)
        {
            this.image = image;
        }

        public void Apply(Filter filter)
        {
            filter.Apply(image);
        }
    }
}
