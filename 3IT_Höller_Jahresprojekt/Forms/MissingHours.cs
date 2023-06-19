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
    public partial class MissingHours : Form
    {
        #region properties
        public List<Worker> ListMissingHours = new List<Worker>();

        public string NameAndNumber;
        public int Number;
        #endregion

        public MissingHours(List<Worker> ListMissingHours, string NameAndNumber)
        {

            try
            {
                InitializeComponent();

                this.NameAndNumber = NameAndNumber;
                this.ListMissingHours = ListMissingHours;

                liBx_name.Items.Add(NameAndNumber);

                ShowMissingHours();
            }

            catch (ArgumentNullException)
            {
                string caption = "Achtung!";
                string message = "Es muss ein Arbeiter bzw. Angestellter ausgewählt sein. \nBitte versuchen Sie es erneut!";
                MessageBox.Show(message, caption);

            }

            catch (Exception)
            {
                string caption = "Achtung!";
                string message = "Anscheinend wurde ein Fehler gemacht. \nBitte versuchen Sie es erneut!";
                MessageBox.Show(message, caption);

            }
        }

        #region buttons
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region methods
        private void ShowMissingHours()
        {

            string[] Split = NameAndNumber.Split('.'); //splits the selected item to get the ID-number

            foreach (Worker i in ListMissingHours)
            {
                if (i.IDNumber == Convert.ToInt32(Split[0])) //checks if the selected Worker and their ID matches with any saved Data 
                {
                    liBx_missingHours.Items.Add("Der Arbeiter oder die Arbeiterin bzw. der Angestellte oder die Angestellte fehlte am " + i.Date.Day + "." + i.Date.Month + ". " + i.Date.Year);
                    liBx_missingHours.Items.Add("zwischen " + i.Start.Hour + ":" + i.Start.Minute + " und " + i.End.Hour + ":" + i.End.Minute + ".");
                    liBx_missingHours.Items.Add("Der Grund für die Abwesenheit war: " + i.CauseOfMissing + ".");
                    liBx_missingHours.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    liBx_missingHours.Items.Add(" ");
                }
            }
        }
        #endregion

    }
}
