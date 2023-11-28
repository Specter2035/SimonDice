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
    public partial class SimonDiceInversoN1 : Form
    {
        int ControlSecuencia = 0;
        Random NumeroAleatorio;
        List<int> SimonDice = new List<int>();
        //se crea una nueva lista para comparala con lo que simon dice para que  al momento de que el
        //jugador la repliqe de manera inversa se verifique si es correcto
        List<int> SecuenciaNormal = new List<int>();//Se crea una nueva lista para almacenar la secuancia original 
        bool Hablando = false;
        public SimonDiceInversoN1()
        {
            InitializeComponent();
            NumeroAleatorio = new Random();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            SimonDice.Add(NumeroAleatorio.Next(0, 4));
            SecuenciaNormal = new List<int>(SimonDice);//se crea una copia de la de simon dice ya que
                                                       //esa a medida que avanza se va modificando

            new Thread(IniciarJuego).Start();
        }

        public void IniciarJuego()
        {
            Thread.Sleep(500);
            Hablando = true;
            foreach (int ParteActiva in SimonDice)
            {
                switch (ParteActiva)
                {
                    case 0:
                        P_0.Image = Properties.Resources.CAzul_2;
                        Thread.Sleep(500);
                        P_0.Image = Properties.Resources.CAzul_1;
                        break;
                    case 1:
                        P_1.Image = Properties.Resources.CVerde_2;
                        Thread.Sleep(500);
                        P_1.Image = Properties.Resources.CVerde_1;
                        break;
                    case 2:
                        P_2.Image = Properties.Resources.CRojo2;
                        Thread.Sleep(500);
                        P_2.Image = Properties.Resources.CRojo_1;
                        break;
                    case 3:
                        P_3.Image = Properties.Resources.CAmarillo_2;
                        Thread.Sleep(500);
                        P_3.Image = Properties.Resources.CAmarillo1;
                        break;

                }
                Thread.Sleep(500);
            }
            Hablando = false;

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        public void VerificarBotonPresionado(int ValorBoton)
        {
            if (Hablando || SimonDice.Count == 0) return;
            //Compara el ultimo elemento de la secuencia Normal con el boton que presione el jugador
            //en forma inversa,si son los mismos botones que el que esta guardado en la secuencia
            //la varieble contro secuencia aumenta
            if (SecuenciaNormal[SecuenciaNormal.Count - 1 - ControlSecuencia] == ValorBoton)
                ControlSecuencia++;
            else
            {
                MessageBox.Show("Tu puntaje final es:" + SimonDice.Count);
                ControlSecuencia = 0;
                SimonDice = new List<int>();
            }
            //despues de cada acierto,se agrega un nuevo numero aleatorio
            if (ControlSecuencia >= SimonDice.Count)
            {
                ControlSecuencia = 0;
                SimonDice.Add(NumeroAleatorio.Next(0, 4));
                SecuenciaNormal = new List<int>(SimonDice);//se actualiza la secuencia Normal
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

        private void P_0_MouseDown(object sender, MouseEventArgs e)
        {
            P_0.Image = Properties.Resources.CAzul_2;
            ReproducirMusica();
        }

        private void P_0_MouseUp(object sender, MouseEventArgs e)
        {
            P_0.Image = Properties.Resources.CAzul_1;
        }

        private void P_3_MouseDown(object sender, MouseEventArgs e)
        {
            P_3.Image = Properties.Resources.CAmarillo_2;
            ReproducirMusica();
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
        private void ReproducirMusica()
        {
            // Aquí puedes incluir la lógica para reproducir la música cuando se presiona un botón si lo tienes implementado
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            SeleccionaNivelInverso sni = new SeleccionaNivelInverso();
            sni.Show();
            this.Close();
        }
    }
}
