using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto21
{
    public partial class FormularioConsultaPorPrecio : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public FormularioConsultaPorPrecio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "select direccion,canthabitaciones,costomes,inmu.descripcion as descriinmuebles, ba.descripcion as describarrio" +
                         " from inmuebles as inmu " +
                         "join barrios as ba on ba.codigo = inmu.codigobarrio     " +
                         "where costomes >=@costo1 and costomes<= @costo2";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@costo1", SqlDbType.Float).Value = textBox1.Text;
            comando.Parameters.Add("@costo2", SqlDbType.Float).Value = textBox2.Text;

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["direccion"].ToString(),
                                       registros["canthabitaciones"].ToString(),
                                       registros["costomes"].ToString(),
                                       registros["describarrio"].ToString(),
                                       registros["descriinmuebles"].ToString());
            }

            registros.Close();
            conexion.Close();
        }
    }
}
