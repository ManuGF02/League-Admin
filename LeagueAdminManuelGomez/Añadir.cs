using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LeagueAdminManuelGomez
{
    public partial class Añadir : UserControl
    {
        public Añadir()
        { 
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb.SelectedIndex)
            {
                case 0:
                    limpiarCampos();

                    txtID.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    txt5.Visible = true;

                    txtID.Hint = "ID (Num)";
                    txt2.Hint = "Apellidos";
                    txt3.Hint = "Nombre";
                    txt4.Hint = "Fecha de Nacimiento";
                    txt5.Hint = "Colegio";
                    break;
                case 1:
                    limpiarCampos();

                    txtID.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    txt5.Visible = true;

                    txtID.Hint = "ID (Num)";
                    txt2.Hint = "Nombre";
                    txt3.Hint = "Capacidad";
                    txt4.Hint = "Dirección";
                    txt5.Hint = "Año de Construcción";
                    break;
                case 2:
                    limpiarCampos();

                    txtID.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    txt5.Visible = true;
                    txt6.Visible = true;
                    txt7.Visible = true;

                    txtID.Hint = "ID (Siglas)";
                    txt2.Hint = "Nombre Completo";
                    txt3.Hint = "Nombre";
                    txt4.Hint = "Ciudad";
                    txt5.Hint = "Estadio";
                    txt6.Hint = "Año de Fundación";
                    txt7.Hint = "Nº Socios";
                    break;
            }
        }

        private void Añadir_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtID.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=C09PC14;Initial Catalog=FUTBOL_MANUEL;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;

            string orden = "";
            //Arbitros
            if (cb.SelectedIndex == 0)
            {
                int id = int.Parse(txtID.Text);
                string apellidos = txt2.Text;
                string nombre = txt3.Text;
                string fechaNacimiento = txt4.Text;
                string colegio = txt5.Text;

                insertarArbitro(conexion, comando, id, apellidos, nombre, fechaNacimiento, colegio);
            }
            //Estadios
            else if (cb.SelectedIndex == 1)
            {
                
                int id = int.Parse(txtID.Text);
                string nombre = txt2.Text;
                int capacidad = int.Parse(txt3.Text);
                string direccion = txt4.Text;
                int añoConstruccion = int.Parse(txt5.Text);

                insertarEstadios(conexion, comando, id, nombre, capacidad, direccion, añoConstruccion);
            }
            //Equipos
            else if (cb.SelectedIndex == 2)
            {
                string id = txtID.Text;
                string nombre = txt2.Text;
                string nombreCompleto = txt3.Text;
                string ciudad = txt4.Text;
                string estadio = txt5.Text;
                int añoFundacion = int.Parse(txt6.Text);
                int numSocios = int.Parse(txt7.Text);

                insertarEquipos(conexion, comando, id, nombre, nombreCompleto, ciudad, estadio, añoFundacion, numSocios); 
            }

            conexion.Close();
            limpiarCampos();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void insertarArbitro(SqlConnection conexion,  SqlCommand comando, int id, string apellidos, string nombre, string fechaNacimiento, string colegio)
        {
            try
            {
                
                string orden = "";


                orden = "insert into Arbitros (ID, Apellidos, Nombre, FechaNacimiento, Colegio) values (" +
                        id + ", '" + apellidos + "', '" + nombre + "', '" + fechaNacimiento + "', '" + colegio + "')";

                comando.CommandText = orden;
                int registros = comando.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                MessageBox.Show("Error SQL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de Formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertarEstadios(SqlConnection conexion, SqlCommand comando, int id, string nombre, int capacidad, string direccion, int añoConstruccion)
        {
            try
            {
                string orden = "";
                orden = "insert into Estadios (ID, Nombre, Capacidad, Direccion, AñoConstruccion) values (" +
                        id + ", '" + nombre + "', " + capacidad + ", '" + direccion + "', " + añoConstruccion + ")";

                comando.CommandText = orden;
                int registros = comando.ExecuteNonQuery();
            }
            catch (SqlException)
            {

                MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de Formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertarEquipos(SqlConnection conexion, SqlCommand comando, string id, string nombreCompleto, string nombre, string ciudad, string estadio, int añoFundacion, int numSocios)
        {
            try
            {
                int idEstadio = 0;

                string orden = "";
                orden = "insert into Equipos (ID, NombreCompleto, Nombre, Ciudad, Estadio,  AñoFundacion, Socios) values ('" +
                        id + "', '" + nombreCompleto + "', '" + nombre + "', '" + ciudad + "', " + idEstadio + ", '" + añoFundacion + "', " + numSocios + ")";

                comando.CommandText = orden;
                int registros = comando.ExecuteNonQuery();
            }
            catch (SqlException)
            {

                MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de Formato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
