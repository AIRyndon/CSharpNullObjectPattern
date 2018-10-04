using System;

namespace CSharpNullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var real = new RealImplementation();
            var nullObject = new NullImplementation();

            //Client code using a real implementation and a null implementation
            var usingReal = new ClientCode(real);
            var usingNull = new ClientCode(nullObject);
            Console.ReadLine();
        }
    }
}
