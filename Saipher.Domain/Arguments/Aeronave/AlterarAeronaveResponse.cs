using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saipher.Domain.Entities;

namespace Saipher.Domain.Arguments.Aeronave
{
    public class AlterarAeronaveResponse
    {
        public Guid Id { get; set; }
        public string Matricula { get; set; }
        public string Tipo { get; set; }
        public static explicit operator AlterarAeronaveResponse(Entities.Aeronave entidade)
        {
            return new AlterarAeronaveResponse()
            {
                Id = entidade.Id,
                Matricula = entidade.Matricula,
                Tipo = entidade.Tipo
            };
        }
    }
}
