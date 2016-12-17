using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



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
            return Request.CreateResponse(HttpStatusCode.OK, 
                                            "Estudante OK");
        }
    }
}
