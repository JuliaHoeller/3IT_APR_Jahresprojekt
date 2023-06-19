using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using StudioManager;

namespace _3IT_Höller_Jahresprojekt
{
    internal class SqlCommands
    {
        public static SqlConnection con = new SqlConnection("server = (localdb)\\MSSQLLocalDb; Integrated Security = true;");
        public static SqlCommand cmd = new SqlCommand("Placeholder", con);
        public static bool DatabaseExists = false;

        public static void ChecksIfDatabaseExists()
        {
            List<string> ListDatabases = new List<string>();

            cmd.CommandText = "SELECT name FROM sys.databases";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListDatabases.Add(reader[0].ToString());    //gets a list of all the databases 
                }
            }

            reader.Close();
            con.Close();

            foreach (string i in ListDatabases)
            {
                if (i.Equals("HoellerJulia_Jahresprojekt")) //checks if the database exists 
                {
                    ChangeDatabase();
                    return;
                }

                else 
                {
                    
                }
                               
            }

            CreateDatabase(); //creates the database if it doesn't exist already

        }

        public static void CreateDatabase()
        {
            cmd.CommandText = "CREATE DATABASE HoellerJulia_Jahresprojekt";     //creates the database

            con.Open();

            cmd.ExecuteNonQuery();

            con.ChangeDatabase("HoellerJulia_Jahresprojekt");

            con.Close();
        }

        public static void ChangeDatabase()
        {
            con.Open();

            con.ChangeDatabase("HoellerJulia_Jahresprojekt");

            con.Close();
        }

        public static void CheckIfTableExists()
        {

            List<string> ListTables = new List<string>();

            cmd.CommandText = String.Format("select TABLE_NAME from INFORMATION_SCHEMA.Tables WHERE Table_Type = 'BASE TABLE' ORDER By TABLE_NAME ASC");   
            con.Open();
            con.ChangeDatabase("HoellerJulia_Jahresprojekt");

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListTables.Add(reader[0].ToString());        //gets a list of all the tables in the database 
                }
            }

            reader.Close();
            con.Close();

            //checks if the specific tables exist 
            CheckIfWorkerExists(ListTables);

            CheckIfHoursExists(ListTables);

            CheckIfMissingHoursExists(ListTables);

            CheckIfUsersExists(ListTables);

        }

        public static void CreateTable(string table)    //creates a table depending on which one is missing 
        {
            if (table.Equals("Worker"))
            {
                cmd.CommandText = "CREATE TABLE worker([ID] INT NOT NULL PRIMARY KEY IDENTITY,[firstname] NVARCHAR(100) NOT NULL,[surname] NVARCHAR(100) NOT NULL,[department] NVARCHAR(100), [phone] NVARCHAR(50), [address] NVARCHAR(100), [money] INT NOT NULL, [hours] INT NOT NULL);";
                con.Open();
                con.ChangeDatabase("HoellerJulia_Jahresprojekt");
                cmd.ExecuteNonQuery();
                con.Close();
            }

            else if (table.Equals("Hours"))
            {
                cmd.CommandText = "CREATE TABLE hours([ID] INT NOT NULL PRIMARY KEY IDENTITY,[workerID] INT NOT NULL, [firstname] NVARCHAR(100) NOT NULL, [surename] NVARCHAR(100) NOT NULL, [date] NVARCHAR(100) NOT NULL, [start] NVARCHAR(100) NOT NULL, [end] NVARCHAR(100) NOT NULL);";
                con.Open();
                con.ChangeDatabase("HoellerJulia_Jahresprojekt");
                cmd.ExecuteNonQuery();
                con.Close();
            }

            else if (table.Equals("MissingHours"))
            {
                cmd.CommandText = "CREATE TABLE missinghours([ID] INT NOT NULL PRIMARY KEY IDENTITY,[workerID] INT NOT NULL, [firstname] NVARCHAR(100) NOT NULL, [surename] NVARCHAR(100) NOT NULL, [date] NVARCHAR(100) NOT NULL, [start] NVARCHAR(100) NOT NULL, [end] NVARCHAR(100) NOT NULL, [causeOfMissing] VARCHAR(100) NOT NULL);";
                con.Open();
                con.ChangeDatabase("HoellerJulia_Jahresprojekt");
                cmd.ExecuteNonQuery();
                con.Close();
            }

            else if (table.Equals("programusers"))
            {
                cmd.CommandText = "CREATE TABLE programusers([ID] INT NOT NULL PRIMARY KEY IDENTITY, [name] NVARCHAR(100), [password] NVARCHAR(100), [e-mail] NVARCHAR(100) NOT NULL, [administrator] NVARCHAR(1) NOT NULL, [head-user] NVARCHAR(1) NOT NULL, [user] NVARCHAR(1) NOT NULL);";
                con.Open();
                con.ChangeDatabase("HoellerJulia_Jahresprojekt");
                cmd.ExecuteNonQuery();
                con.Close();

                //creates three users, so the admin can log into the program and test stuff 
                User admin = new User("admin", "admin", "admin@admin.at", true, true, true);

                string salt;
                string encryptedpassword;

                salt = BCrypt.GenerateSalt();

  
                encryptedpassword = BCrypt.HashPassword(admin.Password, salt);  //encryptes the password 

                string comstring = "INSERT INTO programusers VALUES('" + admin.Name + "', '" + encryptedpassword + "', '" + admin.Email + "', 'j', 'j', 'j')";
                cmd.CommandText = comstring;

                con.Open();
                con.ChangeDatabase("HoellerJulia_Jahresprojekt");
                cmd.ExecuteNonQuery();
                con.Close();


                User headuser = new User("head-user", "head-user", "headuser@headuser.at", false, true, true);


                encryptedpassword = BCrypt.HashPassword(headuser.Password, salt);

                comstring = "INSERT INTO programusers VALUES('" + headuser.Name + "', '" + encryptedpassword + "', '" + headuser.Email + "', 'n', 'j', 'j')";
                cmd.CommandText = comstring; 

                con.Open();
                con.ChangeDatabase("HoellerJulia_Jahresprojekt");
                cmd.ExecuteNonQuery();
                con.Close();


                User user = new User("user", "user", "user@user.at", false, false, true);

                encryptedpassword = BCrypt.HashPassword(user.Password, salt);

                comstring = "INSERT INTO programusers VALUES('" + user.Name + "', '" + encryptedpassword + "', '" + user.Email + "', 'n', 'n', 'j')";
                cmd.CommandText= comstring;

                con.Open();
                con.ChangeDatabase("HoellerJulia_Jahresprojekt");
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
        }

        public static void LoadUsers(List<User> ListUser)
        {
            cmd.CommandText = "Select * from programusers";

            con.Open();
            con.ChangeDatabase("HoellerJulia_Jahresprojekt");

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())   //loads users from database
                {
                    User NewUser = new User();

                    NewUser.UserID = Convert.ToInt32(reader[0]);
                    NewUser.Name = reader[1].ToString();
                    NewUser.Password = reader[2].ToString();
                    NewUser.Email = reader[3].ToString();

                    string admin = reader[4].ToString();

                    if (admin.Equals("j"))  //converts the saved data in the database into the different permissions used in the program
                    {
                        NewUser.Administrator = true;
                    }

                    else if (admin.Equals("n"))
                    {
                        NewUser.Administrator = false;
                    }

                    string headuser = reader[5].ToString();

                    if (headuser.Equals("j"))
                    {
                        NewUser.HeadUser= true;
                    }

                    else if (headuser.Equals("n"))
                    {
                        NewUser.HeadUser= false;
                    }

                    string user = reader[6].ToString();

                    if (user.Equals("j"))
                    {
                        NewUser.NormalUser = true;
                    }

                    else if (user.Equals("n"))
                    {
                        NewUser.NormalUser = false; 
                    }

                    ListUser.Add(NewUser);
               
                }
            }

            reader.Close();
            con.Close();

        }

        public static void LoadData(List<Worker> ListWorker, List<Worker> ListHours, List<Worker> ListMissingHours)
        {
            LoadWorker(ListWorker);

            LoadHours(ListHours);

            LoadMissingHours(ListMissingHours);
        }


        public static void SaveData(List<Worker> ListWorker, List<Worker> ListHours, List<Worker> ListMissingHours, List<User> ListUser, List<User> ListNewUser)
        {
            SaveWorker(ListWorker);
            SaveHours(ListHours);
            SaveMissingHours(ListMissingHours);
            SaveUser(ListUser, ListNewUser);
        }


        public static void CheckIfWorkerExists(List<string> ListTables)
        {
            
            foreach (string i in ListTables)
            {
  
                if (i.Equals("worker"))
                {
                    return;
                }

                else
                {

                }


            }

            string table = "Worker";
            CreateTable(table);
        }

        public static void CheckIfHoursExists(List<string> ListTables)
        {
            foreach (string i in ListTables)
            {
                if (i.Equals("hours"))
                {
                    return;
                }

                else
                {

                }
            }

            string table = "Hours";

            CreateTable(table);
        }

        public static void CheckIfMissingHoursExists(List<string> ListTables)
        {
            foreach (string i in ListTables)
            {
                if (i.Equals("missinghours"))
                {
                    return;
                }

                else
                {

                }
            }

            string table = "MissingHours";

            CreateTable(table);
        }

        public static void CheckIfUsersExists(List<string> ListTables)
        {

            foreach (string i in ListTables)
            {
                if (i.Equals("programusers"))
                {
                    return;
                }

                else
                {

                }
            }

            string table = "programusers";

            CreateTable(table);
        }


        public static void LoadWorker(List<Worker> ListWorker)
        {
            cmd.CommandText = "Select * from worker";

            con.Open();
            con.ChangeDatabase("HoellerJulia_Jahresprojekt");

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Worker NewWorker = new Worker();

                    NewWorker.IDNumber = Convert.ToInt32(reader[0]);
                    NewWorker.FirstName = reader[1].ToString();
                    NewWorker.LastName = reader[2].ToString();
                    NewWorker.Department = reader[3].ToString();
                    NewWorker.PhoneNumber = reader[4].ToString();
                    NewWorker.Address = reader[5].ToString();
                    NewWorker.Money = Convert.ToInt32(reader[6]);
                    NewWorker.Hours = Convert.ToInt32(reader[7]);

                    ListWorker.Add(NewWorker);  //gets all the workers saved in the database and saves them in a list 
                }
            }

            reader.Close();
            con.Close();

            
        }

        public static void LoadHours(List<Worker> ListHours)
        {
            cmd.CommandText = "Select * from hours";

            con.Open();
            con.ChangeDatabase("HoellerJulia_Jahresprojekt");

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Worker NewHours = new Worker();

                    NewHours.IDNumber= Convert.ToInt32(reader[1]);
                    NewHours.FirstName = reader[2].ToString();
                    NewHours.LastName = reader[3].ToString();
                    string Date = reader[4].ToString();
                    string Start = reader[5].ToString();
                    string End = reader[6].ToString();

                    NewHours.Date = DateTime.Parse(Date);
                    NewHours.Start = DateTime.Parse(Start);
                    NewHours.End = DateTime.Parse(End);

                    ListHours.Add(NewHours);    //gets all the hours saved in the database and saves them in a list 
                }
            }

            reader.Close();
            con.Close();
        }

        public static void LoadMissingHours(List<Worker> ListMissingHours)
        {
            cmd.CommandText = "Select * from missinghours";

            con.Open();
            con.ChangeDatabase("HoellerJulia_Jahresprojekt");

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Worker NewMissingHours = new Worker();


                    NewMissingHours.IDNumber = Convert.ToInt32(reader[1]);
                    NewMissingHours.FirstName = reader[2].ToString();
                    NewMissingHours.LastName = reader[3].ToString();
                    string Date = reader[4].ToString();
                    string Start = reader[5].ToString();
                    string End = reader[6].ToString();
                    NewMissingHours.CauseOfMissing = reader[7].ToString();


                    NewMissingHours.Date = DateTime.Parse(Date);
                    NewMissingHours.Start = DateTime.Parse(Start);
                    NewMissingHours.End = DateTime.Parse(End);

                    ListMissingHours.Add(NewMissingHours);  //gets all the missing hours saved in the database and saves them in a list 
                }
            }

            reader.Close();
            con.Close();
        }


        public static void SaveWorker(List<Worker> ListWorker)
        {
            try
            {
                cmd.CommandText = "Truncate table worker";

                con.ConnectionString = "server = (localdb)\\MSSQLLocalDb; Integrated Security = true; Initial Catalog = HoellerJulia_Jahresprojekt;";

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                foreach (Worker w in ListWorker)    //saves all the worker into the database
                {
                    con.Open();

                    cmd.CommandText = "INSERT INTO worker VALUES('" + w.FirstName + "', '" + w.LastName + "', '" + w.Department + "', '" + w.PhoneNumber + "', '" + w.Address + "', '" + w.Money + "', '" + w.Hours + "')";

                    cmd.ExecuteNonQuery();

                    con.Close();

                }

                MessageBox.Show("Die Mitarbeiter wurden erfolgreich gespeichert.", "Speichern");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Beim Speichern der Mitarbeiter ist ein Fehler passiert.\nBitte versuchen Sie es erneut.", "Achtung!");
            }
                       
        }

        public static void SaveHours(List<Worker> ListHours)
        {
            try
            {
                cmd.CommandText = "Truncate table hours;";

                con.ConnectionString = "server = (localdb)\\MSSQLLocalDb; Integrated Security = true; Initial Catalog = HoellerJulia_Jahresprojekt;";

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                foreach (Worker w in ListHours) //saves all the hours into the database
                {
                    con.Open();

                    string Date = w.Date.ToString();    //converts DateTime into a type that can be saved into the database 
                    string Start = w.Start.ToString();
                    string End = w.End.ToString();

                    cmd.CommandText = "INSERT INTO hours VALUES('" + w.IDNumber + "', '" + w.FirstName + "', '" + w.LastName + "', '" + Date + "', '" + Start + "', '" + End + "')";

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                MessageBox.Show("Die Stunden wurden erfolgreich gespeichert.", "Speichern");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Beim Speichern der Stunden ist ein Fehler passiert.\nBitte versuchen Sie es erneut.", "Achtung!");
            }
        }

        public static void SaveMissingHours(List<Worker> ListMissingHours)
        {
            try
            {
                con.Close(); 

                cmd.CommandText = "Truncate table missinghours;";

                con.ConnectionString = "server = (localdb)\\MSSQLLocalDb; Integrated Security = true; Initial Catalog = HoellerJulia_Jahresprojekt;";

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                foreach (Worker w in ListMissingHours) //saves all the missing hours into the database
                {
                    con.Open();

                    string Date = w.Date.ToString();
                    string Start = w.Start.ToString();
                    string End = w.End.ToString();
                   

                    cmd.CommandText = "INSERT INTO missinghours VALUES('" + w.IDNumber + "', '" +  w.FirstName + "', '" + w.LastName + "', '" + Date + "', '" + Start + "', '" + End + "', '" + w.CauseOfMissing + "')";

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                

                MessageBox.Show("Die Fehlstunden wurden erfolgreich gespeichert.", "Speichern");
            }

            catch (Exception ex)
            {

                MessageBox.Show("Beim Speichern der Fehlstunden ist ein Fehler passiert.\nBitte versuchen Sie es erneut.", "Achtung!");
            }
        }

        public static void SaveUser(List<User> ListUser, List<User> ListNewUser)
        {
            try
            {
                con.Close();

                cmd.CommandText = "Truncate table programusers;";

                con.ConnectionString = "server = (localdb)\\MSSQLLocalDb; Integrated Security = true; Initial Catalog = HoellerJulia_Jahresprojekt;";

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                foreach (User u in ListUser) //saves all the old users into the database
                {
                    con.Open();

                    string comstring = "INSERT INTO programusers VALUES('" + u.Name + "', '" + u.Password + "', '" + u.Email + "', '";      //converts the permissions into a type that can be saved into the database

                    if (u.Administrator == true)
                    {
                        cmd.CommandText = comstring + "j', 'j', 'j')";
                    }

                    else if (u.Administrator == false && u.HeadUser == true)
                    {
                        cmd.CommandText = comstring + "n', 'j', 'j')";
                    }

                    else if (u.Administrator == false && u.HeadUser == false && u.NormalUser == true)
                    {
                        cmd.CommandText = comstring + "n', 'n', 'j')";
                    }

                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                foreach (User u in ListNewUser)  //saves all the new users into the database
                {

                    string salt;
                    string encryptedpassword;

                    salt = BCrypt.GenerateSalt();

                    encryptedpassword = BCrypt.HashPassword(u.Password, salt);  //encrypes the password of the new users


                    con.Open();

                    string comstring = "INSERT INTO programusers VALUES('" + u.Name + "', '" + encryptedpassword + "', '" + u.Email + "', '";

                    if (u.Administrator == true)
                    {
                        cmd.CommandText = comstring + "j', 'j', 'j')";
                    }

                    else if (u.Administrator == false && u.HeadUser == true)
                    {
                        cmd.CommandText = comstring + "n', 'j', 'j')";
                    }

                    else if (u.Administrator == false && u.HeadUser == false && u.NormalUser == true)
                    {
                        cmd.CommandText = comstring + "n', 'n', 'j')";
                    }

                    cmd.ExecuteNonQuery();

                    con.Close();

                }


                MessageBox.Show("Die User wurden erfolgreich gespeichert.", "Speichern");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Beim Speichern der User ist ein Fehler passiert.\nBitte versuchen Sie es erneut.", "Achtung!");
            }               
        }
    }
}
