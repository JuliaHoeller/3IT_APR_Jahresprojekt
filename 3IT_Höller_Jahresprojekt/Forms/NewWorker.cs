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
    public partial class NewWorker : Form
    {
        public List<Worker> ListWorker = new List<Worker>();

        public NewWorker(List<Worker> ListWorker)
        {
            InitializeComponent();
            this.ListWorker = ListWorker;
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
                CreateNewWorker();

                txBx_firstname.Clear();
                txBx_lastname.Clear();
                txBx_department.Clear();
                txBx_phoneNumber.Clear();
                txBx_address.Clear();
                txBx_money.Clear();
                txBx_hours.Clear();
            }
            catch (InvalidIDException)
            {
                string caption = "Achtung!";
                string message = "Der Wert der ID-Nummer darf nicht kleiner als 0 sein! \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (InvalidMoneyException)
            {
                string caption = "Achtung!";
                string message = "Das Gehalt für einen Monat muss zwischen 0 und 1.000.000.000 Euro betragen! \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (InvalidHoursException)
            {
                string caption = "Achtung!";
                string message = "Die Anzahl der maximalen Arbeitsstunden pro Monat muss zwischen 0 und 200 Stunden liegen! \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (FormatException)
            {
                string caption = "Achtung!";
                string message = "Eine Eingabe wurde im falschen Format getätigt. \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

            catch (Exception)
            {
                string caption = "Achtung!";
                string message = "Anscheinend wurde ein Fehler gemacht. \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);

            }
        }

        #endregion

        #region methods

        private void CreateNewWorker()
        {
            int i = 1;

            Worker NewWorker = new Worker(); //creates a new worker

            NewWorker.FirstName = txBx_firstname.Text;
            NewWorker.LastName = txBx_lastname.Text;
            NewWorker.Department = txBx_department.Text;
            NewWorker.PhoneNumber = txBx_phoneNumber.Text;
            NewWorker.Address = txBx_address.Text;
            NewWorker.Money = int.Parse(txBx_money.Text);
            NewWorker.Hours = int.Parse(txBx_hours.Text);

            string message = "Ihre Eingabe wurde gespeichert!";
            string caption = "Eingaben speichern";

            MessageBox.Show(message, caption);

            foreach(Worker w in ListWorker)
            {
                i++;
            }

            NewWorker.IDNumber = i;

            ListWorker.Add(NewWorker); //adds the new worker to a list

        }
        #endregion

    }
}

