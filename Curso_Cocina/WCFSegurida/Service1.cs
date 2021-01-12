﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Utilitarios;
using BL;
using System.Data.SqlClient;

namespace WCFSegurida
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
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

        public void Insertar_Usuario(clsUsuario xobj)
        {
            BL.clsBLUsuario x = new clsBLUsuario();
            x.insertar(xobj);
        }
        public SqlDataReader search_product(string valueRichTextBox1)
        {
            BL.clsBLUsuario x = new clsBLUsuario();

            if (x.search_product(valueRichTextBox1) != null)
            {

                var sqlDataReader = x.search_product(valueRichTextBox1);
                return sqlDataReader;
            }
            else
            {
                return null;
            }



        }

    }
}
