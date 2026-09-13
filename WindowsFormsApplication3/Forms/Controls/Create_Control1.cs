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
    public partial class Create_Control1 : UserControl
    {
        UserManager usermanager = new UserManager();
        public Create_Control1()
        {
            InitializeComponent();
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            //CRUD crud = new CRUD();
            Error error = new Error(Error.AlarmList.SUCCESS);
            Error error1 = new Error(Error.AlarmList.WRONG_ID_PW);
            Error error2 = new Error(Error.AlarmList.Error);
            int result = usermanager.Create_Account(Create_ID.Text, Create_PW.Text);
            if (result == 0)
            {
                error2.Show();
            }
            else if (result == 1)
            {
                error1.Show();
            }
            else if (result == 2)
            {
                error.Show();
            }
        }

        private void Create_Control1_Load(object sender, EventArgs e)
        {

        }

        private void Create_PW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
