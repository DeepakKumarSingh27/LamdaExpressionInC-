﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    public class Persons
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public Persons(string SSN, string Name, string Address,int Age)
        {
            this.SSN = SSN;
            this.Name = Name;
            this.Address = Address; 
            this.Age = Age;
        }
    }
}
