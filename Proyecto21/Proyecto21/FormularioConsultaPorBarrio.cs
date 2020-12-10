using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto21
{
    public partial class FormularioConsultaPorBarrio : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public FormularioConsultaPorBarrio()
        {
            InitializeComponent();
        }

        private void FormularioConsultaPorBarrio_Load(object sender, EventArgs e)
        {
            CargarBarrios();
        }

        private void CargarBarrios()
        {
            conexion.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter();

            string sql = "select codigo,descripcion from barrios";
            adaptador.SelectCommand = new SqlCommand(sql, conexion);

            DataTable tabla1 = new DataTable();
            adaptador.Fill(tabla1);
            comboBox1.DataSource = tabla1;
            comboBox1.DisplayMember = "descripcion";
            comboBox1.ValueMember = "codigo";

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "select * from inmuebles where codigobarrio=@codigobarrio";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@codigobarrio", SqlDbType.Int).Value = comboBox1.SelectedValue;

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();

            int cant = 0;
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["direccion"].ToString(),
                                       registros["canthabitaciones"].ToString(),
                                       registros["costomes"].ToString(),
                                       registros["descripcion"].ToString());
                cant++;
            }

            registros.Close();
            conexion.Close();

            if (cant == 0)
                MessageBox.Show("No existen inmuebles en dicho barrio");
        }
    }
}
