namespace SimonDiceProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimonClasico_Click(object sender, EventArgs e)
        {
            SeleccionaNivel sn = new SeleccionaNivel();
            /*SimonDiceN1 sdc = new SimonDiceN1();*/
            sn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSimonInverso_Click(object sender, EventArgs e)
        {
            SeleccionaNivelInverso sn = new SeleccionaNivelInverso();
            sn.Show();
            this.Hide();
        }
    }
}
