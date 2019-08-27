using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saipher.Domain.Entities;

namespace Saipher.Domain.Arguments.PlanoDeVoo
{
    public class PlanoDeVooResponse
    {
        public Guid Id { get; set; }
        public Guid AeroportoOrigemId { get; set; }
        public Guid AeroportoDestinoId { get; set; }
        public Guid AeronaveId { get; set; }
        public Guid VooId { get; set; }

        public static explicit operator PlanoDeVooResponse(Entities.PlanoDeVoo entidade)
        {
            return new PlanoDeVooResponse()
            {
                Id = entidade.Id,
                AeroportoOrigemId = entidade.Id,
                AeroportoDestinoId = entidade.AeroportoDestinoId,
                AeronaveId = entidade.AeronaveId,
                VooId = entidade.VooId
            };
        }
    }
}
