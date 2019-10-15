namespace BlogExport
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Uid = new System.Windows.Forms.TextBox();
            this.Tb_Pwd = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // Tb_Uid
            // 
            this.Tb_Uid.Location = new System.Drawing.Point(105, 20);
            this.Tb_Uid.Name = "Tb_Uid";
            this.Tb_Uid.Size = new System.Drawing.Size(143, 21);
            this.Tb_Uid.TabIndex = 2;
            this.Tb_Uid.Text = "MyUnity";
            // 
            // Tb_Pwd
            // 
            this.Tb_Pwd.Location = new System.Drawing.Point(105, 49);
            this.Tb_Pwd.Name = "Tb_Pwd";
            this.Tb_Pwd.Size = new System.Drawing.Size(143, 21);
            this.Tb_Pwd.TabIndex = 3;
            this.Tb_Pwd.Text = "Lgs@qq.com0";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(60, 91);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(188, 23);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "登陆";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 126);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Tb_Pwd);
            this.Controls.Add(this.Tb_Uid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Uid;
        private System.Windows.Forms.TextBox Tb_Pwd;
        private System.Windows.Forms.Button Btn_Login;
    }
}