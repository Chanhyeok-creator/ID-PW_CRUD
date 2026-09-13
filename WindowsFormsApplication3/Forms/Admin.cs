using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.Controls;
using WindowsFormsApplication3.Forms;


namespace WindowsFormsApplication3.Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Control1 create_control = new Create_Control1();
            panel1.Controls.Clear();
            panel1.Controls.Add(create_control);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Control1 update_contorl = new Update_Control1();
            panel1.Controls.Clear();
            panel1.Controls.Add(update_contorl);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Delete_Control1 delete_cotrol = new Delete_Control1();
            panel1.Controls.Clear();
            panel1.Controls.Add(delete_cotrol);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Account_List account_list = new Account_List();
            account_list.Show();
        }
    }
}