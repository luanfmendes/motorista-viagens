using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Models
{
    public class Viagem
    {

        public int ViagemId { get; set; }

        [Required]
        public DateTime DataHoraViagem { get; set; }

        [Required, MaxLength(40)]
        public string LocalEntrega { get; set; }

        [Required, MaxLength(40)]
        public string LocalSaida { get; set; }

        [Required, MaxLength(20)]
        public string KmTotalEntreCidades { get; set; }
        public Motorista Motorista { get; set; }

        [Required]
        public int? MotoristaId { get; set; }
    }
}
