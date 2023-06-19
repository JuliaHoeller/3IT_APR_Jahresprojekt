using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace _3IT_Höller_Jahresprojekt
{
    public partial class Payment : Form
    {
        #region properties
        public List<Worker> ListHours = new List<Worker>();

        string NameAndNumber;

        int number;
        int money;

        DateTime today = DateTime.Today;

        #endregion


        public Payment(List<Worker> ListHours, string NameAndNumber, int money)
        {
            try
            {
                InitializeComponent();
                this.NameAndNumber = NameAndNumber;
                this.ListHours = ListHours;
                this.money = money;

                liBx_name.Items.Add(NameAndNumber);
            }

            catch (ArgumentNullException)
            {
                Message();
                this.Hide();
            }

            catch (NullReferenceException)
            {
                Message();
                this.Hide();
            }

            catch (Exception)
            {
                string caption = "Achtung!";
                string message = "Anscheinend ist ein Fehler passiert. \nBitte versuchen Sie es erneut!";

                MessageBox.Show(message, caption);
                this.Hide();
            }
        }

        #region buttons
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            libx_payment.Items.Clear();

            ShowMoney();
        }
        #endregion

        #region methods
        private static void Message()
        {
            string caption = "Achtung!";
            string message = "Es muss ein Arbeiter bzw. Angestellter ausgewählt sein. \nBitte versuchen Sie es erneut!";
            MessageBox.Show(message, caption);
        }

        private void ShowMoney()
        {
            string[] Split = NameAndNumber.Split('.');  //splits the selected item to get the ID-number

            number = Convert.ToInt32(Split[0]);

            if (cobx_timespan.Text == "Erarbeitetes Gehalt des heutigen Tages") //shows the payment in a specific range 
            {
                foreach (Worker i in ListHours)
                {
                    if (i.Date.Date == today.Date && i.Date.Month == today.Month && i.Date.Year == today.Year && i.IDNumber == number) //checks if the timerange and the ID-number match with any saved data
                    {
                        int Hour = i.End.Hour - i.Start.Hour;   //calculates the earned money
                        int Money = Hour * money;

                        libx_payment.Items.Add("Am " + i.Date.Day + ". " + i.Date.Month + ". hat der Mitarbeiter " + Hour + " Stunden gearbeitet und somit " + Money + " Euro erarbeitet.");
                        libx_payment.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                }
            }

            else if (cobx_timespan.Text == "Erarbeitetes Gehalt dieses Monats")
            {
                foreach (Worker i in ListHours)
                {
                    if (i.Date.Month == today.Month && i.Date.Year == today.Year && i.IDNumber == number)
                    {
                        int Hour = i.End.Hour - i.Start.Hour;
                        int Money = Hour * money;

                        libx_payment.Items.Add("Am " + i.Date.Day + ". " + i.Date.Month + ". hat der Mitarbeiter " + Hour + " Stunden gearbeitet und somit " + Money + " Euro erarbeitet.");
                        libx_payment.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                }

            }

            else if (cobx_timespan.Text == "Erarbeitetes Gehalt dieses Jahres")
            {
                foreach (Worker i in ListHours)
                {
                    if (i.Date.Year == today.Year && i.IDNumber == number)
                    {
                        int Hour = i.End.Hour - i.Start.Hour;
                        int Money = Hour * money;

                        libx_payment.Items.Add("Am " + i.Date.Day + ". " + i.Date.Month + ". hat der Mitarbeiter " + Hour + " Stunden gearbeitet und somit " + Money + " Euro erarbeitet.");
                        libx_payment.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                }
            }
        }

        #endregion

    }
}
