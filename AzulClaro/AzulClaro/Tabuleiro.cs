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
        public bool[,] parede { get; set; }
        public Azulejo[] modelo { get; set; }
        public List<Azulejo> chao { get; set; }        
    }
}
