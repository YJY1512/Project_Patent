
namespace Project_Patent
{
    partial class ucZipAddr
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.txtAddr3 = new System.Windows.Forms.TextBox();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "우편번호검색";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAddr3
            // 
            this.txtAddr3.Location = new System.Drawing.Point(4, 102);
            this.txtAddr3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddr3.Name = "txtAddr3";
            this.txtAddr3.Size = new System.Drawing.Size(354, 29);
            this.txtAddr3.TabIndex = 1;
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(4, 54);
            this.txtAddr2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.ReadOnly = true;
            this.txtAddr2.Size = new System.Drawing.Size(354, 29);
            this.txtAddr2.TabIndex = 22;
            // 
            // txtAddr1
            // 
            this.txtAddr1.Location = new System.Drawing.Point(4, 5);
            this.txtAddr1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.ReadOnly = true;
            this.txtAddr1.Size = new System.Drawing.Size(81, 29);
            this.txtAddr1.TabIndex = 21;
            // 
            // ucZipAddr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtAddr3);
            this.Controls.Add(this.txtAddr2);
            this.Controls.Add(this.txtAddr1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucZipAddr";
            this.Size = new System.Drawing.Size(378, 147);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAddr3;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.TextBox txtAddr1;
    }
}
