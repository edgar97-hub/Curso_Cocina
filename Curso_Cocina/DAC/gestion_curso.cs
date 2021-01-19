using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{
    public class gestion_curso
    {
        SqlConnection cn = new SqlConnection("Data Source=EDGAR;Initial Catalog=Curso_Cocina;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader loDataReader;
        DataTable schemaTable = new DataTable();
        DataSet dataSet = new DataSet();
        public DataSet search_cursos(string name_curso, string curso_id)
        {
            dataSet.Clear();
            if (name_curso != "")
            {
                cmd = new SqlCommand("Ayuda_curso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name_curso", name_curso);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                //schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
                dataSet.Load(loDataReader, LoadOption.PreserveChanges, new string[] { "list_cursos", "list_temas_receta", "list_curso_temas", "Curso" });
                if (dataSet.Tables["list_cursos"].Rows.Count == 0)
                {
                    cn.Close();
                    return null;
                }

                cn.Close();
                //dataSet.Tables.Add(schemaTable);
                return dataSet;

            }
            if (curso_id != "")
            {
                cmd = new SqlCommand("Seleccionar_UnCurso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@curso_id", curso_id);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                dataSet.Load(loDataReader, LoadOption.PreserveChanges, new string[] { "curso", "producto_det" });
                cn.Close();
                return dataSet;

            }
            return null;
        }
        public DataSet search_receta(string name_receta, string id_receta)
        {
            dataSet.Clear();
            if (name_receta != "")
            {
                cmd = new SqlCommand("Ayuda_receta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name_receta", name_receta);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                dataSet.Load(loDataReader, LoadOption.PreserveChanges, new string[] { "list_receta", "receta_2" });
                cn.Close();
                return dataSet;

            }
            if (id_receta != "")
            {
                cmd = new SqlCommand("Seleccionar_UnReceta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_receta", id_receta);
                cn.Open();
                loDataReader = cmd.ExecuteReader();
                dataSet.Load(loDataReader, LoadOption.PreserveChanges, new string[] { "receta", "receta_ingredientes" });
                cn.Close();
                return dataSet;

            }
            return null;
        }


        public void insert_tema_receta(int id_receta, int id_tema)
        {
            cmd = new SqlCommand("insert_tema_receta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_receta", id_receta);
            cmd.Parameters.AddWithValue("@id_tema", id_tema);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void delete_tema_receta(int id_receta)
        {

            cmd = new SqlCommand("delete_tema_receta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_receta", id_receta);
            //cmd.Parameters.AddWithValue("@id_curso", id_curso);
            //cmd.Parameters.AddWithValue("@id_tema", id_tema);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void insert_curso_tema(string name_tema, int id_curso)
        {
            cmd = new SqlCommand("insert_tema", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_tema", name_tema);
            cmd.Parameters.AddWithValue("@id_curso", id_curso);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void delete_curso_tema(int id_tema, int id_curso)
        {
            cmd = new SqlCommand("delete_tema", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_tema", id_tema);
            cmd.Parameters.AddWithValue("@id_curso", id_curso);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable Cursos()
        {
            schemaTable.Clear();
            cmd = new SqlCommand("SELECT c.Id_Curso as numero_curso, c.name_curso, c.fecha_creacion,c.id_grupo as grupos FROM curso c", cn);
            cn.Open();
            loDataReader = cmd.ExecuteReader();
            schemaTable.Load(loDataReader, LoadOption.OverwriteChanges);
            cn.Close();
            return schemaTable;
        }
        public void insert_curso(string data)
        {
            cmd = new SqlCommand("insert_curso", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_curso", data);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void delete_curso(int data)
        {
            cmd = new SqlCommand("delete_curso", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id_curso", data);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public int insert_receta(string name_receta, string preparacion)
        {
            cmd = new SqlCommand("insert_receta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_receta", name_receta);
            cmd.Parameters.AddWithValue("@preparacion", preparacion);
            SqlParameter id_receta = new SqlParameter("@id_receta", SqlDbType.Int);
            id_receta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(id_receta);

            cn.Open();
            cmd.ExecuteNonQuery();
            int id_receta_out = Convert.ToInt32(cmd.Parameters["@id_receta"].Value);
            cn.Close();

            return id_receta_out;


           
        }
        public void insert_ingrediente_receta(string name_ingrediente, int id_receta)
        {
            cmd = new SqlCommand("insert_ingrediente_receta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name_ingredientes", name_ingrediente);
            cmd.Parameters.AddWithValue("@id_receta", id_receta);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
