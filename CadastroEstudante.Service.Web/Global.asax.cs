using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

//ADICONAMOS UMA NOVA NAMESPACE AO NOSSO PROJETO
using System.Web.Mvc;

namespace CadastroEstudante.Service.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //AQUI NOS REGISTRAMOS AS AREAS DO  NOSSO CODIGO
            //AS AREAS SÃO PARTES SEPARADAS DA NOSSA APLICAÇÃO
            //COMO POR EXEMPLO UM SITE INSTITUCIONAL
            //QUE POSSUI UM PORTAL DE ADMINISTRAÇÃO
            //NO CASO ESTE PORTAL SERIA NOSSA AREA
            AreaRegistration.RegisterAllAreas();
        }
    }
}
