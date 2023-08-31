using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.State
{
    //State is a design pattern that allows your code to behave differently based on different state.
    public class Canva 
    {
        private Tool toolType;

        public Canva(Tool toolType)
        {
            this.toolType = toolType;
        }

        public void SetToolType(Tool toolType)
        {
            this.toolType = toolType;
        }

        public void MouseUp()
        {
            toolType.MouseUp();
        }

        public void MouseDown()
        {
            toolType.MouseDown();
        }
    }
}
