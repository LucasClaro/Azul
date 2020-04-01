using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzulServer;

namespace AzulClaro
{
    public class Jogador
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public int pontos { get; set; }
        public bool bot { get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public void PreencherTabuleiro(int idVerificado)
        {
            string txt = Jogo.LerTabuleiro(this.id, this.senha, idVerificado);
        }
    }
}
