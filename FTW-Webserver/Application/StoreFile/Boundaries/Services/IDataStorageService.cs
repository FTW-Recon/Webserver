using System.Threading.Tasks;
using FTWWebserver.Domain;

namespace FTWWebserver.Infrastructure
{
    public interface IDataStorageService
    {
        Task<bool> Store(File file);
    }
}