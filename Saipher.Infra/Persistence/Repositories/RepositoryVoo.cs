using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Repositories;
using Saipher.Infra.Persistence.Repositories.Base;
using System;

namespace Saipher.Infra.Persistence.Repositories
{
    public class RepositoryVoo : RepositoryBase<Voo, Guid>, IRepositoryVoo
    {
        protected readonly SaipherContext _context;

        public RepositoryVoo(SaipherContext context) : base(context)
        {
            _context = context;
        }
    }
}
