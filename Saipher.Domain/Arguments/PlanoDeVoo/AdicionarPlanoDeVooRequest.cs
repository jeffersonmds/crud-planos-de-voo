using Saipher.Domain.Interfaces.Arguments;
using System;

namespace Saipher.Domain.Arguments
{
    public class AdicionarPlanoDeVooRequest : IRequest
    {
        public Guid AeroportoOrigemId { get; set; }
        public Guid AeroportoDestinoId { get; set; }
        public Guid AeronaveId { get; set; }
        public Guid VooId { get; set; }
    }
}
