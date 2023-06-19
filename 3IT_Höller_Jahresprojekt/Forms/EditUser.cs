using Microsoft.VisualBasic.ApplicationServices;
using StudioManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _3IT_Höller_Jahresprojekt
{
    public partial class EditUser : Form
    {
        #region properties
        List<User> users = new List<User>();
        List<User> newUsers = new List<User>();

        bool checkusername = false;
        bool checkpassword = false;
        bool changeControl = false;
        #endregion

        public EditUser(List<User> users, List<User> newUsers)
        {
            InitializeComponent();
            this.users = users;
            this.newUsers = newUsers;
        }

        #region buttons
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            foreach (User u in users)   //loads all the old users into the combobox for the user to select
            {
                coBx_username.Items.Add(u.UserID + ". " + u.Name);
            }

            int ID = users.Count() + 1;

            foreach (User v in newUsers)     //loads all the new users into the combobox and gives them a nuber 
            {
                coBx_username.Items.Add(ID + ". " + v.Name);
                ID++;
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {

                string nameAndNumber = coBx_username.SelectedItem.ToString();
                string enteredPassword = txbx_password.Text;
                string change = coBx_change.SelectedItem.ToString();


                string[] FirstSplit = nameAndNumber.Split('.'); //splits the selected item to get the number and username
                int number = Convert.ToInt32(FirstSplit[0]);
                string temp = FirstSplit[1];

                string[] SecondSplit = temp.Split(" "); //splits the unsername because there is a space at the beginning 
                string name = SecondSplit[1];


                foreach (User u in users)
                {
                    checkusername = u.Name.Equals(name);
                    checkpassword = BCrypt.CheckPassword(enteredPassword, u.Password);


                    if (checkusername == true && checkpassword == true)     //checks if the username and the password match with any old user 
                    {
                        if (change == "Benutzername")
                        {
                            u.Name = Convert.ToString(txBx_new.Text);

                            ShowMessage();
                            changeControl = true;

                            return;
                        }

                        else if (change == "Passwort")
                        {
                            string salt;
                            string encryptedpassword;

                            salt = BCrypt.GenerateSalt();

                            encryptedpassword = BCrypt.HashPassword(Convert.ToString(txBx_new.Text), salt);     //encryptes the new password

                            u.Password = encryptedpassword;

                            ShowMessage();
                            changeControl = true;

                            return;

                        }

                        else if (change == "E - Mail")
                        {
                            u.Name = Convert.ToString(txBx_new.Text);

                            ShowMessage();
                            changeControl = true;

                            return;
                        }

                    }

                }
                foreach (User v in newUsers)
                {
                    checkusername = v.Name.Equals(name);
                    checkpassword = v.Password.Equals(enteredPassword);

                    if (checkusername == true && checkpassword == true) //checks if the username and the password match with any new user 
                    {
                        if (change == "Benutzername")
                        {
                            v.Name = Convert.ToString(txBx_new.Text);

                            ShowMessage();
                            changeControl = true;

                            return;
                        }

                        else if (change == "Passwort")
                        {
                            v.Password = Convert.ToString(txBx_new.Text);

                            ShowMessage();
                            changeControl = true;

                            return;
                        }

                        else if (change == "E - Mail")
                        {
                            v.Email = Convert.ToString(txBx_new.Text);

                            ShowMessage();
                            changeControl = true;

                            return;
                        }
                    }

                }

                MessageBox.Show("Das Passwort stimmt nicht mit dem Benutzernamen zusammen!", "Fehler");

            }

            catch (Exception)
            {
                string caption = "Achtung!";
                string message = "Anscheinend wurde ein Fehler gemacht. \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }

        }

        private static void ShowMessage()
        {
            MessageBox.Show("Der Benutzer wurde erfolgreich verändert!", "Ändern des Benutzers");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string nameAndNumber = coBx_username.SelectedItem.ToString();
                string password = Convert.ToString(txbx_password.Text);

                string[] FirstSplit = nameAndNumber.Split('.'); //splits the selected item to get the number and name
                string temp = FirstSplit[1];

                string[] SecondSplit = temp.Split(" "); //splits a second time because there is a space at the beginning
                string name = SecondSplit[1];

                string message = "Soll der User wirklich gelöscht werden?";    //asks the user if the user should really be deleted
                string caption = "User löschen";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes) //deletes the user or doesn't delete the user - depending on the users choice
                {

                    int PlaceOfUser = 0;

                    foreach (User u in users)
                    {
                        if (u.Name == name && BCrypt.CheckPassword(password, u.Password))
                        {
                            users.RemoveAt(PlaceOfUser);

                            MessageBox.Show("Der User wurde gelöscht", "User löschen");

                            return;
                        }

                        else
                        {
                            PlaceOfUser++;
                        }
                    }

                    PlaceOfUser = 0;

                    foreach (User v in newUsers)
                    {
                        if (v.Name == name && v.Password == password)
                        {
                            users.RemoveAt(PlaceOfUser);

                            MessageBox.Show("Der User wurde gelöscht", "User löschen");

                            return;
                        }

                        else
                        {
                            PlaceOfUser++;
                        }

                       
                    }

                    MessageBox.Show("Der User konnte nicht gelöscht werden!\nDas Passwort fehlt oder ist falsch.", "Fehler");
                }
            }

            catch (Exception)
            {
                string caption = "Achtung!";
                string message = "Anscheinend wurde ein Fehler gemacht. \nBitte versuchen Sie es erneut.";

                MessageBox.Show(message, caption);
            }
        }

        private void chBx_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chBx_showPassword.Checked == true) //shows the password 
            {
                txbx_password.PasswordChar = '\0';
            }

            else if (chBx_showPassword.Checked == false)
            {
                txbx_password.PasswordChar = '*';
            }
        }

        #endregion
    }
}

