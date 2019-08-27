using Saipher.Domain.Arguments;
using Saipher.Domain.Entities;
using System;
using System.Collections.Generic;
using Saipher.Domain.Interfaces.Repositories.Base;

namespace Saipher.Domain.Interfaces.Repositories
{
    public interface IRepositoryAeronave : IRepositoryBase<Aeronave, Guid>
    {
        //Aeronave AdicionarAeronave(Aeronave aeronave);
        //IEnumerable<Aeronave> ListarAeronaves();
        //Aeronave ObterAeronavePorId(Guid id);
        //void AlterarAeronave(Aeronave aeronave);
    }
}
