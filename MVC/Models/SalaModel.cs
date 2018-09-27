using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class SalaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int qtdComputadores { get; set; }
        public int qtdAlunos { get; set; }
        public bool Projetor { get; set; }
        public string Software1 { get; set; }
        public string Software2 { get; set; }
        public string Software3 { get; set; }
        public string SistemaOperacional { get; set; }
    }
}