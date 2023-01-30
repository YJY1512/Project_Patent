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
    public partial class Form_ReportInfo : Form
    {
        Manager manager;
        string[] categorys = { "Tech", "6T" };
        string[] tech1list = { "모빌리티", "전자전기", "정보통신", "바이오", "에너지", "건축토목", "광기술", "기계", "화학", "기타" };
        string[] tech2list = { "NT", "IT", "ET", "BT", "ST", "CT", "기타" };

        //ReportDTO rdto;

        public Form_ReportInfo()
        {
            InitializeComponent();
        }

        private void Form_ReportInfo_Load(object sender, EventArgs e)
        {
            dtp_RawData_FinalDate.MinDate = DateTime.Now;

            

            manager = new Manager();

            //string n = ((Form_Main)Owner).LoginedEmployee.Split(' ')[1];
            //txtReportWirter.Text = n;

            //manager.LoadCommonData(cmbTech1, categorys, "Tech");
            //manager.LoadCommonData(cmbTech2, categorys, "6T");

        }

        private void btn_RawData_Analysis_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            //rdto = new ReportDTO();
            ////
            //rdto.Title = txtReportTitle.Text;
            //rdto.ReportNum = $"{DateTime.Now.ToString("yyMMdd")}_{((Form_Main)Owner).LoginedUser.UserID}_{((Form_Main)Owner).LoginedUser.Reportlist.Count + 1:000}";
            //rdto.Writer = txtReportWirter.Text;
            //rdto.UserID = ((Form_Main)Owner).LoginedUser.UserID;
            //rdto.Tech1Code = cmbTech1.SelectedValue.ToString();
            //rdto.Tech1 = tech1list[cmbTech1.SelectedIndex];

            //rdto.Tech2Code = cmbTech2.SelectedValue.ToString();
            //rdto.Tech2 = tech2list[cmbTech2.SelectedIndex];
            //rdto.FinalDate = dtp_RawData_FinalDate.Value;

            

            //if (!manager.InsertReportInfo(rdto))
            //{
            //    MessageBox.Show("데이터 저장하는데 실패했습니다.");
            //    return;
            //}

            //MessageBox.Show("데이터를 저장했습니다.");
            //((Form_Main)Owner).LoginedUser.Reportlist.Insert(0, rdto);
            this.Close();
        }

       
    }
}
