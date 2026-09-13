namespace WindowsFormsApplication3.Controls
{
    partial class Update_Control1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Update_Old_PW = new System.Windows.Forms.TextBox();
            this.Update_New_PW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_New_ID = new System.Windows.Forms.TextBox();
            this.Label_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Update";
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(516, 321);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(107, 34);
            this.Update_Button.TabIndex = 4;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Update_Old_PW
            // 
            this.Update_Old_PW.Location = new System.Drawing.Point(244, 238);
            this.Update_Old_PW.Margin = new System.Windows.Forms.Padding(4);
            this.Update_Old_PW.Name = "Update_Old_PW";
            this.Update_Old_PW.Size = new System.Drawing.Size(141, 28);
            this.Update_Old_PW.TabIndex = 1;
            this.Update_Old_PW.TextChanged += new System.EventHandler(this.Update_Old_PW_TextChanged);
            // 
            // Update_New_PW
            // 
            this.Update_New_PW.Location = new System.Drawing.Point(244, 408);
            this.Update_New_PW.Margin = new System.Windows.Forms.Padding(4);
            this.Update_New_PW.Name = "Update_New_PW";
            this.Update_New_PW.Size = new System.Drawing.Size(141, 28);
            this.Update_New_PW.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Old PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "New PW";
            // 
            // Update_New_ID
            // 
            this.Update_New_ID.Location = new System.Drawing.Point(244, 321);
            this.Update_New_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Update_New_ID.Name = "Update_New_ID";
            this.Update_New_ID.Size = new System.Drawing.Size(141, 28);
            this.Update_New_ID.TabIndex = 2;
            // 
            // Label_2
            // 
            this.Label_2.AutoSize = true;
            this.Label_2.Location = new System.Drawing.Point(127, 326);
            this.Label_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_2.Name = "Label_2";
            this.Label_2.Size = new System.Drawing.Size(64, 18);
            this.Label_2.TabIndex = 21;
            this.Label_2.Text = "New ID";
            // 
            // Update_Control1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_2);
            this.Controls.Add(this.Update_New_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Update_Old_PW);
            this.Controls.Add(this.Update_New_PW);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Update_Control1";
            this.Size = new System.Drawing.Size(833, 573);
            this.Load += new System.EventHandler(this.Update_Control1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.TextBox Update_Old_PW;
        private System.Windows.Forms.TextBox Update_New_PW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Update_New_ID;
        private System.Windows.Forms.Label Label_2;
    }
}
