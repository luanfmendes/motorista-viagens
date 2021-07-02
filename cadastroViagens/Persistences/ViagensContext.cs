using cadastroViagens.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Persistences
{
    public class ViagensContext : DbContext
    {
        public DbSet<Viagem> Viagem { get; set; }

        public DbSet<Caminhao> Caminhao { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Motorista> Motorista { get; set; }



        public ViagensContext(DbContextOptions o) : base(o)
        {

        }
    }
}
