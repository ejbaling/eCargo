using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            p.Describe();

            Console.ReadLine();
        }

        private void Describe()
        {
            var implementation = new NodeDescriber();

            var testData = new SingleChildNode("root",
                 new TwoChildrenNode("child1", new NoChildrenNode("leaf1"), new SingleChildNode("child2", new NoChildrenNode("leaf2"))));

            var result = implementation.Describe(testData);
            Console.WriteLine(result);
        }
    }
}
