
namespace Project_Patent
{
    partial class Form_Login
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
            this.btnPWCheck = new System.Windows.Forms.Button();
            this.btnSIgnup = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPWD = new Project_Patent.PlaceholderTextBox();
            this.txtID = new Project_Patent.PlaceholderTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsbLogin = new System.Windows.Forms.ListBox();
            this.btnLogin2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "로 그 인";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPWCheck
            // 
            this.btnPWCheck.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPWCheck.Location = new System.Drawing.Point(179, 65);
            this.btnPWCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPWCheck.Name = "btnPWCheck";
            this.btnPWCheck.Size = new System.Drawing.Size(88, 25);
            this.btnPWCheck.TabIndex = 5;
            this.btnPWCheck.Text = "비번 찾기";
            this.btnPWCheck.UseVisualStyleBackColor = true;
            this.btnPWCheck.Click += new System.EventHandler(this.btnPWCheck_Click);
            // 
            // btnSIgnup
            // 
            this.btnSIgnup.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSIgnup.Location = new System.Drawing.Point(4, 65);
            this.btnSIgnup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSIgnup.Name = "btnSIgnup";
            this.btnSIgnup.Size = new System.Drawing.Size(169, 25);
            this.btnSIgnup.TabIndex = 3;
            this.btnSIgnup.Text = "회원가입";
            this.btnSIgnup.UseVisualStyleBackColor = true;
            this.btnSIgnup.Click += new System.EventHandler(this.btnSIgnup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(179, 6);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 53);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPWD);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnPWCheck);
            this.panel1.Controls.Add(this.btnSIgnup);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(14, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(4, 33);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.PlaceholderText = "비밀번호";
            this.txtPWD.Size = new System.Drawing.Size(169, 27);
            this.txtPWD.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(4, 6);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "아이디";
            this.txtID.Size = new System.Drawing.Size(169, 27);
            this.txtID.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsbLogin);
            this.panel2.Controls.Add(this.btnLogin2);
            this.panel2.Location = new System.Drawing.Point(335, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 100);
            this.panel2.TabIndex = 1;
            // 
            // lsbLogin
            // 
            this.lsbLogin.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lsbLogin.FormattingEnabled = true;
            this.lsbLogin.ItemHeight = 17;
            this.lsbLogin.Location = new System.Drawing.Point(4, 4);
            this.lsbLogin.Name = "lsbLogin";
            this.lsbLogin.Size = new System.Drawing.Size(194, 89);
            this.lsbLogin.TabIndex = 10;
            // 
            // btnLogin2
            // 
            this.btnLogin2.Location = new System.Drawing.Point(204, 4);
            this.btnLogin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.Size = new System.Drawing.Size(63, 89);
            this.btnLogin2.TabIndex = 9;
            this.btnLogin2.Text = "Login";
            this.btnLogin2.UseVisualStyleBackColor = true;
            this.btnLogin2.Click += new System.EventHandler(this.btnLogin2_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(302, 171);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "환영합니다.";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPWCheck;
        private System.Windows.Forms.Button btnSIgnup;
        private System.Windows.Forms.Button btnLogin;
        private PlaceholderTextBox txtID;
        private PlaceholderTextBox txtPWD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lsbLogin;
        private System.Windows.Forms.Button btnLogin2;
    }
}