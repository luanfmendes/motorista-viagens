using cadastroViagens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Repositories
{
    public interface IMotoristaRepository
    {
        void Cadastrar(Motorista motorista);

        void Atualizar(Motorista motorista);

        void Remover(int codigo);

        IList<Motorista> Listar();

        Motorista BuscarPorCodigo(int codigo);

        void Salvar();
    }
}
