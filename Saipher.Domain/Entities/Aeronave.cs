using prmToolkit.NotificationPattern;
using Saipher.Domain.Entities.Base;
using System;

namespace Saipher.Domain.Entities
{
    public class Aeronave : EntityBase
    {
        //public Guid Id { get; private set; }
        public string Matricula { get; private set; }
        public string Tipo { get; private set; }
        public Aeronave(string matricula, string tipo)
        {
            Matricula = matricula;
            Tipo = tipo;

            new AddNotifications<Aeronave>(this)
                .IfNullOrEmpty(x => x.Matricula, "Matrícula Inválida").IfNullOrEmpty(x => x.Tipo, "Tipo Inválido");
        }
        protected Aeronave()
        {

        }

        public void AlterarAeronave(string matricula, string tipo)
        {
            Matricula = matricula;
            Tipo = tipo;

            new AddNotifications<Aeronave>(this)
                .IfNullOrEmpty(x => x.Matricula, "Matrícula Inválida").IfNullOrEmpty(x => x.Tipo, "Tipo Inválido");
        }
    }
}
