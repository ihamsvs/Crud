using Crud2.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud2.Models
{
    public class operacion
    {
        public static void agregar(string rut, string nombre, string apellido, string email,string num, string edad, string est, string peso, string pass)
        {
            //string cnnStr = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            string cnn2 = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CRUD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(cnn2))
            {
                connection.Open();

                SqlCommand sql = new SqlCommand("Insert into CRUD values (@Rut, @Nombre, @Apellido, @Email, @Numtelefono, @Edad,@Estatura, @Peso, @Pass)");

                
                sql.Parameters.AddWithValue("@Rut", rut);
                sql.Parameters.AddWithValue("@Nombre", nombre);
                sql.Parameters.AddWithValue("@Apellido", apellido);
                sql.Parameters.AddWithValue("@Email", email);
                sql.Parameters.AddWithValue("@Numtelefono", num);
                sql.Parameters.AddWithValue("@Edad", edad);
                sql.Parameters.AddWithValue("@Estatura", est);
                sql.Parameters.AddWithValue("@Peso", peso);
                sql.Parameters.AddWithValue("@Pass", pass);






                sql.ExecuteNonQuery();

            }

        }
        public static bool IngresarUsuario(FormCollection collection)
        {
            string cnn2 = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CRUD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection con = new SqlConnection(cnn2))
            {
                try
                {
                    con.Open();

                    string query = ("insert into Pruebas (Rut,Nombre,Apellido, Email, NumTelefono, Edad, Estatura, Peso, Pass)values (@Rut,@Nombre,@Apellido, @Email, @NumTelefono, @Edad, @Estatura, @Peso, @Pass)");
                    SqlCommand comando = new SqlCommand(query, con);
                    comando.CommandType = CommandType.Text;

                    
                    comando.Parameters.AddWithValue("@Id", collection.GetValues(1));
                    comando.Parameters.AddWithValue("@Nombre", collection.GetValues(2));
                    comando.Parameters.AddWithValue("@Apellido", collection.GetValues(3));
                    comando.Parameters.AddWithValue("@Email", collection.GetValues(4));
                    comando.Parameters.AddWithValue("@NumTelefono", collection.GetValues(5));
                    comando.Parameters.AddWithValue("@Edad", collection.GetValues(6));
                    comando.Parameters.AddWithValue("@Estatura", collection.GetValues(7));
                    comando.Parameters.AddWithValue("@Peso", collection.GetValues(8));
                    comando.Parameters.AddWithValue("@Pass", collection.GetValues(9));
                    comando.ExecuteNonQuery();
                    
                }
                catch (SqlException sqlEx)
                {
                    // aquí hacer log o lo que sea
                }
                
               
            } return true;
        }



    }
}