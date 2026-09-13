namespace WindowsFormsApplication3.Controls
{
    partial class Create_Control1
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Label();
            this.Create_ID = new System.Windows.Forms.TextBox();
            this.Create_PW = new System.Windows.Forms.TextBox();
            this.Create_control = new System.Windows.Forms.Label();
            this.Create_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "New PW";
            // 
            // Create
            // 
            this.Create.AutoSize = true;
            this.Create.Location = new System.Drawing.Point(97, 173);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(46, 12);
            this.Create.TabIndex = 6;
            this.Create.Text = "New ID";
            // 
            // Create_ID
            // 
            this.Create_ID.Location = new System.Drawing.Point(201, 164);
            this.Create_ID.Name = "Create_ID";
            this.Create_ID.Size = new System.Drawing.Size(100, 21);
            this.Create_ID.TabIndex = 1;
            // 
            // Create_PW
            // 
            this.Create_PW.Location = new System.Drawing.Point(201, 241);
            this.Create_PW.Name = "Create_PW";
            this.Create_PW.Size = new System.Drawing.Size(100, 21);
            this.Create_PW.TabIndex = 2;
            this.Create_PW.TextChanged += new System.EventHandler(this.Create_PW_TextChanged);
            // 
            // Create_control
            // 
            this.Create_control.AutoSize = true;
            this.Create_control.Location = new System.Drawing.Point(189, 67);
            this.Create_control.Name = "Create_control";
            this.Create_control.Size = new System.Drawing.Size(119, 12);
            this.Create_control.TabIndex = 8;
            this.Create_control.Text = "Create new account";
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(416, 203);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(75, 23);
            this.Create_Button.TabIndex = 3;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Create_Control1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.Create_control);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Create_ID);
            this.Controls.Add(this.Create_PW);
            this.Name = "Create_Control1";
            this.Size = new System.Drawing.Size(583, 382);
            this.Load += new System.EventHandler(this.Create_Control1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Create;
        private System.Windows.Forms.TextBox Create_ID;
        private System.Windows.Forms.TextBox Create_PW;
        private System.Windows.Forms.Label Create_control;
        private System.Windows.Forms.Button Create_Button;
    }
}
