using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1.Other
{
    public class Angajat
    {
        public String username { get; set; }
        String password { get; set; }
        public String role { get; set; }
        public int nrAnunturi { get; set; }


        public Angajat(String username, String password, String role, int nrAnunturi)
        {
            this.username = username;
            this.password = password;
            this.role = role;
            this.nrAnunturi = nrAnunturi;
        }

        //public String getUsername()
        //{
        //    return username;
        //}

        //public String getPassword()
        //{
        //    return password;
        //}

        //public String getRole()
        //{
        //    return role;
        //}

    }
}
