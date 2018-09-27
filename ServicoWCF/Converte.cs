using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoWCF
{
    public class Converte
    {
        public static Sala ToSala(SalaModel sl)
        {
            Sala s = new Sala();

            s.Nome = sl.Nome;
            s.Projetor = sl.Projetor;
            s.qtdAlunos = sl.qtdAlunos;
            s.qtdComputadores = sl.qtdComputadores;
            s.SistemaOperacional = sl.SistemaOperacional;
            s.Software1 = sl.Software1;
            s.Software2 = sl.Software2;
            s.Software3 = sl.Software3;

            return s;
        }

        public static SalaModel ToSalaModel(Sala sl)
        {
            SalaModel s = new SalaModel();

            s.Nome = sl.Nome;
            s.Projetor = sl.Projetor;
            s.qtdAlunos = sl.qtdAlunos;
            s.qtdComputadores = sl.qtdComputadores;
            s.SistemaOperacional = sl.SistemaOperacional;
            s.Software1 = sl.Software1;
            s.Software2 = sl.Software2;
            s.Software3 = sl.Software3;

            return s;
        }
    }
}
