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
    public partial class Form_SignUp : Form
    {
        Manager proManager;
        string[] categorys = { "rank", "email" };
        List<string> emptyList;
        bool isCheckID;

        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            isCheckID = false;
            proManager = new Manager();
            emptyList = new List<string>();

            //초반 설정

            // 1.포커스 설정
            groupBox1.Focus();
            txtID.Focus();

            // 2.숨김 설정
            lblCheckPWD.Hide();
            txtMangerEmail3.Hide();

            // 3. 공통데이터 불러오기 담당자 정보란 rank
            // 중간 클래스에 데이터 넘기기
            // 중간 클래스에서 DAO 를 호출 공통 데이터 전부 가져오기
            // 가저온 전부 데이터 중에서 일부 DataTable을 리턴하기
            // 리턴받은 DataTable을 ComboBox 데이터 소스로 받기
           
            proManager.LoadCommonData(cmbManagerRank, categorys, "rank");

            // 공통데이터 불러오기 담당자 정보란 email

            proManager.LoadCommonData(cmbMangerEmail2, categorys, "email");
           
            // 직원 column 불러오기

            DataGridViewUtil.SetInitDataGridView(dgv_SignUp);

            DataGridViewUtil.AddGridTextBoxColumn(dgv_SignUp, "이름", "EmployeeName", colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgv_SignUp, "코드", "EmployeeRank", visible: false,colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgv_SignUp, "직책", "", colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);

            // 공통데이터 불러오기 직원 정보란 Rank
            proManager.LoadCommonData(cmbEmployeeRank, categorys, "rank");
            
        }


        private void btn_Signup_IDCheck_Click(object sender, EventArgs e)
        {
            bool result = proManager.LookUPID(txtID.Text);

            if (result)
            {
                MessageBox.Show("이미 사용중인 아이디 입니다.");
                txtID.Clear();
                txtID.Focus();
            }
            else
            {
                isCheckID = true;
                MessageBox.Show("사용 가능한 아이디 입니다.");
                txtPWD1.Focus();
            }
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text) || txtEmployeeName.Text.Length > 5)
            {
                MessageBox.Show("직원 이름(5자 이하)을 작성해 주세요");
                txtEmployeeName.Focus();
                return;
            }
            
            dgv_SignUp.Rows.Add(txtEmployeeName.Text, cmbEmployeeRank.SelectedValue, cmbEmployeeRank.Text);

            MessageBox.Show($"{cmbEmployeeRank.Text} - {txtEmployeeName.Text}, 직원이 추가되었습니다.");

            txtEmployeeName.Clear();
            
        }

        private void btnEmployeeDel_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.TextLength < 1 || dgv_SignUp.CurrentRow == null)
            {
                MessageBox.Show("선택된 직원의 데이터가 없습니다.");
                return;
            }

            

            if (MessageBox.Show($"{cmbEmployeeRank.Text} - {txtEmployeeName.Text}, 해당 정보를 삭제하시겠습니까?", "직원 데이터 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(dgv_SignUp.CurrentRow.Index.ToString());
                dgv_SignUp.Rows.RemoveAt(dgv_SignUp.CurrentRow.Index);
            }

            txtEmployeeName.Clear();
            
        }


        //등록
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!isCheckID)
            {
                MessageBox.Show("아이디 중복 체크는 필수 입니다.");
                return;
            }

            // 회사 정보란 필수 데이터 확인
            foreach (var item in panel1.Controls)
            {
                if (item is CustomControl1)
                {
                    if (string.IsNullOrWhiteSpace(((CustomControl1)item).Text))
                    {
                        emptyList.Add(((CustomControl1)item).Title);
                    }
                }
                
            }

            // 관리자 정보란 필수 데이터 확인
            foreach (var item in groupBox2.Controls)
            {
                if (item.GetType() == typeof(CustomControl1)) 
                {
                    if (string.IsNullOrWhiteSpace(((CustomControl1)item).Text))
                    {
                        emptyList.Add(((CustomControl1)item).Title);
                    }
                }
            }

            // 필수 데이터 입력 확인
            if (emptyList.Count != 0)
            {
                MessageBox.Show($"필수정보({string.Join(",", emptyList)})를 작성해 주세요  ");
                return;
            }


            bool result = proManager.SignUP(txtID.Text,
                txtPWD1.Text,
                txtCompanyName.Text,
                ucZipAddr1.Addr1, ucZipAddr1.Addr2, ucZipAddr1.Addr3,
                txtManagerName.Text,
                cmbManagerRank.SelectedValue.ToString(),
                txtManagerPWD.Text,
                mskManagerPhone.Text,
                txtMangerEmail1.Text, cmbMangerEmail2.SelectedValue.ToString(), txtMangerEmail3.Text,
                dgv_SignUp);

            
            

            if (result)
            {
                MessageBox.Show("등록 되었습니다.");
                this.Close();
            }
            else
            {
                MessageBox.Show("등록 실패했습니다.");
            }
        }

        private void dgv_SignUp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeName.Text = dgv_SignUp.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbEmployeeRank.SelectedValue = dgv_SignUp.Rows[e.RowIndex].Cells[1].Value;
        }

        

        private void cmbMangerEmail2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMangerEmail2.SelectedValue.ToString() == "eml05")
            {
                txtMangerEmail3.Visible = true;
                txtMangerEmail3.Focus();
            }
        }

        private void txtPWD2_Leave_1(object sender, EventArgs e)
        {
            if (txtPWD2.Text != txtPWD1.Text)
            {
                lblCheckPWD.Visible = true;
            }
            else
            {
                lblCheckPWD.Visible = false;
            }
        }
    }
}
