using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Models
{
    public class Motorista
    {
        public int MotoristaId { get; set; }

        [Required, MaxLength(20)]
        public string Nome { get; set; }

        public Caminhao Caminhao { get; set; }

        public int CaminhaoId { get; set; }

        public Endereco Endereco { get; set; }

        public int EnderecoId { get; set; }
    }
}
