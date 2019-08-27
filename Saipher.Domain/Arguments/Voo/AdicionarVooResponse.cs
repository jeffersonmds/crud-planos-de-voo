using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Arguments;
using System;

namespace Saipher.Domain.Arguments
{
    public class AdicionarVooResponse : IResponse
    {
        public Guid Id { get; set; }

        public static explicit operator AdicionarVooResponse(Entities.Voo entidade)
        {
            return new AdicionarVooResponse()
            {
                Id = entidade.Id
            };
        }
    }
}
