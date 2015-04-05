using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1.DAL;
using Tema1.Other;

namespace Tema1.BL
{
    public class AnunturiService
    {
        AnunturiDAL anuntDAL;
        
        public AnunturiService()
        {
            anuntDAL = new AnunturiDAL();
        }

        public AnunturiService(String titlu, String descriere)
        {
            anuntDAL = new AnunturiDAL(titlu, descriere);
        }

        public AnunturiService(String titlu)
        {
            anuntDAL = new AnunturiDAL(titlu);
        }

        public Anunt adaugaAnunt(String titlu, String descriere)
        {
            Anunt anunt = anuntDAL.creareAnunt(titlu, descriere);
            return anunt;
        }

        public Anunt editeazaAnunt(String titlu, String descriere)
        {
            Anunt anunt = anuntDAL.editeazaAnunt(titlu, descriere);
            return anunt;
        }

        public Anunt stergeAnunt(String titlu)
        {
            Anunt anunt = anuntDAL.stergeAnunt(titlu);
            return anunt;
        }

        public Anunt afiseazaAnunt(String titlu)
        {
            Anunt anunt = anuntDAL.afiseazaAnunt(titlu);
            //Console.WriteLine("SERVICE: " + anunt.getTitlu());
            return anunt;
        }

        public String[] fillCombo()
        {
            string[] s = new string[100];
            s = anuntDAL.FillCombo();
            //Console.WriteLine("SERVICE:  " +s[0] + s[1]+  "\n");
            return s;
        }

    }
}
