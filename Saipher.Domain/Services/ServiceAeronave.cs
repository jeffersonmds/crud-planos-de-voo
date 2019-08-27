using System;
using System.Collections.Generic;
using System.Linq;
using prmToolkit.NotificationPattern;
using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Aeronave;
using Saipher.Domain.Arguments.Base;
using Saipher.Domain.Entities;
using Saipher.Domain.Interfaces.Repositories;
using Saipher.Domain.Interfaces.Services;

namespace Saipher.Domain.Services
{
    public class ServiceAeronave : Notifiable, IServiceAeronave
    {
        private readonly IRepositoryAeronave _repositoryAeronave;
        public ServiceAeronave(IRepositoryAeronave repositoryAeronave)
        {
            _repositoryAeronave = repositoryAeronave;
        }
        protected ServiceAeronave()
        {
        }

        public AdicionarAeronaveResponse AdicionarAeronave(AdicionarAeronaveRequest request)
        {
            if (request == null)
            {
                AddNotification("AdicionarAeronaveRequest", "AdicionarAeronaveRequest é obrigatório");
            }

            if (_repositoryAeronave.Existe(x=>x.Matricula == request.Matricula))
            {
                AddNotification("Matricula", "Já existe uma aeronave com essa matrícula!");
            }

            if (this.IsInvalid())
            {
                return null;
            }

            var aeronave = _repositoryAeronave.Adicionar(new Aeronave(request.Matricula, request.Tipo));

            return (AdicionarAeronaveResponse)aeronave;
        }

        public AlterarAeronaveResponse AlterarAeronave(AlterarAeronaveRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarAeronaveRequest", "AlterarAeronaveRequest é obrigatório");
            }
            Aeronave aeronave = _repositoryAeronave.ObterPorId(request.Id);

            if(aeronave == null)
            {
                AddNotification("Id", "Dados não encontrados");
                return null;
            }

            aeronave.AlterarAeronave(request.Matricula, request.Tipo);
            AddNotifications(aeronave);

            if (IsInvalid())
            {
                return null;
            }

            _repositoryAeronave.Editar(aeronave);
            
            return (AlterarAeronaveResponse)aeronave;
        }

        public IEnumerable<AeronaveResponse> ListarAeronaves()
        {
            return _repositoryAeronave.Listar().ToList().Select(aeronave => (AeronaveResponse)aeronave).ToList();
        }
        public ResponseBase ExcluirAeronave(Guid id)
        {
            Aeronave aeronave = _repositoryAeronave.ObterPorId(id);

            if (aeronave == null)
            {
                AddNotification("Id", "Dados não encontrados");
                return null;
            }
            _repositoryAeronave.Remover(aeronave);

            return new ResponseBase();
        }
    }
}
