using prmToolkit.NotificationPattern;
using Saipher.Domain.Entities.Base;
using System;

namespace Saipher.Domain.Entities
{
    public class Voo : EntityBase
    {
        //public Guid Id { get; private set; }
        public string Numero { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime Horario { get; private set; }
        public Voo(string numero, DateTime data, DateTime horario)
        {
            Numero = numero;
            Data = data;
            Horario = horario;

            new AddNotifications<Voo>(this)
                .IfNullOrEmpty(x => x.Numero, "Numero Inválido").IfNull(x => x.Data, "Data Inválida").IfNull(x => x.Horario, "Horário Inválida");
        }

        protected Voo()
        {

        }
        public void AlterarVoo(string numero, DateTime data, DateTime horario)
        {
            Numero = numero;
            Data = data;
            Horario = horario;

            new AddNotifications<Voo>(this)
                .IfNullOrEmpty(x => x.Numero, "Numero Inválido").IfNull(x => x.Data, "Data Inválida").IfNull(x => x.Horario, "Horário Inválida");
        }
    }
}
