using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    class Pas
    {

        private static string _globalVar = "";
        private static string _globalVar2 = "";
        public static string log
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
        
        public static string password
        {
            get { return _globalVar2; }
            set { _globalVar2 = value; }
        }

        //private string login, pass;
        //public string Login
        //{
        //    get { return login; }
        //    set { login = value; }
        //}
        //public string Pass
        //{
        //    get { return pass; }
        //    set { pass = value; }
        //}

        //public Pas() { }

        //public Pas(string login, string pass)
        //{
        //    this.login = login;
        //    this.pass = pass;
        //}
    }
}
