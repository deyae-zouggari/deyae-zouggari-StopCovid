using System;
using System.Collections.Generic;
using System.Text;

namespace stopcovid2
{
    class Vaccine
    {
        public string vac;
       
        public bool Vaccination()
        {

            //Console.WriteLine("es ce que vous etes vaccine ? ");
            // vac = Console.ReadLine();

            if (vac == "oui")
            {
                
                return true;
            }
            else return false;

        }
    }
}
