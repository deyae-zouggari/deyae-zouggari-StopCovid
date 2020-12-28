using System;

using System.Data;

using System.Data.SqlClient;

namespace stopcovid2
{



    class citoyen
    {

        public string Nom;
        public string Prenom;
        public int Age;
        public string CIN;
        public string vac;
        public string cont;
        public string etat;




        static string chaine = @"Data Source=DESKTOP-D7HHOO9;Initial Catalog=StopCovid;Integrated Security=True";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);    

        public void Information()
        {
            /* cnx.Open();
             cmd.Connection = cnx;*/
           
            Console.WriteLine("entrer votre nom:");
             Nom = Console.ReadLine();
            Console.WriteLine("entrer votre prenom:");
             Prenom = Console.ReadLine();
            Console.WriteLine("entrer votre age:");
             Age =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("entrer votre CIN:");
             CIN = Console.ReadLine();
           
            
        }

        
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
            etat = Console.ReadLine();
          

            if (etat == "oui")
            {
               
                return true;
            }
            else return false;

          
        }

        public bool Contacter()
        {
           
            Console.WriteLine("es ce que vous avez contacter quelqu'un malade :");
             cont = Console.ReadLine();
            
            cnx.Close();
            if (cont == "oui")
            {
                
                return true;

            }
            else return false;
            
           
        }
          
        
        public void TestPositive()
        {
            Console.WriteLine("Votre Code est : Rouge");
            Console.WriteLine("Vous de vez confiner d'une duree de 15 jours:");
        }
        public void TestNegative()
        {
            Console.WriteLine("Votre Code est : Vert");
            
        }

        public bool Vaccination()
        {

            Console.WriteLine("es ce que vous etes vaccine ? ");
             vac = Console.ReadLine();
            
            if (vac == "oui")
            {
              
                return true;
            }
            else
            {
                vac = "non";
                return false;
            }
           

        }
        public void recuperer()
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Personne(Nom,Prenom,Age,CIN,Malad,Contacteur,Vaccine) values('" + Nom + "','" + Prenom + "','" + Age + "','" + CIN + "','" + etat + "','" + cont + "','" + vac + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        
       
        //public override string ToString()
        //{
            
        //    return ("Information sur la personne : nom :" + Nom + " prenom :" + Prenom + " age :" + Age + " Etat :" + malad + "contacter :" + contact + "vaccin :" + vacc);
        //}



        // end public bool Load()
    }


}
    
