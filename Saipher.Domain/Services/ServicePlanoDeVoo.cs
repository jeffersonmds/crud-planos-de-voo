using prmToolkit.NotificationPattern;
using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Base;
using Saipher.Domain.Arguments.PlanoDeVoo;
using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Repositories;
using Saipher.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Saipher.Domain.Services
{
    public class ServicePlanoDeVoo : Notifiable, IServicePlanoDeVoo
    {
        private readonly IRepositoryPlanoDeVoo _repositoryPlanoDeVoo;
        public ServicePlanoDeVoo(IRepositoryPlanoDeVoo repositoryPlanoDeVoo)
        {
            _repositoryPlanoDeVoo = repositoryPlanoDeVoo;
        }
        protected ServicePlanoDeVoo()
        {
        }
        public AdicionarPlanoDeVooResponse AdicionarPlanoDeVoo(AdicionarPlanoDeVooRequest request)
        {
            if (request == null)
            {
                AddNotification("AdicionarPlanoDeVooRequest", "AdicionarPlanoDeVooRequest é obrigatório");
            }
            var planoDeVoo = _repositoryPlanoDeVoo.Adicionar(new PlanoDeVoo(request.AeroportoOrigemId, request.AeroportoDestinoId, request.AeronaveId, request.VooId));

            return (AdicionarPlanoDeVooResponse)planoDeVoo;
        }

        public AlterarPlanoDeVooResponse AlterarPlanoDeVoo(AlterarPlanoDeVooRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarPlanoDeVooRequest", "AlterarPlanoDeVooRequest é obrigatório");
            }
            PlanoDeVoo planoDeVoo = _repositoryPlanoDeVoo.ObterPorId(request.Id);

            if (planoDeVoo == null)
            {
                AddNotification("Id", "Dados não encontrados");
                return null;
            }

            planoDeVoo.AlterarPlanoDeVoo(request.AeroportoOrigemId, request.AeroportoDestinoId, request.AeronaveId, request.VooId);
            AddNotifications(planoDeVoo);

            if (IsInvalid())
            {
                return null;
            }

            _repositoryPlanoDeVoo.Editar(planoDeVoo);

            return (AlterarPlanoDeVooResponse)planoDeVoo;
        }

        public IEnumerable<PlanoDeVooResponse> ListarPlanosDeVoo()
        {
            return _repositoryPlanoDeVoo.Listar().ToList().Select(planoDeVoo => (PlanoDeVooResponse)planoDeVoo).ToList();
        }
        public ResponseBase ExcluirPlanoDeVoo(Guid id)
        {
            PlanoDeVoo planoDeVoo = _repositoryPlanoDeVoo.ObterPorId(id);

            if (planoDeVoo == null)
            {
                AddNotification("Id", "Dados não encontrados");
                return null;
            }
            _repositoryPlanoDeVoo.Remover(planoDeVoo);

            return new ResponseBase();
        }
    }
}
