using Estudio;
using MySql.Data.MySqlClient;
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
    public partial class cadastrarTurma : Form
    {
        public cadastrarTurma()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Modalidade con_mod = new Modalidade();
            MySqlDataReader r = con_mod.ConsultarTodasModalidades();
            while (r.Read())
                dataGridView1.Rows.Add(r["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
        }

        private void cadastrarTurma_Load(object sender, EventArgs e)
        {

        }
    }
}
