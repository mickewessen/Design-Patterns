﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Cat:ICat
    {
        public Cat(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
