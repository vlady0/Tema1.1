using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Tema1.DAL;
using Tema1.Other;

namespace Tema1.BL
{
    public class UserService
    {
        UserDAL userDAL;

        public UserService()
        {

        }

        public UserService(String username, String password)
        {
            userDAL = new UserDAL(username, password);
        }

        public UserService(String username, String password, String role)
        {
            userDAL = new UserDAL(username, password, role);
        }
     

        public Angajat login(String username, String password)
        {
            String p = getMd5Hash(password);
            Angajat angajat = userDAL.getAngajat(username, p);
            return angajat;
        }
        
        public Angajat creareCont(String newUsername, String newPassword, String newRole)
        {
            String p = getMd5Hash(newPassword);
            Angajat angajat = userDAL.creareAngajat(newUsername, p, newRole);
            return angajat;

        }

        public Angajat incrementareNrAnunturi(String username)
        {            
            Angajat angajat = userDAL.incrementeazaAnunt(username);
            return angajat;
        }


        public int getNrAnunturi(string username)
        {
            int nrAnunturi = userDAL.getNrAnunturi(username);
            return nrAnunturi;
        }

              

        public string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
