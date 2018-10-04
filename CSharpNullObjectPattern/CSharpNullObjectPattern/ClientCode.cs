using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNullObjectPattern
{
    public class ClientCode
    {
        public void DoSomething(ISampleAbstraction abstraction)
        {
            abstraction.SampleMethod();
        }
    }
}
