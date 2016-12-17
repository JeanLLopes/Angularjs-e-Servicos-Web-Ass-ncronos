using System.Web.Http;
using WebActivatorEx;
using CadastroEstudante.Service.Web;
using Swashbuckle.Application;
using System;
using System.Xml.XPath;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace CadastroEstudante.Service.Web
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration 
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "SwaggerApi");
                        c.IncludeXmlComments(GetXmlCommentsPath());
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }

        private static string GetXmlCommentsPath()
        {
            //AQUI NOS BUSCAMOS NA PASTA AONDE A APLICAÇÃO
            //ESTA SENDO EXECUTADA  O ARQUIVO XML
            //COM A DOCUMENTAÇÃO DO NOSSO CODIGO       
            return string.Format(@"{0}\bin\CadastroEstudante.Service.Web.XML", 
                System.AppDomain.CurrentDomain.BaseDirectory);

            throw new NotImplementedException();
        }
    }
}
