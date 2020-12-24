using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace stopcovid2
{
    class citoyen
    {
         static string chaine = @"Data Source=DESKTOP-D7HHOO9;Integrated Security=True";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        ConnectSQLServer A = new ConnectSQLServer();
         public void InformationDuPersonne()
        {
            cnx.Open();
            cmd.Connection = cnx;
            Console.WriteLine("entrer votre nom:");
            string Nom = Console.ReadLine();
            Console.WriteLine("entrer votre prenom:");
            string Prenom = Console.ReadLine();
            Console.WriteLine("entrer votre age:");
            string Age = Console.ReadLine();
            Console.WriteLine("entrer votre cin:");
            string CIN = Console.ReadLine();
            Console.WriteLine("es ce que vous avez fait le test:");
            string Pcr = Console.ReadLine();
            cmd.CommandText = "insert into personne(nom)values (@nom);";
            cmd.Parameters.AddWithValue("@nom", Nom);
            cmd.CommandText = "insert into personne(prenom)values (@prenom);";
            cmd.Parameters.AddWithValue("@prenom", Prenom);
            cmd.CommandText = "insert into personne(age)values (@age);";
            cmd.Parameters.AddWithValue("@age", Age);
            cmd.CommandText = "insert into personne(cin)values (@cin);";
            cmd.Parameters.AddWithValue("@cin", CIN);
            cmd.CommandText = "insert into personne(pcr)values (@pcr);";
            cmd.Parameters.AddWithValue("@pcr", Pcr);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
