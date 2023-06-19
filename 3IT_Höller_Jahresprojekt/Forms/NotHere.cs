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

namespace _3IT_Höller_Jahresprojekt
{
    public partial class NotHere : Form
    {
        #region properties 
        public List<Worker> ListWorker = new List<Worker>();
        public List<Worker> ListMissingHours = new List<Worker>();

        public string NameAndNumber;
        public string name;

        DateTime start;
        DateTime end;

        #endregion

        public NotHere(List<Worker> ListWorker, List<Worker> ListMissingHours, string NameAndNumber)
        {
            try
            {
                InitializeComponent();
                this.ListWorker = ListWorker;
                this.NameAndNumber = NameAndNumber;
                this.ListMissingHours = ListMissingHours;
                liBx_name.Items.Add(NameAndNumber);
            }

            catch (ArgumentNullException)
            {
                string caption = "Achtung!";
                string message = "Es muss ein Arbeiter bzw. Angestellter ausgewählt sein. \nBitte versuchen Sie es erneut!";
                MessageBox.Show(message, caption);
                this.Hide();
            }
        }

        #region buttons
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                start = DateTime.Parse(txBx_startMissing.Text);
                end = DateTime.Parse(txBx_endMissing.Text);

                if (start < end) //checks if the entered time is right 
                {
                    Worker MissingWorker = new Worker();    //creates a new Worker to save the information

                    string[] FirstSplit = NameAndNumber.Split('.');  //splits the selected item to get the ID-number

                    MissingWorker.IDNumber = Convert.ToInt32(FirstSplit[0]);

                    Name = FirstSplit[1];   //splits the name a second time to get the firstname and the lastname

                    string[] SecondSplit = Name.Split(' ');

                    MissingWorker.FirstName = SecondSplit[1];
                    MissingWorker.LastName = SecondSplit[2];

                    MissingWorker.Date = DateTime.Parse(txBx_dateMissing.Text);
                    MissingWorker.Start = start;
                    MissingWorker.End = end;

                    MissingWorker.CauseOfMissing = Convert.ToString(cobx_cause.SelectedItem);

                    ListMissingHours.Add(MissingWorker);    //adds all the information to ListMissingHours


                    string caption = "Speichern";
                    string message = "Ihre Eingaben wurde gespeichert!";
                    MessageBox.Show(message, caption);

                    txBx_dateMissing.Clear();
                    txBx_endMissing.Clear();
                    txBx_startMissing.Clear();

                    AddTodaysDate();
                }

                else
                {
                    string caption = "Achtung";
                    string message = "Die Endzeit darf nicht kleiner sein als die Startzeit!";
                    MessageBox.Show(message, caption);
                }
            }

            catch (InvalidMissingDateException)
            {
                Message();
            }

            catch (InvalidMissingStartException)
            {
                Message();
            }

            catch (InvalidMissingEndException)
            {
                Message();
            }

            catch (NullReferenceException)
            {
                Message();
            }

            catch (FormatException)
            {
                Message();
            }

            catch (Exception)
            {
                Message();
            }
        }

        private void NotHere_Load(object sender, EventArgs e)
        {
            AddTodaysDate();
        }

        #endregion

        #region methods

        private static void Message()
        {
            string caption = "Achtung!";
            string message = "Anscheinend ist bei der Eingabe ein Fehler passiert. \nBitte versuchen Sie es erneut!";
            MessageBox.Show(message, caption);
        }

        public void AddTodaysDate()
        {

            DateTime today = DateTime.Today; //gets todays date and writes it into the textbox
            string date = today.ToString();

            string[] Split = date.Split(' ');


            txBx_dateMissing.Text = Split[0];
        }
        #endregion

   
    }
}
