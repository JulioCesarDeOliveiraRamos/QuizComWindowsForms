namespace QUIZ_.net_Windows_forms
{
    public partial class frmin : Form
    {
        public frmin()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }




        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            frmP1 p1 = new frmP1();
            p1.ShowDialog();

            ClassesGlobais.Acertos = 0;
            ClassesGlobais.Erros = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 creditos = new Form1();
            creditos.ShowDialog();
        }
    }
}