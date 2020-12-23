using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace stopcovid2
{
    class citoyen
    {
        private static void OpenSqlConnection()
        {
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("ServerVersion: {0}", connection.ServerVersion);
                Console.WriteLine("State: {0}", connection.State);
            }
        }

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file, using the
            // System.Configuration.ConfigurationManager.ConnectionStrings property
            return " Data Source = DESKTOP - D7HHOO9;Initial Catalog = StopCovid;"
                + "Integrated Security = True;";
        }
        public void informationDuPersonne(int id,string nom,string prenom,int age,string cin,bool pcr)
        {
            Console.WriteLine("entrer votre nom:");
            string Nom = Console.ReadLine();


        }
    }
}
