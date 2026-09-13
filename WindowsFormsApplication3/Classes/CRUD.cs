using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.Classes;
using System.IO;
using WindowsFormsApplication3.Forms;
using WindowsFormsApplication3;

namespace WindowsFormsApplication3.Classes
{
    public class CRUD
    {
        User user = new User();


        public bool Read(string ID , string PW)  
        {
            bool rtn = false;
            int check = 0;
            using (StreamReader reader = new StreamReader("User_Data.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line == ID + "|" + PW)
                    {
                        check = 1;
                        break;
                    }
                    line = reader.ReadLine();
                }
                if (check == 1)
                {
                    rtn = true;
                }
                else 
                {
                }
            }
            return rtn;
        }

        public int Create(string ID, string PW) 
        {

            user.ID = ID;
            user.PW = PW;
            int is_there_error = 0;

            if (ID == null || PW == null || ID == "" || PW == "")
            {
                return 0;
            }
            else
            {
                using (StreamReader reader = new StreamReader("User_Data.txt"))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        string[] line2 = line.Split('|');

                        if (line2.Length == 2)
                        {
                            if (line2[0] == user.ID)
                            {
                                return 1;
                            }
                        }

                        line = reader.ReadLine();
                    }

                    //string line = reader.ReadLine();
                    //string[] line2 = new string[2];
                    //line2 = line.Split('|');
                    //while (line != null)
                    //{
                    //    if (line2[0] == user.ID || line2[1] == user.PW) // 이미 ID,PW 정보가 있음.
                    //    {
                    //        return 1;
                    //    }
                    //    line = reader.ReadLine();
                    //    if (line != null)
                    //    {
                    //        line2 = line.Split('|');
                    //    }
                    //}
                }
                using (StreamWriter writer = new StreamWriter("User_Data.txt", true))
                {
                    if (is_there_error == 0)
                    {
                        writer.WriteLine(user.ID + "|" + user.PW);
                    }
                }
                return 2;
            }
        }

        public bool Delete(string ID, string PW)
        {
            int no_id = 0;
            using (StreamWriter writer = new StreamWriter("User_Data2.txt",true))
            using (StreamReader reader = new StreamReader("User_Data.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line != ID + "|" + PW)
                    {
                        writer.WriteLine(line);
                    }
                    else
                    {
                        no_id = 1; // 지울 정보가 있는 상황
                    }
                    line = reader.ReadLine();
                }
            }
            if (no_id == 0)
            {
                File.Delete("User_Data2.txt");
                return false;
            }
            else
            {
                File.Delete("User_Data.txt");
                File.Move("User_Data2.txt", "User_Data.txt");
                File.Delete("User_Data2.txt");
                return true;
            }
        }

        public bool Update(string ID, string Old_PW, string New_PW)
        {
            int check = 0;

            using (StreamReader reader = new StreamReader("User_Data.txt"))
            using (StreamWriter writer = new StreamWriter("User_Data3.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] userData = line.Split('|');

                    if (userData.Length == 2)
                    {
                        if (userData[0] == ID && userData[1] == Old_PW)
                        {
                            writer.WriteLine(userData[0] + "|" + New_PW);
                            check = 1;
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            if (check == 0)
            {
                File.Delete("User_Data3.txt");
                return false;
            }

            File.Delete("User_Data.txt");
            File.Move("User_Data3.txt", "User_Data.txt");

            return true;
        }
    }
}
