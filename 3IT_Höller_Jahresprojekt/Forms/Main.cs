using _3IT_Höller_Jahresprojekt.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace _3IT_Höller_Jahresprojekt
{
    public partial class Main : Form
    {
        #region properties
        public static List<Worker> ListWorker = new List<Worker>();
        public static List<Worker> ListHours = new List<Worker>();

        public static List<Worker> ListMissingHours = new List<Worker>();

        List<User> ListNewUser = new List<User>();
        List<User> ListUser = new List<User>();

        User activeUser = new User();

        string NameAndNumber;
        public string infos;

        int number;
        public int money;


        DateTime start;
        DateTime end;
        #endregion

        public Main(User activeUser, List<User> ListUser)
        {
            InitializeComponent();

            this.activeUser = activeUser;
            this.ListUser = ListUser;
        }

        #region buttons
        //buttons just doing button-things

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                start = DateTime.Parse(txBx_start.Text);
                end = DateTime.Parse(txBx_end.Text);

                if (start < end) //checks if the entered time is right 
                {
                    Worker WorkingHours = new Worker();

                    string[] FirstSplit = NameAndNumber.Split('.'); //splits the selected variable to get the ID-Number

                    WorkingHours.IDNumber = Convert.ToInt32(FirstSplit[0]);
                    Name = FirstSplit[1];

                    string[] SecondSplit = Name.Split(' '); //splits the full name to get the firstname and lastname
                    WorkingHours.FirstName = SecondSplit[1];
                    WorkingHours.LastName = SecondSplit[2];

                    WorkingHours.Date = DateTime.Parse(txBx_date.Text);
                    WorkingHours.Start = start;
                    WorkingHours.End = end;

                    ListHours.Add(WorkingHours);

                    string caption = "Eingaben speichern";
                    string message = "Ihre Eingaben wurde gespeichert! ";
                    MessageBox.Show(message, caption);

                    txBx_date.Clear();
                    txBx_end.Clear();
                    txBx_start.Clear();

                    AddTodaysDate();
                }

                else
                {
                    string caption = "Achtung";
                    string message = "Die Endzeit darf nicht kleiner sein als die Startzeit!";
                    MessageBox.Show(message, caption);
                }


            }
            catch (InvalidStartException)
            {
                string caption = "Achtung!";
                string message = "Der Startwert darf nicht leer sein! \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (InvalidEndException)
            {
                string caption = "Achtung!";
                string message = "Der Endwert darf nicht leer sein! \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (InvalidDateException)
            {
                string caption = "Achtung!";
                string message = "Das Datum darf nicht leer sein! \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (FormatException)
            {
                string caption = "Achtung!";
                string message = "Eine Eingabe wurde im falschen Format getätigt. \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);

            }

            catch (NullReferenceException)
            {
                string caption = "Achtung!";
                string message = "Anscheinend wurde bei der Eingabe ein Fehler gemacht. \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (Exception)
            {
                string caption = "Achtung!";
                string message = "Anscheinend wurde ein Fehler gemacht. \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

        }

        private void btn_saveAll_Click(object sender, EventArgs e)
        {
            SqlCommands.SaveData(ListWorker, ListHours, ListMissingHours, ListUser, ListNewUser);   //saves all the data in the database
        }


        private void btn_loadWorker_Click(object sender, EventArgs e)
        {
            LoadWorkerInCoBx();
        }

        private void btn_newWorker_Click(object sender, EventArgs e)
        {
            NewWorker NewWorkerForm = new NewWorker(ListWorker);
            this.Hide();
            NewWorkerForm.ShowDialog();
            this.Show();

            ListWorker = NewWorkerForm.ListWorker;

            LoadWorkerInCoBx();
        }

        private void btn_editWorker_Click(object sender, EventArgs e)
        {
            EditWorker EditWorkerForm = new EditWorker(ListWorker, ListHours, ListMissingHours);
            this.Hide();
            EditWorkerForm.ShowDialog();
            this.Show();

            LoadWorkerInCoBx();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            Payment PaymentForm = new Payment(ListHours, NameAndNumber, money);
            this.Hide();
            PaymentForm.ShowDialog();
            this.Show();

            ListHours = PaymentForm.ListHours;
        }

        private void btn_notHere_Click(object sender, EventArgs e)
        {
            NotHere NotHereForm = new NotHere(ListWorker, ListMissingHours, NameAndNumber);
            this.Hide();
            NotHereForm.ShowDialog();
            this.Show();

            ListMissingHours = NotHereForm.ListMissingHours;
        }

        private void btn_missingHours_Click(object sender, EventArgs e)
        {
            MissingHours MissingHoursForm = new MissingHours(ListMissingHours, NameAndNumber);

            this.Hide();
            MissingHoursForm.ShowDialog();
            this.Show();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            All AllForm = new All(ListWorker, ListHours, ListMissingHours, money);
            this.Hide();
            AllForm.ShowDialog();
            this.Show();
        }

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            NewUser NewUserForm = new NewUser(ListNewUser, ListUser);
            this.Hide();
            NewUserForm.ShowDialog();
            this.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SqlCommands.LoadData(ListWorker, ListHours, ListMissingHours); //loads all the data regarding workers and hours
            LoadWorkerInCoBx();

            if (activeUser.Administrator == false)  //checks what permissions the user has and enables buttons depending on the permissions 
            {
                btn_newUser.Enabled = false;
            }

            if (activeUser.HeadUser == false)
            {
                btn_newWorker.Enabled = false;
                btn_editWorker.Enabled = false;
                btn_editUser.Enabled = false;
            }

            AddTodaysDate();

        }

        private void coBx_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameAndNumber = Convert.ToString(coBx_name.SelectedItem); //gets the selected item and saves it in a string

            string[] Split = NameAndNumber.Split('.');

            number = Convert.ToInt32(Split[0]);

            foreach (Worker i in ListWorker) //saves the information about the money, witch the selected worker gets for every hour they work, in a special variable for the calculation of the salary
            {
                if (number == i.IDNumber)
                {
                    money = i.Money;
                }
            }
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            EditUser edituserform = new EditUser(ListUser, ListNewUser);
            this.Hide();
            edituserform.ShowDialog();
            this.Show();
        }

        #endregion

        #region methods

        public void LoadWorkerInCoBx()  //every time the main-form is opened, the infos in ListWorker are put in the combobox to get selected by the user
        {
            coBx_name.Items.Clear();

            foreach (Worker i in ListWorker)
            {
                infos = Convert.ToString(i.IDNumber) + ". " + i.FirstName + " " + i.LastName;

                coBx_name.Items.Add(infos);
            }

        }

        public void AddTodaysDate()
        {

            DateTime today = DateTime.Today;    //gets todays date and writes it in the textbox
            string date = today.ToString();

            string[] Split = date.Split(' ');


            txBx_date.Text = Split[0];
        }
        #endregion
    
    }
}
