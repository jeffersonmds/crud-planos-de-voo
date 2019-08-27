using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Repositories;
using Saipher.Infra.Persistence.Repositories.Base;
using System;

namespace Saipher.Infra.Persistence.Repositories
{
    public class RepositoryAeroporto : RepositoryBase<Aeroporto, Guid>, IRepositoryAeroporto
    {
        protected readonly SaipherContext _context;

        public RepositoryAeroporto(SaipherContext context) : base(context)
        {
            _context = context;
        }
    }
}
