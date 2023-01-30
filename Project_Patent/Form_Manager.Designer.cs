
namespace Project_Patent
{
    partial class Form_Manager
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucZipAddr1 = new Project_Patent.ucZipAddr();
            this.txtCompanyName = new Project_Patent.CustomControl1();
            this.txtID = new Project_Patent.CustomControl1();
            this.btn_Signup_Addr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblco = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMansger = new System.Windows.Forms.ComboBox();
            this.txtMangerEmail1 = new Project_Patent.CustomControl1();
            this.txtMangerEmail3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMangerEmail2 = new System.Windows.Forms.ComboBox();
            this.cmbManagerRank = new System.Windows.Forms.ComboBox();
            this.mskManagerPhone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblME = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.ucZipAddr1);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btn_Signup_Addr);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblco);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회사 정보";
            // 
            // ucZipAddr1
            // 
            this.ucZipAddr1.Addr1 = "";
            this.ucZipAddr1.Addr2 = "";
            this.ucZipAddr1.Addr3 = "";
            this.ucZipAddr1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucZipAddr1.Location = new System.Drawing.Point(138, 87);
            this.ucZipAddr1.Margin = new System.Windows.Forms.Padding(5);
            this.ucZipAddr1.Name = "ucZipAddr1";
            this.ucZipAddr1.Size = new System.Drawing.Size(348, 96);
            this.ucZipAddr1.TabIndex = 14;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCompanyName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyName.Location = new System.Drawing.Point(137, 55);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(168, 27);
            this.txtCompanyName.TabIndex = 4;
            this.txtCompanyName.TextType = Project_Patent.CustomControl1.InputTextType.CoName;
            this.txtCompanyName.Title = null;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(137, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 27);
            this.txtID.TabIndex = 0;
            this.txtID.TextType = Project_Patent.CustomControl1.InputTextType.NNID;
            this.txtID.Title = null;
            // 
            // btn_Signup_Addr
            // 
            this.btn_Signup_Addr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Signup_Addr.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Signup_Addr.Location = new System.Drawing.Point(262, 91);
            this.btn_Signup_Addr.Name = "btn_Signup_Addr";
            this.btn_Signup_Addr.Size = new System.Drawing.Size(75, 5);
            this.btn_Signup_Addr.TabIndex = 5;
            this.btn_Signup_Addr.Text = "찾기";
            this.btn_Signup_Addr.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 96);
            this.label8.TabIndex = 13;
            this.label8.Text = "회사 주소";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblco
            // 
            this.lblco.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblco.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblco.ForeColor = System.Drawing.Color.Black;
            this.lblco.Location = new System.Drawing.Point(6, 58);
            this.lblco.Name = "lblco";
            this.lblco.Size = new System.Drawing.Size(125, 23);
            this.lblco.TabIndex = 12;
            this.lblco.Text = "회사 이름";
            this.lblco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AllowDrop = true;
            this.lblID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblID.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(6, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 23);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "아이디";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.cmbMansger);
            this.groupBox2.Controls.Add(this.txtMangerEmail1);
            this.groupBox2.Controls.Add(this.txtMangerEmail3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbMangerEmail2);
            this.groupBox2.Controls.Add(this.cmbManagerRank);
            this.groupBox2.Controls.Add(this.mskManagerPhone);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblMN);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblME);
            this.groupBox2.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "담당자 정보";
            // 
            // cmbMansger
            // 
            this.cmbMansger.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbMansger.FormattingEnabled = true;
            this.cmbMansger.ItemHeight = 16;
            this.cmbMansger.Location = new System.Drawing.Point(137, 28);
            this.cmbMansger.Name = "cmbMansger";
            this.cmbMansger.Size = new System.Drawing.Size(109, 24);
            this.cmbMansger.TabIndex = 13;
            this.cmbMansger.SelectedIndexChanged += new System.EventHandler(this.cmbMansger_SelectedIndexChanged);
            // 
            // txtMangerEmail1
            // 
            this.txtMangerEmail1.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtMangerEmail1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMangerEmail1.Location = new System.Drawing.Point(137, 82);
            this.txtMangerEmail1.Name = "txtMangerEmail1";
            this.txtMangerEmail1.Size = new System.Drawing.Size(107, 27);
            this.txtMangerEmail1.TabIndex = 3;
            this.txtMangerEmail1.TextType = Project_Patent.CustomControl1.InputTextType.Email;
            this.txtMangerEmail1.Title = null;
            // 
            // txtMangerEmail3
            // 
            this.txtMangerEmail3.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMangerEmail3.Location = new System.Drawing.Point(381, 82);
            this.txtMangerEmail3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtMangerEmail3.Name = "txtMangerEmail3";
            this.txtMangerEmail3.Size = new System.Drawing.Size(107, 26);
            this.txtMangerEmail3.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(243, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "@";
            // 
            // cmbMangerEmail2
            // 
            this.cmbMangerEmail2.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbMangerEmail2.FormattingEnabled = true;
            this.cmbMangerEmail2.ItemHeight = 16;
            this.cmbMangerEmail2.Location = new System.Drawing.Point(268, 84);
            this.cmbMangerEmail2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cmbMangerEmail2.Name = "cmbMangerEmail2";
            this.cmbMangerEmail2.Size = new System.Drawing.Size(106, 24);
            this.cmbMangerEmail2.TabIndex = 4;
            // 
            // cmbManagerRank
            // 
            this.cmbManagerRank.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbManagerRank.FormattingEnabled = true;
            this.cmbManagerRank.ItemHeight = 16;
            this.cmbManagerRank.Location = new System.Drawing.Point(379, 27);
            this.cmbManagerRank.Name = "cmbManagerRank";
            this.cmbManagerRank.Size = new System.Drawing.Size(109, 24);
            this.cmbManagerRank.TabIndex = 1;
            // 
            // mskManagerPhone
            // 
            this.mskManagerPhone.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mskManagerPhone.Location = new System.Drawing.Point(137, 55);
            this.mskManagerPhone.Mask = "999-9000-0000";
            this.mskManagerPhone.Name = "mskManagerPhone";
            this.mskManagerPhone.Size = new System.Drawing.Size(107, 26);
            this.mskManagerPhone.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(250, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "직급";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMN
            // 
            this.lblMN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMN.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMN.ForeColor = System.Drawing.Color.Black;
            this.lblMN.Location = new System.Drawing.Point(6, 28);
            this.lblMN.Name = "lblMN";
            this.lblMN.Size = new System.Drawing.Size(125, 23);
            this.lblMN.TabIndex = 6;
            this.lblMN.Text = "이름";
            this.lblMN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "전화 번호";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblME
            // 
            this.lblME.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblME.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblME.ForeColor = System.Drawing.Color.Black;
            this.lblME.Location = new System.Drawing.Point(6, 85);
            this.lblME.Name = "lblME";
            this.lblME.Size = new System.Drawing.Size(125, 23);
            this.lblME.TabIndex = 10;
            this.lblME.Text = "이메일 주소";
            this.lblME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(523, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 324);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "직원 정보";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEmployees);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 293);
            this.panel1.TabIndex = 1;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowTemplate.Height = 23;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(488, 293);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(12, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1005, 356);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "직원 정보";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvReports);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 325);
            this.panel2.TabIndex = 1;
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.Location = new System.Drawing.Point(0, 0);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowTemplate.Height = 23;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(999, 325);
            this.dgvReports.TabIndex = 0;
            this.dgvReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellContentClick);
            // 
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1034, 708);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Manager";
            this.Load += new System.EventHandler(this.Form_Manager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControl1 txtCompanyName;
        private CustomControl1 txtID;
        private System.Windows.Forms.Button btn_Signup_Addr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblco;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomControl1 txtMangerEmail1;
        private System.Windows.Forms.TextBox txtMangerEmail3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbMangerEmail2;
        private System.Windows.Forms.ComboBox cmbManagerRank;
        private System.Windows.Forms.MaskedTextBox mskManagerPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblME;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private ucZipAddr ucZipAddr1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbMansger;
    }
}