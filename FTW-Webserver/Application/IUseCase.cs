using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IUseCase<in TInput> where TInput : IUseCaseInput
    {
        Task ExecuteAsync(TInput input);
    }
}
