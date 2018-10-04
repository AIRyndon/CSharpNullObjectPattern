using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNullObjectPattern
{
    public class NullImplementation : ISampleAbstraction
    {
        public void SampleMethod()
        {
            Console.WriteLine("Hello I'm the null implementation");
        }
    }
}
