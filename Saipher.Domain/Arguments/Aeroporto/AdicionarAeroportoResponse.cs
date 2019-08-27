using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Arguments;
using System;

namespace Saipher.Domain.Arguments
{
    public class AdicionarAeroportoResponse : IResponse
    {
        public Guid Id { get; set; }

        public static explicit operator AdicionarAeroportoResponse(Entities.Aeroporto entidade)
        {
            return new AdicionarAeroportoResponse()
            {
                Id = entidade.Id
            };
        }
    }
}
