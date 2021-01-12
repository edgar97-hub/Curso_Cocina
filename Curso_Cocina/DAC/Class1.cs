using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilitarios;
using System.Windows.Forms;

namespace DAC
{
    public class clsDAUsario
    {
        SqlConnection cn = new SqlConnection("Data Source=EDGAR;Initial Catalog=Curso_Cocina;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader loDataReader;
        public List<clsUsuario> lista()
        {
            List<clsUsuario> x=new List<clsUsuario>();

            return x;
        }
        public void insertar(clsUsuario xobj )
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[seguridad].[usuario_insert]";
            cmd.Parameters.AddWithValue("@usuario",xobj.Usuario );
            cmd.Parameters.AddWithValue("@clave", xobj.clave);
            cmd.Parameters.AddWithValue("@nombres", xobj.Nombres);
            cmd.Parameters.AddWithValue("@apellidos", xobj.Apellidos);
            cmd.Parameters.AddWithValue("@correo", xobj.Correo);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void eliminar(clsUsuario xobj)
        {


        }
        public clsUsuario validar_usuario(string xusuario, string xclave)
        {
            clsUsuario x = new clsUsuario();

            return x;
        }
        public SqlDataReader search_product(string richTextBox1, DataGridViewRow dataGridViewRow )
        {
            if (richTextBox1 != "")
            {
                cmd = new SqlCommand("Ayuda_curso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_curso", richTextBox1);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                cn.Close();
                return loDataReader;

            }
            if (dataGridViewRow != null)
            {
                cmd = new SqlCommand("Seleccionar_UnProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PROD_ID", dataGridViewRow.Cells[0].Value);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                cn.Close();
                return loDataReader;

            }
            return null;



        }



    }
    public class clsDAAplicaciones
    { }

}
