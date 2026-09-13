using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Error : Form
    {
        // ----------------------------
        // Form에서 사용하는 변수
        // ----------------------------

        private Button button1;
        private Label labelMessage;

        // 현재 팝업의 종류
        private AlarmList alarmlist;


        // ----------------------------
        // 알람 종류
        // ----------------------------

        public enum AlarmList
        {
            LOGIN,
            ID_PW,
            SUCCESS,
            WRONG_ID_PW,
            Error
        }


        // ----------------------------
        // 기본 생성자
        // ----------------------------

        public Error()
        {
            InitializeComponent();
        }


        // ----------------------------
        // 알람 종류를 전달받는 생성자
        // ----------------------------

        public Error(AlarmList alarm)
        {
            InitializeComponent();

            alarmlist = alarm;

            SetMessage();
        }


        // ----------------------------
        // Form 디자인
        // ----------------------------

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = false;
            this.labelMessage.Location = new System.Drawing.Point(30, 60);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(220, 50);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "메시지";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // Error
            // 
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.button1);
            this.Name = "Error";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "알림";

            this.ResumeLayout(false);
        }


        // ----------------------------
        // 알람 종류에 따라 메시지 설정
        // ----------------------------

        private void SetMessage()
        {
            switch (alarmlist)
            {
                case AlarmList.LOGIN:
                    labelMessage.Text = "로그인에 성공하였습니다.";
                    break;

                case AlarmList.ID_PW:
                    labelMessage.Text = "ID 또는 PW를 입력해주세요.";
                    break;

                case AlarmList.SUCCESS:
                    labelMessage.Text = "성공하였습니다.";
                    break;

                case AlarmList.WRONG_ID_PW:
                    labelMessage.Text = "ID 또는 PW가 올바르지 않습니다.";
                    break;

                case AlarmList.Error:
                    labelMessage.Text = "알 수 없는 오류가 발생했습니다.";
                    break;

                default:
                    labelMessage.Text = "알 수 없는 오류가 발생했습니다.";
                    break;
            }
        }


        // ----------------------------
        // 확인 버튼
        // ----------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}