using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Patent
{
    public partial class Form_FInd : Form
    {
        Manager manager;
        string[] categorys = { "email" };
        

        public Form_FInd()
        {
            InitializeComponent();
        }

        private void Form_FInd_Load(object sender, EventArgs e)
        {
            
            manager = new Manager();


        }

        private void cmbAddr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Control item in this.Controls)
            {
                if (item is CustomControl1)
                {
                    if (string.IsNullOrWhiteSpace(((CustomControl1)item).Text))
                    {
                        sb.Append(((CustomControl1)item).Title + " ");
                    }
                }
            }

            if (sb.Length != 0)
            {
                string msg = sb.ToString() + "필수 정보를 입력해 주세요";
                MessageBox.Show(msg);
                return;
            }

            bool isFind = manager.FindPW(txtID.Text, txtName.Text, txtManagerName.Text);

            if (isFind)
            {
                MessageBox.Show("저장된 담당자 메일로 비밀번호 관련 메일을 송부드렸습니다.");
                this.Close();
            }
            else
            {
                MessageBox.Show("입력하신 데이터를 확인해 주세요");
            }

        }
    }
}
