using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using busqueda;
using System.Data.SqlClient;
using BL;
namespace WindowsFormsApp1
{
    public partial class Gestion_cursos : UserControl
    {
        SqlDataReader loDataReader;
        public Gestion_cursos()
        {
            InitializeComponent();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        { 

            

           
                BL.clsBLUsuario x = new clsBLUsuario();
                var _sqlDataReader = x.search_product(richTextBox1.Text,null);
                if (_sqlDataReader != null)
                {
                     Busqueda objayuda = new Busqueda();
                     objayuda.objDR = _sqlDataReader;
                     objayuda.ShowDialog(this);
                      if (objayuda.objRow != null)
                      {
                             var loDataReader = x.search_product("", objayuda.objRow);
                             if (loDataReader.HasRows)
                             {
                                 MessageBox.Show("loDataReader");
                                 loDataReader.Read();
                                 //textBox1.Text = loDataReader.GetValue(loDataReader.GetOrdinal("id_prod")).ToString();
                                 //textBox2.Text = loDataReader.GetValue(loDataReader.GetOrdinal("name_product")).ToString();
                             }
                      }


                }
                 



            

            //try
            //{
            //
            //     
            //    command = new SqlCommand("Ayuda_producto", connection);
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.Clear();
            //    command.Parameters.AddWithValue("@id_producto", richTextBox1.Text);
            //    connection.Open();
            //    loDataReader = command.ExecuteReader();
            //    Busqueda objayuda = new Busqueda();
            //    objayuda.objDR = loDataReader;
            //    objayuda.ShowDialog(this);
            //    if (objayuda.objRow != null)
            //    {
            //        command = new SqlCommand("Seleccionar_UnProducto", connection);
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.Parameters.Clear();
            //        command.Parameters.AddWithValue("@PROD_ID", objayuda.objRow.Cells[0].Value);
            //        loDataReader = command.ExecuteReader();
            //        if (loDataReader.HasRows)
            //        {
            //            MessageBox.Show("loDataReader");
            //            loDataReader.Read();
            //            //textBox1.Text = loDataReader.GetValue(loDataReader.GetOrdinal("id_prod")).ToString();
            //            //textBox2.Text = loDataReader.GetValue(loDataReader.GetOrdinal("name_product")).ToString();
            //        }
            //    }
            //     
            //
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    connection.Close();
            //}
            //
            //DialogResult result = MsgBox.Show("edit product ?", "id: " + 323, MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
            //
            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("Exiting now");
            //}
            //if (value.buttonResult == "edit")
            //{
            //    MessageBox.Show("edit");
            //}
            //if (value.buttonResult == "delete")
            //{
            //    MessageBox.Show("delete");
            //}




        }
    }
}
