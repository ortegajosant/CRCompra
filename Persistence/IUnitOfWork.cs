using System.Threading.Tasks;

namespace CRCompras.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}