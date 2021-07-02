using Microsoft.EntityFrameworkCore;
using cadastroViagens.Models;
using cadastroViagens.Persistences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Repositories
{
    public class MotoristaRepository : IMotoristaRepository
    {
        private ViagensContext _context { get; set; }

        public MotoristaRepository(ViagensContext context)
        {
            _context = context;
        }

        public void Atualizar(Motorista motorista)
        {
            _context.Motorista.Update(motorista);
        }

        public Motorista BuscarPorCodigo(int codigo)
        {
            return _context.Motorista.Include(x => x.Caminhao).Include(x => x.Endereco).FirstOrDefault(x => x.MotoristaId == codigo);
        }

        public void Cadastrar(Motorista motorista)
        {
            _context.Motorista.Add(motorista);
        }

        public IList<Motorista> Listar()
        {
            return _context.Motorista.Include(x => x.Caminhao).Include(x => x.Endereco).ToList();
        }

        public void Remover(int codigo)
        {
            var motorista = _context.Motorista.Find(codigo);
            _context.Remove(motorista);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
