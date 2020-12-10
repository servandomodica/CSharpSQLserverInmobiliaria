using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto21
{
    public partial class FormularioInmuebles : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public FormularioInmuebles()
        {
            InitializeComponent();
        }

        private void FormularioInmuebles_Load(object sender, EventArgs e)
        {
            CargarBarrios();
        }

        private void CargarBarrios()
        {
            conexion.Open();

            string sql = "select codigo,descripcion from barrios";

            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = new SqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);

            comboBox1.DataSource = tabla;
            comboBox1.DisplayMember = "descripcion";
            comboBox1.ValueMember = "codigo";

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "insert into inmuebles(direccion,canthabitaciones,costomes,codigobarrio,descripcion) values(@direccion,@canthabitaciones,@costomes,@codigobarrio,@descripcion)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = textBox1.Text;
            comando.Parameters.Add("@canthabitaciones", SqlDbType.Int).Value = textBox2.Text;
            comando.Parameters.Add("@costomes", SqlDbType.Float).Value = textBox3.Text;
            comando.Parameters.Add("@codigobarrio", SqlDbType.Int).Value = comboBox1.SelectedValue.ToString();
            comando.Parameters.Add("@descripcion", SqlDbType.Text).Value = textBox4.Text;
            comando.ExecuteNonQuery();

            conexion.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            MessageBox.Show("Los datos fueron cargados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "select * from inmuebles where direccion=@direccion";

            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = textBox1.Text;

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["canthabitaciones"].ToString();
                textBox3.Text = registro["costomes"].ToString();
                textBox4.Text = registro["descripcion"].ToString();
                comboBox1.SelectedValue = registro["codigobarrio"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un inmueble en dicha dirección");
            }

            registro.Close();
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "update inmuebles set canthabitaciones=@canthabitaciones,costomes=@costomes," +
                         "codigobarrio=@codigobarrio, descripcion=@descripcion where direccion=@direccion ";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@canthabitaciones", SqlDbType.Int).Value = textBox2.Text;
            comando.Parameters.Add("@costomes", SqlDbType.Float).Value = textBox3.Text;
            comando.Parameters.Add("@codigobarrio", SqlDbType.Int).Value = comboBox1.SelectedValue.ToString();
            comando.Parameters.Add("@descripcion", SqlDbType.Text).Value = textBox4.Text;
            comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = textBox1.Text;
            int cant = comando.ExecuteNonQuery();

            conexion.Close();

            if (cant == 1)
                MessageBox.Show("Los datos fueron actualizados");
            else
                MessageBox.Show("No existe un inmueble con dicha direccion");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "delete from inmuebles where direccion=@direccion";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = textBox1.Text;
            int cant = comando.ExecuteNonQuery();

            conexion.Close();

            if (cant==1)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Se ha eliminado el inmueble");
            }
            else
            {
                MessageBox.Show("No existe un inmueble en dicha dirección");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
