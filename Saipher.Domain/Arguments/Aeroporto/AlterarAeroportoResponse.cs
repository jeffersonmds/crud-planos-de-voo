using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saipher.Domain.Entities;

namespace Saipher.Domain.Arguments.Aeroporto
{
    public class AlterarAeroportoResponse
    {
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public static explicit operator AlterarAeroportoResponse(Entities.Aeroporto entidade)
        {
            return new AlterarAeroportoResponse()
            {
                Id = entidade.Id,
                Sigla = entidade.Sigla,
                Nome = entidade.Nome
            };
        }
    }
}
