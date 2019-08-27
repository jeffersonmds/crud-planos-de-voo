using prmToolkit.NotificationPattern;
using Saipher.Domain.Entities.Base;
using System;

namespace Saipher.Domain.Entities
{
    public class Aeroporto : EntityBase
    {
        //public Guid Id { get; private set; }
        public string Sigla { get; private set; }
        public string Nome { get; private set; }
        public Aeroporto(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;

            new AddNotifications<Aeroporto>(this)
                .IfNullOrEmpty(x => x.Sigla, "Sigla Inválida").IfNullOrEmpty(x => x.Nome, "Nome Inválido");
        }
        protected Aeroporto()
        {

        }
        public void AlterarAeroporto(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;

            new AddNotifications<Aeroporto>(this)
                .IfNullOrEmpty(x => x.Sigla, "Sigla Inválida").IfNullOrEmpty(x => x.Nome, "Nome Inválido");
        }
    }
}
