using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using SystemWrapper.IO;

namespace ConsoleApplication1
{
    public class StreamWriterWrap : IStreamWriterWrap
    {
        private readonly StreamWriter _writer;

        public StreamWriterWrap(StreamWriter writer)
        {
            _writer = writer;
        }

        public bool AutoFlush
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Stream BaseStream
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Encoding Encoding
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IFormatProvider FormatProvider
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string NewLine
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public StreamWriter StreamWriterInstance
        {
            get
            {
                return _writer;
            }
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public ObjRef CreateObjRef(Type requestedType)
        {
            throw new NotImplementedException();
        }

        public void Flush()
        {
            throw new NotImplementedException();
        }

        public void Initialize(string path)
        {
            throw new NotImplementedException();
        }

        public void Initialize(Stream stream)
        {
            throw new NotImplementedException();
        }

        public void Initialize(StreamWriter streamWriter)
        {
            throw new NotImplementedException();
        }

        public void Initialize(string path, bool append)
        {
            throw new NotImplementedException();
        }

        public void Initialize(Stream stream, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public void Initialize(string path, bool append, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public void Initialize(Stream stream, Encoding encoding, int bufferSize)
        {
            throw new NotImplementedException();
        }

        public void Initialize(string path, bool append, Encoding encoding, int bufferSize)
        {
            throw new NotImplementedException();
        }

        public void Write(double value)
        {
            throw new NotImplementedException();
        }

        public void Write(int value)
        {
            throw new NotImplementedException();
        }

        public void Write(long value)
        {
            throw new NotImplementedException();
        }

        public void Write(float value)
        {
            throw new NotImplementedException();
        }

        public void Write(uint value)
        {
            throw new NotImplementedException();
        }

        public void Write(ulong value)
        {
            throw new NotImplementedException();
        }

        public void Write(object value)
        {
            throw new NotImplementedException();
        }

        public void Write(decimal value)
        {
            throw new NotImplementedException();
        }

        public void Write(string value)
        {
            throw new NotImplementedException();
        }

        public void Write(bool value)
        {
            throw new NotImplementedException();
        }

        public void Write(char[] buffer)
        {
            throw new NotImplementedException();
        }

        public void Write(char value)
        {
            throw new NotImplementedException();
        }

        public void Write(string format, object[] arg)
        {
            throw new NotImplementedException();
        }

        public void Write(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void Write(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void Write(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void Write(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }
    }
}
