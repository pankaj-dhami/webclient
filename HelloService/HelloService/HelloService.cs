﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloService
{
    public class HelloService : IHelloService
    {
        public string Hello(string name)
        {
            return "Hello " + name;
        }
    }
}
