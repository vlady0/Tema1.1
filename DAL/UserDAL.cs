using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Tema1.Other;

namespace Tema1.DAL
{
    public class UserDAL
    {
        //private static UserDAL usersDAL = null;
        //private String connectionString = "";
        //MySqlConnection conn = null;
        Angajat ang;
        //private string username;
        //private string password;
        //private string role;

        public UserDAL(String username, String password)
        {

            getAngajat(username, password);
        }

        public UserDAL(String username, String password, String role)
        {
            //creareAngajat(username, password, role);
        }  


        public Angajat getAngajat(String username, String password)
        {
            //connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "acasalab4");
            //conn = new MySqlConnection(connectionString);
            //User u = null;
            //String sql = "SELECT * FROM users WHERE name='" + username + "' AND password='" + password + "'";
            //try
            //{
            //    conn.Open();
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    reader.Read();
            //    if (reader.HasRows)
            //    {
            //        u = new User(reader["name"].ToString(), reader["password"].ToString(), reader["type"].ToString());
            //    }
            //    else
            //    {
            //        u = null;
            //    }
            //    conn.Close();

            //}
            //catch (MySqlException e)
            //{
            //    Console.WriteLine(e.Message);
            //    conn.Close();
            //    return null;
            //}
            //return u;



            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                // MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM angajat.angajati WHERE username='" + username + "'and password='" + password + "' ;", myConn);
                MySqlDataReader myReader;

                // MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                //MessageBox.Show("Connected!");               

                while (myReader.Read())
                {
                    //Console.WriteLine(" !!!!" + myReader["username"].ToString() + myReader["password"].ToString());
                    ang = new Angajat(myReader["username"].ToString(), myReader["password"].ToString(), myReader["role"].ToString(), int.Parse(myReader["nranunturi"].ToString()));
                    //Console.WriteLine("!!!222" + u.getName());
                }
                
                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ang;
        }

        public Angajat creareAngajat(String username, String password, String role)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string q = "INSERT INTO angajat.angajati (username, password, role, nranunturi) VALUES ('" + username + "','" + password + "','" + role + "','" + 0 + "') ;";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                // MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                MySqlCommand SelectCommand = new MySqlCommand(q, myConn);
                MySqlDataReader myReader;

                // MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();                              

                while (myReader.Read())
                {
                    //Console.WriteLine(" !!!!" + myReader["username"].ToString() + myReader["password"].ToString());
                    ang = new Angajat(myReader["username"].ToString(), myReader["password"].ToString(), myReader["role"].ToString(), int.Parse(myReader["nranunturi"].ToString()));
                    //Console.WriteLine("!!!222" + u.getName());
                }


                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ang;

        }

        public Angajat incrementeazaAnunt(String username)
        {
            try
            {
                Console.WriteLine("FSFDS: " + username);
                //int nrAnunturi = getNrAnunturi(username) + 1;
                string myConnection = "datasource=localhost;port=3306;username=root;password=";                
                string q = "UPDATE angajat.angajati set username='" + username + "',nranunturi='" + 7 + "' WHERE username='" + username + "' ;";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                // MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                MySqlCommand SelectCommand = new MySqlCommand(q, myConn);
                MySqlDataReader myReader;

                // MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    //Console.WriteLine(" !!!!" + myReader["username"].ToString() + myReader["password"].ToString());
                    ang = new Angajat(myReader["username"].ToString(), myReader["password"].ToString(), myReader["role"].ToString(), int.Parse(myReader["nranunturi"].ToString()));
                    //Console.WriteLine("!!!222" + u.getName());
                }


                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ang;

        }

        public int getNrAnunturi(string username)
        {
            int nrAnunturi = 0;            
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string q = "SELECT * FROM angajat.angajati WHERE username='" + username + "' ;";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                // MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                MySqlCommand SelectCommand = new MySqlCommand(q, myConn);
                MySqlDataReader myReader;

                // MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    nrAnunturi = int.Parse(myReader.GetString("nranunturi"));                             
                }


                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return nrAnunturi;
        }

      
    }
}
