using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saipher.Domain.Arguments.Voo
{
    public class AlterarVooRequest
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }
    }
}
