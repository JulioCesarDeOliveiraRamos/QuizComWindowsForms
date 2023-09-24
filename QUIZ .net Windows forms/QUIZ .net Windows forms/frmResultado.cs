using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ_.net_Windows_forms
{
    public partial class frmResultado : Form
    {
        public frmResultado()
        {
            InitializeComponent();
        }

        private void frmResultado_Load(object sender, EventArgs e)
        {
            label2.Text = ClassesGlobais.Acertos.ToString();

            label4.Text = ClassesGlobais.Erros.ToString();

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
