using Saipher.Api.Controllers.Base;
using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Aeronave;
using Saipher.Domain.Interfaces.Services;
using Saipher.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Saipher.Api.Controllers
{
    [RoutePrefix("api/aeronave")]
    public class AeronaveController : ControllerBase
    {
        private readonly IServiceAeronave _serviceAeronave;

        public AeronaveController(IUnitOfWork unitOfWork, IServiceAeronave serviceAeronave) : base(unitOfWork)
        {
            _serviceAeronave = serviceAeronave;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarAeronaveRequest request)
        {
            try
            {
                var response = _serviceAeronave.AdicionarAeronave(request);

                return await ResponseAsync(response, _serviceAeronave);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _serviceAeronave.ListarAeronaves();

                return await ResponseAsync(response, _serviceAeronave);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Alterar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarAeronaveRequest request)
        {
            try
            {
                var response = _serviceAeronave.AlterarAeronave(request);

                return await ResponseAsync(response, _serviceAeronave);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Excluir")]
        [HttpDelete]
        public async Task<HttpResponseMessage> Excluir(Guid id)
        {
            try
            {
                var response = _serviceAeronave.ExcluirAeronave(id);

                return await ResponseAsync(response, _serviceAeronave);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}