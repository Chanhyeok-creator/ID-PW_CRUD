using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication3.Classes
{
    class UserManager
    {
        CRUD crud = new CRUD();

        public bool LogIn(string ID, string PW)
        {
            return crud.Read(ID, PW);

        }

        public int Create_Account(string ID, string PW)
        {
            return crud.Create(ID, PW);
        }


        public bool UpdateAccount(string ID, string Old_PW, string New_PW)
        {
            return crud.Update(ID, Old_PW, New_PW);
        }


        public bool Delete_Account(string ID, string PW)
        {
            return crud.Delete(ID, PW);
        }
    }
}
