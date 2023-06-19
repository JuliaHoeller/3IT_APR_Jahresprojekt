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
    public partial class NewUser : Form
    {
        #region properties
        List<User> ListNewUser = new List<User>();
        List<User> ListUser = new List<User>();
        #endregion

        public NewUser(List<User> ListNewUser, List<User> ListUser)
        {
            InitializeComponent();
            this.ListNewUser = ListNewUser;
            this.ListUser = ListUser;
        }

        #region buttons

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                CreateNewUser(ListNewUser, ListUser);

                txbx_username.Clear();
                txbx_password.Clear();
                txbx_email.Clear();

                string caption = "User erstellen";
                string message = "Der User wurde erfolgreich erstellt";

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

        #region methodes 
        private void CreateNewUser(List<User> ListNewUser, List<User> ListUser)
        {
            try
            {

                int i = 1;

                User NewUser = new User();  //creates a new user

                NewUser.Name = txbx_username.Text;
                NewUser.Password = txbx_password.Text;
                NewUser.Email = txbx_email.Text;

                string usertype = Convert.ToString(cobx_usertypes.SelectedItem);

                if (usertype.Equals("Admistrator"))     //converts the selected usertype into booleans 
                {
                    NewUser.Administrator = true;
                    NewUser.HeadUser = true;
                    NewUser.NormalUser = true;
                }

                if (usertype.Equals("Head-User"))
                {
                    NewUser.Administrator = false;
                    NewUser.HeadUser = true;
                    NewUser.NormalUser = true;
                }

                if (usertype.Equals("User"))
                {
                    NewUser.Administrator = false;
                    NewUser.HeadUser = false;
                    NewUser.NormalUser = true;
                }

                foreach (User user in ListNewUser)  //gives the new user a temporary id until the user gets saved into the database
                {
                    i++;
                    i += ListUser.Count();

                }

                NewUser.UserID = i;

                ListNewUser.Add(NewUser);   //the new user gets added into the list 
            }

            catch(Exception)
            {
                string caption = "Achtung!";
                string message = "Anscheinend wurde ein Fehler gemacht. \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }
        }
        #endregion 

    }
}
