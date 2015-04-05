using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Tema1.Other;

namespace Tema1.DAL
{
    public class AnunturiDAL
    {
        Anunt anunt;
   
        public AnunturiDAL()
        {
            //FillCombo();
        }

        public AnunturiDAL(String titlu, String descriere)
        {
            //getAnunt(titlu, descriere);
        }

        public AnunturiDAL(String titlu)
        {
            //stergeAnunt(titlu);
        }

        public Anunt getAnunt(String titlu, String descriere)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                // MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM angajat.anunt WHERE titlu='" + titlu + "'and descriere='" + descriere + "' ;", myConn);
                MySqlDataReader myReader;

                // MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                //MessageBox.Show("Connected!");               

                while (myReader.Read())
                {
                    //Console.WriteLine(" !!!!" + myReader["username"].ToString() + myReader["password"].ToString());
                    anunt = new Anunt(myReader["titlu"].ToString(), myReader["descriere"].ToString());
                    //Console.WriteLine("!!!222" + u.getName());
                }


                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return anunt;
        }

        public Anunt creareAnunt(String titlu, String descriere)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string q = "INSERT INTO angajat.anunt (titlu, descriere) VALUES ('" + titlu + "','" + descriere + "') ;";

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
                    anunt = new Anunt(myReader["titlu"].ToString(), myReader["descriere"].ToString());
                    //Console.WriteLine("!!!222" + u.getName());
                }


                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return anunt;
        }

        public Anunt editeazaAnunt(String titlu, String descriere)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string q = "UPDATE angajat.anunt set titlu='" + titlu + "',descriere='" + descriere + "' WHERE titlu='" + titlu + "' ;";

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
                    anunt = new Anunt(myReader["titlu"].ToString(), myReader["descriere"].ToString());
                    //Console.WriteLine("!!!222" + u.getName());
                }


                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return anunt;
        }

        public Anunt stergeAnunt(String titlu) 
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string q = "DELETE FROM angajat.anunt WHERE titlu='" + titlu + "' ;";

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
                    anunt = new Anunt(myReader["titlu"].ToString(), myReader["descriere"].ToString());
                    //Console.WriteLine("!!!222" + u.getName());
                }


                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return anunt;
        }

        public String[] FillCombo()
        {
            string[] titlu = new string[100];
            int i = 0;
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string q = "SELECT * FROM angajat.anunt  ;";                

                MySqlConnection myConn = new MySqlConnection(myConnection);
                // MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                MySqlCommand SelectCommand = new MySqlCommand(q, myConn);
                MySqlDataReader myReader;

                // MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    titlu[i] = myReader.GetString("titlu");
                    //Console.WriteLine(i + " " + titlu[i] + "\n");
                    i++;
                    
                }


                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return titlu;
        }

        public Anunt afiseazaAnunt(String titlu)
        {            
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string q = "SELECT * FROM angajat.anunt WHERE titlu='" + titlu + "' ;";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                // MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                MySqlCommand SelectCommand = new MySqlCommand(q, myConn);
                MySqlDataReader myReader;

                // MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    //Console.WriteLine("DAL1: " + myReader["titlu"].ToString() + myReader["descriere"].ToString());
                    anunt = new Anunt(myReader["titlu"].ToString(), myReader["descriere"].ToString());
                    //Console.WriteLine("DAL2: " + anunt.getTitlu());
                   
                    
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return anunt;
        }

    }
}
