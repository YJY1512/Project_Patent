using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Project_Patent
{
    class UserDAO : IDisposable
    {
        string connStr = ConfigurationManager.ConnectionStrings["jyproject"].ConnectionString;
        MySqlConnection conn;

        public UserDAO()
        {
            conn = new MySqlConnection(connStr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public bool IDLookUP(string txtID)
        {
            string sql = $@"select count(UserID) from usercompany
                            where UserID = @UserID";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserID", txtID);
            conn.Open();

            int isRow = Convert.ToInt32(cmd.ExecuteScalar());

            return (isRow > 0); //true면 해당하는 정보가 존재, false 해당하는 정보가 없거나 틀린거임
        }

        public bool Insert(UserDTO user)
        {
            string sql = @"insert into usercompany (userID, userPW, userAddr1, userAddr2, userAddr3, userManger, managerPW, managerRank, managerPhone, managerEmail1, managerEmail2, managerEmail3, username)
                            values (@userID, @userPW, @userAddr1, @userAddr2, @userAddr3, @userManger, @managerPW, @managerRank, @managerPhone, @managerEmail1, @managerEmail2, @managerEmail3, @username)";
            MySqlCommand cmd1 = new MySqlCommand(sql, conn);
            cmd1.Parameters.AddWithValue("@userID", user.UserID);
            cmd1.Parameters.AddWithValue("@username", user.UserName);
            cmd1.Parameters.AddWithValue("@userPW", user.UserPW);
            cmd1.Parameters.AddWithValue("@userAddr1", user.UserAddr1);
            cmd1.Parameters.AddWithValue("@userAddr2", user.UserAddr2);
            cmd1.Parameters.AddWithValue("@userAddr3", user.UserAddr3);
            cmd1.Parameters.AddWithValue("@userManger", user.ManagerName);
            cmd1.Parameters.AddWithValue("@managerPW", user.ManagerPW);
            cmd1.Parameters.AddWithValue("@managerRank", user.ManagerRankCode);
            cmd1.Parameters.AddWithValue("@managerPhone", user.ManagerPhone);
            cmd1.Parameters.AddWithValue("@managerEmail1", user.Email1);
            cmd1.Parameters.AddWithValue("@managerEmail2", user.Email2);
            cmd1.Parameters.AddWithValue("@managerEmail3", user.Email3);

            conn.Open();
            int iRowAffect1 = cmd1.ExecuteNonQuery();


            sql = @"insert into employees(UserID, EmployeeName, Employeerank, isManager) 
                    values (@UserID, @EmployeeName, @Employeerank, @isManager)";

            MySqlCommand cmd2 = new MySqlCommand(sql, conn);
            cmd2.Parameters.Add("@UserID", MySqlDbType.String);
            cmd2.Parameters.Add("@EmployeeName", MySqlDbType.String);
            cmd2.Parameters.Add("@Employeerank", MySqlDbType.String);
            cmd2.Parameters.Add("@isManager", MySqlDbType.String);



            for (int i = 0; i < user.Employeeslist.Count; i++)
            {
                cmd2.Parameters["@UserID"].Value = user.UserID;
                cmd2.Parameters["@EmployeeName"].Value = user.Employeeslist[i].EmployeeName;
                cmd2.Parameters["@Employeerank"].Value = user.Employeeslist[i].RankCode;
                if (i == 0)
                {
                    cmd2.Parameters["@isManager"].Value = "Y";
                }
                else
                {
                    cmd2.Parameters["@isManager"].Value = "N";
                }

                cmd2.ExecuteNonQuery();
            }

            conn.Close();

            return (iRowAffect1 > 0);
        }
        public void Update()
        {

        }
        public void Delete()
        {

        }

        public UserDTO Login(string ID, string PW)
        {
            //로그인 창에서 입력 된 ID / PW 가 DB와 일치하면
            //UserDTO에 회원 정보직원 리스트, 작업 리스트를 모두 담아서 리턴

            UserDTO dto = new UserDTO();

            DataTable dt = new DataTable();
            string checkid;
            string sql = @"select userID, userPW, username, userAddr1, userAddr2, userAddr3, 
                            userManger, managerPW, u.managerRank, c.data, managerPhone, managerEmail1, managerEmail2, managerEmail3 
                            from usercompany u inner Join cmntable c on u.managerRank = c.code
                            where userID = @UserID and userPW = @UserPW";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserID", ID);
            cmd.Parameters.AddWithValue("@UserPW", PW);

            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            // userCompany 가져오기
            // 아이디 또는 비번이 하나라도 다르면 select 되는 값이 없음 null 값 반환

            if (!reader.Read())
            {
                return null;
            }
            // dto(UserDTO)에 데이터 넣기

            dto.UserID = reader["UserID"].ToString();
            dto.UserPW = reader["UserPW"].ToString();
            dto.UserName = reader["username"].ToString();
            dto.UserAddr1 = reader["userAddr1"].ToString();
            dto.UserAddr2 = reader["userAddr2"].ToString();
            dto.UserAddr3 = reader["userAddr3"].ToString();
            dto.ManagerName = reader["userManger"].ToString();
            dto.ManagerPW = reader["managerPW"].ToString();
            dto.ManagerRankCode = reader["managerRank"].ToString();

            dto.ManagerPhone = reader["managerPhone"].ToString();
            dto.Email1 = reader["managerEmail1"].ToString();
            dto.Email2 = reader["managerEmail2"].ToString();
            dto.Email3 = reader["managerEmail3"].ToString();

            // employeesList 가져오기

            sql = @"Select EmployeeName, e.Employeerank, c.data ,isManager, isCurrent
                        from employees e inner join cmntable c on e.Employeerank = c.code
                        where UserID = @UserID";
            checkid = reader["UserID"].ToString();
            MySqlCommand cmde = new MySqlCommand(sql, conn);
            cmde.Parameters.AddWithValue("@UserID", checkid);

            reader.Dispose();
            reader = cmde.ExecuteReader();

            EmployeeDTO edto;
            dto.Employeeslist = new List<EmployeeDTO>();

            while (reader.Read())
            {
                edto = new EmployeeDTO();

                edto.UserID = checkid;
                edto.EmployeeName = reader["EmployeeName"].ToString();
                edto.RankCode = reader["Employeerank"].ToString();
                edto.Rank = reader["data"].ToString();
                edto.Admin = reader["isManager"].ToString();
                edto.isCurrent = reader["isCurrent"].ToString();

                dto.Employeeslist.Add(edto);
            }

            // reportList 가져오기

            sql = @"Select reportno, UserID, EmployeeName, title, tech1Code, tech1, tech2Code, tech2, finalDate 
                        from report 
                        where UserID = @UserID";

            MySqlCommand cmdr = new MySqlCommand(sql, conn);
            cmdr.Parameters.AddWithValue("@UserID", checkid);

            reader.Dispose();
            reader = cmdr.ExecuteReader();

            ReportDTO rdto;
            dto.Reportlist = new List<ReportDTO>();

            while (reader.Read())
            {
                rdto = new ReportDTO();

                rdto.ReportNum = reader["reportno"].ToString();
                rdto.UserID = reader["UserID"].ToString();
                rdto.Writer = reader["EmployeeName"].ToString();
                rdto.Title = reader["title"].ToString();
                rdto.Tech1Code = reader["tech1Code"].ToString();
                rdto.Tech1 = reader["Tech1"].ToString();
                rdto.Tech2Code = reader["tech2Code"].ToString();
                rdto.Tech2 = reader["Tech2"].ToString();
                rdto.FinalDate = (DateTime)reader["FinalDate"];

                dto.Reportlist.Add(rdto);
            }

            conn.Close();
            return dto;
        }

        public string FindPW(string txtID, string txtName, string txtManagerName)
        {

            string sql = @"select managerEmail1, managerEmail2, managerEmail3 , data
                            from usercompany u inner Join cmntable c on u.managerEmail2 = c.code
                            where userID = @userID and username = @username and userManger = @userManger";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@userID", txtID);
            cmd.Parameters.AddWithValue("@username", txtName);
            cmd.Parameters.AddWithValue("@userManger", txtManagerName);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            if (reader["managerEmail2"].ToString() == "eml05")
            {
                return reader["managerEmail1"].ToString() + "@" + reader["managerEmail3"].ToString();
            }
            else
            {
                return reader["managerEmail1"].ToString() + "@" + reader["data"].ToString();
            }
        }

    }
}
