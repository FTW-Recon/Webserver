using System;
using System.Collections.Generic;
using System.Text;

namespace FTWWebserver.Application.StoreFile.Boundaries
{
    public class StoreFileInput : IUseCaseInput
    {
        public string Name { get; set; }
        public byte[] Bytes { get; set; }
        public DateTime UploadedDate { get; set; }
        public int Size => Bytes.Length;
    }
}
