using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FTWWebserver.Application;
using FTWWebserver.Application.StoreFile.Boundaries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FTWWebserver.Controllers.StoreFile
{
    [Route("api/Store")]
    [ApiController]
    public class StoreFileController : ControllerBase
    {
        private readonly ILogger<StoreFileController> _logger;
        private readonly IUseCase<StoreFileInput> _useCase;
        private readonly StoreFilePresentation _presentation;

        public StoreFileController(
            ILogger<StoreFileController> logger, 
            StoreFilePresentation presentation, 
            IUseCase<StoreFileInput> useCase
            )
        {
            _logger = logger;
            _presentation = presentation;
            _useCase = useCase;
        }

        [HttpGet]
        [Route("Store")]
        public async Task<IActionResult> Store(string base64Image)
        {
            _logger.LogInformation("Imagem recebida");

            var input = StoreFileAdapter.ToStoreFileInput(base64Image);
            
            await _useCase.ExecuteAsync(input);

            if (_presentation.UseCaseSuccess)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
