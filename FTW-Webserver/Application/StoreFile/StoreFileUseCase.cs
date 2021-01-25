using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Application.StoreFile.Boundaries;
using Microsoft.Extensions.Logging;

namespace Application.StoreFile
{
    public class StoreFileUseCase : IUseCase<StoreFileInput>
    {
        private readonly ILogger<StoreFileUseCase> _logger;
        private readonly IStoreFilePort _port;
        public StoreFileUseCase(ILogger<StoreFileUseCase> logger, IStoreFilePort port)
        {
            _logger = logger;
            _port = port;
        }

        public async Task ExecuteAsync(StoreFileInput input)
        {
            _logger.LogInformation("inicio caso de uso");

            _port.Success();
        }
    }
}
