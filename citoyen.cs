using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace stopcovid2
{

    [Serializable]
     
    class citoyen
        {
        public string Nom;
        public string Prenom;
        public string Age;
        public string CIN;
        public string contact;
        public string malad;
        public string vacc;
        public citoyen()
        {

        }


        /*static string chaine = @"Data Source=DESKTOP-D7HHOO9;Integrated Security=True";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        ConnectSQLServer A = new ConnectSQLServer();*/
        public citoyen(string Nom,string Prenom,string Age,string CIN,string contact,string malad,string vacc)
        {
            this.Nom=Nom;
            this.Prenom = Prenom;
            this.Age = Age;
            this.CIN = CIN;
            this.contact = contact;
            this.malad = malad;
            this.vacc = vacc;

        }

        public void Information()
             {
           /* cnx.Open();
            cmd.Connection = cnx;*/
            Console.WriteLine("entrer votre nom:");
             this.Nom = Console.ReadLine();
            Console.WriteLine("entrer votre prenom:");
             this.Prenom = Console.ReadLine();
            Console.WriteLine("entrer votre age:");
            this.Age = Console.ReadLine();
            Console.WriteLine("entrer votre CIN:");
           this.CIN = Console.ReadLine();

           
            
            /*cmd.CommandText = "insert into personne (nom) values (@nom);";
            cmd.Parameters.Add(new SqlParameter("@nom", Nom));

            cmd.ExecuteNonQuery();
            cnx.Close();*/
              }


        /*
        Console.WriteLine("entrer votre prenom:");
            string Prenom = Console.ReadLine();
            Console.WriteLine("entrer votre age:");
            string Age = Console.ReadLine();
            Console.WriteLine("entrer votre cin:");
            string CIN = Console.ReadLine();
            Console.WriteLine("es ce que vous avez fait le test:");
            string Pcr = Console.ReadLine();


            cmd.Parameters.AddWithValue("@prenom", Prenom);

            cmd.Parameters.AddWithValue("@age", Age);

            cmd.Parameters.AddWithValue("@cin", CIN);

            cmd.Parameters.AddWithValue("@pcr", Pcr);*/
        
        public bool Sumptomes()
        {
            Console.WriteLine("es ce que vous avez des sumptomes de covid: ");
            string S = Console.ReadLine();
            if (S == "oui")
            {
                return true;
            }
            else return false;
        }
        public bool AfaireLeTest()
        {
            Console.WriteLine("es ce que vous avez fait le test: ");
            String T = Console.ReadLine();
            if (T =="oui")
            {
                return true;
            }
            else return false;

        }
        public bool EtatTest()
        {
            Console.WriteLine("es ce que le test est positive: ");
            string etat = Console.ReadLine();
            if (etat == "oui")
            {
                this.malad = "malad";
                return true;
            }
            else return false;
        }

        public bool Contacter()
        {
            Console.WriteLine("es ce que vous avez contacter quelqu'un malade :");
            string cont = Console.ReadLine();
            if (cont == "oui")
            {
                this.contact = "contacteur";
                return true;

            }
            else return false;
        }
          
        
        public void TestPositive()
        {
            Console.WriteLine("Votre Code est : Rouge");
            Console.WriteLine("Vous de vez confiner d'une duree de 15 jours:");
        }
       
        public bool Vaccination()
        {
            Console.WriteLine("es ce que vous etes vaccine ? ");
            string vac = Console.ReadLine();
            if (vac == "oui")
            {
               this.vacc = "vaccine"; 
                return true;
            }
            else
            {
                return false;
            }

        }
        
       
        public override string ToString()
        {
            
            return ("Information sur la personne : nom :" + Nom + " prenom :" + Prenom + " age :" + Age + " Etat :" + malad + "contacter :" + contact + "vaccin :" + vacc);
        }



        // end public bool Load()
    }


}
    
