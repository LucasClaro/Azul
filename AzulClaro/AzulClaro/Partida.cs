using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzulServer;

namespace AzulClaro
{
    public class Partida
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Status { get; set; }

        public List<Jogador> jogadores { get; set; }
        public List<Fabrica> fabricas { get; set; }

        public void preencherFabricas(string txt)
        {
            txt = txt.Replace("\r", "");//corta o caracter /r do retorno
            string[] fabs = txt.Split('\n');//Separa as linhas do retorno    

            int numFabs = Convert.ToInt32(fabs[fabs.Length - 1].Substring(0,1));
            int p = 0;

            for (int i = 1; i <= numFabs; i++)
            {
                Fabrica fabrica = new Fabrica();
                fabrica.id = i;

                while(i == Convert.ToInt32(fabs[p].Substring(0,1)))
                {
                    //9 ADB0F8
                }
            }
        }
    }
}
