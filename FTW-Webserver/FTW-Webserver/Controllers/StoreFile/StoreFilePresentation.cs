using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FTWWebserver.Application.StoreFile.Boundaries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FTWWebserver.Controllers.StoreFile
{
    public class StoreFilePresentation : IStoreFilePort
    {
        private readonly ILogger<StoreFilePresentation> _logger;
        public bool UseCaseSuccess;
        public StoreFilePresentation(ILogger<StoreFilePresentation> logger)
        {
            _logger = logger;
        }

        public void Success()
        {
            _logger.LogInformation("Imagem salva com sucesso.");
            UseCaseSuccess = true;
        }

        public void ValidationErrors(IEnumerable<string> errors)
        {
            _logger.LogInformation("Erros encontrados na validação do input do caso de uso.");
            UseCaseSuccess = false;
        }

        public void ServerError(Exception exception)
        {
            _logger.LogInformation("Erros encontrados no processamento do caso de uso.");
            UseCaseSuccess = false;
        }

        public void ServerError(string error)
        {
            _logger.LogInformation("Erros encontrados no processamento do caso de uso.");
            UseCaseSuccess = false;
        }
    }
}
