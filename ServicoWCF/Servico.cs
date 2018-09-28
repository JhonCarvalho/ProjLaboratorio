
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicoWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Servico" no arquivo de código e configuração ao mesmo tempo.
    public class Servico : IServico
    {

        public bool inserir(Sala sala)
        {
            return new Dados.Dados().Inserir(sala);
        }

        public List<Sala> Listar()
        {
            return new Dados.Dados().Listar();
        }

        public Sala getById(int id)
        {
            return new Dados.Dados().getById(id);
        }

        public int editar(Sala sala)
        {
            return new Dados.Dados().editar(sala);
        }

        public int excluir(int id)
        {
            return new Dados.Dados().excluir(id);
        }
    }
}
