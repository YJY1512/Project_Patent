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
    public partial class Form_Login : Form
    {
        
        Manager manager;
        

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            manager = new Manager();
            panel2.Visible = false;

        }

        private void btnSIgnup_Click(object sender, EventArgs e)
        {
            manager.OpneForm<Form_SignUp>();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 여기서 manager로 ID / PWD 매개변수로 보냄
            // manager에서 ID / PWD 를 UserDAO 매개변수로 확인
            // 확인이 되면 UserDTO(직원 리스트, 작업 리스트 포함) 반환
            // UserDTO(login된 데이터) 이거를 loginform으로 보내고 > 로그인 되면서 mainform으로 옮기기?
            // login창에는  직원 리스트만 보내고, mainfomr으로 옮길수 있나? 불가능 해보이는데.......
            // manager > UserDAO로 가서 
            // 회사정보, 직원 리스트, 작업 리스트 가져오기
            //
            // Login 폼 변화


            //
            ((Form_Main)Owner).LoginedUser = manager.UserLogin(txtID.Text, txtPWD.Text);


            if (((Form_Main)Owner).LoginedUser == null)
            {
                MessageBox.Show("로그인 실패했습니다. 확인해주세요");
                return;
            }

            panel1.Visible = false;
            
            panel2.Visible = true;

            panel2.Location = panel1.Location;

            foreach (EmployeeDTO employee in ((Form_Main)Owner).LoginedUser.Employeeslist)
            {
                string item = string.Concat(employee.Rank, " ", employee.EmployeeName);
                lsbLogin.Items.Add(item);
            }

            lsbLogin.SelectedIndex = 0;
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            ((Form_Main)Owner).LoginedEmployee = lsbLogin.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPWCheck_Click(object sender, EventArgs e)
        {
            manager.OpneForm<Form_FInd>();
        }
    }
}
