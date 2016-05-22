using System;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Moq;
// using NUnit.Framework;
using System.Linq;
using SystemWrapper.IO;
using Rhino.Mocks;
using System.IO;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class NodeWriterTests
    {
        private readonly IFileInfoWrap _fileInfoWrap = MockRepository.GenerateStub<IFileInfoWrap>();
        private readonly IStreamWriterWrap _streamWriterWrap = MockRepository.GenerateStub<IStreamWriterWrap>();
        private const string FILE_PATH = "C:\\ejbaling\\eCargo\\result.txt";
        private MemoryStream _memoryStream;

        [TestInitialize]
        public void Setup()
        {
            _memoryStream = new MemoryStream();
            var sw = new StreamWriter(_memoryStream, Encoding.UTF8, 512, true);
            sw.AutoFlush = true;

            _streamWriterWrap.Stub(x => x.StreamWriterInstance).Return(sw);
            _fileInfoWrap.Stub(x => x.CreateText()).Return(_streamWriterWrap);
        }

        [TestMethod]
        public void Given_NoChildrenNode_WhenIWriteToFile_ThenReturnedResultContainsWrittenText()
        {
            var nodeWriter = new NodeWriter();
            nodeWriter.WriteToFileAsync(new NoChildrenNode("root"), _fileInfoWrap);
            _memoryStream.Position = 0;
            var sr = new StreamReader(_memoryStream);
            var result = sr.ReadToEnd();

            string[] source = result.Split(new char[] { ' ', ',', '(', ')', '"' }, StringSplitOptions.RemoveEmptyEntries);

            var searchTerm = "root";
            var matchQuery = from word in source
                             where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                             select word;

            Assert.IsTrue(matchQuery.Count() == 1);
        }
    }
}
