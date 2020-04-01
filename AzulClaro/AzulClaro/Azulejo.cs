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
    }
}
