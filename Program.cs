using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;


namespace stopcovid2
{
    class Program
    {
        public static string QR;

        static string chaine = @"Data Source=DESKTOP-D7HHOO9;Initial Catalog=StopCovid;Integrated Security=True";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
       
            
        

        static void Main(string[] args)
        {
            citoyen a = new citoyen();
            AffectationMalade b = new AffectationMalade();
            Vaccine c = new Vaccine();
            a.Information();
            Console.WriteLine("es ce que vous etes vaccine ? ");
            c.vac = Console.ReadLine();
            if (c.Vaccination())
            {
                Console.WriteLine("c'est bient votre code est vert");
                
            }
            else
            {
                Console.WriteLine("es ce que vous avez contacter quelqu'un malade :");
                b.cont = Console.ReadLine();
                if (b.Contacter())
                {
                    QR = "orange";
                    Console.WriteLine("code orange ");
                    Console.WriteLine("vous devez confine pendant une semaine ");
                }
                Console.WriteLine("es ce que vous avez des sumptomes de covid: ");
                b.symptomes = Console.ReadLine();
                if (b.Sumptomes())
                {
                    QR = "orange";
                    Console.WriteLine("votre code est orange ");
                    Console.WriteLine("un confinement de 7 jours");
                    Console.WriteLine("vous devez faire le test pour confirmer");
                }
                Console.WriteLine("es ce que vous avez fait le test: ");
                b.Test= Console.ReadLine();

                if (b.AfaireLeTest())
                {
                    Console.WriteLine("es ce que le test est positive: ");
                   b.etat = Console.ReadLine();
                    if (b.EtatTest())
                    {
                        QR = "rouge";
                        Console.WriteLine(QR);
                    }
                    else
                    {
                        QR = "vert";
                        Console.WriteLine(QR);
                    }
                }
                else
                {
                    Console.WriteLine("vous devez faire le test pour confirmer");
                }
                
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into Personne(Nom,Prenom,Age,CIN,Malad,Contacteur,Vaccine,QR) values('" +a.Nom + "','" +a.Prenom + "','" +a.Age + "','" +a.CIN + "','" +b.etat + "','" +b.cont + "','" +c.vac + "','" + QR + "') ";
                cmd.ExecuteNonQuery();
                cnx.Close();


            }





            //Stream fichier = File.OpenWrite("C://Users//HP//Desktop//stopcovid!!//citoyen.dat");

            //BinaryFormatter serialiser = new BinaryFormatter();
            //serialiser.Serialize(fichier, c);

            //fichier.Close();
            //Console.WriteLine("la serialisation a ete terminer");
            //Console.ReadKey();

            //citoyen f;
            //Stream fichier = File.OpenRead("C://Users//HP//Desktop//stopcovid!!//citoyen.dat");
            //BinaryFormatter deserialiser = new BinaryFormatter();
            //f = (citoyen)deserialiser.Deserialize(fichier);
            //fichier.Close();
            //Console.WriteLine(fichier);
            //Console.ReadKey();

        }
        
       

    }
}
