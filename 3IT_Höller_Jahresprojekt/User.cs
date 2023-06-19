using _3IT_Höller_Jahresprojekt.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3IT_Höller_Jahresprojekt
{
    public class User
    {
        #region properties
        //the properties of the user class

        private int _userId;

        public int UserID 
        { 
            get 
            { 
                return _userId; 
            } 
            
            set 
            {
                if (value > 0)
                {
                    _userId = value;
                }

                else
                {
                    throw new InvalidIDException("Der Wert der ID-Nummer darf nicht kleiner als 0 sein!");
                }
            } 
        }


        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        private string _Password;

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password= value;
            }
        }

        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
                
        }

        private bool _administrator;

        public bool Administrator
        {
            get 
            { 
                return _administrator; 
            }

            set
            {
                _administrator = value;
            }
        }

        private bool _headuser;

        public bool HeadUser
        {
            get
            {
                return _headuser;
            }

            set
            {
                _headuser = value;
            }
        }

        private bool _normaluser;

        public bool NormalUser
        {
            get
            {
                return _normaluser;
            }

            set
            {
                _normaluser = value;
            }
        }


        #endregion

        #region constructors 
        //the constructors of the user class
        public User() { }

        public User(string name, string password, string email, bool administrator, bool headuser, bool normaluser)
        {
            this.Name = name;
            this.Password = password;
            this.Email= email;
            this.Administrator = administrator;
            this.HeadUser = headuser;
            this.NormalUser = normaluser;
        }
        #endregion
    }
}
