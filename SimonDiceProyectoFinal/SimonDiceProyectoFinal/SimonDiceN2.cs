using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonDiceProyectoFinal
{
    public partial class SimonDiceN2 : Form
    {

        int ControlSecuencia = 0;
        Random NumeroAleatorio;
        List<int> SimonDice = new List<int>();
        bool Hablando = false;
        public SimonDiceN2()
        {
            InitializeComponent();
            NumeroAleatorio = new Random();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            SeleccionaNivel sn = new SeleccionaNivel();
            sn.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SimonDice.Add(NumeroAleatorio.Next(0, 4));
            new Thread(IniciarJuego).Start();
        }

        public void IniciarJuego()
        {
            Thread.Sleep(200);
            Hablando = true;
            foreach (int ParteActiva in SimonDice)
            {
                switch (ParteActiva)
                {
                    case 0:
                        P_0.Image = Properties.Resources.CAzul_2;
                        Thread.Sleep(1000);
                        P_0.Image = Properties.Resources.CAzul_1;
                        break;
                    case 1:
                        P_1.Image = Properties.Resources.CVerde_2;
                        Thread.Sleep(1000);
                        P_1.Image = Properties.Resources.CVerde_1;
                        break;
                    case 2:
                        P_2.Image = Properties.Resources.CRojo2;
                        Thread.Sleep(1000);
                        P_2.Image = Properties.Resources.CRojo_1;
                        break;
                    case 3:
                        P_3.Image = Properties.Resources.CAmarillo_2;
                        Thread.Sleep(1000);
                        P_3.Image = Properties.Resources.CAmarillo1;
                        break;
                    case 4:
                        P_4.Image = Properties.Resources.CNegro_2;
                        Thread.Sleep(1000);
                        P_4.Image = Properties.Resources.CNegro_1;
                        break;
                }
                Thread.Sleep(1000);
            }
            Hablando = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
        public void VerificarBotonPresionado(int ValorBoton)
        {
            if (Hablando || SimonDice.Count == 0) return;
            if (SimonDice[ControlSecuencia] == ValorBoton)
                ControlSecuencia++;
            else
            {
                MessageBox.Show("Tu puntaje : " + SimonDice.Count);
                ControlSecuencia = 0;
                SimonDice = new List<int>();
            }
            if (ControlSecuencia >= SimonDice.Count)
            {
                ControlSecuencia = 0;
                SimonDice.Add(NumeroAleatorio.Next(0, 5));
                new Thread(IniciarJuego).Start();
            }
            lblPuntos.Text = SimonDice.Count.ToString();
        }

        private void P_0_Click(object sender, EventArgs e)
        {
            string Presionado = ((PictureBox)sender).Name;
            string[] NumeroBoton = Presionado.Split('_');
            VerificarBotonPresionado(Convert.ToInt32(NumeroBoton[1]));
        }

        private void P_3_MouseDown(object sender, MouseEventArgs e)
        {
            P_3.Image = Properties.Resources.CAmarillo_2;
            ReproducirMusica();
        }

        private void P_0_MouseDown(object sender, MouseEventArgs e)
        {
            P_0.Image = Properties.Resources.CAzul_2;
            ReproducirMusica();
        }

        private void P_0_MouseUp(object sender, MouseEventArgs e)
        {
            P_0.Image = Properties.Resources.CAzul_1;
        }

        private void P_3_MouseUp(object sender, MouseEventArgs e)
        {
            P_3.Image = Properties.Resources.CAmarillo1;
        }

        private void P_1_MouseDown(object sender, MouseEventArgs e)
        {
            P_1.Image = Properties.Resources.CVerde_2;
            ReproducirMusica();
        }

        private void P_1_MouseUp(object sender, MouseEventArgs e)
        {
            P_1.Image = Properties.Resources.CVerde_1;
        }

        private void P_2_MouseDown(object sender, MouseEventArgs e)
        {
            P_2.Image = Properties.Resources.CRojo2;
            ReproducirMusica();
        }

        private void P_2_MouseUp(object sender, MouseEventArgs e)
        {
            P_2.Image = Properties.Resources.CRojo_1;
        }
        private void P_4_MouseDown(object sender, MouseEventArgs e)
        {
            P_4.Image = Properties.Resources.CNegro_2;
            ReproducirMusica();
        }

        private void P_4_MouseUp(object sender, MouseEventArgs e)
        {
            P_4.Image = Properties.Resources.CNegro_1;
        }

        public void ReproducirMusica()
        {

            /*SoundPlayer sndplayr = new SoundPlayer(Properties.Resources.ponglong);
            sndplayr.Play();*/
        }
    }
}
