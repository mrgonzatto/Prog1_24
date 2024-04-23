using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240325_01.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime DtAtendimento { get; set; }
        public Animal Animal {get; set;}
        public Veterinario Veterinario { get; set; }
        public string Observacao {get; set;}
    }
}