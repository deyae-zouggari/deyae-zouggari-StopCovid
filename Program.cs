using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace stopcovid2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            citoyen a = new citoyen();
           

            a.Information();
            citoyen c = new citoyen(a.Nom, a.Prenom, a.Age, a.CIN, a.contact, a.malad, a.vacc);
            if (a.Vaccination())
            {
                Console.WriteLine("c'est bient votre code est vert");
                
            }
            else
            {
                if (a.Contacter())
                {
                    Console.WriteLine("code orange ");
                    Console.WriteLine("vous devez confine pendant une semaine ");
                }

                if (a.Sumptomes())
                {
                    Console.WriteLine("votre code est orange ");
                    Console.WriteLine("un confinement de 7 jours");
                    Console.WriteLine("vous devez faire le test pour confirmer");
                }

                if (a.AfaireLeTest())
                {
                    if (a.EtatTest())
                    {
                        a.TestPositive();
                    }
                }
                else
                {
                    Console.WriteLine("vous devez faire le test pour confirmer");
                }

                
            }





            Stream fichier = File.OpenWrite("C://Users//HP//Desktop//stopcovid!!//citoyen.dat");

            BinaryFormatter serialiser = new BinaryFormatter();
            serialiser.Serialize(fichier, c);

            fichier.Close();
            Console.WriteLine("la serialisation a ete terminer");
            Console.ReadKey();

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
