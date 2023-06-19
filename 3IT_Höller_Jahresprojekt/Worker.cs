using _3IT_Höller_Jahresprojekt.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3IT_Höller_Jahresprojekt
{
    public class Worker
    {
        #region properties 
        //the properties of the worker class

        public List<Worker> ListWorker = new List<Worker>();

        private string _firstname;


        public string FirstName
        {
            get
            {
                return _firstname;
            }

            set
            {
                _firstname = value;
            }
        }


        private string _lastname;

        public string LastName
        {
            get
            {
                return _lastname;
            }

            set
            {
                _lastname = value;
            }
        }

        private int _idnumber = -1;

        public int IDNumber
        {
            get
            {
                return _idnumber;
            }

            set
            {
                if (value > 0)
                {
                    _idnumber = value;
                }

                else
                {
                    throw new InvalidIDException("Der Wert der ID-Nummer darf nicht kleiner als 0 sein!");
                }
            }
        }

        private string _department;

        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }

        private string _phonenumber;

        public string PhoneNumber
        {
            get
            {
                return _phonenumber;
            }

            set
            {
                _phonenumber = value;
            }
        }

        private string _address;

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        private int _money = -1;

        public int Money
        {
            get
            {
                return _money;
            }

            set
            {
                if (value > 0 && value <= 1000000000)
                {
                    _money = value;
                }


                else
                {
                    throw new InvalidMoneyException("Das Gehalt für einen Monat muss zwischen 0 und 1.000.000.000 Euro betragen!");
                }
            }
        }

        private int _hours = -1;

        public int Hours
        {
            get
            {
                return _hours;
            }

            set
            {
                if (value > 0 && value <= 200)
                {
                    _hours = value;
                }

                else
                {
                    throw new InvalidHoursException("Die Anzahl der maximalen Arbeitsstunden pro Monat muss zwischen 0 und 200 Stunden liegen!");
                }
            }
        }

        private DateTime _start;

        public DateTime Start
        {
            get
            {
                return _start;
            }

            set
            {
                if (value == null)
                {
                    throw new InvalidStartException("Der Startwert darf nicht leer sein!");
                }
                else
                {
                    _start = value;
                }
            }
        }

        private DateTime _end;

        public DateTime End
        {
            get
            {
                return _end;
            }

            set
            {
                if (value == null)
                {
                    throw new InvalidEndException("Der Endwert darf nicht leer sein!");
                }

                else
                {
                    _end = value;
                }
            }
        }

        private DateTime _date;

        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                if (value == null)
                {
                    throw new InvalidDateException("Das Datum darf nicht leer sein!");
                }

                else
                {
                    _date = value;
                }
            }
        }
     

        public string _causeofmissing;

        public string CauseOfMissing
        {
            get
            {
                return _causeofmissing;
            }

            set
            {
                _causeofmissing = value;
            }
        }

        #endregion 

        #region constructors 
        //the constructors of the worker class
        public Worker() { }

        public Worker(string FirstName, string LastName, int Number, string Department, int Money, int Hours)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IDNumber = Number;
            this.Department = Department;
            this.Money = Money;
            this.Hours = Hours;
        }

        public Worker(string FirstName, string LastName, int Number, string Department, string PhoneNumber, string Address, int Money, int Hours)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IDNumber = Number;
            this.Department = Department;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Money = Money;
            this.Hours = Hours;
        }

        public Worker(string FirstName, string LastName, int Number, string Department, string PhoneNumber, string Address, int Money, int Hours, DateTime Start, DateTime End, DateTime Date)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IDNumber = Number;
            this.Department = Department;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Money = Money;
            this.Hours = Hours;
            this.Start = Start;
            this.End = End;
            this.Date = Date;
        }

        public Worker(string FirstName, string LastName, int Number, DateTime Start, DateTime End, DateTime Date)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IDNumber = Number;
            this.Start = Start;
            this.End = End;
            this.Date = Date;
        }

        public Worker(string FirstName, string LastName, int Number, DateTime Start, DateTime End, DateTime Date, string CauseOfMissing)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IDNumber = Number;
            this.Start = Start;
            this.End = End;
            this.Date = Date;
            this.CauseOfMissing = CauseOfMissing;
        }

        #endregion

    }
}
