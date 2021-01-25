using System;
using System.Collections.Generic;
using System.Text;

namespace FTWWebserver.Domain
{
    public class File
    {
        public File(string filename, DateTime creationDate, byte[] content, string producerName)
        {
            Filename = filename;
            CreationDate = creationDate;
            Content = content;
            ProducerName = producerName;
            Size = Content.Length;
        }

        public string Filename { get; }
        public DateTime CreationDate { get;}
        public byte[] Content { get; }
        public string ProducerName { get; }
        public int Size { get; }
    }
}
