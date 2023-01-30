using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project_Patent
{
    class AnalysisDAO
    {
        string connStr = ConfigurationManager.ConnectionStrings["jyproject"].ConnectionString;
        MySqlConnection conn;

        public AnalysisDAO()
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

        public bool InsertDB(DataGridView dgv) //
        {
            string sql = @"insert into rationaldata(ReportNum, no, Country, _ApplicantDate, _DateDivision1, _DateDivision2, 
                                                    _Applicant, _Applicant_FD, 4IP, ApplicantNum, RCode, _ApplicantCountry) 
                            values(@ReportNum, @no, @Country, @_ApplicantDate, @_DateDivision1, @_DateDivision2, 
                                                    @_Applicant, @_Applicant_FD, @4IP, @ApplicantNum, @RCode, @_ApplicantCountry);";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@ReportNum", MySqlDbType.String);
            cmd.Parameters.Add("@no", MySqlDbType.Int32);
            cmd.Parameters.Add("@Country", MySqlDbType.String);
            cmd.Parameters.Add("@_ApplicantDate", MySqlDbType.String);
            cmd.Parameters.Add("@_DateDivision1", MySqlDbType.String);
            cmd.Parameters.Add("@_DateDivision2", MySqlDbType.String);
            cmd.Parameters.Add("@_Applicant", MySqlDbType.String);
            cmd.Parameters.Add("@_Applicant_FD", MySqlDbType.String);
            cmd.Parameters.Add("@4IP", MySqlDbType.String);
            cmd.Parameters.Add("@ApplicantNum", MySqlDbType.String);
            cmd.Parameters.Add("@RCode", MySqlDbType.String);
            cmd.Parameters.Add("@_ApplicantCountry", MySqlDbType.String);

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                cmd.Parameters["@ReportNum"].Value = dgv["ReportNum", i].Value.ToString();

                cmd.Parameters["@no"].Value = Convert.ToInt32(dgv["no", i].Value);
                cmd.Parameters["@country"].Value = dgv["country", i].Value.ToString();
                cmd.Parameters["@_ApplicantDate"].Value = dgv["_ApplicantDate", i].Value.ToString();
                cmd.Parameters["@_DateDivision1"].Value = dgv["_DateDivision1", i].Value.ToString();
                cmd.Parameters["@_DateDivision2"].Value = dgv["_DateDivision2", i].Value.ToString();
                cmd.Parameters["@_Applicant"].Value = dgv["_Applicant", i].Value.ToString();
                cmd.Parameters["@_Applicant_FD"].Value = dgv["_Applicant_FD", i].Value.ToString();
                cmd.Parameters["@4IP"].Value = dgv["4IP", i].Value.ToString();
                cmd.Parameters["@ApplicantNum"].Value = dgv["ApplicantNum", i].Value.ToString();
                cmd.Parameters["@RCode"].Value = dgv["RCode", i].Value.ToString();
                cmd.Parameters["@_ApplicantCountry"].Value = dgv["_ApplicantCountry", i].Value.ToString();
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            return true;
        }


        public DataSet CountryTotal()
        {
            DataSet ds = new DataSet();

            string sql = @"select 
                        	    sum(case when `국가코드` = 'KR' then 1 Else 0 end) as 'KR',
                                sum(case when `국가코드` = 'JP' then 1 Else 0 end) as 'JP',
                        	    sum(case when `국가코드` = 'US' then 1 Else 0 end) as 'US',
                                sum(case when `국가코드` = 'EP' then 1 Else 0 end) as 'EP',
                        	    sum(case when `국가코드` = 'CN' then 1 Else 0 end) as 'CN'
                            from testargdb;";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.Fill(ds);
            return ds;
        }


        public DataSet RationalizedDataSet()
        {
            DataSet ds = new DataSet();


            string sql = @"select `정비_출원일` as Years,
                            	sum(case when `국가코드` = 'KR' then cnt Else 0 end) as 'KR',
                                sum(case when `국가코드` = 'JP' then cnt Else 0 end) as 'JP',
                            	sum(case when `국가코드` = 'US' then cnt Else 0 end) as 'US',
                                sum(case when `국가코드` = 'EP' then cnt Else 0 end) as 'EP',
                            	sum(case when `국가코드` = 'CN' then cnt Else 0 end) as 'CN'
                            from 
                            	(select `국가코드`,`정비_출원일`, if((count(*) = 0), 0 , count(*)) as cnt
                            	from testargdb
                            	group by `정비_출원일`,`국가코드`) Origin
                            where `정비_출원일` between '2010' AND '2022'
                            group by `정비_출원일`
                            order by 1;";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.Fill(ds);

            return ds;
        }

        public DataSet ApplicantInOut()
        {
            DataSet ds = new DataSet();


            string sql = @"select `정비_내외국인` as Applicant,
                            	sum(case when `국가코드` = 'KR' then cnt Else 0 end) as 'KR',
                                sum(case when `국가코드` = 'JP' then cnt Else 0 end) as 'JP',
                            	sum(case when `국가코드` = 'US' then cnt Else 0 end) as 'US',
                                sum(case when `국가코드` = 'EP' then cnt Else 0 end) as 'EP',
                            	sum(case when `국가코드` = 'CN' then cnt Else 0 end) as 'CN'
                            from 
                                (select `국가코드`,`정비_내외국인`, if((count(*) = 0), 0 , count(*)) as cnt
                                from testargdb
                                group by `정비_내외국인`,`국가코드`) Origin
                            group by `정비_내외국인`
                            order by 1;";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.Fill(ds);

            return ds;
        }

        public bool insertReportInfo(ReportDTO rdto)
        {
            string sql = @"Insert into report(reportno, UserID, EmployeeName, title, tech1Code, tech2Code, finalDate, tech1, tech2) 
                        values (@reportno, @UserID, @EmployeeName, @title, @tech1Code, @tech2Code, @finalDate, @tech1, @tech2)";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@reportno", rdto.ReportNum);
            cmd.Parameters.AddWithValue("@UserID", rdto.UserID);
            cmd.Parameters.AddWithValue("@EmployeeName", rdto.Writer);
            cmd.Parameters.AddWithValue("@title", rdto.Title);
            cmd.Parameters.AddWithValue("@tech1Code", rdto.Tech1Code);
            cmd.Parameters.AddWithValue("@tech1", rdto.Tech1);
            cmd.Parameters.AddWithValue("@tech2Code", rdto.Tech2Code);
            cmd.Parameters.AddWithValue("@tech2", rdto.Tech2);
            cmd.Parameters.AddWithValue("@finalDate", rdto.FinalDate);

            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return (result > 0);
        }

        public DataTable SelectedRportDB(string reportNum)
        {
            DataTable dt = new DataTable();
            string sql = @"select ReportNum, no, Country, _ApplicantDate, _DateDivision1, _DateDivision2, _Applicant, 
                                    _Applicant_FD, 4IP, ApplicantNum, RCode, _ApplicantCountry 
                            from rationaldata where ReportNum = @ReportNum";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@ReportNum", reportNum);

            da.Fill(dt);

            return dt;
        }

        public DataTable YearCountry()
        {
            DataTable dt = new DataTable();

            string sql = @"select sum(case when `정비_출원일` = '2011' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2011',
                            		sum(case when `정비_출원일` = '2012' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2012',
                                    sum(case when `정비_출원일` = '2013' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2013',
                            		sum(case when `정비_출원일` = '2014' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2014',
                                    sum(case when `정비_출원일` = '2015' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2015',
                            		sum(case when `정비_출원일` = '2016' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2016',
                                    sum(case when `정비_출원일` = '2017' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2017',
                            		sum(case when `정비_출원일` = '2018' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2018',
                                    sum(case when `정비_출원일` = '2019' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2019',
                            		sum(case when `정비_출원일` = '2020' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2020',
                                    sum(case when `정비_출원일` = '2021' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2021',
                            		sum(case when `정비_출원일` = '2022' and `국가코드` = 'KR' THEN 1 ELSE 0 End) as '2022' FROM testargdb
                            UNION
                            select sum(case when `정비_출원일` = '2011' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2011',
                            		sum(case when `정비_출원일` = '2012' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2012',
                                    sum(case when `정비_출원일` = '2013' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2013',
                            		sum(case when `정비_출원일` = '2014' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2014',
                                    sum(case when `정비_출원일` = '2015' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2015',
                            		sum(case when `정비_출원일` = '2016' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2016',
                                    sum(case when `정비_출원일` = '2017' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2017',
                            		sum(case when `정비_출원일` = '2018' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2018',
                                    sum(case when `정비_출원일` = '2019' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2019',
                            		sum(case when `정비_출원일` = '2020' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2020',
                                    sum(case when `정비_출원일` = '2021' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2021',
                            		sum(case when `정비_출원일` = '2022' and `국가코드` = 'JP' THEN 1 ELSE 0 End) as '2022' FROM testargdb
                            UNION
                            select sum(case when `정비_출원일` = '2011' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2011',
                            		sum(case when `정비_출원일` = '2012' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2012',
                                    sum(case when `정비_출원일` = '2013' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2013',
                            		sum(case when `정비_출원일` = '2014' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2014',
                                    sum(case when `정비_출원일` = '2015' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2015',
                            		sum(case when `정비_출원일` = '2016' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2016',
                                    sum(case when `정비_출원일` = '2017' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2017',
                            		sum(case when `정비_출원일` = '2018' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2018',
                                    sum(case when `정비_출원일` = '2019' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2019',
                            		sum(case when `정비_출원일` = '2020' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2020',
                                    sum(case when `정비_출원일` = '2021' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2021',
                            		sum(case when `정비_출원일` = '2022' and `국가코드` = 'US' THEN 1 ELSE 0 End) as '2022' FROM testargdb
                            UNION
                            select sum(case when `정비_출원일` = '2011' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2011',
                            		sum(case when `정비_출원일` = '2012' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2012',
                                    sum(case when `정비_출원일` = '2013' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2013',
                            		sum(case when `정비_출원일` = '2014' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2014',
                                    sum(case when `정비_출원일` = '2015' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2015',
                            		sum(case when `정비_출원일` = '2016' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2016',
                                    sum(case when `정비_출원일` = '2017' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2017',
                            		sum(case when `정비_출원일` = '2018' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2018',
                                    sum(case when `정비_출원일` = '2019' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2019',
                            		sum(case when `정비_출원일` = '2020' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2020',
                                    sum(case when `정비_출원일` = '2021' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2021',
                            		sum(case when `정비_출원일` = '2022' and `국가코드` = 'EP' THEN 1 ELSE 0 End) as '2022' FROM testargdb
                            UNION
                            select sum(case when `정비_출원일` = '2011' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2011',
                            		sum(case when `정비_출원일` = '2012' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2012',
                                    sum(case when `정비_출원일` = '2013' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2013',
                            		sum(case when `정비_출원일` = '2014' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2014',
                                    sum(case when `정비_출원일` = '2015' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2015',
                            		sum(case when `정비_출원일` = '2016' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2016',
                                    sum(case when `정비_출원일` = '2017' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2017',
                            		sum(case when `정비_출원일` = '2018' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2018',
                                    sum(case when `정비_출원일` = '2019' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2019',
                            		sum(case when `정비_출원일` = '2020' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2020',
                                    sum(case when `정비_출원일` = '2021' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2021',
                            		sum(case when `정비_출원일` = '2022' and `국가코드` = 'CN' THEN 1 ELSE 0 End) as '2022' FROM testargdb
                            UNION
                            select sum(case when `정비_출원일` = '2011' THEN 1 ELSE 0 End) as '2011',
                            		sum(case when `정비_출원일` = '2012' THEN 1 ELSE 0 End) as '2012',
                                    sum(case when `정비_출원일` = '2013' THEN 1 ELSE 0 End) as '2013',
                            		sum(case when `정비_출원일` = '2014' THEN 1 ELSE 0 End) as '2014',
                                    sum(case when `정비_출원일` = '2015' THEN 1 ELSE 0 End) as '2015',
                            		sum(case when `정비_출원일` = '2016' THEN 1 ELSE 0 End) as '2016',
                                    sum(case when `정비_출원일` = '2017' THEN 1 ELSE 0 End) as '2017',
                            		sum(case when `정비_출원일` = '2018' THEN 1 ELSE 0 End) as '2018',
                                    sum(case when `정비_출원일` = '2019' THEN 1 ELSE 0 End) as '2019',
                            		sum(case when `정비_출원일` = '2020' THEN 1 ELSE 0 End) as '2020',
                                    sum(case when `정비_출원일` = '2021' THEN 1 ELSE 0 End) as '2021',
                            		sum(case when `정비_출원일` = '2022' THEN 1 ELSE 0 End) as '2022' FROM testargdb;";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.Fill(dt);

            return dt;
        }

    }
}
