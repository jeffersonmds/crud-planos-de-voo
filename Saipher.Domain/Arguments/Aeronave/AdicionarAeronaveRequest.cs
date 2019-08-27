using Saipher.Domain.Interfaces.Arguments;
using System;

namespace Saipher.Domain.Arguments
{
    public class AdicionarAeronaveRequest : IRequest
    {
        public string Matricula { get; set; }
        public string Tipo { get; set; }
    }
}
