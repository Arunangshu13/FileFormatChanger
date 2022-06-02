using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFormatChanger.FormatChangers
{
    public class Base8Formatter
    {
        public Base8Formatter()
        {

        }
        public Base8Formatter(string FilePath, byte[] FileData)
        {
            this.FilePath = FilePath;
            this.FileData = FileData;
        }

        public byte[] ReadFileInBytes(string FilePath)
        {
            using (FileStream stream = File.OpenRead(FilePath))
            {
                var totalBytes = (int)stream.Length;
                FileData = new byte[totalBytes];
                var bytesRead = 0;

                while (bytesRead < totalBytes)
                {
                    int len = stream.Read(FileData, bytesRead, totalBytes);
                    bytesRead += len;
                }
                this.FilePath = FilePath;
                stream.Close();
            }
            return this.FileData;
        }

        public string FilePath { get; set; } = string.Empty;
        public byte[] FileData { get; set; } 


        public byte[] GetBase8FormattedData()
        {
            return null;
        }

    }
}
