using BL;
using busqueda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Gestion_cursos : Form
    {
        DataSet _dataSet = new DataSet();

        public static Gestion_cursos objCursos = new Gestion_cursos();
        public  int id_curso = 0;
        public static string name_curso = "";
        Bl_gestion_cusos gestion_Curso = new Bl_gestion_cusos();

        public Gestion_cursos()
        {
            InitializeComponent();
        }

        public void list_cursos()
        {
            var cursos_list = gestion_Curso.cursos();



            cursos.DataSource = cursos_list;
        }
        private void Gestion_cusos_Load(object sender, EventArgs e)
        {
            list_cursos();
        }

        private void gestion_tema_Click(object sender, EventArgs e)
        {
            name_curso = name.Text;
            Gestion_temas gestion_temas = new Gestion_temas();
            gestion_temas.Show();
            //MessageBox.Show(Gestion_temas.flat.ToString());
            if(Gestion_temas.flat)
            {
                this.Hide();
            }


            


        }

        private void gestion_horario_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buscar_curso_Click(object sender, EventArgs e)
        {
          

            var _DataSet = gestion_Curso.search_curso(name.Text, "");

            if (_DataSet != null)
            {
             
                Busqueda objayuda = new Busqueda();
                objayuda.objTabla = _DataSet.Tables["list_cursos"];
                objayuda.ShowDialog(this);
                if (objayuda.objRow != null)
                {
                    var datarow = objayuda.objRow.Cells[0].Value.ToString();

                    //list_productos.Rows.Clear();
                    var DataSet_2 = gestion_Curso.search_curso("", datarow);
                    var Table_producto = DataSet_2.Tables["curso"];
                    name.Text = Table_producto.Rows[0]["name_curso"].ToString();

                    //id_curso = Convert.ToInt32(Table_producto.Rows[0]["Id_curso"].ToString());
                    //name_curso = Table_producto.Rows[0]["name_curso"].ToString();

                }
            }

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

            name_curso = name.Text;
        }

        private void crear_curso_Click(object sender, EventArgs e)
        {
            gestion_Curso.insert_curso(name.Text);
            list_cursos();
        }

        private void delete_curso_Click(object sender, EventArgs e)
        {
            var id_curso = Convert.ToInt32(cursos.CurrentRow.Cells[0].Value);
            gestion_Curso.delete_curso(id_curso);
            list_cursos();
        }
    }
    
}
