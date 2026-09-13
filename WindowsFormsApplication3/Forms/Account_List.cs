using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication3.Forms
{
    public partial class Account_List : Form
    {
        public Account_List()
        {
            InitializeComponent();

            LoadAccountList();
        }

        private void LoadAccountList()
        {
            Table.ColumnCount = 2; // DataGridView에 열 2개 생성

            Table.Columns[0].Name = "아이디";  // 열 이름 설정
            Table.Columns[1].Name = "비밀번호";

            Table.AllowUserToAddRows = false;// 사용자가 직접 새로운 행을 추가하지 못하도록 설정

            Table.ReadOnly = true; 

            try
            {
                using (StreamReader reader = new StreamReader("User_Data.txt"))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');

                        // 데이터가 정확히 2개로 나뉘었을 경우
                        if (data.Length == 2)
                        {
                            Table.Rows.Add(data[0], data[1]);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(
                    "User_Data.txt 파일을 찾을 수 없습니다.",
                    "파일 오류",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "계정 목록을 불러오는 중 오류가 발생했습니다.\n\n" + ex.Message,
                    "오류",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

