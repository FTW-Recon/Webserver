using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using File = FTWWebserver.Domain.File;

namespace FTWWebserver.Infrastructure
{
    public class DataStorageService : IDataStorageService
    {
        private readonly ILogger<DataStorageService> _logger;
        public DataStorageService(ILogger<DataStorageService> logger)
        {
            _logger = logger;
        }

        public async Task<bool> Store(File file)
        {
            if (FileExists(file.Filename))
            {
                _logger.LogWarning($"File: {file.Filename} already exists in the disk !");
                return false;
            }

            try
            {
                _logger.LogInformation($"Storing file:{file.Filename}");

                using (FileStream SourceStream = System.IO.File.Open(file.Filename, FileMode.OpenOrCreate))
                {
                    SourceStream.Seek(0, SeekOrigin.End);
                    await SourceStream.WriteAsync(file.Content, 0, file.Size);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError($"Exception ocurred, message: {exception.Message}");
                return false;
            }

            return true;
        }

        private bool FileExists(string filename)
        {
            return System.IO.File.Exists(filename);
        }
    }
}
