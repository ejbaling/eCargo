using System;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
// using NUnit.Framework;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class NodeTransformerTests
    {
        [TestMethod]
        public void Given_NoChildrenNode_ThenReturnOneNode()
        {
            var transformer = new NodeTransformer();
            var result = transformer.Transform(new ManyChildrenNode("leaf"));

            var searchTerm = "leaf";

            string[] source = result.Split(new char[] { ' ', ',', '(', ')', '"' }, StringSplitOptions.RemoveEmptyEntries);

            var matchQuery = from word in source
                             where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                             select word;

            Assert.IsTrue(matchQuery.Count() == 1);
        }

        [TestMethod]
        public void Given_SingleChildNode_ThenReturnTwoNodes()
        {
            var transformer = new NodeTransformer();
            var result = transformer.Transform(new ManyChildrenNode("root", new ManyChildrenNode("leaf")));

                        string[] source = result.Split(new char[] { ' ', ',', '(', ')', '"' }, StringSplitOptions.RemoveEmptyEntries);

            var searchTerm = "root";
            var matchQuery = from word in source
                             where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                             select word;

            Assert.IsTrue(matchQuery.Count() == 1);

            searchTerm = "leaf";
            matchQuery = from word in source
                             where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                             select word;

            Assert.IsTrue(matchQuery.Count() == 1);
        }

        [TestMethod]
        public void Given_TwoChilrenNode_ThenReturnThreeNodes()
        {
            var transformer = new NodeTransformer();
            var result = transformer.Transform(new ManyChildrenNode("root", new ManyChildrenNode("leaf1"), new ManyChildrenNode("leaf2")));

            string[] source = result.Split(new char[] { ' ', ',', '(', ')', '"' }, StringSplitOptions.RemoveEmptyEntries);

            var searchTerm = "root";
            var matchQuery = from word in source
                             where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                             select word;

            Assert.IsTrue(matchQuery.Count() == 1);

            searchTerm = "leaf1";
            matchQuery = from word in source
                         where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                         select word;

            Assert.IsTrue(matchQuery.Count() == 1);

            searchTerm = "leaf2";
            matchQuery = from word in source
                         where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                         select word;

            Assert.IsTrue(matchQuery.Count() == 1);
        }
    }
}
