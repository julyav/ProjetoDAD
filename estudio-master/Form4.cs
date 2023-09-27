using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudio
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text);
            if(e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    if (aluno.excluirAluno())
                    {
                        MessageBox.Show("Aluno Excluído com sucesso!");
                    }
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
