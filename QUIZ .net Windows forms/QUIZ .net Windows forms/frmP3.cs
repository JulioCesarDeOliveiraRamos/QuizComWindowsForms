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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (restrue.Checked == true)
            {
                MessageBox.Show("Você acertou a resposta🎉");

                ClassesGlobais.Acertos++;

                Form4 P4 = new Form4();
                P4.ShowDialog();
                this.Dispose();
                
            }
            else if (resfalse1.Checked || resfalse2.Checked || resfalse3.Checked)
            {
                MessageBox.Show("Você Errou a resposta😭");

                ClassesGlobais.Erros += 1;

                Form4 P4 = new Form4();
                P4.ShowDialog();
                this.Dispose();
                
            }
            else
            {
                MessageBox.Show("selecione uma das alternativas");
            }
        }
    }
}
