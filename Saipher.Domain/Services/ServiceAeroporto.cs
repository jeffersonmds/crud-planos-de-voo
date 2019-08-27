using System;
using System.Collections.Generic;
using System.Linq;
using prmToolkit.NotificationPattern;
using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Aeroporto;
using Saipher.Domain.Arguments.Base;
using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Repositories;
using Saipher.Domain.Interfaces.Services;

namespace Saipher.Domain.Services
{
    public class ServiceAeroporto : Notifiable, IServiceAeroporto
    {
        private readonly IRepositoryAeroporto _repositoryAeroporto;
        public ServiceAeroporto(IRepositoryAeroporto repositoryAeroporto)
        {
            _repositoryAeroporto = repositoryAeroporto;
        }
        protected ServiceAeroporto()
        {
        }
        public AdicionarAeroportoResponse AdicionarAeroporto(AdicionarAeroportoRequest request)
        {
            if (request == null)
            {
                AddNotification("AdicionarAeroportoRequest", "AdicionarAeroportoRequest é obrigatório");
            }

            var aeroporto = _repositoryAeroporto.Adicionar(new Aeroporto(request.Sigla, request.Nome));

            return (AdicionarAeroportoResponse)aeroporto;
        }

        public AlterarAeroportoResponse AlterarAeroporto(AlterarAeroportoRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarAeroportoRequest", "AlterarAeroportoRequest é obrigatório");
            }
            Aeroporto aeroporto = _repositoryAeroporto.ObterPorId(request.Id);

            if (aeroporto == null)
            {
                AddNotification("Id", "Dados não encontrados");
                return null;
            }

            aeroporto.AlterarAeroporto(request.Sigla, request.Nome);
            AddNotifications(aeroporto);

            if (IsInvalid())
            {
                return null;
            }

            _repositoryAeroporto.Editar(aeroporto);

            return (AlterarAeroportoResponse)aeroporto;
        }
       
        public IEnumerable<AeroportoResponse> ListarAeroportos()
        {
            return _repositoryAeroporto.Listar().ToList().Select(aeroporto => (AeroportoResponse)aeroporto).ToList();
        }
        public ResponseBase ExcluirAeroporto(Guid id)
        {
            Aeroporto aeroporto = _repositoryAeroporto.ObterPorId(id);

            if (aeroporto == null)
            {
                AddNotification("Id", "Dados não encontrados");
                return null;
            }
            _repositoryAeroporto.Remover(aeroporto);

            return new ResponseBase();
        }
    }
}
