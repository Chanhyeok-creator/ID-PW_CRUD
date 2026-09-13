using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.Classes;


namespace WindowsFormsApplication3.Classes
{
  

    public class User
    {
        private string id;
        private string pw;
        private string old_pw;

        public string ID
        {
            get
            {
                return id;
            }
            set 
            {
                id = value;
            }
        }
        public string PW
        {
            get
            {
                return pw;
            }
            set
            {
                pw = value;
            }
        }
        public string OLD_PW
        {
            get
            {
                return old_pw;
            }
            set
            {
                old_pw = value;
            }
        }
    }
}
