using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FTWWebserver.Controllers.StoreFile
{
    [Route("api/StoreFile")]
    [ApiController]
    public class StoreFileController : ControllerBase
    {
        private readonly ILogger<StoreFileController> _logger;
        private readonly StoreFilePresentation _presentation;

        public StoreFileController(ILogger<StoreFileController> logger, StoreFilePresentation presentation)
        {
            _logger = logger;
            _presentation = presentation;
        }

        [HttpGet]
        [Route("Store")]
        public IActionResult Get(string Base64Image)
        {
            _logger.LogInformation("Imagem recebida");

            var input = StoreFileAdapter.ToStoreFileInput(Base64Image);
            
            return Ok();
        }
    }
}
