using System.Threading.Tasks;

namespace CRCompras.Persistence
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly CRCompraDBContext context;

        public UnitOfWork(CRCompraDBContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}