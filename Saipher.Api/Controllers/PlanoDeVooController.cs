using Saipher.Api.Controllers.Base;
using Saipher.Domain.Arguments;
using Saipher.Domain.Arguments.Aeroporto;
using Saipher.Domain.Arguments.PlanoDeVoo;
using Saipher.Domain.Interfaces.Services;
using Saipher.Infra.Transactions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Saipher.Api.Controllers
{
    [RoutePrefix("api/plano_voo")]
    public class PlanoDeVooController : ControllerBase
    {
        private readonly IServicePlanoDeVoo _servicePlanoDeVoo;

        public PlanoDeVooController(IUnitOfWork unitOfWork, IServicePlanoDeVoo servicePlanoDeVoo) : base(unitOfWork)
        {
            _servicePlanoDeVoo = servicePlanoDeVoo;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarPlanoDeVooRequest request)
        {
            try
            {
                var response = _servicePlanoDeVoo.AdicionarPlanoDeVoo(request);

                return await ResponseAsync(response, _servicePlanoDeVoo);
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
                var response = _servicePlanoDeVoo.ListarPlanosDeVoo();

                return await ResponseAsync(response, _servicePlanoDeVoo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Alterar")]
        [HttpPut]
        public async Task<HttpResponseMessage> Alterar(AlterarPlanoDeVooRequest request)
        {
            try
            {
                var response = _servicePlanoDeVoo.AlterarPlanoDeVoo(request);

                return await ResponseAsync(response, _servicePlanoDeVoo);
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
                var response = _servicePlanoDeVoo.ExcluirPlanoDeVoo(id);

                return await ResponseAsync(response, _servicePlanoDeVoo);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}