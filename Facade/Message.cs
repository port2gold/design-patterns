﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Facade
{
    public class Message
    {
        private  string content;

        public Message(string content)
        {
            this.content = content;
        }

        public string GetContent()
        { 
            return content; 
        }

    }
}
