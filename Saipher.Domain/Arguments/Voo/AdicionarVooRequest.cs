using Saipher.Domain.Interfaces.Arguments;
using System;

namespace Saipher.Domain.Arguments
{
    public class AdicionarVooRequest : IRequest
    {
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public DateTime Horario { get; set; }
    }
}
