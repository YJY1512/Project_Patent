
namespace Project_Patent
{
    partial class frmZipSearchPopup
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgvZip = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtRoadAddr2 = new System.Windows.Forms.TextBox();
            this.txtRoadAddr1 = new System.Windows.Forms.TextBox();
            this.txtRoadZip = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtJibunAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunAddr1 = new System.Windows.Forms.TextBox();
            this.txtJibunZip = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZip)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "도로명(지번) 주소검색";
            // 
            // dgvZip
            // 
            this.dgvZip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZip.Location = new System.Drawing.Point(17, 53);
            this.dgvZip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvZip.Name = "dgvZip";
            this.dgvZip.RowTemplate.Height = 23;
            this.dgvZip.Size = new System.Drawing.Size(693, 319);
            this.dgvZip.TabIndex = 18;
            this.dgvZip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZip_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(499, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 25);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtKeyWord.Location = new System.Drawing.Point(323, 12);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(156, 25);
            this.txtKeyWord.TabIndex = 16;
            this.txtKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyWord_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 391);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 51);
            this.button4.TabIndex = 29;
            this.button4.Text = "도로명 주소확인";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtRoadAddr2
            // 
            this.txtRoadAddr2.Location = new System.Drawing.Point(294, 419);
            this.txtRoadAddr2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoadAddr2.Name = "txtRoadAddr2";
            this.txtRoadAddr2.Size = new System.Drawing.Size(416, 25);
            this.txtRoadAddr2.TabIndex = 28;
            // 
            // txtRoadAddr1
            // 
            this.txtRoadAddr1.Location = new System.Drawing.Point(172, 391);
            this.txtRoadAddr1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoadAddr1.Name = "txtRoadAddr1";
            this.txtRoadAddr1.Size = new System.Drawing.Size(538, 25);
            this.txtRoadAddr1.TabIndex = 27;
            // 
            // txtRoadZip
            // 
            this.txtRoadZip.Location = new System.Drawing.Point(172, 419);
            this.txtRoadZip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoadZip.Name = "txtRoadZip";
            this.txtRoadZip.Size = new System.Drawing.Size(118, 25);
            this.txtRoadZip.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 51);
            this.button1.TabIndex = 33;
            this.button1.Text = "지번 주소확인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtJibunAddr2
            // 
            this.txtJibunAddr2.Location = new System.Drawing.Point(294, 484);
            this.txtJibunAddr2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtJibunAddr2.Name = "txtJibunAddr2";
            this.txtJibunAddr2.Size = new System.Drawing.Size(416, 25);
            this.txtJibunAddr2.TabIndex = 32;
            // 
            // txtJibunAddr1
            // 
            this.txtJibunAddr1.Location = new System.Drawing.Point(172, 456);
            this.txtJibunAddr1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtJibunAddr1.Name = "txtJibunAddr1";
            this.txtJibunAddr1.Size = new System.Drawing.Size(538, 25);
            this.txtJibunAddr1.TabIndex = 31;
            // 
            // txtJibunZip
            // 
            this.txtJibunZip.Location = new System.Drawing.Point(172, 484);
            this.txtJibunZip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtJibunZip.Name = "txtJibunZip";
            this.txtJibunZip.Size = new System.Drawing.Size(118, 25);
            this.txtJibunZip.TabIndex = 30;
            // 
            // frmZipSearchPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJibunAddr2);
            this.Controls.Add(this.txtJibunAddr1);
            this.Controls.Add(this.txtJibunZip);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtRoadAddr2);
            this.Controls.Add(this.txtRoadAddr1);
            this.Controls.Add(this.txtRoadZip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvZip);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyWord);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZipSearchPopup";
            this.Text = "우편번호검색";
            this.Load += new System.EventHandler(this.frmZipSearchPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvZip;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtRoadAddr2;
        private System.Windows.Forms.TextBox txtRoadAddr1;
        private System.Windows.Forms.TextBox txtRoadZip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtJibunAddr2;
        private System.Windows.Forms.TextBox txtJibunAddr1;
        private System.Windows.Forms.TextBox txtJibunZip;
    }
}