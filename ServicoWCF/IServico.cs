﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicoWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IServico" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IServico
    {
        [OperationContract]
        bool inserir(Sala sala);

        [OperationContract]
        List<Sala> Listar();

        [OperationContract]
        Sala getById(int id);

        [OperationContract]
        int editar(Sala sala);

        [OperationContract]
        int excluir(int id);
    }
}
