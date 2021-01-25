using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FTW_Webserver.Controllers.StoreFile;
using FTWWebserver.Application;
using FTWWebserver.Application.StoreFile.Boundaries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FTWWebserver.Controllers.StoreFile
{
    [Route("api/ImageStore")]
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

        [HttpPost]
        [Route("Store")]
        public async Task<IActionResult> Store([FromBody] StoreFileRequest data)
        {
            _logger.LogInformation("Imagem recebida");

            //var input = StoreFileAdapter.ToStoreFileInput(data);
            
            //await _useCase.ExecuteAsync(input);

            //if (_presentation.UseCaseSuccess)
            //{
            //    return Ok();
            //}

            return NotFound();
        }
    }
}
