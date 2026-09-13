using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.Classes;

namespace WindowsFormsApplication3.Controls
{
    public partial class Delete_Control1 : UserControl
    {
        UserManager usermanager = new UserManager();
        public Delete_Control1()
        {
            InitializeComponent();
        }
        
        private void Create_Button_Click(object sender, EventArgs e)
        {
            //CRUD crud = new CRUD();
            Error error = new Error(Error.AlarmList.SUCCESS);
            Error error1 = new Error(Error.AlarmList.WRONG_ID_PW);
            if (usermanager.Delete_Account(Delete_ID.Text, Delete_PW.Text))
            {
                error.Show();
            }
            else error1.Show();
        }

        private void Create_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_PW_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
