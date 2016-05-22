using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
            p.Transform();
            p.Write();

            Console.ReadLine();
        }

        private void Describe()
        {
            var implementation = new NodeDescriber();

            var testData = new SingleChildNode("root",
                 new TwoChildrenNode("child1", new NoChildrenNode("leaf1"), new SingleChildNode("child2", new NoChildrenNode("leaf2"))));

            var result = implementation.Describe(testData);
            Console.WriteLine("Node describer result:\n");
            Console.WriteLine(result);
        }

        private void Transform()
        {
            var implementation = new NodeTransformer();

            var testData = new ManyChildrenNode("root",
                new ManyChildrenNode("child",
                    new ManyChildrenNode("leaf1"),
                    new ManyChildrenNode("child2",
                        new ManyChildrenNode("leaf2"))));

            var result = implementation.Transform(testData);
            Console.WriteLine("\nNode transformer result:\n");
            Console.WriteLine(result);
        }

        private async void Write()
        {
            var implementation = new NodeWriter();

            var testData = new NoChildrenNode("root");

            var filePath = ConfigurationManager.AppSettings.Get("filePath");

            await implementation.WriteToFileAsync(testData, filePath);

            var result = File.ReadAllText(filePath);
            Console.WriteLine("\nNode writer result:\n");
            Console.WriteLine(result);
        }
    }
}
