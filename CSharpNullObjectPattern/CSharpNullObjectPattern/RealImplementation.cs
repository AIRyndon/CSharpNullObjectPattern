﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNullObjectPattern
{
    public class RealImplementation : ISampleAbstraction
    {
        public void SampleMethod()
        {
            Console.WriteLine("Hello I'm the real implementation");
        }
    }
}
