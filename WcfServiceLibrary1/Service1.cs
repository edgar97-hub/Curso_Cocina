using BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public SqlDataReader search_product(string valueRichTextBox1)
        {
            BL.clsBLUsuario x = new clsBLUsuario();
            var sqlDataReader = x.search_product(valueRichTextBox1);
            if (sqlDataReader != null)
            {
                return sqlDataReader;
            }
            else
            {
                return null;
            }



        }

        
    }
}
