using Saipher.Api.Controllers.Base;
using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Aeroporto;
using Saipher.Domain.Interfaces.Services;
using Saipher.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Saipher.Api.Controllers
{
    [RoutePrefix("api/aeroporto")]
    public class AeroportoController : ControllerBase
    {
        private readonly IServiceAeroporto _serviceAeroporto;

        public AeroportoController(IUnitOfWork unitOfWork, IServiceAeroporto serviceAeroporto) : base(unitOfWork)
        {
            _serviceAeroporto = serviceAeroporto;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarAeroportoRequest request)
        {
            try
            {
                var response = _serviceAeroporto.AdicionarAeroporto(request);

                return await ResponseAsync(response, _serviceAeroporto);
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
                var response = _serviceAeroporto.ListarAeroportos();

                return await ResponseAsync(response, _serviceAeroporto);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Alterar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarAeroportoRequest request)
        {
            try
            {
                var response = _serviceAeroporto.AlterarAeroporto(request);

                return await ResponseAsync(response, _serviceAeroporto);
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
                var response = _serviceAeroporto.ExcluirAeroporto(id);

                return await ResponseAsync(response, _serviceAeroporto);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}