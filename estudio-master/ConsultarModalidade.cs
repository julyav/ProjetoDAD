using Estudio;
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
    public partial class ConsultarModalidade : Form
    {
        public ConsultarModalidade()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);
            if (e.KeyChar == 13)
            {
                if (modalidade.consultarBoolean())
                {
                    MessageBox.Show("Metodo já está cadastrado!");
                }
                else
                {
                    textBox2.Focus();
                }

                DAO_Conexao.con.Close();
            }

        }

        private void ConsultarModalidade_Load(object sender, EventArgs e)
        {

        }
    }
}
