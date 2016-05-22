using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemWrapper.IO;

namespace ConsoleApplication1
{
    public class NodeWriter : NodeBase, INodeWriter
    {
        public Task WriteToFileAsync(Node node, string filePath)
        {
            CreateFileLocation(filePath);

            var fileInfo = new FileInfo(filePath);
            return WriteToFileAsync(node, new FileInfoWrap(fileInfo));
        }

        public Task WriteToFileAsync(Node node, IFileInfoWrap fileInfoWrap)
        {
            var streamWriterWrap = fileInfoWrap.CreateText();
            using (StreamWriter writer = streamWriterWrap.StreamWriterInstance)
            {
                var text = GetFormat(node.GetType(), node);
                return writer.WriteAsync(text);
            }
        }

        public void CreateFileLocation(string filePath)
        {
            var words = filePath.Split('\\').ToList();

            var drive = words.First();
            words.Remove(drive);

            var file = words.Last();
            words.Remove(file);

            var path = drive + "\\";
            foreach (var e in words)
            {
                path += "\\";
                path += e;
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }

            path += "\\";
            path += file;
            if (!File.Exists(path))
                File.Create(path);
        }
    }
}
