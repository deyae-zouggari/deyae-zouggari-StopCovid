using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;
using System.Timers;
using System.Diagnostics;
using System.Threading;


namespace stopcovid2
{
    class Program
    {
        public static string QR;






        static void Main(string[] args)
        {
            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();
            //Thread.Sleep(10000);
            //stopWatch.Stop();
            //// Get the elapsed time as a TimeSpan value.
            //TimeSpan ts = stopWatch.Elapsed;

            //// Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //    ts.Hours, ts.Minutes, ts.Seconds,
            //    ts.Milliseconds / 10);
            //Console.WriteLine("RunTime " + elapsedTime);
           
            citoyen a = new citoyen();
            AffectationMalade b = new AffectationMalade();
            Vaccine c = new Vaccine();
            persistance d = new persistance();
            Console.WriteLine("entrer votre nom:");
            a.Nom = Console.ReadLine();
            Console.WriteLine("entrer votre prenom:");
            a.Prenom = Console.ReadLine();
            Console.WriteLine("entrer votre age:");
            a.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entrer votre CIN:");
           a.CIN = Console.ReadLine();

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
                    DateTime todaysDate = DateTime.Today; // returns today's date
                    TimeSpan time = new TimeSpan(7, 0, 0, 0);
                    Console.WriteLine("de " + todaysDate+"jusqua");
                    Console.WriteLine(todaysDate + time);
                    
                }
                Console.WriteLine("es ce que vous avez des sumptomes de covid: ");
                b.symptomes = Console.ReadLine();
                if (b.Sumptomes())
                {

                    QR = "orange";
                    Console.WriteLine("votre code est orange ");
                    Console.WriteLine("un confinement de 7 jours");
                    DateTime todaysDate = DateTime.Today; // returns today's date
                    TimeSpan time = new TimeSpan(7, 0, 0, 0);
                    Console.WriteLine("de " + todaysDate + "jusqua");
                    Console.WriteLine(todaysDate + time);
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
                        DateTime todaysDate = DateTime.Today; // returns today's date
                        TimeSpan time = new TimeSpan(15, 0, 0, 0);
                        Console.WriteLine("confinement de " + todaysDate + "jusqua ");
                        Console.WriteLine(todaysDate + time);
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
                d.DatabaseConnection(a.Nom,a.Prenom,a.Age,a.CIN,b.etat,b.cont,c.vac,QR);


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
