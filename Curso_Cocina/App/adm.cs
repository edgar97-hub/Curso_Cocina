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
    public partial class adm : Form
    {
        
        public adm()
        {
            InitializeComponent();
            panel.Height = button4.Height;
            panel.Top = button4.Top;
          //  gestion_cursos1.BringToFront();
        }

        private void gestion_cursos_Click(object sender, EventArgs e)
        {
            panel.Height = manager_cursos.Height;
            panel.Top = manager_cursos.Top;
            gestion_cursos1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel.Height = button4.Height;
            panel.Top = button4.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.Height = button1.Height;
            panel.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel.Height = button2.Height;
            panel.Top = button2.Top;
        }

        private void gestion_cursos1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
