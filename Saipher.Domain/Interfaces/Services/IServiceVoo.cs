using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Base;
using Saipher.Domain.Arguments.Voo;
using Saipher.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace Saipher.Domain.Interfaces.Services
{
    public interface IServiceVoo : IServiceBase
    {
        AdicionarVooResponse AdicionarVoo(AdicionarVooRequest request);
        AlterarVooResponse AlterarVoo(AlterarVooRequest request);
        IEnumerable<VooResponse> ListarVoos();
        ResponseBase ExcluirVoo(Guid id);
    }
}
