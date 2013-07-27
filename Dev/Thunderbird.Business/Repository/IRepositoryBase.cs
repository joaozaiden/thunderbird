using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunderbird.Business.Repository
{
    public interface IRepositoryBase<T>
    {
        T Salvar(T entity);
        
        T Alterar(T entity);

        void Excluir(T entity);

        T ObterPorId(int id);

        IList<T> ObterTodos();

    }

}
