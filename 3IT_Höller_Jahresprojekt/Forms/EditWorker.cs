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
    public partial class EditWorker : Form
    {
        #region properties
        List<Worker> ListWorker = new List<Worker>();
        List<Worker> ListHours = new List<Worker>();
        List<Worker> ListMissingHours = new List<Worker>();

        string infos;
        string nameandnumber;
        string name;
        string change;

        int number;
        string firstname;
        string lastname;
        #endregion

        public EditWorker(List<Worker> ListWorker, List<Worker> ListHours, List<Worker> ListMissingHours)
        {
            InitializeComponent();

            this.ListWorker = ListWorker;
            this.ListHours = ListHours;
            this.ListMissingHours = ListMissingHours;
        }

        #region buttons
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {

                string[] FirstSplit = nameandnumber.Split('.'); //splits the selected item to get the ID-number
                number = Convert.ToInt32(FirstSplit[0]);
                name = FirstSplit[1];

                change = coBx_change.SelectedItem.ToString();   //gets the selected value that should be changed

                foreach (Worker i in ListWorker)    //changes the selected value in ListWorker
                {
                    if (i.IDNumber == number && change == "Vorname")
                    {
                        i.FirstName = Convert.ToString(txBx_new.Text);

                    }

                    else if (i.IDNumber == number && change == "Nachname")
                    {
                        i.LastName = Convert.ToString(txBx_new.Text);

                    }

                    else if (i.IDNumber == number && change == "Abteilung")
                    {
                        i.Department = Convert.ToString(txBx_new.Text);

                    }

                    else if (i.IDNumber == number && change == "Telefonnummer")
                    {
                        i.PhoneNumber = Convert.ToString(txBx_new.Text);

                    }

                    else if (i.IDNumber == number && change == "Adresse")
                    {
                        i.Address = Convert.ToString(txBx_new.Text);

                    }

                    else if (i.IDNumber == number && change == "Verdienst pro Stunde")
                    {
                        i.Money = Convert.ToInt32(txBx_new.Text);

                    }

                    else if (i.IDNumber == number && change == "Stunden pro Monat")
                    {
                        i.Hours = Convert.ToInt32(txBx_new.Text);

                    }

                }

                foreach (Worker i in ListHours) //changes the selected value in ListHours
                {
                    if (i.IDNumber == number && change == "Vorname")
                    {
                        i.FirstName = Convert.ToString(txBx_new.Text);

                    }

                    else if (i.IDNumber == number && change == "Nachname")
                    {
                        i.LastName = Convert.ToString(txBx_new.Text);

                    }
  
                }

                foreach (Worker i in ListMissingHours)  //changes the selected value in ListMissingHours
                {
                    if (i.IDNumber == number && change == "Vorname")
                    {
                        i.FirstName = Convert.ToString(txBx_new.Text);

                    }

                    else if (i.IDNumber == number && change == "Nachname")
                    {
                        i.LastName = Convert.ToString(txBx_new.Text);

                    }

                }

                coBx_name.Items.Clear();

                foreach (Worker i in ListWorker)    //puts the information in the combobox 
                {
                    infos = Convert.ToString(i.IDNumber) + ". " + i.FirstName + " " + i.LastName;

                    coBx_name.Items.Add(infos);
                }

                EditMessage();
            }

            catch (InvalidHoursException)
            {
                string caption = "Achtung!";
                string message = "Die Anzahl der maximalen Arbeitsstunden pro Monat muss zwischen 0 und 200 Stunden liegen! \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (InvalidMoneyException)
            {
                string caption = "Achtung!";
                string message = "Das Gehalt für einen Monat muss zwischen 0 und 1.000.000.000 Euro betragen! \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (FormatException)
            {
                string caption = "Achtung!";
                string message = "Eine Eingabe wurde im falschen Format getätigt. \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (ArgumentNullException)
            {
                Message();
            }

            catch (Exception)
            {
                Message();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string[] FirstSplit = nameandnumber.Split('.'); //splits the selected item to get the ID-number
                number = Convert.ToInt32(FirstSplit[0]);
                name = FirstSplit[1];

                string[] SecondSplit = name.Split(' ');         //splits the name a second time to get the firstname and the lastname
                firstname = SecondSplit[1];
                lastname = SecondSplit[2];

                string message = "Soll der Arbeiter bzw. Angestellte wirklich gelöscht werden?";    //asks the user if the worker should really be deleted
                string caption = "Arbeiter bzw. Angestellten löschen";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    DeleteWorker(ListWorker, number, firstname, lastname);
                    DeleteHours(ListHours, number, firstname, lastname);
                    DeleteMissing(ListMissingHours, number, firstname, lastname);
                    DeleteMessage();

                    coBx_name.Items.Clear();

                    foreach (Worker i in ListWorker)    //puts the information in the combobox when the form loads
                    {
                        infos = Convert.ToString(i.IDNumber) + ". " + i.FirstName + " " + i.LastName;

                        coBx_name.Items.Add(infos);
                    }
                }

                else
                {
                    string message_no = "Das Löschen wurde abgebrochen.";
                    string caption_no = "Löschen abbrechen";

                    MessageBox.Show(message_no, caption_no);
                }
            }

            catch (ArgumentNullException)
            {
                Message();
            }

            catch (Exception)
            {
                Message();
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            foreach (Worker i in ListWorker)    //puts the information in the combobox when the form loads
            {
                infos = Convert.ToString(i.IDNumber) + ". " + i.FirstName + " " + i.LastName;

                coBx_name.Items.Add(infos);
            }
        }

        private void coBx_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameandnumber = coBx_name.SelectedItem.ToString();
        }

        #endregion

        #region methods
        public static void EditMessage()
        {
            string message = "Der veränderte Wert wurde erfolgreich gespeichert!";
            string caption = "Wert verändern";
            MessageBox.Show(message, caption);
        }

        public static void DeleteMessage()
        {
            string message = "Der Arbeiter bzw. Angestellte wurde erfolgreich gelöscht!";
            string caption = "Arbeiter bzw. Angestellten löschen";
            MessageBox.Show(message, caption);
        }


        public static void Message()
        {
            string caption = "Achtung!";
            string message = "Anscheinend wurde ein Fehler gemacht. \nBitte versuchen Sie es erneut.";

            MessageBox.Show(message, caption);

        }

        public static void DeleteWorker(List<Worker> ListWorker, int number, string firstname, string lastname)
        {
            int PlaceOfWorker = 0;

            foreach (Worker i in ListWorker)    //deletes the worker in ListWorker
            {
                if (i.IDNumber == number && i.FirstName == firstname && i.LastName == lastname) //checks if the selected worker matches with any saved data
                {
                    ListWorker.RemoveAt(PlaceOfWorker);

                    return;
                }

                else //if the current worker doesn't match with the selected information, the int PlaceOfWorker gets higher
                {
                    PlaceOfWorker++;
                }
            }
        }

        public static void DeleteHours(List<Worker> ListHours, int number, string firstname, string lastname)
        {
            int PlaceOfHours = 0;

            foreach (Worker i in ListHours) //deletes the worker in ListHours
            {
                if (i.IDNumber == number && i.FirstName == firstname && i.LastName == lastname) //checks if the selected worker matches with any saved data
                {
                    ListHours.RemoveAt(PlaceOfHours);
                    return;
                }

                else //if the current worker doesn't match with the selected information, the int PlaceOfWorker gets higher
                {
                    PlaceOfHours++;
                }
            }

        }

        public static void DeleteMissing(List<Worker> ListMissingHours, int number, string firstname, string lastname)
        {
            int PlaceOfMissing = 0;

            foreach (Worker i in ListMissingHours)   //deletes the worker in ListMissingHours
            {
                if (i.IDNumber == number && i.FirstName == firstname && i.LastName == lastname) //checks if the selected worker matches with any saved data
                {
                    ListMissingHours.RemoveAt(PlaceOfMissing);
                    return;
                }

                else //if the current worker doesn't match with the selected information, the int PlaceOfWorker gets higher
                {
                    PlaceOfMissing++;
                }
            }

        }

        public static void LoadWorkerInCoBx() {
        }

        #endregion
    }
}
