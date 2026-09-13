using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.Classes;
using WindowsFormsApplication3.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        UserManager usermanager = new UserManager();
        public Form1()
        {
            
            InitializeComponent();

            string ID = ID_Box.Text;
            string PW = PW_Box.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, pw;
            id = ID_Box.Text;
            pw = PW_Box.Text;
            //CRUD crud = new CRUD();
          
            if (usermanager.LogIn(id, pw))
            {
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                MessageBox.Show("ID,PW를 다시 확인하십시오");
            }
        }
    }
}