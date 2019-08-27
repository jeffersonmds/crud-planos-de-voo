using Saipher.Infra.Persistence;

namespace Saipher.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SaipherContext _context;

        public UnitOfWork(SaipherContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
