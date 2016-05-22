using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using SystemWrapper;
using SystemWrapper.IO;
using SystemWrapper.Security.AccessControl;

namespace ConsoleApplication1
{
    public class FileInfoWrap : IFileInfoWrap
    {
        private readonly FileInfo _fileInfo;

        public FileInfoWrap(FileInfo fileInfo)
        {
            _fileInfo = fileInfo;
        }

        public FileAttributes Attributes
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

        public IDateTimeWrap CreationTime
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

        public IDateTimeWrap CreationTimeUtc
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

        public IDirectoryInfoWrap Directory
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string DirectoryName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Exists
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Extension
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public FileInfo FileInfoInstance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string FullName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
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

        public IDateTimeWrap LastAccessTime
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

        public IDateTimeWrap LastAccessTimeUtc
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

        public IDateTimeWrap LastWriteTime
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

        public IDateTimeWrap LastWriteTimeUtc
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

        public long Length
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStreamWriterWrap AppendText()
        {
            throw new NotImplementedException();
        }

        public IFileInfoWrap CopyTo(string destFileName)
        {
            throw new NotImplementedException();
        }

        public IFileInfoWrap CopyTo(string destFileName, bool overwrite)
        {
            throw new NotImplementedException();
        }

        public IFileStreamWrap Create()
        {
            throw new NotImplementedException();
        }

        public IStreamWriterWrap CreateText()
        {
            return new StreamWriterWrap(_fileInfo.CreateText());
        }

        public void Decrypt()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Encrypt()
        {
            throw new NotImplementedException();
        }

        public IFileSecurityWrap GetAccessControl()
        {
            throw new NotImplementedException();
        }

        public IFileSecurityWrap GetAccessControl(AccessControlSections includeSections)
        {
            throw new NotImplementedException();
        }

        public void Initialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public void Initialize(FileInfo fileInfo)
        {
            throw new NotImplementedException();
        }

        public void MoveTo(string destFileName)
        {
            throw new NotImplementedException();
        }

        public IFileStreamWrap Open(FileMode mode)
        {
            throw new NotImplementedException();
        }

        public IFileStreamWrap Open(FileMode mode, FileAccess access)
        {
            throw new NotImplementedException();
        }

        public IFileStreamWrap Open(FileMode mode, FileAccess access, FileShare share)
        {
            throw new NotImplementedException();
        }

        public IFileStreamWrap OpenRead()
        {
            throw new NotImplementedException();
        }

        public IStreamReaderWrap OpenText()
        {
            throw new NotImplementedException();
        }

        public IFileStreamWrap OpenWrite()
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public IFileInfoWrap Replace(string destinationFileName, string destinationBackupFileName)
        {
            throw new NotImplementedException();
        }

        public IFileInfoWrap Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            throw new NotImplementedException();
        }

        public void SetAccessControl(IFileSecurityWrap fileSecurity)
        {
            throw new NotImplementedException();
        }
    }
}
