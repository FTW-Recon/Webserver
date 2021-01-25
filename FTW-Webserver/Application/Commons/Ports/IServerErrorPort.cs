using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commons.Ports
{
    public interface IServerErrorPort
    {
        void ServerError(Exception exception);
        void ServerError(string error);
    }
}
