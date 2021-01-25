using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FTWWebserver.Application.Commons.Extensions;
using FTWWebserver.Application.StoreFile.Boundaries;
using FTWWebserver.Infrastructure;
using Microsoft.Extensions.Logging;

namespace FTWWebserver.Application.StoreFile
{
    public class StoreFileUseCase : IUseCase<StoreFileInput>
    {
        private readonly ILogger<StoreFileUseCase> _logger;
        private readonly IStoreFilePort _port;
        private readonly IDataStorageService _dataStorage;
        public StoreFileUseCase(
            ILogger<StoreFileUseCase> logger,
            IStoreFilePort port, 
            IDataStorageService dataStorage)
        {
            _logger = logger;
            _port = port;
            _dataStorage = dataStorage;
        }

        public async Task ExecuteAsync(StoreFileInput input)
        {
            _logger.LogInformation("inicio caso de uso");
            var file = input.ToFile();

            var success = await _dataStorage.Store(file);

            if (success)
            {
                _port.Success();
            }
            
            _port.ServerError("Erro ao salvar o arquivo");
        }
    }
}
