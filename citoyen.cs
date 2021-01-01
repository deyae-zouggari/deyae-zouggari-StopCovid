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
        





        public void Information()
        {
            /* cnx.Open();
             cmd.Connection = cnx;*/

            Console.WriteLine("entrer votre nom:");
            Nom = Console.ReadLine();
            Console.WriteLine("entrer votre prenom:");
            Prenom = Console.ReadLine();
            Console.WriteLine("entrer votre age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entrer votre CIN:");
            CIN = Console.ReadLine();


        }





        //public override string ToString()
        //{

        //    return ("Information sur la personne : nom :" + Nom + " prenom :" + Prenom + " age :" + Age + " Etat :" + malad + "contacter :" + contact + "vaccin :" + vacc);
        //}



        // end public bool Load()
    }


}
    
