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
    public partial class SeleccionaNivelInverso : Form
    {
        public SeleccionaNivelInverso()
        {
            InitializeComponent();
        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            SimonDiceInversoN1 sdiN1 = new SimonDiceInversoN1();
            sdiN1.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
