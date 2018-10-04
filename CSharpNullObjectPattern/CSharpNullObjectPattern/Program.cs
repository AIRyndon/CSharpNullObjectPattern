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
            var client = new ClientCode();
            client.DoSomething(real);
            client.DoSomething(nullObject);
            Console.ReadLine();
        }
    }
}
