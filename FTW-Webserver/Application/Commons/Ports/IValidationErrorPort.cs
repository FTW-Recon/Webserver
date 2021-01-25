using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commons.Ports
{
    public interface IValidationErrorPort
    {
        void ValidationErrors(IEnumerable<string> errors);
    }
}
