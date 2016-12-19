using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//IMPORTAMOS NOSSA CLASSE DE MODELOS PARA A CONTROLLER
using CadastroEstudante.Service.Web.Areas.HelpPage.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace CadastroEstudante.Service.Web.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    //[EnableCors(origins:"*",headers:"*",methods:"GET,POST")]
    //[EnableCors(origins:"*",headers:"Authetication",methods:"*")]
    //[EnableCors(origins: "http://meudominio.com.br,http://meudominio2.com.br", headers:"*",methods:"*")]
    public class EstudanteController : ApiController
    {

        /// <summary>
        /// Retorna os dados do Estudante Pesquisado
        /// </summary>
        /// <param name="id">Codigo do Estudante</param>
        /// <returns>Informações do estudante solicitado</returns>
        public Task<HttpResponseMessage> GetEstudante(int id)
        {
            try
            {
                //AQUI  NOS CRIAMOS UM MODELO DE RETORNO DE DADOS
                //PARA NOSSA API
                var estudante = new EstudanteModel()
                {
                    Id = 1,
                    Nome = "Jean Lopes",
                    Email = "jean.llopes@outlook.com",
                    Observacoes = "Nenhuma"
                };

                //AQUI NOS MONTAMOS O RETORNO DE DADOS PARA NOSSA API
                //QUANDO TUDDO DER CERTO NOS IREMOS RETORNAR UM STATUS
                //HTTP OK, E OS DADOS DO ESTUDANTE
                return Task.FromResult(Request.CreateResponse(
                    HttpStatusCode.OK, estudante));
            }
            catch (SqlException)
            {
                return Task.FromResult(Request.CreateResponse(
                    HttpStatusCode.InternalServerError,
                    "Serviço Indisponivel"));
            }
            catch (TimeoutException)
            {
                return Task.FromResult(Request.CreateResponse(
                    HttpStatusCode.RequestTimeout,
                    "Sua requisição deu TimeOut, Tente novamente mais tarde"));
            }
            catch (Exception)
            {
                return Task.FromResult(Request.CreateResponse(
                    HttpStatusCode.InternalServerError,
                    "Serviço Indisponivel"));
            }
        }


        /// <summary>
        /// Cadastra Estudante na API
        /// </summary>
        /// <param name="dados">Dados cadastrais do Estudante</param>
        /// <returns>Nome do Estudante juntamente com a mensagem de sucesso</returns>
        public Task<HttpResponseMessage> PostEstudante(EstudanteModel dados)
        {
            try
            {
                //CADASTRA USUARIO NO BANCO
                return Task.FromResult(Request.CreateResponse(
                    HttpStatusCode.Created,
                    string.Format("{0} cadastrado com sucesso", dados.Nome)));
            }
            catch (Exception)
            {
                return Task.FromResult(Request.CreateResponse(
                    HttpStatusCode.InternalServerError,
                    "Serviço Indisponivel"));
            }
        }

    }
}
