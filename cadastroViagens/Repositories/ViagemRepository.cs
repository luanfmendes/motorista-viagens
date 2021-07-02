using Microsoft.EntityFrameworkCore;
using cadastroViagens.Models;
using cadastroViagens.Persistences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Repositories
{
    public class ViagemRepository : IViagemRepository
    {
        private ViagensContext _context { get; set; }

        public ViagemRepository(ViagensContext context)
        {
            _context = context;
        }

        public void Atualizar(Viagem Viagem)
        {
            _context.Viagem.Update(Viagem);
        }

        public Viagem BuscarPorCodigo(int codigo)
        {
            return _context.Viagem.Find(codigo);
        }

        public void Cadastrar(Viagem Viagem)
        {
            _context.Viagem.Add(Viagem);
        }

        public IList<Viagem> Listar()
        {
            return _context.Viagem.Include(x => x.Motorista).ToList();
        }

        public void Remover(int codigo)
        {
            var Viagem = _context.Viagem.Find(codigo);
            _context.Remove(Viagem);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}



