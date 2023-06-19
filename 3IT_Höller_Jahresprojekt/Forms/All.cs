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
    public partial class All : Form
    {
        #region properties
        List<Worker> ListWorker = new List<Worker>();
        List<Worker> ListHours = new List<Worker>();
        List<Worker> ListMissingHours = new List<Worker>();
        int money;

        string infos;
        string name;

        #endregion

        public All(List<Worker> ListWorker, List<Worker> ListHours, List<Worker> ListMissingHours, int money)
        {
            InitializeComponent();

            this.ListWorker = ListWorker;
            this.ListHours = ListHours;
            this.ListMissingHours = ListMissingHours;
            this.money = money;

        }

        #region buttons
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                name = coBx_name.SelectedItem.ToString();   //gets the selected item

                liBx_all.Items.Clear();

                string[] Split = name.Split('.');   //splits the selected item to get the ID-number

                foreach (Worker i in ListHours)
                {
                    if (i.IDNumber == Convert.ToInt32(Split[0]))    //checks if the selected Worker and their ID matches with any saved Data 
                    {
                        int Hour = i.End.Hour - i.Start.Hour;   //calculates the earned money
                        int Money = Hour * money;

                        liBx_all.Items.Add("Am " + i.Date.Day + ". " + i.Date.Month + ". " + i.Date.Year + " hat der Mitarbeiter " + Hour + " Stunden gearbeitet und somit " + Money + " Euro erarbeitet.");
                        liBx_all.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                        liBx_all.Items.Add(" ");
                    }
                }

                foreach (Worker i in ListMissingHours)  //checks if the selected Worker and their ID matches with any saved Data 
                {
                    if (i.IDNumber == Convert.ToInt32(Split[0]))
                    {
                        liBx_all.Items.Add("Der Mitarbeiter fehlte am " + i.Date.Day + "." + i.Date.Month + ". " + i.Date.Year + " zwischen " + i.Start.Hour + ":" + i.Start.Minute + " und " + i.End.Hour + ":" + i.End.Minute + ".");
                        liBx_all.Items.Add("Der Grund für die Abwesenheit war: " + i.CauseOfMissing + ".");
                        liBx_all.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                        liBx_all.Items.Add(" ");
                    }
                }
            }

            catch (NullReferenceException)
            {
                string caption = "Achtung!";
                string message = "Es muss ein Arbeiter bzw. Angestellter ausgewählt sein. \nBitte versuchen Sie es erneut!";
                MessageBox.Show(message, caption);
            }

            catch (Exception)
            {
                string caption = "Achtung!";
                string message = "Anscheinend ist ein Fehler passiert. \nBitte versuchen Sie es erneut!";
                MessageBox.Show(message, caption);
            }
        }

        private void All_Load(object sender, EventArgs e)
        {
            coBx_name.Items.Clear();

            foreach (Worker i in ListWorker)    //loads the workers into the combobox for the user to select
            {
                infos = Convert.ToString(i.IDNumber) + ". " + i.FirstName + " " + i.LastName;

                coBx_name.Items.Add(infos);
            }
        }

        #endregion

    }
}
