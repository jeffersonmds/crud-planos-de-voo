using System;

namespace Saipher.Domain.Arguments.PlanoDeVoo
{
    public class AlterarPlanoDeVooRequest
    {
        public Guid Id { get; set; }
        public Guid AeroportoOrigemId { get; set; }
        public Guid AeroportoDestinoId { get; set; }
        public Guid AeronaveId { get; set; }
        public Guid VooId { get; set; }
    }
}
