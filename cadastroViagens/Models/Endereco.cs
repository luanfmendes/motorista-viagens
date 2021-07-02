using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Models
{
    public class Endereco
    {

        public int EnderecoId { get; set; }

        [Required, MaxLength(20)]
        public string Logradouro { get; set; }

        [Required, MaxLength(9)]
        public string Cep { get; set; }

        [Required, MaxLength(12)]
        public string Numero { get; set; }

        [Required, MaxLength(30)]
        public string Bairro { get; set; }

        [Required, MaxLength(30)]
        public string Cidade { get; set; }


    }
}
