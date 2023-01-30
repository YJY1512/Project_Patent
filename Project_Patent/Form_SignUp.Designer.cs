
namespace Project_Patent
{
    partial class Form_SignUp
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
            this.cmbEmployeeRank = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnEmployeeDel = new System.Windows.Forms.Button();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.dgv_SignUp = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCheckPWD = new System.Windows.Forms.Label();
            this.btn_Signup_IDCheck = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblco = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPW1 = new System.Windows.Forms.Label();
            this.lblPW2 = new System.Windows.Forms.Label();
            this.mskManagerPhone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblME = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMangerEmail3 = new System.Windows.Forms.TextBox();
            this.lblMPW = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMangerEmail2 = new System.Windows.Forms.ComboBox();
            this.cmbManagerRank = new System.Windows.Forms.ComboBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.ucZipAddr1 = new Project_Patent.ucZipAddr();
            this.txtPWD2 = new Project_Patent.CustomControl1();
            this.txtPWD1 = new Project_Patent.CustomControl1();
            this.txtCompanyName = new Project_Patent.CustomControl1();
            this.txtID = new Project_Patent.CustomControl1();
            this.txtManagerPWD = new Project_Patent.CustomControl1();
            this.txtMangerEmail1 = new Project_Patent.CustomControl1();
            this.txtManagerName = new Project_Patent.CustomControl1();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SignUp)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEmployeeRank
            // 
            this.cmbEmployeeRank.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbEmployeeRank.FormattingEnabled = true;
            this.cmbEmployeeRank.ItemHeight = 16;
            this.cmbEmployeeRank.Location = new System.Drawing.Point(372, 501);
            this.cmbEmployeeRank.Name = "cmbEmployeeRank";
            this.cmbEmployeeRank.Size = new System.Drawing.Size(128, 24);
            this.cmbEmployeeRank.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.LightCyan;
            this.label10.Location = new System.Drawing.Point(19, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "* 노란색으로 표시된 정보란은 필수 입력란입니다.";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(369, 570);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(131, 30);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "등록";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnEmployeeDel
            // 
            this.btnEmployeeDel.Location = new System.Drawing.Point(434, 531);
            this.btnEmployeeDel.Name = "btnEmployeeDel";
            this.btnEmployeeDel.Size = new System.Drawing.Size(66, 33);
            this.btnEmployeeDel.TabIndex = 5;
            this.btnEmployeeDel.Text = "삭제";
            this.btnEmployeeDel.UseVisualStyleBackColor = true;
            this.btnEmployeeDel.Click += new System.EventHandler(this.btnEmployeeDel_Click);
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(372, 531);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(64, 33);
            this.btnEmployeeAdd.TabIndex = 4;
            this.btnEmployeeAdd.Text = "추가";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // dgv_SignUp
            // 
            this.dgv_SignUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SignUp.Location = new System.Drawing.Point(3, 28);
            this.dgv_SignUp.MultiSelect = false;
            this.dgv_SignUp.Name = "dgv_SignUp";
            this.dgv_SignUp.ReadOnly = true;
            this.dgv_SignUp.RowHeadersWidth = 51;
            this.dgv_SignUp.RowTemplate.Height = 23;
            this.dgv_SignUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SignUp.Size = new System.Drawing.Size(348, 124);
            this.dgv_SignUp.TabIndex = 0;
            this.dgv_SignUp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SignUp_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.dgv_SignUp);
            this.groupBox3.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(12, 446);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 155);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "직원 정보";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.ucZipAddr1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblco);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblPW1);
            this.groupBox1.Controls.Add(this.lblPW2);
            this.groupBox1.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회사 정보";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPWD2);
            this.panel1.Controls.Add(this.txtPWD1);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.lblCheckPWD);
            this.panel1.Controls.Add(this.btn_Signup_IDCheck);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(137, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 142);
            this.panel1.TabIndex = 0;
            // 
            // lblCheckPWD
            // 
            this.lblCheckPWD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckPWD.BackColor = System.Drawing.SystemColors.Control;
            this.lblCheckPWD.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCheckPWD.ForeColor = System.Drawing.Color.Red;
            this.lblCheckPWD.Location = new System.Drawing.Point(169, 69);
            this.lblCheckPWD.Name = "lblCheckPWD";
            this.lblCheckPWD.Size = new System.Drawing.Size(164, 31);
            this.lblCheckPWD.TabIndex = 5;
            this.lblCheckPWD.Text = "비밀 번호가 다릅니다.";
            this.lblCheckPWD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Signup_IDCheck
            // 
            this.btn_Signup_IDCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Signup_IDCheck.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Signup_IDCheck.Location = new System.Drawing.Point(175, 6);
            this.btn_Signup_IDCheck.Name = "btn_Signup_IDCheck";
            this.btn_Signup_IDCheck.Size = new System.Drawing.Size(73, 31);
            this.btn_Signup_IDCheck.TabIndex = 1;
            this.btn_Signup_IDCheck.Text = "확인";
            this.btn_Signup_IDCheck.UseVisualStyleBackColor = true;
            this.btn_Signup_IDCheck.Click += new System.EventHandler(this.btn_Signup_IDCheck_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(6, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 97);
            this.label8.TabIndex = 13;
            this.label8.Text = "회사 주소";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblco
            // 
            this.lblco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblco.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblco.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblco.ForeColor = System.Drawing.Color.Black;
            this.lblco.Location = new System.Drawing.Point(6, 123);
            this.lblco.Name = "lblco";
            this.lblco.Size = new System.Drawing.Size(125, 31);
            this.lblco.TabIndex = 12;
            this.lblco.Text = "회사 이름";
            this.lblco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AllowDrop = true;
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblID.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(6, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 31);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "아이디";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPW1
            // 
            this.lblPW1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPW1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPW1.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPW1.ForeColor = System.Drawing.Color.Black;
            this.lblPW1.Location = new System.Drawing.Point(6, 61);
            this.lblPW1.Name = "lblPW1";
            this.lblPW1.Size = new System.Drawing.Size(125, 31);
            this.lblPW1.TabIndex = 10;
            this.lblPW1.Text = "비밀 번호";
            this.lblPW1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPW2
            // 
            this.lblPW2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPW2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPW2.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPW2.ForeColor = System.Drawing.Color.Black;
            this.lblPW2.Location = new System.Drawing.Point(6, 92);
            this.lblPW2.Name = "lblPW2";
            this.lblPW2.Size = new System.Drawing.Size(125, 31);
            this.lblPW2.TabIndex = 11;
            this.lblPW2.Text = "비밀 번호 확인";
            this.lblPW2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtManagerPWD);
            this.groupBox2.Controls.Add(this.txtMangerEmail1);
            this.groupBox2.Controls.Add(this.txtManagerName);
            this.groupBox2.Controls.Add(this.txtMangerEmail3);
            this.groupBox2.Controls.Add(this.lblMPW);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbMangerEmail2);
            this.groupBox2.Controls.Add(this.cmbManagerRank);
            this.groupBox2.Controls.Add(this.mskManagerPhone);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblMN);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblME);
            this.groupBox2.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "담당자 정보";
            // 
            // txtMangerEmail3
            // 
            this.txtMangerEmail3.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMangerEmail3.Location = new System.Drawing.Point(381, 82);
            this.txtMangerEmail3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtMangerEmail3.Name = "txtMangerEmail3";
            this.txtMangerEmail3.Size = new System.Drawing.Size(107, 26);
            this.txtMangerEmail3.TabIndex = 6;
            // 
            // lblMPW
            // 
            this.lblMPW.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMPW.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMPW.ForeColor = System.Drawing.Color.Black;
            this.lblMPW.Location = new System.Drawing.Point(250, 56);
            this.lblMPW.Name = "lblMPW";
            this.lblMPW.Size = new System.Drawing.Size(125, 23);
            this.lblMPW.TabIndex = 9;
            this.lblMPW.Text = "담당자 PW";
            this.lblMPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmbMangerEmail2.TabIndex = 5;
            this.cmbMangerEmail2.SelectedIndexChanged += new System.EventHandler(this.cmbMangerEmail2_SelectedIndexChanged);
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
            // txtEmployeeName
            // 
            this.txtEmployeeName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtEmployeeName.Location = new System.Drawing.Point(372, 468);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(128, 27);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // ucZipAddr1
            // 
            this.ucZipAddr1.Addr1 = "";
            this.ucZipAddr1.Addr2 = "";
            this.ucZipAddr1.Addr3 = "";
            this.ucZipAddr1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucZipAddr1.Location = new System.Drawing.Point(137, 171);
            this.ucZipAddr1.Margin = new System.Windows.Forms.Padding(5);
            this.ucZipAddr1.Name = "ucZipAddr1";
            this.ucZipAddr1.Size = new System.Drawing.Size(293, 100);
            this.ucZipAddr1.TabIndex = 2;
            // 
            // txtPWD2
            // 
            this.txtPWD2.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPWD2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPWD2.Location = new System.Drawing.Point(1, 71);
            this.txtPWD2.Name = "txtPWD2";
            this.txtPWD2.PasswordChar = '○';
            this.txtPWD2.Size = new System.Drawing.Size(168, 27);
            this.txtPWD2.TabIndex = 3;
            this.txtPWD2.TextType = Project_Patent.CustomControl1.InputTextType.PWD;
            this.txtPWD2.Title = "비밀번호";
            this.txtPWD2.Leave += new System.EventHandler(this.txtPWD2_Leave_1);
            // 
            // txtPWD1
            // 
            this.txtPWD1.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPWD1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPWD1.Location = new System.Drawing.Point(1, 37);
            this.txtPWD1.Name = "txtPWD1";
            this.txtPWD1.PasswordChar = '○';
            this.txtPWD1.Size = new System.Drawing.Size(168, 27);
            this.txtPWD1.TabIndex = 2;
            this.txtPWD1.TextType = Project_Patent.CustomControl1.InputTextType.PWD;
            this.txtPWD1.Title = "비밀번호";
            this.txtPWD1.Leave += new System.EventHandler(this.txtPWD2_Leave_1);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCompanyName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyName.Location = new System.Drawing.Point(1, 102);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(168, 27);
            this.txtCompanyName.TabIndex = 4;
            this.txtCompanyName.TextType = Project_Patent.CustomControl1.InputTextType.CoName;
            this.txtCompanyName.Title = "회사이름";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(1, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 27);
            this.txtID.TabIndex = 0;
            this.txtID.TextType = Project_Patent.CustomControl1.InputTextType.NNID;
            this.txtID.Title = "아이디";
            // 
            // txtManagerPWD
            // 
            this.txtManagerPWD.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtManagerPWD.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtManagerPWD.Location = new System.Drawing.Point(379, 53);
            this.txtManagerPWD.Name = "txtManagerPWD";
            this.txtManagerPWD.PasswordChar = '○';
            this.txtManagerPWD.Size = new System.Drawing.Size(109, 27);
            this.txtManagerPWD.TabIndex = 3;
            this.txtManagerPWD.TextType = Project_Patent.CustomControl1.InputTextType.PWD;
            this.txtManagerPWD.Title = "담당자 비밀번호";
            // 
            // txtMangerEmail1
            // 
            this.txtMangerEmail1.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtMangerEmail1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMangerEmail1.Location = new System.Drawing.Point(137, 82);
            this.txtMangerEmail1.Name = "txtMangerEmail1";
            this.txtMangerEmail1.Size = new System.Drawing.Size(107, 27);
            this.txtMangerEmail1.TabIndex = 4;
            this.txtMangerEmail1.TextType = Project_Patent.CustomControl1.InputTextType.Email;
            this.txtMangerEmail1.Title = "이메일";
            // 
            // txtManagerName
            // 
            this.txtManagerName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtManagerName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtManagerName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtManagerName.Location = new System.Drawing.Point(137, 25);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(107, 27);
            this.txtManagerName.TabIndex = 0;
            this.txtManagerName.TextType = Project_Patent.CustomControl1.InputTextType.ManagerName;
            this.txtManagerName.Title = "담당자 이름";
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(528, 618);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.cmbEmployeeRank);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnEmployeeDel);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원 가입";
            this.Load += new System.EventHandler(this.Form_SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SignUp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployeeRank;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnEmployeeDel;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.DataGridView dgv_SignUp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCheckPWD;
        private System.Windows.Forms.Button btn_Signup_IDCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblco;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPW1;
        private System.Windows.Forms.Label lblPW2;
        private System.Windows.Forms.MaskedTextBox mskManagerPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblME;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMangerEmail3;
        private System.Windows.Forms.Label lblMPW;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbMangerEmail2;
        private System.Windows.Forms.ComboBox cmbManagerRank;
        private Project_Patent.CustomControl1 txtCompanyName;
        private Project_Patent.CustomControl1 txtPWD2;
        private Project_Patent.CustomControl1 txtPWD1;
        private Project_Patent.CustomControl1 txtID;
        private Project_Patent.CustomControl1 txtManagerPWD;
        private Project_Patent.CustomControl1 txtMangerEmail1;
        private Project_Patent.CustomControl1 txtManagerName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Panel panel1;
        private ucZipAddr ucZipAddr1;
    }
}