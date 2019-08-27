using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Aeroporto;
using Saipher.Domain.Arguments.Base;
using Saipher.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace Saipher.Domain.Interfaces.Services
{
    public interface IServiceAeroporto : IServiceBase
    {
        AdicionarAeroportoResponse AdicionarAeroporto(AdicionarAeroportoRequest request);
        AlterarAeroportoResponse AlterarAeroporto(AlterarAeroportoRequest request);
        IEnumerable<AeroportoResponse> ListarAeroportos();
        ResponseBase ExcluirAeroporto(Guid id);
    }
}
