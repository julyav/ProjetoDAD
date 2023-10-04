using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudio
{
    class Turma
    {
        private string professor, dia_semana, hora;
        private int modalidade;

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }

        public Turma(int modalidade, string professor, string dia_semana, string hora)
        {

        }

        public Turma(int modalidade)
        {

        }

        public Turma(int modalidade, string dia_semana)
        {

        }

        public bool cadastrarTurma()
        {

        }

        public bool excluirTurma()
        {

        }

        public MySqlDataReader consultarTurma()
        {

        }

        public MySqlDataReader consultarTurma01()
        {

        }
    }

 
 
}
