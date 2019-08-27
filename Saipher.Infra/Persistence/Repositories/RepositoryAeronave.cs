using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Repositories;
using Saipher.Infra.Persistence.Repositories.Base;
using System;

namespace Saipher.Infra.Persistence.Repositories
{
    public class RepositoryAeronave : RepositoryBase<Aeronave, Guid>, IRepositoryAeronave
    {
        protected readonly SaipherContext _context;

        public RepositoryAeronave(SaipherContext context) : base(context)
        {
            _context = context;
        }

        //public Aeronave AdicionarAeronave(Aeronave aeronave)
        //{
        //    _context.Aeronaves.Add(aeronave);
        //    _context.SaveChanges();

        //    return aeronave;
        //}

        //public void AlterarAeronave(Aeronave aeronave)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Aeronave> ListarAeronaves()
        //{
        //    return _context.Aeronaves.ToList();
        //}

        //public Aeronave ObterAeronavePorId(Guid id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
