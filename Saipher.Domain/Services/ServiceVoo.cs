using prmToolkit.NotificationPattern;
using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Base;
using Saipher.Domain.Arguments.Voo;
using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Repositories;
using Saipher.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Saipher.Domain.Services
{
    public class ServiceVoo : Notifiable, IServiceVoo
    {
        private readonly IRepositoryVoo _repositoryVoo;
        public ServiceVoo(IRepositoryVoo repositoryVoo)
        {
            _repositoryVoo = repositoryVoo;
        }
        protected ServiceVoo()
        {
        }
        public AdicionarVooResponse AdicionarVoo(AdicionarVooRequest request)
        {
            if (request == null)
            {
                AddNotification("AdicionarVooRequest", "AdicionarVooRequest é obrigatório");
            }
            var voo = _repositoryVoo.Adicionar(new Voo(request.Numero, request.Data, request.Horario));

            return (AdicionarVooResponse)voo;
        }

        public AlterarVooResponse AlterarVoo(AlterarVooRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarVooRequest", "AlterarVooRequest é obrigatório");
            }
            Voo voo = _repositoryVoo.ObterPorId(request.Id);

            if (voo == null)
            {
                AddNotification("Id", "Dados não encontrados");
                return null;
            }

            voo.AlterarVoo(request.Numero, request.Data, request.Horario);
            AddNotifications(voo);

            if (IsInvalid())
            {
                return null;
            }

            _repositoryVoo.Editar(voo);

            return (AlterarVooResponse)voo;
        }        

        public IEnumerable<VooResponse> ListarVoos()
        {
            return _repositoryVoo.Listar().ToList().Select(voo => (VooResponse)voo).ToList();
        }
        public ResponseBase ExcluirVoo(Guid id)
        {
            Voo voo = _repositoryVoo.ObterPorId(id);

            if (voo == null)
            {
                AddNotification("Id", "Dados não encontrados");
                return null;
            }
            _repositoryVoo.Remover(voo);

            return new ResponseBase();
        }
    }
}
