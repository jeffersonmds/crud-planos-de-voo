using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saipher.Domain.Arguments.Aeronave
{
    public class AlterarAeronaveRequest
    {
        public Guid Id { get; set; }
        public string Matricula { get; set; }
        public string Tipo { get; set; }
    }
}
