using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEstudante.Service.Web.Areas.HelpPage.Models
{
    public class EstudanteModel
    {
        //prop {TAB} {TAB}
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Observacoes { get; set; }
    }
}