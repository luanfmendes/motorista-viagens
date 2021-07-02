using cadastroViagens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Repositories
{
    public interface IViagemRepository
    {
         void Cadastrar(Viagem viagem);

        void Atualizar(Viagem viagem);

        void Remover(int codigo);

        IList<Viagem> Listar();

        Viagem BuscarPorCodigo(int codigo);

        void Salvar();
    }
}
