﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Visitor
{
    public interface HtmlNode
    {
        void Visit(Visitor visitor);
    }
}
