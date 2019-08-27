using System;
using Saipher.Domain.Entities;

namespace Saipher.Domain.Arguments.PlanoDeVoo
{
    public class AlterarPlanoDeVooResponse
    {
        public Guid Id { get; set; }
        public Guid AeroportoOrigemId { get; set; }
        public Guid AeroportoDestinoId { get; set; }
        public Guid AeronaveId { get; set; }
        public Guid VooId { get; set; }

        public static explicit operator AlterarPlanoDeVooResponse(Entities.PlanoDeVoo entidade)
        {
            return new AlterarPlanoDeVooResponse()
            {
                Id = entidade.Id,
                AeroportoOrigemId = entidade.AeroportoOrigemId,
                AeroportoDestinoId = entidade.AeroportoDestinoId,
                AeronaveId = entidade.AeronaveId
            };
        }
    }
}
