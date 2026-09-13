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
    public partial class Update_Control1 : UserControl
    {
        UserManager usermanager = new UserManager();
        public Update_Control1()
        {
            InitializeComponent();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            Error error = new Error(Error.AlarmList.SUCCESS);
            Error error1 = new Error(Error.AlarmList.Error);
            //CRUD crud = new CRUD();
            if (usermanager.UpdateAccount(Update_New_ID.Text, Update_Old_PW.Text,Update_New_PW.Text))
            {
                error.Show();
            }
            else error1.Show();
        }

        private void Update_Control1_Load(object sender, EventArgs e)
        {

        }

        private void Update_Old_PW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
