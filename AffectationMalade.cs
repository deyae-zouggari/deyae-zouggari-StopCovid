using System;
using System.Collections.Generic;
using System.Text;

namespace stopcovid2
{
   
    class AffectationMalade
    {
        public string symptomes;
        public string Test;
        public string cont;
        public string etat;
       
        public bool Sumptomes()
        {
            //Console.WriteLine("es ce que vous avez des sumptomes de covid: ");
            //string S = Console.ReadLine();
            if (symptomes == "oui")
            {
              return true;
            }
           else return false;
        }
        public bool AfaireLeTest()
        {
            //Console.WriteLine("es ce que vous avez fait le test: ");
            //String T = Console.ReadLine();
            if (Test=="oui")
            {
                return true;
            }
            else return false;

        }
        public bool EtatTest()
        {

            //Console.WriteLine("es ce que le test est positive: ");
            //etat = Console.ReadLine();


            if (etat == "oui")
            {
               
                return true;
            }
            else {
                
                return false; }


        }

        public bool Contacter()

        {

            //Console.WriteLine("es ce que vous avez contacter quelqu'un malade :");
            // cont = Console.ReadLine();

            //cnx.Close();
            if (cont == "oui")
            {

               
                return true;

            }
            else return false;


        }


        //public void TestPositive()
        //{
        //    //    Console.WriteLine("Votre Code est : Rouge");
        //    //    Console.WriteLine("Vous de vez confiner d'une duree de 15 jours:");
        //}
        //public void TestNegative()
        //{
        //    //Console.WriteLine("Votre Code est : Vert");

        //}
    }
}
