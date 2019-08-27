using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Aeronave;
using Saipher.Domain.Arguments.Base;
using Saipher.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace Saipher.Domain.Interfaces.Services
{
    public interface IServiceAeronave : IServiceBase
    {
        AdicionarAeronaveResponse AdicionarAeronave(AdicionarAeronaveRequest request);
        AlterarAeronaveResponse AlterarAeronave(AlterarAeronaveRequest request);
        IEnumerable<AeronaveResponse> ListarAeronaves();
        ResponseBase ExcluirAeronave(Guid id);
    }
}
