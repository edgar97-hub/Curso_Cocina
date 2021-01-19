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
    public partial class Gestion_temas : Form
    {
        Bl_gestion_cusos gestion_Curso = new Bl_gestion_cusos();
        DataTable dataTable = new DataTable();
        public static int id_curso = 0;
        static DataSet dataSet1 = new DataSet();
        public static int id_receta = 0;
        public static Boolean flat = false;
        public Gestion_temas()
        {
            InitializeComponent();
        }
        public Boolean datagriedviewAlready()
        {
            
            dataSet1 = gestion_Curso.search_curso(Gestion_cursos.name_curso, "");

            if (dataSet1 != null)
            {
                var Table_curso = dataSet1.Tables["Curso"];
                if(Table_curso.Rows.Count != 0)
                {
                    id_curso = Convert.ToInt32(Table_curso.Rows[0]["id_curso"].ToString());
                    flat = true;
                }
                if (dataSet1.Tables["list_temas_receta"].Rows.Count != 0)  
                {
                    list_temas_rece.Enabled = true;
                    
                    return true;
                }
                else
                {
                    list_temas_rece.Enabled = false;
                     return false;
                }
            }
            else
            {
                flat = false;
                return false;
            }
            
        }
        public void list_temas_receta()
        {
         
            
            if(datagriedviewAlready())
            {
               
                dataTable = dataSet1.Tables["list_temas_receta"];
                list_temas_rece.DataSource = dataTable;
                list_temas_rece.Columns[0].Visible = false;
                list_temas_rece.Columns[4].Visible = false;
                list_temas_rece.CurrentCell = list_temas_rece.Rows[0].Cells[1];

            }





        }
        private void Gestion_temas_Load(object sender, EventArgs e)
        {
            list_temas_receta();

            if (!flat)
            {
                this.Close(); ;
            }
        }

        private void ayuda_receta_Click(object sender, EventArgs e)
        {

            var _DataSet = gestion_Curso.search_receta(name_receta.Text, "");

            if (_DataSet != null)
            {

                Busqueda objayuda = new Busqueda();
                objayuda.objTabla = _DataSet.Tables["list_receta"];
                objayuda.ShowDialog(this);
                if (objayuda.objRow != null)
                {
                    var datarow = objayuda.objRow.Cells[0].Value.ToString();

                    //list_productos.Rows.Clear();
                    var DataSet_2 = gestion_Curso.search_receta("", datarow);
                    var Table_producto = DataSet_2.Tables["receta"];

                    //name_receta.Text = Table_producto.Rows[0]["id_receta"].ToString();
                    name_receta.Text = Table_producto.Rows[0]["name_receta"].ToString();
                    //list_temas_rece.DataSource = DataSet_2;
                    list_temas_receta();
                }
            }


            list_temas_receta();
        }

        private void insert_Click(object sender, EventArgs e)
        {

            if (true)
            {
                id_curso = Convert.ToInt32(list_temas_rece.CurrentRow.Cells[0].Value);
                var id_tema = Convert.ToInt32(list_temas_rece.CurrentRow.Cells[1].Value);

                if (name_receta.Text == "")
                {
                    MessageBox.Show("error insert");
                }
                else
                {
                    var DataSet_2 = gestion_Curso.search_receta(name_receta.Text, "");
                    if (DataSet_2.Tables["receta_2"].Rows.Count == 0)
                    {
                        MessageBox.Show("error insert");
                    }
                    else
                    {
                        var Table_receta = DataSet_2.Tables["receta_2"];
                        var id_receta = Table_receta.Rows[0]["id_receta"].ToString();

                        //MessageBox.Show("id_tema:" + id_tema + "id_receta: " + id_receta);
                        gestion_Curso.insert_tema_receta(Convert.ToInt32(id_receta), id_tema);
                        //MessageBox.Show("reguistro insertado");

                    }

                }
                list_temas_receta();
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
             


            if (true)
            {
               


                if (list_temas_rece.CurrentRow.Cells[4].Value != DBNull.Value)
                {
                    
                    var id_receta = Convert.ToInt32(list_temas_rece.CurrentRow.Cells[4].Value);
                    gestion_Curso.delete_tema_receta(Convert.ToInt32(id_receta));
                    //MessageBox.Show("reguistro eliminado");
                    list_temas_receta();
                }
                else
                {
                    MessageBox.Show("no eliminado");
                }
               
            }
            
          
        }

        private void list_temas_rece_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //name_receta.Text = list_temas_rece.CurrentRow.Cells[3].Value.ToString();
            if(list_temas_rece.CurrentRow.Cells[4].Value != DBNull.Value)
            {
                id_receta = Convert.ToInt32(list_temas_rece.CurrentRow.Cells[4].Value);
 

            }
        }

        private void temas_Click(object sender, EventArgs e)
        {
           
            creacion_temas creacion_Temas = new creacion_temas();
            creacion_Temas.Show();
            this.Hide();
 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion_cursos gestion_cursos = new Gestion_cursos();
            gestion_cursos.Show();
            this.Close();
        }

        private void editar_receta_Click(object sender, EventArgs e)
        {
            if(id_receta != 0)
            {
                Gestion_Receta gestion_Receta = new Gestion_Receta();
                gestion_Receta.Show();
                gestion_Receta.receta(id_receta.ToString());
                this.Hide();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestion_Receta gestion_Receta = new Gestion_Receta();
            gestion_Receta.Show();
            this.Hide();
        }
    }
}
