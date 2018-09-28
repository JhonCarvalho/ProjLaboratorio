using MVC.Models;
using MVC.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Util
{
    public class Converte
    {
        public static SalaModel ToSalaModel(Sala sala)
        {
            SalaModel s = new SalaModel();
            s.Id = sala.Id;
            s.Nome = sala.Nome;
            s.Projetor = sala.Projetor;
            s.qtdAlunos = sala.qtdAlunos;
            s.qtdComputadores = sala.qtdComputadores;
            s.SistemaOperacional = sala.SistemaOperacional;
            s.Software1 = sala.Software1;
            s.Software2 = sala.Software2;
            s.Software3 = sala.Software3;

            return s;
        }

        public static Sala ToSala(SalaModel sala)
        {
            Sala s = new Sala();
            s.Id = sala.Id;
            s.Nome = sala.Nome;
            s.Projetor = sala.Projetor;
            s.qtdAlunos = sala.qtdAlunos;
            s.qtdComputadores = sala.qtdComputadores;
            s.SistemaOperacional = sala.SistemaOperacional;
            s.Software1 = sala.Software1;
            s.Software2 = sala.Software2;
            s.Software3 = sala.Software3;

            return s;
        }
    }
}