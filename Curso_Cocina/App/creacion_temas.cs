using BL;
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
    public partial class creacion_temas : Form
    {
        Bl_gestion_cusos gestion_Curso = new Bl_gestion_cusos();
        public creacion_temas()
        {
            InitializeComponent();
        }

        private void creacion_temas_Load(object sender, EventArgs e)
        {
            list_curso_temas();
        }
        public void list_curso_temas()
        {

            var DataSet_2 = gestion_Curso.search_curso(Gestion_cursos.name_curso, "");
            var Table_curso_temas = DataSet_2.Tables["list_curso_temas"];

            if(Table_curso_temas.Rows.Count != 0)
            {
                dataGrid_temas.DataSource = Table_curso_temas;
                dataGrid_temas.CurrentCell = dataGrid_temas.Rows[0].Cells[1];
                dataGrid_temas.Columns[0].Visible = false;
            }
           


        }
        private void add_tema_Click(object sender, EventArgs e)
        {
            if(name_tema.Text != "")
            {
                var id_curso = Gestion_temas.id_curso;
                gestion_Curso.insert_cuso_tema(name_tema.Text, id_curso);
                MessageBox.Show("reguistro insertado");
                list_curso_temas();

            }


        }

        private void atras_Click(object sender, EventArgs e)
        {
            Gestion_temas gestion_Temas = new Gestion_temas();
            gestion_Temas.Show();

            this.Close();
        }

        private void delete_tema_Click(object sender, EventArgs e)
        {
            if (dataGrid_temas.CurrentRow.Cells[1].Value != DBNull.Value || String.IsNullOrWhiteSpace(dataGrid_temas.CurrentRow.Cells[1].Value.ToString()))
            {
                
                var id_curso = Gestion_temas.id_curso;
                var id_tema = Convert.ToInt32(dataGrid_temas.CurrentRow.Cells[1].Value);
                gestion_Curso.delete_curso_tema(id_tema, id_curso);
                MessageBox.Show("reguistro eliminado");
                list_curso_temas();
            }

        }

        private void dataGrid_temas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_temas.CurrentRow.Cells[1].Value != DBNull.Value)
            {
                name_tema.Text = dataGrid_temas.CurrentRow.Cells[2].Value.ToString();

            }
        }
    }
}
