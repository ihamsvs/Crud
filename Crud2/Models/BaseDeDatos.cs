using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Crud2.Models
{
    public class BaseDeDatos
    {
        public SqlConnection getConexion()
        {

            try
            {
                String cnnStr = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(cnnStr);
                cnn.Open();
                return cnn;
            }
            catch (Exception)
            {

                return null;
            }




        }
    }
}