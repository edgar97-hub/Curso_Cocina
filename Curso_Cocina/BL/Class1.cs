using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAC;
using Utilitarios;

namespace BL
{
    public class clsBLUsuario
    {
        clsDAUsario dausuario = new clsDAUsario();
        public void insertar(clsUsuario xobj)
        {
            dausuario.insertar(xobj);
        }
        public SqlDataReader search_product(string richTextBox1, DataGridViewRow dataGridViewRow)
        {
            var _sqlDataReader = dausuario.search_product(richTextBox1, dataGridViewRow);
            if (_sqlDataReader != null)
            {
                return _sqlDataReader;
            }
            return null;
        }
    }
}
