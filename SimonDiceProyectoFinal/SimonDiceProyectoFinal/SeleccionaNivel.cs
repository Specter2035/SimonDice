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
    public partial class SeleccionaNivel : Form
    {
        public SeleccionaNivel()
        {
            InitializeComponent();
        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            SimonDiceN1 sn1 = new SimonDiceN1();
            sn1.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void btnNivel2_Click(object sender, EventArgs e)
        {
            SimonDiceN2 sn2 = new SimonDiceN2();
            sn2.Show();
            this.Hide();
        }

        private void btnNivel3_Click(object sender, EventArgs e)
        {
            SimonDiceN3 sn3 = new SimonDiceN3();
            sn3.Show();
            this.Hide();
        }

        private void btnNivel4_Click(object sender, EventArgs e)
        {
            SimonDiceN4 sn4 = new SimonDiceN4();
            sn4.Show();
            this.Hide();
        }
    }
}
