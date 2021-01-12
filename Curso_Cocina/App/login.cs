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

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public static string Value= "";
        public static int richTextlent = 1;
        public string[] Rol_Usuario = new string[10];
        static adm _adm = new adm();
        static alumno _alumno = new alumno();

        List<Form> listForm = new List<Form>();





        static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        static SqlConnection connection = new SqlConnection();
        static SqlCommand command = new SqlCommand();
        public login()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
         
            if(pasword.Text.Length == richTextlent)
            {
                Value += pasword.Text[0].ToString();
                pasword.Text = pasword.Text.Remove(0, 1);
                pasword.Text += "*";
              //  MessageBox.Show("1"+"value: "+ Value.ToString()+" Value.Length: " + Value.Length + " richTextBox2: " + richTextBox2.Text.Length + "richTextlent: " + richTextlent);
            }
            else
            {

              
                Value = "";
                pasword.Text = "";
            }
            richTextlent = pasword.Text.Length + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               command = new SqlCommand("Select id, usuario, clave,id_rol  from Chef.Usuario INNER JOIN Chef.Roles_Persona  ON  Id = id_usuario and  usuario = '" + user_name.Text + "' and clave = '" + Value + "'", connection);

               connection.Open();
               SqlDataAdapter adapt = new SqlDataAdapter(command);
               DataSet ds = new DataSet();
               adapt.Fill(ds);
               connection.Close();
               int count = ds.Tables[0].Rows.Count;
              
               if (count == 1)
               {
                   Value = "";
                   richTextlent = 1;
                   MessageBox.Show("Login Successful!");
                    MessageBox.Show("user_Id_Rol: "+ ds.Tables[0].Rows[0]["id_rol"]);
                   this.Hide();
                   int id_Rol = Int32.Parse(ds.Tables[0].Rows[0]["id_rol"].ToString());
                    id_Rol = id_Rol - 1;
                    for (int x= 0; x < listForm.Count(); x++)
                    {
                        if (x == id_Rol)
                        {
                            listForm[x].Show();
                        }
                    }
                }
               else
               {
                   MessageBox.Show("Login Failed!");
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            builder.DataSource = "EDGAR";
            builder.InitialCatalog = "Curso_Cocina";
            builder.IntegratedSecurity = true;

            connection = new SqlConnection(builder.ConnectionString);
            command.Connection = connection;
            listForm.Add(_adm);
            listForm.Add(_alumno);
           



        }
    }
}
