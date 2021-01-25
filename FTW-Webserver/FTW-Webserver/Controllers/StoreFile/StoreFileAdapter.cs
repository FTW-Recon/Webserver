using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FTW_Webserver.Controllers.StoreFile;
using FTWWebserver.Application.StoreFile.Boundaries;

namespace FTWWebserver.Controllers.StoreFile
{
    public static class StoreFileAdapter
    {
        public static StoreFileInput ToStoreFileInput(StoreFileRequest base64Image)
        {
            var currentDate = DateTime.Now;
            return new StoreFileInput
            {
                Name = $"{Guid.NewGuid().ToString().Substring(0, 5)}-.jpg",
                Bytes = Convert.FromBase64String(base64Image.Data),
                UploadedDate = currentDate
            };
        }
    }
}
