using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Produto_Marca.Repositories.Interfaces {
    public interface IRepository<T> {

        void Criar(T obj);
        void Excluir(T obj);
        void Editar(T obj);
        IEnumerable<T> Listar();
        T Buscar(int id);

    }
}
