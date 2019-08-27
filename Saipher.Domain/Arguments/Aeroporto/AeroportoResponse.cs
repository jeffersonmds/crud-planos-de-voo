using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saipher.Domain.Entities;

namespace Saipher.Domain.Arguments.Aeroporto
{
    public class AeroportoResponse
    {
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public static explicit operator AeroportoResponse(Entities.Aeroporto entidade)
        {
            return new AeroportoResponse()
            {
                Id = entidade.Id,
                Nome = entidade.Nome,
                Sigla = entidade.Sigla
            };
        }
    }
}
