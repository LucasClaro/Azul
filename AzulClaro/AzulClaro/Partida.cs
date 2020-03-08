using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzulClaro
{
    class Partida
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<Jogador> jogadores { get; set; }
    }
}
