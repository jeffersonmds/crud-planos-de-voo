using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saipher.Domain.Entities;

namespace Saipher.Domain.Arguments.Voo
{
    public class AlterarVooResponse
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }

        public static explicit operator AlterarVooResponse(Entities.Voo entidade)
        {
            return new AlterarVooResponse()
            {
                Id = entidade.Id,
                Numero = entidade.Numero,
                Data = entidade.Data,
                Horario = entidade.Horario
            };
        }
    }
}
