using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.StoreFile.Boundaries;

namespace FTWWebserver.Controllers.StoreFile
{
    public static class StoreFileAdapter
    {
        public static StoreFileInput ToStoreFileInput(string base64Image)
        {
            var currentDate = DateTime.Now;
            return new StoreFileInput
            {
                Name = $"{Guid.NewGuid().ToString().Substring(0, 5)}-{currentDate}-.jpg",
                Bytes = Convert.FromBase64String(base64Image),
                UploadedDate = currentDate
            };
        }
    }
}
