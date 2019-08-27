using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Arguments;
using System;

namespace Saipher.Domain.Arguments
{
    public class AdicionarAeronaveResponse : IResponse
    {
        public Guid Id { get; set; }

        public static explicit operator AdicionarAeronaveResponse(Entities.Aeronave entidade)
        {
            return new AdicionarAeronaveResponse()
            {
                Id = entidade.Id
            };
        }
    }
}
