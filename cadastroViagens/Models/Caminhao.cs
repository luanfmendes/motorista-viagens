using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Models
{
    public class Caminhao
    {
        public int CaminhaoId { get; set; }

        [Required, MaxLength(20)]
        public string Placa { get; set; }

        [Required, MaxLength(20)]
        public string Marca { get; set; }

        [Required, MaxLength(20)]
        public string Modelo { get; set; }

        [Required, MaxLength(10)]
        public string Eixos { get; set; }
        
    }
}
