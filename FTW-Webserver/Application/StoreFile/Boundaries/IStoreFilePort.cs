using System;
using System.Collections.Generic;
using System.Text;
using Application.Commons.Ports;

namespace Application.StoreFile.Boundaries
{
    public interface IStoreFilePort : ISuccessPort, IValidationErrorPort, IServerErrorPort
    {
    }
}
