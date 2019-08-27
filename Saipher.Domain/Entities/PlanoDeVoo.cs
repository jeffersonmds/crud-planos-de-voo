using prmToolkit.NotificationPattern;
using Saipher.Domain.Entities.Base;
using System;

namespace Saipher.Domain.Entities
{
    public class PlanoDeVoo : EntityBase
    {
        //public Guid Id { get; private set; }
        //public Aeroporto AeroportoOrigem { get; private set; }
        //public Aeroporto AeroportoDestino { get; private set; }
        //public Aeronave Aeronave { get; private set; }
        //public Voo Voo { get; private set; }
        //public PlanoDeVoo(Aeroporto aeroportoOrigem, Aeroporto aeroportoDestino, Aeronave aeronave, Voo voo)
        //{
        //    AeroportoOrigem = aeroportoOrigem;
        //    AeroportoDestino = aeroportoDestino;
        //    Aeronave = aeronave;
        //    Voo = voo;
        //    Id = Guid.NewGuid();

        //    AddNotifications(aeroportoOrigem, aeroportoDestino, aeronave, voo);
        //}

        //public Guid Id { get; private set; }
        public Guid AeroportoOrigemId { get; private set; }
        public Guid AeroportoDestinoId { get; private set; }
        public Guid AeronaveId { get; private set; }
        public Guid VooId { get; private set; }

        public PlanoDeVoo(Guid aeroportoOrigemId, Guid aeroportoDestinoId, Guid aeronaveId, Guid vooId)
        {
            AeroportoOrigemId = aeroportoOrigemId;
            AeroportoDestinoId = aeroportoDestinoId;
            AeronaveId = aeronaveId;
            VooId = vooId;

            new AddNotifications<PlanoDeVoo>(this)
                .IfNull(x => x.AeroportoOrigemId, "Número do Aeroporto Origem Inválido")
                .IfNull(x => x.AeroportoDestinoId, "Número do Aeroporto Destino Inválido")
                .IfNull(x => x.AeronaveId, "Número da Aeronave Inválido")
                .IfNull(x => x.VooId, "Número do vôo Inválido");
        }

        protected PlanoDeVoo()
        {

        }

        public void AlterarPlanoDeVoo(Guid aeroportoOrigemId, Guid aeroportoDestinoId, Guid aeronaveId, Guid vooId)
        {
            AeroportoOrigemId = aeroportoOrigemId;
            AeroportoDestinoId = aeroportoDestinoId;
            AeronaveId = aeronaveId;
            VooId = vooId;

            new AddNotifications<PlanoDeVoo>(this)
                .IfNull(x => x.AeroportoOrigemId, "Número do Aeroporto Origem Inválido")
                .IfNull(x => x.AeroportoDestinoId, "Número do Aeroporto Destino Inválido")
                .IfNull(x => x.AeronaveId, "Número da Aeronave Inválido")
                .IfNull(x => x.VooId, "Número do vôo Inválido");
        }
    }
}
