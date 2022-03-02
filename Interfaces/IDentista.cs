using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Interfaces
{
    [ServiceContract]
    public interface IDentista
    {
        [OperationContract]
        void Cadastrar(Dentista obj);

        [OperationContract]
        Dentista Buscar(int id);

        [OperationContract]
        List <Dentista>Listar();

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(Dentista obj);
    }
}
