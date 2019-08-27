using Saipher.Domain.Interfaces.Arguments;
using System;

namespace Saipher.Domain.Arguments
{
    public class AdicionarAeroportoRequest : IRequest
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
}
