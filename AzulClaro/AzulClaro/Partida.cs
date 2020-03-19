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

            for (int i = 1; i <= numFabs; i++)//Controla as fábricas
            {
                Fabrica fabrica = new Fabrica();
                fabrica.id = i;

                while (i == Convert.ToInt32(fabs[p].Substring(0, 1)))//Controla o azulejo
                {
                    Azulejo azul = new Azulejo();
                    azul.Id = Convert.ToInt32(fabs[p].Substring(1, 1));
                    azul.quantidade = Convert.ToInt32(fabs[p].Substring(fabs[p].Length, 1));//Lê o último caractere e pega a quantidade

                    //Define a imagem do Azulejo
                    switch (azul.Id)
                    {
                        case 1:
                            azul.image = Properties.Resources.a1;
                            break;
                        case 2:
                            azul.image = Properties.Resources.a2;
                            break;
                        case 3:
                            azul.image = Properties.Resources.a3;
                            break;
                        case 4:
                            azul.image = Properties.Resources.a4;
                            break;
                        case 5:
                            azul.image = Properties.Resources.a5;
                            break;
                        default:
                            break;
                    }

                    p++;
                }

                //Definir o x y das fábricas aqui

                this.fabricas.Add(fabrica);
            }
        }
    }
}
