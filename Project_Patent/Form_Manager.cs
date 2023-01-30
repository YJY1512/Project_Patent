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
    public partial class Form_Manager : Form
    {

        UserDTO logined;
        List<EmployeeDTO> loginedEmployeesList;
        List<ReportDTO> loginedReportList;
        Manager manager;
        string[] categorys = { "rank", "email" };
        bool isRevise = true;

        public Form_Manager()
        {
            InitializeComponent();
        }

        private void Form_Manager_Load(object sender, EventArgs e)
        {
            manager = new Manager();
            
            // combobox 데이터 로드
            manager.LoadCommonData(cmbMangerEmail2, categorys, "Email");
            manager.LoadCommonData(cmbManagerRank, categorys, "Rank");

            // 데이터 설정

            // 1. 회사 정보, 직원, 보고서 정보 가져와서 로드 시키기

            logined = ((Form_Main)Owner).LoginedUser;
            loginedEmployeesList = ((Form_Main)Owner).LoginedUser.Employeeslist;
            loginedReportList = ((Form_Main)Owner).LoginedUser.Reportlist;

            txtID.Text = logined.UserID;
            txtID.Enabled = false;
            txtCompanyName.Text = logined.UserName;
            txtCompanyName.Enabled = false;
            ucZipAddr1.Addr1 = logined.UserAddr1;

            ucZipAddr1.Addr2 = logined.UserAddr2;

            ucZipAddr1.Addr3 = logined.UserAddr3;
            ucZipAddr1.Enabled = false;
            cmbMansger.SelectedText = logined.ManagerName;
            cmbMansger.Enabled = false;
            mskManagerPhone.Text = logined.ManagerPhone;
            mskManagerPhone.Enabled = false;
            cmbManagerRank.SelectedValue = logined.ManagerRankCode;
            cmbManagerRank.Enabled = false;
            txtMangerEmail1.Text = logined.Email1;
            txtMangerEmail1.Enabled = false;
            cmbMangerEmail2.Enabled = false;
            cmbMangerEmail2.SelectedValue = logined.Email2;
            if (logined.Email2.ToString() == "Eml05")
            {
                txtMangerEmail3.Text = logined.Email3;
                txtMangerEmail3.Enabled = false;
            }
            else
            {
                txtMangerEmail3.Visible = false;
            }

            // 2. 직원 데이터

            DataGridViewUtil.SetInitDataGridView(dgvEmployees);

            DataGridViewUtil.AddGridTextBoxColumn(dgvEmployees, "직급", "Employeerank", colWidth: 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmployees, "Rank", "Code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmployees, "이름", "EmployeeName", align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmployees, "관리자", "Admin", align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmployees, "isCurrent", "isCurrent", visible: false);
            DataGridViewUtil.AddGridButtonColumn(dgvEmployees, "삭제", "", colWidth: 80,align: DataGridViewContentAlignment.MiddleCenter);


            foreach (var item in loginedEmployeesList)
            {
                if (item.isCurrent == "Y")
                {
                    continue;
                }

                cmbMansger.Items.Add(item.EmployeeName);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvEmployees, item.Rank, item.RankCode, item.EmployeeName, item.Admin, item.isCurrent);
                dgvEmployees.Rows.Add(row);
            }



            // 3. 보고서 데이터 

            DataGridViewUtil.SetInitDataGridView(dgvReports);

            DataGridViewUtil.AddGridTextBoxColumn(dgvReports, "No", "reportno", colWidth: 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReports, "제목", "title", colWidth: 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReports, "작성자", "EmployeeName", colWidth: 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReports, "필드1", "techField1");
            DataGridViewUtil.AddGridTextBoxColumn(dgvReports, "Tech1", "Code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReports, "필드2", "techField2");
            DataGridViewUtil.AddGridTextBoxColumn(dgvReports, "Tech12", "Code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvReports, "마감일", "finalDate", colWidth: 200);
            

            foreach (var item in loginedReportList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvReports, item.ReportNum, item.Title, item.Writer,
                                item.Tech1, item.Tech1Code, item.Tech2, item.Tech2Code, item.FinalDate.ToString("yyyy-MM-dd"));
                dgvReports.Rows.Add(row);
            }



        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isRevise)
            {
                MessageBox.Show("수정 버튼 클릭 후 수정 가능합니다.");
                return;
            }

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;


            if (e.ColumnIndex == 5) //삭제
            {
                if (dgvEmployees[3, e.RowIndex].Value.ToString() == "Y")
                {
                    MessageBox.Show("관리자는 삭제할 수 없습니다. 관리자를 수정 후 삭제하세요");
                    return;
                }

                string msg = dgvEmployees[2, e.RowIndex].Value.ToString();
                if (MessageBox.Show($"{msg}님을 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    //List<EmployeesDTO> 값 Y 로 변경
                    dgvEmployees[4, e.RowIndex].Value = "Y";
                    // Datagridview 에서 삭제
                    dgvEmployees.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void cmbMansger_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 리스트 순서 바꾸기
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((Form_Main)Owner).R_DataTable != null || ((Form_Main)Owner).dt != null)
            {
                DialogResult result = MessageBox.Show("분석중인 데이터가 있습니다. 바꾸시겠습니까?", "", MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                {
                    ((Form_Main)Owner).dt = null;
                    return;
                }
            }

            string selectedRNO = dgvReports.SelectedRows[0].Cells["reportno"].Value.ToString();


            if (manager.CallReportDB(selectedRNO) != null)
            {
                MessageBox.Show("데이터를 불러왔습니다.");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("데이터를 불러오는데 실패했습니다.");
                return;
            }

            ((Form_Main)Owner).R_DataTable = manager.CallReportDB(selectedRNO);
        }
    }
}
