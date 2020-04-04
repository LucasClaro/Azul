using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AzulClaro
{
    public class Azulejo
    {
        public int id { get; set; }
        public Image image { get; set; }
        public int quantidade { get; set; }

        public void DefinirCor()
        {
            switch (this.id)
            {
                case 0:
                    this.image = Properties.Resources.marcaUm;
                    break;
                case 1:
                    this.image = Properties.Resources.a1;
                    break;
                case 2:
                    this.image = Properties.Resources.a2;
                    break;
                case 3:
                    this.image = Properties.Resources.a3;
                    break;
                case 4:
                    this.image = Properties.Resources.a4;
                    break;
                case 5:
                    this.image = Properties.Resources.a5;
                    break;
                default:
                    break;
            }
        }

        public static string LembraCor(int id, bool plural)
        {
            string retorno;
            switch (id)
            {
                case 1:
                    retorno = "Azul";
                    if (plural)
                    {
                        retorno = "Azuis";
                    }
                    break;
                case 2:
                    retorno = "Amarelo";
                    if (plural)
                    {
                        retorno += "s";
                    }
                    break;
                case 3:
                    retorno = "Vermelho";
                    if (plural)
                    {
                        retorno += "s";
                    }
                    break;
                case 4:
                    retorno = "Preto";
                    if (plural)
                    {
                        retorno += "s";
                    }
                    break;
                case 5:
                    retorno = "Branco";
                    if (plural)
                    {
                        retorno += "s";
                    }
                    break;
                default:
                    retorno = "";
                    break;
            }

            return retorno;
        }
    }
}
