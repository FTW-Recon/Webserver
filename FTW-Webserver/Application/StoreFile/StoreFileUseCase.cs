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

        public StoreFileUseCase(ILogger<StoreFileUseCase> logger)
        {
            _logger = logger;
        }

        public async Task ExecuteAsync(StoreFileInput input)
        {

        }
    }
}
