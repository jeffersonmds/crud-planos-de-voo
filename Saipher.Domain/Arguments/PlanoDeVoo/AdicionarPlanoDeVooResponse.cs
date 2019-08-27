using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Arguments;
using System;

namespace Saipher.Domain.Arguments
{
    public class AdicionarPlanoDeVooResponse : IResponse
    {
        public Guid Id { get; set; }

        public static explicit operator AdicionarPlanoDeVooResponse(Entities.PlanoDeVoo entidade)
        {
            return new AdicionarPlanoDeVooResponse()
            {
                Id = entidade.Id
            };
        }
    }
}
