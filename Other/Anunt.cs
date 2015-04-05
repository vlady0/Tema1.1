using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1.Other
{
    public class Anunt
    {
        String titlu; //{ get; set; }
        String descriere; //{ get; set; }

        public Anunt(String titlu, String descriere)
        {
            this.titlu = titlu;
            this.descriere = descriere;
        }

        public String getTitlu()
        {
            return titlu;
        }

        public String getDescriere()
        {
            return descriere;
        }

    }
}
