using System;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
// using NUnit.Framework;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class NodeDescriberTests
    {
        // private readonly Mock<INodeDescriber> _describer;

        [TestMethod]
        public void Given_NoChildrenNode_ThenReturnOneNode()
        {
            var describer = new NodeDescriber();
            var result = describer.Describe(new NoChildrenNode("leaf"));

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
            var describer = new NodeDescriber();
            var result = describer.Describe(new SingleChildNode("root", new NoChildrenNode("leaf")));

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
            var describer = new NodeDescriber();
            var result = describer.Describe(new TwoChildrenNode("root", new NoChildrenNode("leaf1"), new NoChildrenNode("leaf2")));

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
