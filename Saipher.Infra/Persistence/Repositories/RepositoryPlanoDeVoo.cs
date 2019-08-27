using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Repositories;
using Saipher.Infra.Persistence.Repositories.Base;
using System;

namespace Saipher.Infra.Persistence.Repositories
{
    public class RepositoryPlanoDeVoo : RepositoryBase<PlanoDeVoo, Guid>, IRepositoryPlanoDeVoo
    {
        protected readonly SaipherContext _context;

        public RepositoryPlanoDeVoo(SaipherContext context) : base(context)
        {
            _context = context;
        }
    }
}
