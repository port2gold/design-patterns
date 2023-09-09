﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Mediator
{
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }
}
