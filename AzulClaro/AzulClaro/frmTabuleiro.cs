﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace AzulClaro
{
    public partial class frmTabuleiro : Form
    {
        public string erro { get; set; }
        public int vez { get; set; }
        public Partida partida { get; set; }
        public Jogador jogador { get; set; }
        public Compra compra { get; set; }
        public List<Compra  > listaCompras { get; set; }
        public List<Compra> BoasCompras { get; set; }

        struct valores
        {
            int fabId;
            int azulId;
            int qtd;
        }
        public frmTabuleiro(Partida partida, Jogador jogador)
        {
            this.partida = partida;
            this.jogador = jogador;
            this.Location = new Point(0, 0);
            InitializeComponent();
        }//Construtor: preenche os objetos partida e jogador

        private void frmTabuleiro_Load(object sender, EventArgs e)
        {
            lblCabecalho.Text = "Partida: " + partida.nome + "Jogador: " + jogador.id + " " + jogador.nome;

            if (verificaLogin().Equals("ERRO"))//Confere senha do jogador
            {
                this.Close();
                tmrRefresh.Enabled = false;
            }
            else
            {
                //tmrRefresh.Enabled = jogador.bot;

                //Preenche Tudo
                configurarFabricas();
                desenharCentro();                
                desenharFabricas();
                desenharTabuleiro();
            }
        }//Load do form: Verifica senha e Desenha Tudo

        /////////////////////////////////////////////////////////////

        public string verificaLogin()
        {
            string txtF;

            txtF = Jogo.LerFabricas(jogador.id, jogador.senha);

            if (txtF.Equals("")) { return "NAODEUERRO"; }
            else if (txtF.Substring(0, 4) == "ERRO")
            {
                this.erro = txtF.Substring(5);
                this.Close();
                return "ERRO";
            }
            return "NAODEUERRO";
        }//Verifica senha do Jogador

        /////////////////////////////////////////////////////////////

        public void configurarFabricas()
        {
            string txtF;

            txtF = Jogo.LerFabricas(jogador.id, jogador.senha);

            if (txtF.Equals("")) { }
            else if (txtF.Substring(0, 4) == "ERRO")
            {
                this.erro = txtF.Substring(5);
                this.Close();
                return;
            }                        

            partida.preencherFabricas(txtF);//Preenche as fábricas do obj partida
           
        }//Configura Texto das fábricas e chama preencher fabricas da partida
        public void desenharFabricas()
        {
            int i;
            int ang = 0;

            definePos(partida.qtdFabricas);

            foreach (Fabrica fab in partida.fabricas) //Para cada fabrica na aprtida
            {
                i = 0; //Qual é o azulejo, vai de 0 a 3
                ang = 0; //Qual o angulo, será usado para definir se fica em cima ou em baixo

                foreach (Azulejo azul in fab.azulejos) //Para cada azulejo da fabrica
                {
                    for (int j = 0; j < azul.quantidade; j++) //Ver a quantidade de azulejos
                    {
                        if (i % 2 == 0) // Ver se é o 1º, 2º, 3º ou 4º e coloca um angulo pra cima ou baixo;
                            ang = 90;
                        else
                            ang = 270;

                        PictureBox pcbAzul = new PictureBox(); //Azulejo
                        pcbAzul.Image = azul.image;
                        int x = fab.x - 60;                    //Pega o centro da fabrica e volta 50
                        if (i > 1) x += 52;                    //Se for o 3º e 4º azulejo, move eles pro lado
                        pcbAzul.Location = new Point(x, fab.y + 26 * Convert.ToInt32(Math.Round(Math.Sin(ang * Math.PI / 180))) - 55); //Define a posição do azulejo x -> calculado anteriomente, y -> y da fabrica + ou - sen do ang
                        i++;
                        pcbAzul.Width = 50;
                        pcbAzul.Height = 50;
                        pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcbAzul.Name = "pcbFabricas" + fab.id + "" + i;

                        pcbAzul.AccessibleName = "F" + fab.id + azul.id + azul.quantidade;//Informações para o carrinho
                        pcbAzul.Click += azulejo_Click;

                        this.Controls.Add(pcbAzul);            //Adiciona no form
                        pcbAzul.BringToFront();                //Puxa pra frente
                    }
                }
            }
        }//Chama definePos e desenha seus azulejos
        public void desenharCentro()
        {
            string txtC;
            txtC = Jogo.LerCentro(jogador.id, jogador.senha);

            if (txtC.Substring(0, 4) == "ERRO")
            {
                this.erro = txtC.Substring(5);
                Close();
                return;
            }

            partida.preencherCentro(txtC);
            //Desenhar centro controla i e j
            //Vai do canto superior esquerdo e somando +50 (altura e largura)
            //Quando atingir um certo numero no horizontal, incrementar 1 na altura e zerar horizontal e ir até acabar
            Point[] points = partida.centro.organizarEmLinhas();
            int w = 0;

            foreach(Azulejo azul in partida.centro.azulejos)
            {
                for(int i = 0; i < azul.quantidade; i++)
                {
                    PictureBox pcbAzul = new PictureBox(); //Azulejo
                    pcbAzul.Image = azul.image;

                    //pcbAzul.Location = new Point(190 + 50 * Xcentro, 265 + 50 * Ycentro);
                    pcbAzul.Location = points[w++];

                    pcbAzul.Width = 50;
                    pcbAzul.Height = 50;
                    pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                    pcbAzul.Name = "pcbCentro" + "" + i;

                    pcbAzul.AccessibleName = "c0" + azul.id + azul.quantidade;//Informações para o carrinho
                    pcbAzul.Click += azulejo_Click;

                    this.Controls.Add(pcbAzul);            //Adiciona no form
                    pcbAzul.BringToFront();                //Puxa pra frente

                    //if (qtdAzul++ > 4)
                    //{
                    //    Xcentro = 0;
                    //    Ycentro++;
                    //    qtdAzul = 0;
                    //}
                    //else
                    //    Xcentro++;
                }
            }
        }//Configura Texto do centro, chama preencher centro e desenha seus azulejos
        public void desenharTabuleiro()
        {
            jogador.preencherTabuleiro(jogador.id, jogador.senha);
            //C9C4F5

            /* ======= MODELO ======= */
            //superior esquerdo 1 do modelo 1 - 1025,100
            for (int i = 0; i < jogador.tabuleiro.modelo.Length; i++)
            {
                if (jogador.tabuleiro.modelo[i] != null)
                {
                    for (int j = 0; j < jogador.tabuleiro.modelo[i].quantidade; j++)
                    {
                        PictureBox pcbAzul = new PictureBox(); //Azulejo
                        pcbAzul.Image = jogador.tabuleiro.modelo[i].image;
                        pcbAzul.Location = new Point(1025 - 50 * j, 100 + (50 * i));
                        Console.WriteLine(i + " " + jogador.tabuleiro.modelo[i].id + " x= " + (1025 - 50 * j) + " y= " + (100 + 50 * i));
                        pcbAzul.Width = 50;
                        pcbAzul.Height = 50;
                        pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                        pcbAzul.Name = "pcbModelo" + "" + i + "" + jogador.tabuleiro.modelo[i].id + "" + j;

                        this.Controls.Add(pcbAzul);            //Adiciona no form
                        pcbAzul.BringToFront();                //Puxa pra frente
                    }
                }
            }

            /* ======= PAREDE ======= */
            List<PictureBox> paredeAzs = Controls.OfType<PictureBox>().ToList().Where(az => az.Name.StartsWith("pcbParede")).ToList();
            paredeAzs.Remove(paredeAzs.Find(pcb => pcb.Name.Equals("pcbParede")));

            for(int lp = 0; lp < 5; lp++)
            {
                for(int cp = 0; cp < 5; cp++)
                {
                    paredeAzs.Find(azul => azul.Name.Equals("pcbParede" + lp + cp)).Visible = jogador.tabuleiro.parede[lp, cp];
                }
            }

            /* ======= CHÃO ======= */
            int c = 0;
            foreach (Azulejo azul in jogador.tabuleiro.chao)
            {
                PictureBox pcbAzul = new PictureBox(); //Azulejo
                pcbAzul.Image = azul.image;
                pcbAzul.Location = new Point(715 + 50 * c, 410);
                pcbAzul.Width = 50;
                pcbAzul.Height = 50;
                pcbAzul.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbAzul.Name = "pcbChao" + "" + c;
                c++;
                this.Controls.Add(pcbAzul);            //Adiciona no form
                pcbAzul.BringToFront();                //Puxa pra frente
            }
        }
        public void definePos(int qtd)
        {
            int[] posX = { }; //Array dos Xs dos centros das fabricas
            int[] posY = { }; //Array dos Ys dos centros das fabricas
            switch (qtd)
            {
                case 5:
                    pcbFabricas.Image = Properties.Resources.f5; //5 fabricas
                    posX = new int[] { 345, 577, 505, 183, 113 };
                    posY = new int[] { 185, 397, 667, 667, 397 };
                    break;
                case 7:
                    pcbFabricas.Image = Properties.Resources.f7; //7 fabricas
                    posX = new int[] { 345, 555, 590, 460, 230, 103, 135 };
                    posY = new int[] { 185, 290, 505, 665, 665, 505, 290 };
                    break;
                case 9:
                    pcbFabricas.Image = Properties.Resources.f9; //9 fabricas
                    posX = new int[] { 345, 518, 592, 574, 426, 245, 122, 102, 174 };
                    posY = new int[] { 175, 223, 388, 548, 672, 672, 548, 388, 223 };
                    break;
            }

            //Define as posições    
            for (int i = 0; i < qtd; i++)
            {
                partida.fabricas[i].x = posX[i];
                partida.fabricas[i].y = posY[i];
            }
        }//Define a posição das fábricas

        /////////////////////////////////////////////////////////////

        public void atualizarAzulejos()
        {
            tirarAzulejos();

            configurarFabricas();
            desenharCentro();
            desenharFabricas();
            desenharTabuleiro();
        }//Função que tira os azulejos da tela a coloca de novo     
        public void tirarAzulejos()
        {
            List<PictureBox> pcbs = Controls.OfType<PictureBox>().Where(pcb => pcb.Name.StartsWith("pcbFabricas") || pcb.Name.StartsWith("pcbModelo") || pcb.Name.StartsWith("pcbChao") || pcb.Name.StartsWith("pcbCentro")).ToList();

            pcbs.Remove(pcbs.Find(pcb => pcb.Name.Equals("pcbFabricas"))); //Remove o PictureBox do fundo (Fabricas)

            for (int i = 0; i < pcbs.Count; i++)
            {
                Controls.Remove(pcbs[i]);       //Remove do Form
                pcbs[i].Image = null;
                pcbs[i] = null;                 //Deixa null a PictureBox
            }
            //pcbs = null;
            GC.Collect();
        }//Tira os PictureBoxes dos azulejos da tela e atribui null a eles (e torce para o GC fazer o resto);
        public void listarPontos()
        {
            string txt = Jogo.ListarJogadores(partida.id);
            lblPontos.Text = txt;
        }

        /////////////////////////////////////////////////////////////                    

        private void btnVez_Click(object sender, EventArgs e)
        {
            lblVez.Text = Jogo.VerificarVez(jogador.id, jogador.senha);
        }//Botão Vez: printa a vez
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            jogarAutomatico();
            atualizarAzulejos();
        }//Recarrega azulejos (REMOVER)
        public void Jogar()
        {
            string txt = Jogo.Jogar(jogador.id, jogador.senha, compra.tipo, compra.fabrica, compra.azulejo, compra.modelo);
            lblErro.Text = txt;
            atualizarAzulejos();
        }//Manda um pedido de compra
        private void azulejo_Click(object sender, EventArgs e)
        {
            compra = new Compra();//Instacia o objeto compra

            PictureBox pcb = (PictureBox)sender;//Recebe a picturebox que mandou o evento

            //Preence o objeto compra
            compra.tipo = pcb.AccessibleName.Substring(0,1);
            compra.fabrica = Convert.ToInt32(pcb.AccessibleName.Substring(1, 1));
            compra.azulejo = Convert.ToInt32(pcb.AccessibleName.Substring(2, 1));
            compra.qtd = Convert.ToInt32(pcb.AccessibleName.Substring(3, 1));

            string cor = Azulejo.LembraCor(compra.azulejo, compra.qtd > 1);//Pega a cor na função da classe azulejo, essa comparação diz se é plural ou não
            string azu = "azulejo";//Pego o plural ou o singular de Azulejos
            if (compra.qtd > 1)
                azu += "s";
            string dx;//Vê se a compra é da fábrica ou do centro
            if (compra.tipo == "F")
                dx = "da fábrica " + compra.fabrica;
            else
                dx = "do centro";

            lblCompra.Text = "Compra: " + compra.qtd + " " + azu + " " + cor + " " + dx;//Escreve a corrinho de compras na tela

        }//Clique em um azulejo das fábricas e centro: adiciona o azulejo no carrinho     
        private void btnModelo1_Click(object sender, EventArgs e)
        {
            compra.modelo = 1;
            Jogar();
        }//Botão modelo 1: Chama jogar mandando 1 como modelo
        private void btnModelo2_Click(object sender, EventArgs e)
        {
            compra.modelo = 2;
            Jogar();
        }//Botão modelo 2: Chama jogar mandando 2 como modelo
        private void btnModelo3_Click(object sender, EventArgs e)
        {
            compra.modelo = 3;
            Jogar();
        }//Botão modelo 3: Chama jogar mandando 3 como modelo
        private void btnModelo4_Click(object sender, EventArgs e)
        {
            compra.modelo = 4;
            Jogar();
        }//Botão modelo 4: Chama jogar mandando 4 como modelo
        private void btnModelo5_Click(object sender, EventArgs e)
        {
            compra.modelo = 5;
            Jogar();
        }//Botão modelo 5: Chama jogar mandando 5 como modelo        

        /////////////////////////////////////////////////////////////

        public void Vez()
        {
            //string txt = Jogo.VerificarVez(jogador.id, jogador.senha);

            //string v = txt.Substring(2,3);
            //v = v.Remove(v.Length - 2);
            //this.vez = Convert.ToInt32(v);

            //lblVez.Text = "jogador: " + txt;
            
            //if (!(vez == jogador.id))
            //{
            //    atualizarAzulejos();
            //    btnModelo1.Enabled = false;
            //    btnModelo2.Enabled = false;
            //    btnModelo3.Enabled = false;
            //    btnModelo4.Enabled = false;
            //    btnModelo5.Enabled = false;

            //    this.compra = null;
            //}
            //else
            //{
            //    if (this.compra == null)
            //    {
            //        this.compra = new Compra();
            //    }

            //    btnModelo1.Enabled = true;
            //    btnModelo2.Enabled = true;
            //    btnModelo3.Enabled = true;
            //    btnModelo4.Enabled = true;
            //    btnModelo5.Enabled = true;
            //}

        }

        /////////////////////////////////////////////////////////////

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            //Vez();            
            separaPorQuantidade();
            jogarAutomatico();
            listarPontos();
        }
        private bool verVez()
        {
            string txt = Jogo.VerificarVez(jogador.id, jogador.senha);

            string[] v = txt.Split(',');
            this.vez = Convert.ToInt32(v[1]);
            return this.vez == jogador.id;
        }

        //Dicionário (principal) que guarda <Quantidade de azulejos que quer, DicionarioCor>  ----> DicionarioCor<Id do azulejo (Cor) , Lista de compras possíveis >
        Dictionary<int, Dictionary<int, List<Compra>>> azulPorQtd;
        //Para recuperar um valor (Lista de compras) desse monstrinho usar tipo matriz azulPorQtd[Int de quantidade][Int de cor]
        private void jogarAutomatico()
        {
            compra = new Compra();

            if(verVez())
            {
                atualizarAzulejos();

                //Analisa os modelos e diz se falta algo para completa-los
                listaCompras = new List<Compra>();
                listaComprasModelos();
                listaComprasModelosVazios();

                listaCompras = listaCompras.OrderByDescending(l => l.qtd).ToList();

                //Analisar os azulejos das fabricas
                //ver em qual modelo não tem nada, cabe ou completa
                //ou 
                //Ver as linhas do modelo e ver qual dos azulejos das fabricas
                //cabe(m) ou completa(m)
                if (semOpcaoCores())
                {
                    //azulPorQtd[3][1].
                    //Aqui vc é obrigado a comprar pro chão, buscas a compra menos pior
                    for(int qtd = 1; qtd <= 6; qtd++)
                    {
                        for(int cor = 1; cor <= 5; cor++)
                        {
                            if (azulPorQtd[qtd][cor].Count > 0)
                            {
                                compra.azulejo = azulPorQtd[qtd][cor].First().azulejo;
                                compra.fabrica = azulPorQtd[qtd][cor].First().fabrica;
                                compra.tipo = azulPorQtd[qtd][cor].First().tipo;
                                compra.qtd = azulPorQtd[qtd][cor].First().qtd;
                                compra.modelo = 0;
                                Jogar();
                                return;
                            }
                        }
                    }
                }

                foreach (Compra c in listaCompras)
                {
                    if(azulPorQtd[c.qtd][c.azulejo].Count > 0)
                    {
                        compra.fabrica = azulPorQtd[c.qtd][c.azulejo].First().fabrica;
                        compra.tipo = azulPorQtd[c.qtd][c.azulejo].First().tipo;
                        compra.azulejo = c.azulejo;
                        compra.qtd = c.qtd;
                        compra.modelo = c.modelo;
                        Jogar();
                        return;
                    }
                }

                if (jogaComOqTem())
                {
                    return;
                }                



                lidaComABaldada();
                         

                /*
                bool jogou = false;
                for(int i = 0; i < jogador.tabuleiro.modelo.Length; i++)
                {
                    if(jogador.tabuleiro.modelo[i] == null)
                    {
                        foreach (Fabrica fab in partida.fabricas)
                        {
                            foreach (Azulejo a in fab.azulejos)
                            {
                                if (a.quantidade <= i+1)
                                {
                                    //string txt = Jogo.Jogar(jogador.id, jogador.senha, "f", fab.id, a.id, i+1);
                                    textBox1.Text = "\n\ntipo f" + ", Fab id " + fab.id.ToString() + ", azul Id " + a.id.ToString() + ", modelo " + (i + 1).ToString();
                                    //lblErro.Text = txt;
                                    jogou = true;
                                    break;
                                }
                            }
                            if (jogou)
                                break;
                        }
                    }
                    if (jogou)
                        break;
                }*/
                //jogador.tabuleiro.modelo 000000000000000000000000 listaCompras.OrderBy(l => l.qtd);
            }
        }
        private void listaComprasModelos()
        {
            for (int i = 0; i < 5; i++)
            {
                if (jogador.tabuleiro.modelo[i] != null && jogador.tabuleiro.modelo[i].quantidade > 0 && jogador.tabuleiro.modelo[i].quantidade != i+1)//confere se a linha tá prenchida mas não completa
                {
                    int qtd = (i + 1) - jogador.tabuleiro.modelo[i].quantidade;
                    while (qtd >= 1)
                    {
                        Compra compra = new Compra();
                        compra.azulejo = jogador.tabuleiro.modelo[i].id;
                        compra.modelo = i+1;
                        compra.qtd = qtd;
                        listaCompras.Add(compra);

                        qtd--;
                    }                    

                    textBox1.Text += compra.qtd.ToString() + Azulejo.LembraCor(compra.azulejo, false) + " modelo " + (i+1).ToString() + "\r\n";
                }
            }
        }//Busca Linhas de Modelo incompletas
        private void listaComprasModelosVazios()
        {
            for (int l = 0; l < 5; l++)
            {
                Compra MelhorCorLinha = new Compra();

                if (jogador.tabuleiro.modelo[l] == null || jogador.tabuleiro.modelo[l].quantidade == 0)
                {
                    int maisPontos = 0;
                    for (int c = 0; c < 5; c++)
                    {
                        
                        if (!jogador.tabuleiro.parede[l,c])
                        {
                            int p = checarPontosAzul(l, c);
                            if (p >= maisPontos)
                            {
                                maisPontos = p;


                                MelhorCorLinha.azulejo = Azulejo.VerCorNaParede(l, c);


                                MelhorCorLinha.modelo = l +1;
                                MelhorCorLinha.qtd = l + 1;

                            }
                        }
                    }
                    int qtd = MelhorCorLinha.qtd;
                    while (qtd >= 1)
                    {
                        Compra c = new Compra();
                        c.azulejo = MelhorCorLinha.azulejo;
                        c.modelo = MelhorCorLinha.modelo;
                        c.qtd = qtd;
                        listaCompras.Add(c);
                        qtd--;
                    }
                    textBox1.Text += Azulejo.LembraCor(MelhorCorLinha.azulejo, false) + " modelo " + (l + 1).ToString() + "\r\n";
                }
            }
        }//Busca a melhor cor pra cada linha de modelo vazia
        private int checarPontosAzul(int linha, int coluna)
        {
            int pontos = 1;
            int vizinhos = 0;
            bool conectado = false;

            for (int i = 0; i < 5; i++)//Checa os pontos na linha
            {
                if (i < coluna)
                {
                    if (jogador.tabuleiro.parede[linha, i])
                    {
                        vizinhos++;
                    }
                    else
                    {
                        vizinhos = 0;
                    }
                }
                else if (i == coluna)
                {
                    pontos += vizinhos;
                    vizinhos = 0;
                    conectado = true;
                }
                else if (i > coluna)
                {
                    if (jogador.tabuleiro.parede[linha, i])
                    {
                        vizinhos++;
                        if (conectado && i == 4)//Verifica se os vizinhos do final estão conectados ao azulejo  //i == 4 && vizinhos == 4 - coluna
                        {
                            pontos += vizinhos;
                        }
                    }
                    else
                    {
                        if (conectado)
                            pontos += vizinhos;
                        
                        vizinhos = 0;
                        conectado = false;
                    }
                }
            }

            conectado = false;
            vizinhos = 0;

            for (int i = 0; i < 5; i++)//Checa os pontos na coluna
            {
                if (i < linha)
                {
                    if (jogador.tabuleiro.parede[i, coluna])
                    {
                        vizinhos++;
                    }
                    else
                    {
                        vizinhos = 0;
                    }
                }
                else if (i == linha)
                {
                    pontos += vizinhos;
                    conectado = true;
                    vizinhos = 0;
                }
                else if (i > linha)
                {
                    if (jogador.tabuleiro.parede[i, coluna])
                    {
                        vizinhos++;
                        if (conectado && i == 4) //i == 4 && vizinhos == 4 - linha
                        {
                            pontos += vizinhos;
                        }
                    }
                    else
                    {
                        if(conectado)
                            pontos += vizinhos;

                        vizinhos = 0;
                        conectado = false;
                    }
                }
            }

            return pontos;
        }//Diz quantos pontos a linha vai fazer

        /*private bool tabuleiroCheio()
        {
            for (int i = 0; i < 5; i++)
            {
                if (jogador.tabuleiro.modelo[i] == null || jogador.tabuleiro.modelo[i].quantidade == 0)
                {
                    return false;
                }
            }
            return true;
        }*/

        private bool semOpcaoCores()
        {
            List<int> Ids = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                if(jogador.tabuleiro.modelo[i] == null)//Verifica as linhas vazias se ela pode colocar alguma das cores a venda
                {
                    for (int cor = 1; cor < 6; cor++)
                    {
                        if (CorDisponível(cor))
                        {
                            if(podeColocar(cor, i+1))
                            {
                                return false;
                            }
                        }
                    }                    
                }
                
                if (jogador.tabuleiro.modelo[i] != null && jogador.tabuleiro.modelo[i].quantidade != i + 1)//Verifica as cores usadas nas linhas preenchidas não completas
                {
                    if (CorDisponível(jogador.tabuleiro.modelo[i].id))
                    {
                        return false;
                    }

                }
            }

            return true;

        }//Diz se você tem ainda como comprar algo

        private bool CorDisponível(int id)
        {

            foreach (Fabrica fabrica in partida.fabricas)
            {
                foreach (Azulejo azulejo in fabrica.azulejos)
                {
                    if(azulejo.id == id)
                    {
                        return true;
                    }
                }
            }

            foreach (Azulejo azulejo in partida.centro.azulejos)
            {
                if (azulejo.id == id && azulejo.quantidade > 0)
                {
                    return true;
                }
            }

            return false;


        }//Vê se tal cor está disponível

        bool podeColocar(int azulejo, int modelo)
        {

            for(int i = 0; i < 5; i++)
            {
                if(jogador.tabuleiro.parede[modelo - 1, i])
                {
                    if (azulejo == Azulejo.VerCorNaParede(modelo - 1, i))
                        return false;
                }
            }
            return true;
        }


        bool jogaComOqTem()
        {
            // partida.fabricas;
            // partida.centro;
            List<Compra> lc = new List<Compra>();

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if(azulPorQtd[i][j].Count > 0)
                    {
                        lc.Add(azulPorQtd[i][j].First());
                    }
                }
            }

            for (int l = 4; l >= 0; l--)
            {
                if (jogador.tabuleiro.modelo[l] != null && jogador.tabuleiro.modelo[l].quantidade > 0 && jogador.tabuleiro.modelo[l].quantidade != l + 1)
                {
                    foreach (Compra c in lc)
                    {
                        if (jogador.tabuleiro.modelo[l].id == c.azulejo)
                        {
                            compra.fabrica = c.fabrica;
                            compra.tipo = c.tipo;
                            compra.azulejo = c.azulejo;
                            compra.qtd = c.qtd;
                            compra.modelo = l + 1;
                            Jogar();
                            return true;
                        }
                    }
                }
            }

            for (int l = 4; l >= 0; l--)
            {
                if (jogador.tabuleiro.modelo[l] == null || jogador.tabuleiro.modelo[l].quantidade == 0)
                {
                    foreach (Compra c in lc)
                    {
                        if (podeColocar(c.azulejo, l+1))
                        {
                            compra.fabrica = c.fabrica;
                            compra.tipo = c.tipo;
                            compra.azulejo = c.azulejo;
                            compra.qtd = c.qtd;
                            compra.modelo = l+1;
                            Jogar();
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        void lidaComABaldada()
        {
            List<Compra> baldadas = new List<Compra>();

            for (int i = 1; i < 6; i++)
            {

                if (azulPorQtd[6][i].Count > 0)
                {
                    baldadas.Add(azulPorQtd[6][i].First());
                }

            }

            baldadas = baldadas.OrderBy(l => l.qtd).ToList();

            foreach (Compra baldada in baldadas)
            {
                for (int i = 5; i > 0; i--)
                {
                    if (jogador.tabuleiro.modelo[i - 1] == null && podeColocar(baldada.azulejo, i)) 
                    {
                        compra.azulejo = baldada.azulejo;
                        compra.fabrica = baldada.fabrica;
                        compra.modelo = i;
                        compra.qtd = baldada.qtd;
                        compra.tipo = baldada.tipo;
                        Jogar();
                        return;
                    }
                    if (jogador.tabuleiro.modelo[i - 1] != null && jogador.tabuleiro.modelo[i - 1].id == baldada.azulejo)
                    {
                        compra.azulejo = baldada.azulejo;
                        compra.fabrica = baldada.fabrica;
                        compra.modelo = i;
                        compra.qtd = baldada.qtd;
                        compra.tipo = baldada.tipo;
                        Jogar();
                        return;
                    }

                }
            }
        }

        /////////////////////////////////////////////////////////////

        //Pega os valores de partida.centro e partida.fabricas e separa em listas por quantidade
        void separaPorQuantidade()
        {
            azulPorQtd = new Dictionary<int, Dictionary<int, List<Compra>>>();

            //Para a quantidade padrão de azulejos que cabem no modelo ( de 1 a 5 )
            for (int quatidadeDeAzulejosPorFabrica = 1; quatidadeDeAzulejosPorFabrica <= 5; quatidadeDeAzulejosPorFabrica++)
            {
                //Pega os azulejosId e fabricasId com determinda quantidade
                var centro1 = (from cen in partida.centro.azulejos where cen.quantidade == quatidadeDeAzulejosPorFabrica select new { fabId = 0, azulId = cen.id, qtd = cen.quantidade }).ToList();
                var fabs1 = (from fabs in partida.fabricas
                             from azs in fabs.azulejos
                             where azs.quantidade == quatidadeDeAzulejosPorFabrica
                             select new { fabId = fabs.id, azulId = azs.id, qtd = azs.quantidade }).ToList();

                //Lista de compras possiveis
                List<Compra> listCompra = new List<Compra>();

                //Trata os valores recebidos e adiciona na lista de compras possiveis
                foreach (var a in centro1)
                {
                    Compra compra = new Compra();
                    compra.fabrica = a.fabId;
                    compra.azulejo = a.azulId;
                    compra.qtd = a.qtd;
                    compra.tipo = "c";

                    // compra.modelo
                    listCompra.Add(compra);
                }

                //Trata os valores recebidos e adiciona na lista de compras possiveis
                foreach (var a in fabs1)
                {
                    Compra compra = new Compra();
                    compra.fabrica = a.fabId;
                    compra.azulejo = a.azulId;
                    compra.qtd = a.qtd;
                    compra.tipo = "f";
                    // compra.modelo
                    listCompra.Add(compra);
                }

                //pega a lista de compras possiveis e separa elas por cor para colocar no dicionario principal
                separaPorCor(quatidadeDeAzulejosPorFabrica, listCompra);
            }

            var centro6Mais = (from cen in partida.centro.azulejos where cen.quantidade > 5 select new { fabId = 0, azulId = cen.id, qtd = cen.quantidade }).ToList();
            List<Compra> listCompra6 = new List<Compra>();
            foreach (var a in centro6Mais)
            {
                Compra compra = new Compra();
                compra.fabrica = a.fabId;
                compra.azulejo = a.azulId;
                compra.qtd = a.qtd;
                compra.tipo = "c";

                // compra.modelo
                listCompra6.Add(compra);
            }
            //pega a lista de compras possiveis e separa elas por cor para colocar no dicionario principal
            separaPorCor(6, listCompra6);
        }

        //Recebe a quantidade e a lista de compras separadas por quantidade e 
        //Adiciona no DicionarioCor<Id do azulejo (Cor) , Lista de compras possíveis > no id do azulejo a lista de compras com aquela quantidade e cor
        void separaPorCor(int quatidadeDeAzulejosPorFabrica, List<Compra> listCompra)
        {
            //DicionarioCor<Id do azulejo (Cor) , Lista de compras possíveis >
            Dictionary<int, List<Compra>> azulPorCor = new Dictionary<int, List<Compra>>();

            //Para cada cor dos azulejos
            for(int i = 1; i <= 5; i++)
            {
                azulPorCor.Add(i,listCompra.Where(c => c.azulejo == i).ToList());
            }

            //Adiciona no dicionario principal
            azulPorQtd.Add(quatidadeDeAzulejosPorFabrica, azulPorCor);
        }
    }
}


//O porquê do cos(270) retornar -1
//https://stackoverflow.com/questions/9652695/why-does-math-cos90-math-pi-180-yield-6-123031769111-and-not-zero
//https://stackoverflow.com/questions/6082632/math-cos-math-sin-in-c-sharp
/* Define posição antigo, deixava os azulejos em cruz
           pcbAzul.Location = new Point(fab.x + 50 * Convert.ToInt32(Math.Round(Math.Cos((ang * Math.PI)/180))), fab.y + 50 * Convert.ToInt32(Math.Round(Math.Sin(ang * Math.PI / 180))) - 50);
           ang += 90;
*/
