
namespace Project_Patent
{
    partial class Form_Main
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblLoginedRank = new System.Windows.Forms.Label();
            this.lblLoginedEmployee = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_SaveDB = new System.Windows.Forms.Button();
            this.btnDataChoice = new System.Windows.Forms.Button();
            this.pnlDataInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReportD_Day = new System.Windows.Forms.Label();
            this.lblReportFinalDay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReportTeck2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReportTeck1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnRationalization = new System.Windows.Forms.Button();
            this.cmbDataSheet = new System.Windows.Forms.ComboBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtRawDataPath = new System.Windows.Forms.TextBox();
            this.dgvRawDataView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblIsManager = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelectedDataSave = new System.Windows.Forms.Button();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlDataInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1186, 51);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCompanyName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCompanyName.Location = new System.Drawing.Point(26, 14);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(95, 25);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "회사 이름";
            // 
            // lblLoginedRank
            // 
            this.lblLoginedRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginedRank.AutoSize = true;
            this.lblLoginedRank.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLoginedRank.Location = new System.Drawing.Point(914, 14);
            this.lblLoginedRank.Name = "lblLoginedRank";
            this.lblLoginedRank.Size = new System.Drawing.Size(39, 20);
            this.lblLoginedRank.TabIndex = 3;
            this.lblLoginedRank.Text = "직책";
            // 
            // lblLoginedEmployee
            // 
            this.lblLoginedEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginedEmployee.AutoSize = true;
            this.lblLoginedEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLoginedEmployee.Location = new System.Drawing.Point(1001, 14);
            this.lblLoginedEmployee.Name = "lblLoginedEmployee";
            this.lblLoginedEmployee.Size = new System.Drawing.Size(39, 20);
            this.lblLoginedEmployee.TabIndex = 4;
            this.lblLoginedEmployee.Text = "이름";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1089, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 26);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 51);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_SaveDB);
            this.splitContainer1.Panel1.Controls.Add(this.btnDataChoice);
            this.splitContainer1.Panel1.Controls.Add(this.pnlDataInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdmin);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnalysis);
            this.splitContainer1.Panel1.Controls.Add(this.btnRationalization);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Panel2.Controls.Add(this.cmbDataSheet);
            this.splitContainer1.Panel2.Controls.Add(this.btnLoadData);
            this.splitContainer1.Panel2.Controls.Add(this.txtRawDataPath);
            this.splitContainer1.Panel2.Controls.Add(this.dgvRawDataView);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 513);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 6;
            // 
            // btn_SaveDB
            // 
            this.btn_SaveDB.Location = new System.Drawing.Point(12, 143);
            this.btn_SaveDB.Name = "btn_SaveDB";
            this.btn_SaveDB.Size = new System.Drawing.Size(146, 38);
            this.btn_SaveDB.TabIndex = 7;
            this.btn_SaveDB.Text = "출력(Excel)";
            this.btn_SaveDB.UseVisualStyleBackColor = true;
            this.btn_SaveDB.Click += new System.EventHandler(this.btn_SaveDB_Click);
            // 
            // btnDataChoice
            // 
            this.btnDataChoice.Location = new System.Drawing.Point(13, 11);
            this.btnDataChoice.Name = "btnDataChoice";
            this.btnDataChoice.Size = new System.Drawing.Size(146, 38);
            this.btnDataChoice.TabIndex = 6;
            this.btnDataChoice.Text = "데이터 선택";
            this.btnDataChoice.UseVisualStyleBackColor = true;
            this.btnDataChoice.Click += new System.EventHandler(this.btnDataChoice_Click);
            // 
            // pnlDataInfo
            // 
            this.pnlDataInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDataInfo.AutoScroll = true;
            this.pnlDataInfo.Controls.Add(this.label6);
            this.pnlDataInfo.Controls.Add(this.label4);
            this.pnlDataInfo.Controls.Add(this.label2);
            this.pnlDataInfo.Controls.Add(this.lblReportD_Day);
            this.pnlDataInfo.Controls.Add(this.lblReportFinalDay);
            this.pnlDataInfo.Controls.Add(this.label7);
            this.pnlDataInfo.Controls.Add(this.lblReportTeck2);
            this.pnlDataInfo.Controls.Add(this.label5);
            this.pnlDataInfo.Controls.Add(this.lblReportTeck1);
            this.pnlDataInfo.Controls.Add(this.label3);
            this.pnlDataInfo.Controls.Add(this.lblReportTitle);
            this.pnlDataInfo.Controls.Add(this.label1);
            this.pnlDataInfo.Font = new System.Drawing.Font("돋움체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlDataInfo.Location = new System.Drawing.Point(13, 195);
            this.pnlDataInfo.Name = "pnlDataInfo";
            this.pnlDataInfo.Size = new System.Drawing.Size(145, 262);
            this.pnlDataInfo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("바탕체", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(7, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "현재시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // lblReportD_Day
            // 
            this.lblReportD_Day.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReportD_Day.Location = new System.Drawing.Point(7, 209);
            this.lblReportD_Day.Name = "lblReportD_Day";
            this.lblReportD_Day.Size = new System.Drawing.Size(139, 18);
            this.lblReportD_Day.TabIndex = 8;
            this.lblReportD_Day.Text = "D-Day";
            // 
            // lblReportFinalDay
            // 
            this.lblReportFinalDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReportFinalDay.Location = new System.Drawing.Point(7, 182);
            this.lblReportFinalDay.Name = "lblReportFinalDay";
            this.lblReportFinalDay.Size = new System.Drawing.Size(139, 18);
            this.lblReportFinalDay.TabIndex = 7;
            this.lblReportFinalDay.Text = "마감일";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("바탕체", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(7, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "마감일";
            // 
            // lblReportTeck2
            // 
            this.lblReportTeck2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReportTeck2.Location = new System.Drawing.Point(7, 129);
            this.lblReportTeck2.Name = "lblReportTeck2";
            this.lblReportTeck2.Size = new System.Drawing.Size(139, 18);
            this.lblReportTeck2.TabIndex = 5;
            this.lblReportTeck2.Text = "기술 구분_2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("바탕체", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(7, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "기술 구분_2";
            // 
            // lblReportTeck1
            // 
            this.lblReportTeck1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReportTeck1.Location = new System.Drawing.Point(7, 80);
            this.lblReportTeck1.Name = "lblReportTeck1";
            this.lblReportTeck1.Size = new System.Drawing.Size(139, 18);
            this.lblReportTeck1.TabIndex = 3;
            this.lblReportTeck1.Text = "기술 구분_1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("바탕체", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "기술 구분_1";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReportTitle.Location = new System.Drawing.Point(7, 30);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(157, 18);
            this.lblReportTitle.TabIndex = 1;
            this.lblReportTitle.Text = "보고서";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("바탕체", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "보고서";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdmin.Location = new System.Drawing.Point(13, 463);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(146, 38);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "관리자";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(12, 99);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(146, 38);
            this.btnAnalysis.TabIndex = 1;
            this.btnAnalysis.Text = "데이터 분석";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnRationalization
            // 
            this.btnRationalization.Location = new System.Drawing.Point(13, 55);
            this.btnRationalization.Name = "btnRationalization";
            this.btnRationalization.Size = new System.Drawing.Size(146, 38);
            this.btnRationalization.TabIndex = 0;
            this.btnRationalization.Text = "데이터 정비";
            this.btnRationalization.UseVisualStyleBackColor = true;
            this.btnRationalization.Click += new System.EventHandler(this.btnRationalization_Click);
            // 
            // cmbDataSheet
            // 
            this.cmbDataSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDataSheet.FormattingEnabled = true;
            this.cmbDataSheet.Location = new System.Drawing.Point(710, 3);
            this.cmbDataSheet.Name = "cmbDataSheet";
            this.cmbDataSheet.Size = new System.Drawing.Size(156, 28);
            this.cmbDataSheet.TabIndex = 3;
            this.cmbDataSheet.SelectedIndexChanged += new System.EventHandler(this.cmbDataSheet_SelectedIndexChanged);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadData.Location = new System.Drawing.Point(872, 6);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(128, 27);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "데이터 가져오기";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtRawDataPath
            // 
            this.txtRawDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRawDataPath.Enabled = false;
            this.txtRawDataPath.Location = new System.Drawing.Point(8, 3);
            this.txtRawDataPath.Name = "txtRawDataPath";
            this.txtRawDataPath.Size = new System.Drawing.Size(669, 27);
            this.txtRawDataPath.TabIndex = 1;
            // 
            // dgvRawDataView
            // 
            this.dgvRawDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRawDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawDataView.Location = new System.Drawing.Point(8, 38);
            this.dgvRawDataView.Name = "dgvRawDataView";
            this.dgvRawDataView.RowHeadersWidth = 51;
            this.dgvRawDataView.RowTemplate.Height = 23;
            this.dgvRawDataView.Size = new System.Drawing.Size(995, 466);
            this.dgvRawDataView.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblIsManager
            // 
            this.lblIsManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIsManager.AutoSize = true;
            this.lblIsManager.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIsManager.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIsManager.ForeColor = System.Drawing.Color.Red;
            this.lblIsManager.Location = new System.Drawing.Point(887, 9);
            this.lblIsManager.Name = "lblIsManager";
            this.lblIsManager.Size = new System.Drawing.Size(23, 30);
            this.lblIsManager.TabIndex = 7;
            this.lblIsManager.Text = "*";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnSelectedDataSave);
            this.panel2.Controls.Add(this.lblRight);
            this.panel2.Controls.Add(this.lblLeft);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnLeft);
            this.panel2.Controls.Add(this.btnRight);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(206, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 461);
            this.panel2.TabIndex = 4;
            // 
            // btnSelectedDataSave
            // 
            this.btnSelectedDataSave.Location = new System.Drawing.Point(529, 8);
            this.btnSelectedDataSave.Name = "btnSelectedDataSave";
            this.btnSelectedDataSave.Size = new System.Drawing.Size(116, 29);
            this.btnSelectedDataSave.TabIndex = 13;
            this.btnSelectedDataSave.Text = "저장";
            this.btnSelectedDataSave.UseVisualStyleBackColor = true;
            this.btnSelectedDataSave.Click += new System.EventHandler(this.btnSelectedDataSave_Click);
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRight.Location = new System.Drawing.Point(539, 54);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(27, 20);
            this.lblRight.TabIndex = 12;
            this.lblRight.Text = "00";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLeft.Location = new System.Drawing.Point(168, 55);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(27, 20);
            this.lblLeft.TabIndex = 11;
            this.lblLeft.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(438, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "컬럼 수 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(67, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "컬럼 수 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(250, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "데이터 선택";
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(285, 266);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "<<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(285, 202);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">>>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(377, 83);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(263, 344);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(11, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 344);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblIsManager);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblLoginedEmployee);
            this.Controls.Add(this.lblLoginedRank);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.splitter1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Main";
            this.Text = "특허 분석 프로그램";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlDataInfo.ResumeLayout(false);
            this.pnlDataInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblLoginedRank;
        private System.Windows.Forms.Label lblLoginedEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtRawDataPath;
        private System.Windows.Forms.DataGridView dgvRawDataView;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnRationalization;
        private System.Windows.Forms.ComboBox cmbDataSheet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlDataInfo;
        private System.Windows.Forms.Label lblReportD_Day;
        private System.Windows.Forms.Label lblReportFinalDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReportTeck2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReportTeck1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblIsManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDataChoice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectedDataSave;
        private System.Windows.Forms.Button btn_SaveDB;
    }
}

