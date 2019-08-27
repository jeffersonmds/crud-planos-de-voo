using Saipher.Api.Controllers.Base;
using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Aeroporto;
using Saipher.Domain.Arguments.PlanoDeVoo;
using Saipher.Domain.Arguments.Voo;
using Saipher.Domain.Interfaces.Services;
using Saipher.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Saipher.Api.Controllers
{
    [RoutePrefix("api/voo")]
    public class VooController : ControllerBase
    {
        private readonly IServiceVoo _serviceVoo;

        public VooController(IUnitOfWork unitOfWork, IServiceVoo serviceVoo) : base(unitOfWork)
        {
            _serviceVoo = serviceVoo;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarVooRequest request)
        {
            try
            {
                var response = _serviceVoo.AdicionarVoo(request);

                return await ResponseAsync(response, _serviceVoo);
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
                var response = _serviceVoo.ListarVoos();

                return await ResponseAsync(response, _serviceVoo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Alterar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarVooRequest request)
        {
            try
            {
                var response = _serviceVoo.AlterarVoo(request);

                return await ResponseAsync(response, _serviceVoo);
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
                var response = _serviceVoo.ExcluirVoo(id);

                return await ResponseAsync(response, _serviceVoo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}