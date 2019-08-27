using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Base;
using Saipher.Domain.Arguments.PlanoDeVoo;
using Saipher.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace Saipher.Domain.Interfaces.Services
{
    public interface IServicePlanoDeVoo : IServiceBase
    {
        AdicionarPlanoDeVooResponse AdicionarPlanoDeVoo(AdicionarPlanoDeVooRequest request);
        AlterarPlanoDeVooResponse AlterarPlanoDeVoo(AlterarPlanoDeVooRequest request);
        IEnumerable<PlanoDeVooResponse> ListarPlanosDeVoo();
        ResponseBase ExcluirPlanoDeVoo(Guid id);
    }
}
