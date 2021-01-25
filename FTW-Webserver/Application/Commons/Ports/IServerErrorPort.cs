using System;
using System.Collections.Generic;
using System.Text;

namespace FTWWebserver.Application.Commons.Ports
{
    public interface IServerErrorPort
    {
        void ServerError(Exception exception);
        void ServerError(string error);
    }
}
