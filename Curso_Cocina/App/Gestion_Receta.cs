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
    public partial class Gestion_Receta : Form
    {
        Bl_gestion_cusos gestion_Curso = new Bl_gestion_cusos();
        public static List<RichTextBox> textBoxes = new List<RichTextBox>();
        public int Index = 0;
        public static int x = 20;
        public static int y = 15;
        public Gestion_Receta()
        {
            InitializeComponent();
        }
        public void receta(string data)
        {
            var DataSet_3 = gestion_Curso.search_receta("", data);
            var receta_ingredientes = DataSet_3.Tables["receta_ingredientes"];
            name_rece.Text = receta_ingredientes.Rows[0]["name_receta"].ToString();
            richTextBox4.Text = receta_ingredientes.Rows[0]["preparacion"].ToString();
            Index = 0;
            x = 20;
            textBoxes.Clear();
            ingredientes.Controls.Clear();

            for (int i = 0; i < receta_ingredientes.Rows.Count; i++)
            {

                create_richtexbox(null, x, y);
                textBoxes[i].Text = receta_ingredientes.Rows[i]["name_ingredientes"].ToString();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {

            var _DataSet = gestion_Curso.search_receta(name_rece.Text, "");

            if (_DataSet != null)
            {

                Busqueda objayuda = new Busqueda();
                objayuda.objTabla = _DataSet.Tables["list_receta"];
                objayuda.ShowDialog(this);
                if (objayuda.objRow != null)
                {
                    var datarow = objayuda.objRow.Cells[0].Value.ToString();
                    receta(datarow);

                 }
            }



            //var DataSet_2 = gestion_Curso.search_receta("", Gestion_temas.id_receta.ToString());
         

           
        }

        public void create_richtexbox(string data , int xPosition,int yPosition)
        {
            RichTextBox richTB = new RichTextBox();
            textBoxes.Add(richTB); 
            textBoxes[Index].Name = "richTB";
            textBoxes[Index].Height = 35;
            textBoxes[Index].Width = 250;
            textBoxes[Index].BackColor =  Color.FromArgb(240, 240, 240) ;
            textBoxes[Index].BorderStyle = BorderStyle.None;
            textBoxes[Index].Location = new Point(yPosition, xPosition);
            x = x + 50;
            textBoxes[Index].TextChanged += new EventHandler(_TextChanged);
            textBoxes[Index].Font = new Font(" Century Gothic", 12);
            Index = Index + 1;
            ingredientes.Controls.Add(richTB);
                
        }
        void _TextChanged(object action, EventArgs eventArgs)
        {

            if (textBoxes[Index - 1].Text != "")
            {
                create_richtexbox(null, x, y);
            }
          
        }
        private void Gestion_Receta_Load(object sender, EventArgs e)
        {
            create_richtexbox(null,x,y);

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            var id_receta = gestion_Curso.insert_receta(name_rece.Text, richTextBox4.Text);

            foreach(RichTextBox i in  textBoxes)
            {
                gestion_Curso.insert_ingrediente_receta(i.Text, id_receta);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestion_temas gestion_temas = new Gestion_temas();
            gestion_temas.Show();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
