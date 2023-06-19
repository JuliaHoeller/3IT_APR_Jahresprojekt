using StudioManager;

namespace _3IT_Höller_Jahresprojekt
{
    public partial class Login : Form
    {
        #region properties
        public string username = "";
        public string password = "";

        public User activeUser = new User();

        public List<User> ListUser = new List<User>();

        #endregion
        public Login()
        {
            InitializeComponent();

            txbx_password.PasswordChar = '*';
        }

        #region buttons
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                username = txbx_login.Text.ToString(); //gets the entered username and password
                password= txbx_password.Text.ToString();

                if (username.Equals("")) //checks if one textbox is empty
                {
                    MessageBox.Show("Bitte geben Sie einen Benutzernamen ein.", "Achtung");
                }

                else if (password.Equals(""))
                {
                    MessageBox.Show("Bitte geben Sie ein Passwort ein.", "Achtung");
                }

                else
                {
                    foreach(User user in ListUser) //searches for the user in ListUser and checks if the data matches
                    {
                        bool checkusername = user.Name.Equals(username);
                        bool checkpassword = BCrypt.CheckPassword(password, user.Password);

                        if (checkusername == true && checkpassword == true)
                        {
                            activeUser = user;

                            txbx_login.Clear();
                            txbx_password.Clear();


                            this.Hide();
                            Main MainForm = new Main(activeUser, ListUser);
                            MainForm.ShowDialog();
                            return;
                        }

                        else
                        {

                        }
                    }

                    MessageBox.Show("Der Benutzername oder das Passwort ist falsch.", "Achtung!");

                }
 
            }

            catch(Exception ex)
            {
                MessageBox.Show("Anscheinend ist ein Fehler passiert.\nBitte versuchen Sie es erneut.", "Achtung");

                MessageBox.Show(ex.ToString());
            }
        }

        private void Login_Load(object sender, EventArgs e) //checks if the database and tables exist and creates them if necessary 
        {
            SqlCommands.ChecksIfDatabaseExists();
            SqlCommands.CheckIfTableExists();

            SqlCommands.LoadUsers(ListUser);
        }

        private void chbx_showPassword_CheckedChanged(object sender, EventArgs e) //when the user clicks the checkbox, it will show them the entered password
        {
            if (chbx_showPassword.Checked == true)
            {
                txbx_password.PasswordChar = '\0';
            }

            else if(chbx_showPassword.Checked == false)
            {
                txbx_password.PasswordChar = '*';
            }
            
        }

        #endregion 
    }
}