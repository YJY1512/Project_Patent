using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Mail;
using Project_Patent;

namespace Project_Patent
{
    class Manager
    {
        CommonDAO cdDao;
        AnalysisDAO dataDao;
        UserDAO userDao;
        public DataTable DB { get; set; }

        // 
        public bool LookUPID(string txtID)
        {
            userDao = new UserDAO();

            bool result = userDao.IDLookUP(txtID);

            return result;
        }


        // 입력받은 값을 통해 
        public void LoadCommonData(ComboBox cmb, string[] categorys, string category)
        {
            
            CommonDAO dao = new CommonDAO();
            // 하나 이상의 카테고리 DB 전부 받아오기
            DataTable dt = dao.CommonDataList(categorys);
            dao.Dispose();

            cmb.ValueMember = "code";
            cmb.DisplayMember = "data";
            
            cmb.DataSource = CommonUtils.ComboBoxBinding(cmb, dt, category, "data", "code");

        }


        public bool SignUP(string userID, string userpw, string username, string userAddr1, string userAddr2,
            string userAddr3, string managerName, string managerRank, string managerPw, string managerPhone,
            string email1, string email2, string email3, DataGridView employeesList)
        {
            UserDAO udao = new UserDAO();

            UserDTO dto = new UserDTO
            {
                UserID = userID,
                UserName = username,
                UserPW = userpw,
                UserAddr1 = userAddr1,
                UserAddr2 = userAddr2,
                UserAddr3 = userAddr3,
                ManagerName = managerName,
                ManagerPW = managerPw,
                ManagerPhone = managerPhone,
                ManagerRankCode = managerRank,
                Email1 = email1,
                Email2 = email2,
                Email3 = email3,
                Employeeslist = new List<EmployeeDTO>()
            };

            dto.Employeeslist = InputEmployeesData(managerName, managerRank, employeesList);

            return udao.Insert(dto);
        }


        public List<EmployeeDTO> InputEmployeesData(string managerName, string managerRank, DataGridView employeesList)
        {
            List<EmployeeDTO> eDTOList = new List<EmployeeDTO>();

            EmployeeDTO dto = new EmployeeDTO();
            dto.EmployeeName = managerName;
            dto.RankCode = managerRank;
            

            eDTOList.Add(dto);

            if (employeesList.RowCount > 0)
            {
                DataGridView dgv = (DataGridView)employeesList;

                for (int i = 0; i < dgv.RowCount; i++)
                {
                    EmployeeDTO Dto = new EmployeeDTO();
                    Dto.EmployeeName = dgv.Rows[i].Cells[0].Value.ToString();
                    Dto.RankCode = dgv.Rows[i].Cells[1].Value.ToString();
                    Dto.Rank = dgv.Rows[i].Cells[2].Value.ToString();

                    eDTOList.Add(Dto);
                }
            }
            
            return eDTOList;
        }


        public UserDTO UserLogin(string id, string pwd)
        {
            userDao = new UserDAO();
            UserDTO loginUser = userDao.Login(id, pwd);

            if (loginUser == null)
            {
                return null;
            }

            return loginUser;
        }


        public DialogResult OpneForm<T>(Form f = null,FormWindowState formState = FormWindowState.Normal) where T : Form, new()
        {
            
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    form.BringToFront();
                    return DialogResult.No;
                }
            }

            T frm = new T();
            frm.WindowState = FormWindowState.Normal;
            return frm.ShowDialog(f);

        }

        public bool FindPW(string txtID, string txtName, string txtManagerName)
        {
            UserDAO dao = new UserDAO();
            string to = dao.FindPW(txtID, txtName, txtManagerName);

            if (string.IsNullOrWhiteSpace(to))
            {
                return false;  
            }

            string newPwd = CreateNewPwd();
            dao.Dispose();
            try
            {
                SmtpClient client = new SmtpClient("smtp.naver.com", 587);
                client.EnableSsl = true; //SSL사용한다.
                client.UseDefaultCredentials = false; //시스템에 설정된 인증정보 사용하지 않겠다.
                client.Credentials = new NetworkCredential("kmop9112", "DREAM4052@");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage msg = new MailMessage(new MailAddress("kmop9112@naver.com"),
                                                  new MailAddress(to));
                msg.Subject = $"특허 데이터 분석 프로그램 메일";
                msg.Body = $"{txtID}님의 변경된 비밀번호는 : {newPwd} 입니다.";
                msg.SubjectEncoding = Encoding.UTF8;
                msg.BodyEncoding = Encoding.UTF8;
                //msg.IsBodyHtml;
                //msg.Attachments.Add();

                client.Send(msg);
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }

        }

        public string CreateNewPwd()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            sb.Append(rnd.Next(10,100).ToString().PadLeft(2,'0'));

            int num1 = rnd.Next(58, 123);

            char n1 = (char)num1;

            sb.Append(n1.ToString());

            int num2 = rnd.Next(58, 123);

            char n2 = (char)num2;

            sb.Append(rnd.Next(10, 100).ToString().PadLeft(2, '0'));

            sb.Append(n2.ToString());


            return sb.ToString();
        }

        public bool StoreRationalData(DataGridView dgv)
        {
            AnalysisDAO daoA = new AnalysisDAO();
            
            bool result = daoA.InsertDB(dgv);
    
            return result;
        }




        public bool LoadBaseDB()
        {
            DB = new DataTable();
            AnalysisDAO Adoa = new AnalysisDAO();
            bool result;

            // DB = Adao.BaseDB()

            return true;
        }


        public bool InsertReportInfo(ReportDTO rdto)
        {
            AnalysisDAO dao = new AnalysisDAO();

            return dao.insertReportInfo(rdto);
        }

        public DataTable CallReportDB(string reportNum)
        {
            AnalysisDAO dao = new AnalysisDAO();

            return dao.SelectedRportDB(reportNum);
        }

    }
}
