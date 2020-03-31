using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzulServer;

namespace AzulClaro
{
    public class Tabuleiro
    {
        public bool[,,] parede { get; set; }
        public Azulejo Fileira1 { get; set; }
        public List<Azulejo> Fileira2 { get; set; }
        public List<Azulejo> Fileira3 { get; set; }
        public List<Azulejo> Fileira4 { get; set; }
        public List<Azulejo> Fileira5 { get; set; }
        public List<Azulejo> Chao { get; set; }        
    }
}
