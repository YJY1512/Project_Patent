
namespace Project_Patent
{
    partial class Form_FInd
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblMN = new System.Windows.Forms.Label();
            this.lblco = new System.Windows.Forms.Label();
            this.btnFine = new System.Windows.Forms.Button();
            this.txtID = new Project_Patent.CustomControl1();
            this.txtName = new Project_Patent.CustomControl1();
            this.txtManagerName = new Project_Patent.CustomControl1();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AllowDrop = true;
            this.lblID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblID.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(15, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 30);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "아이디";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMN
            // 
            this.lblMN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMN.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMN.ForeColor = System.Drawing.Color.Black;
            this.lblMN.Location = new System.Drawing.Point(15, 107);
            this.lblMN.Name = "lblMN";
            this.lblMN.Size = new System.Drawing.Size(100, 30);
            this.lblMN.TabIndex = 13;
            this.lblMN.Text = "담당자 이름";
            this.lblMN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblco
            // 
            this.lblco.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblco.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblco.ForeColor = System.Drawing.Color.Black;
            this.lblco.Location = new System.Drawing.Point(15, 63);
            this.lblco.Name = "lblco";
            this.lblco.Size = new System.Drawing.Size(100, 30);
            this.lblco.TabIndex = 16;
            this.lblco.Text = "회사 이름";
            this.lblco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFine
            // 
            this.btnFine.Location = new System.Drawing.Point(37, 141);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(203, 32);
            this.btnFine.TabIndex = 5;
            this.btnFine.Text = "확인";
            this.btnFine.UseVisualStyleBackColor = true;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(130, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 27);
            this.txtID.TabIndex = 23;
            this.txtID.TextType = Project_Patent.CustomControl1.InputTextType.NNID;
            this.txtID.Title = "아이디";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(130, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 24;
            this.txtName.TextType = Project_Patent.CustomControl1.InputTextType.NNID;
            this.txtName.Title = "름회사이";
            // 
            // txtManagerName
            // 
            this.txtManagerName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtManagerName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtManagerName.Location = new System.Drawing.Point(130, 108);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(125, 27);
            this.txtManagerName.TabIndex = 25;
            this.txtManagerName.TextType = Project_Patent.CustomControl1.InputTextType.NNID;
            this.txtManagerName.Title = "담당자 이름";
            // 
            // Form_FInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 190);
            this.Controls.Add(this.txtManagerName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblMN);
            this.Controls.Add(this.lblco);
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_FInd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "비밀번호 찾기";
            this.Load += new System.EventHandler(this.Form_FInd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMN;
        private System.Windows.Forms.Label lblco;
        private System.Windows.Forms.Button btnFine;
        private CustomControl1 txtID;
        private CustomControl1 txtName;
        private CustomControl1 txtManagerName;
    }
}