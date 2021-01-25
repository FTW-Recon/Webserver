using System;
using System.Collections.Generic;
using System.Text;
using FTWWebserver.Application.Commons.Ports;

namespace FTWWebserver.Application.StoreFile.Boundaries
{
    public interface IStoreFilePort : ISuccessPort, IValidationErrorPort, IServerErrorPort
    {
    }
}
