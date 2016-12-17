using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//IMPORTAMOS NOSSA CLASSE DE MODELOS PARA A CONTROLLER
using CadastroEstudante.Service.Web.Areas.HelpPage.Models;
using System.Data.SqlClient;

namespace CadastroEstudante.Service.Web.Controllers
{
    public class EstudanteController : ApiController
    {
        /// <summary>
        /// RETORNA DADOS DE ESTUDANTE
        /// </summary>
        /// <param name="id">CODIGO DO ESTUDANTE</param>
        /// <returns>MENSAGEM DE OK</returns>
        public HttpResponseMessage GetEstudante(int id)
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
                return Request.CreateResponse(HttpStatusCode.OK, estudante);
            }
            catch (SqlException)
            {
                return Request.CreateResponse(
                    HttpStatusCode.InternalServerError,
                    "Serviço Indisponivel");
            }
            catch (TimeoutException)
            {
                return Request.CreateResponse(
                    HttpStatusCode.RequestTimeout,
                    "Sua requisição deu TimeOut, Tente novamente mais tarde");
            }
            catch (Exception)
            {
                return Request.CreateResponse(
                    HttpStatusCode.InternalServerError,
                    "Serviço Indisponivel");
            }
        }
    }
}
