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
    public partial class FormularioBarrios : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public FormularioBarrios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ExisteBarrio(textBox1.Text))
            {
                conexion.Open();

                string sql = "insert into barrios(descripcion) values(@descripcion)";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = textBox1.Text;

                comando.ExecuteNonQuery();

                conexion.Close();

                CargarGrilla();

                textBox1.Text = "";

                MessageBox.Show("Se ha cargado el barrio");
            }
            else
                MessageBox.Show("Ya se ha cargado dicho nombre de barrio");
        }

        private bool ExisteBarrio(string barrio)
        {
            conexion.Open();

            string sql = "select codigo,descripcion from barrios where descripcion=@descripcion";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = barrio;

            SqlDataReader registro = comando.ExecuteReader();
            bool existe = false;
            if (registro.Read())
                existe = true;

            registro.Close();
            conexion.Close();

            return existe;
        }

        private void FormularioBarrios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            conexion.Open();

            string sql = "select codigo,descripcion from barrios";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["codigo"].ToString(), registros["descripcion"].ToString());
            }

            registros.Close();
            conexion.Close();
        }
    }
}
