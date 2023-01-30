using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project_Patent
{
    public partial class Form_Rationalization : Form
    {
        Manager manager;
        List<int> years;
        int nullCount;
        public DataTable RationalDT { get; set; }
        public Form_Rationalization()
        {
            InitializeComponent();
        }

        private void Form_Rationalization_Load(object sender, EventArgs e)
        {
            years = new List<int>();
            // panel visible false
            pnlDivision1.Visible = pnlDivision2.Visible = pnlApplicant.Visible = pnlInOut.Visible = pnlIP4.Visible = false;
             
            pnlInOut.Location = pnlDivision2.Location = pnlApplicant.Location = pnlIP4.Location = pnlDivision1.Location;

            // 최대화를 이렇게?
            this.WindowState = FormWindowState.Maximized;
           
            // DataGridView 설정

            DataGridViewUtil.SetInitDataGridView(dgvBefore);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "번호", "no", colWidth: 70, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "Report", "ReportNum", align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "DB", "country", colWidth: 60, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "출원번호", "ApplicantNum");
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "출원일", "ApplicantDate", align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "출원인국적", "ApplicantCountry", colWidth: 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "대표출원코드", "Code1", colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);

            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "출원인", "Applicant");
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "출원인(영문)", "E_Applicant", colWidth: 120);

            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "제1출원인", "1_Applicant", colWidth: 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "제1출원인(영문)", "1E_Applicant", colWidth: 120);

            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "대표출원인(영문)", "RE_Applicant", colWidth: 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "대표출원인(국문)", "RK_Applicant", colWidth: 120);

            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "IP4", "4IP", colWidth: 50, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "국내외여부", "isInOut", colWidth: 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBefore, "유럽여부", "isEP");

            //datagridview2 설정
            DataGridViewUtil.SetInitDataGridView(dgvAfter);

            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "번호", "no", colWidth: 70, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "Report", "ReportNum", align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "출원인코드", "RCode", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "DB", "country", colWidth: 60, align: DataGridViewContentAlignment.MiddleCenter);
            //정비
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "정비_출원일", "_ApplicantDate", colWidth: 120, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "정비_구간1", "_DateDivision1", colWidth: 120, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "정비_구간2", "_DateDivision2", colWidth: 120, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "정비_출원인", "_Applicant", colWidth: 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "정비_내외국인", "_Applicant_FD", colWidth: 130, align: DataGridViewContentAlignment.MiddleCenter);
            //출원번호
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "IP4", "4IP", colWidth: 50, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "출원번호", "ApplicantNum");
            DataGridViewUtil.AddGridTextBoxColumn(dgvAfter, "출원인국적", "_ApplicantCountry", colWidth: 120);

            for (int i = 0; i < ((Form_Main)Owner).dt.Rows.Count; i++)
            {
                dgvBefore.Rows.Add();
                dgvBefore["no", i].Value = i + 1;
                //dgvBefore["ReportNum", i].Value = ((Form_Main)Owner).LoginedUser.Reportlist[0].ReportNum;
                dgvBefore["ReportNum", i].Value = "NoDB";
                dgvBefore["country", i].Value = ((Form_Main)Owner).dt.Rows[i]["국가코드"].ToString();

                dgvBefore["ApplicantNum", i].Value = ((Form_Main)Owner).dt.Rows[i]["출원번호"].ToString();
                dgvBefore["ApplicantDate", i].Value = ((Form_Main)Owner).dt.Rows[i]["출원일"].ToString();
                dgvBefore["ApplicantCountry", i].Value = ((Form_Main)Owner).dt.Rows[i]["출원인 국적"].ToString();
                dgvBefore["Code1", i].Value = ((Form_Main)Owner).dt.Rows[i]["출원인 대표명화 코드"].ToString();
                dgvBefore["Applicant", i].Value = ((Form_Main)Owner).dt.Rows[i]["출원인"].ToString();
                dgvBefore["E_Applicant", i].Value = ((Form_Main)Owner).dt.Rows[i]["R_출원인(영문)"].ToString();
                dgvBefore["1_Applicant", i].Value = ((Form_Main)Owner).dt.Rows[i]["R_제1출원인"].ToString();
                dgvBefore["1E_Applicant", i].Value = ((Form_Main)Owner).dt.Rows[i]["R_제1출원인(영문)"].ToString();
                dgvBefore["RE_Applicant", i].Value = ((Form_Main)Owner).dt.Rows[i]["R_제1대표출원인명칭(영문)"].ToString();
                dgvBefore["RK_Applicant", i].Value = ((Form_Main)Owner).dt.Rows[i]["R_제1대표출원인명칭(국문)"].ToString();
                dgvBefore["4IP", i].Value = ((Form_Main)Owner).dt.Rows[i]["R_패밀리4극여부"].ToString();
                dgvBefore["isInOut", i].Value = ((Form_Main)Owner).dt.Rows[i]["R_국내외출원여부"].ToString();
                dgvBefore["isEP", i].Value = ((Form_Main)Owner).dt.Rows[i]["R_유럽출원여부"].ToString();

                dgvAfter.Rows.Add();
                dgvAfter["no", i].Value = i + 1;
                //dgvAfter["ReportNum", i].Value = ((Form_Main)Owner).LoginedUser.Reportlist[0].ReportNum;
                dgvAfter["ReportNum", i].Value = "NoDB";
                dgvAfter["country", i].Value = ((Form_Main)Owner).dt.Rows[i]["국가코드"].ToString();
                dgvAfter["_ApplicantDate", i].Value = ((Form_Main)Owner).dt.Rows[i]["출원일"].ToString().Substring(0, 4);
                dgvAfter["_DateDivision1", i].Value = "";
                dgvAfter["_DateDivision2", i].Value = "";
                dgvAfter["_Applicant", i].Value = "";
                dgvAfter["_Applicant_FD", i].Value = "";
                dgvAfter["4IP", i].Value = "";
                dgvAfter["ApplicantNum", i].Value = ((Form_Main)Owner).dt.Rows[i]["출원번호"];
                if (string.IsNullOrWhiteSpace(((Form_Main)Owner).dt.Rows[i]["출원인 국적"].ToString().Split('|')[0].Trim()))
                {
                    dgvAfter["_ApplicantCountry", i].Value = ((Form_Main)Owner).dt.Rows[i]["국가코드"].ToString().Trim(); 
                }
                else
                {
                    dgvAfter["_ApplicantCountry", i].Value = ((Form_Main)Owner).dt.Rows[i]["출원인 국적"].ToString().Split('|')[0].Trim();
                }

                if (string.IsNullOrWhiteSpace(((Form_Main)Owner).dt.Rows[i]["출원인 대표명화 코드"].ToString()))
                {
                    dgvAfter["RCode", i].Value = i + 1;
                }
                else
                {
                    dgvAfter["RCode", i].Value = ((Form_Main)Owner).dt.Rows[i]["출원인 대표명화 코드"];
                }
                
                years.Add(Convert.ToInt32(((Form_Main)Owner).dt.Rows[i][2].ToString().Substring(0, 4)));

            }

            



            // 구간 판넬 데이터 정비 1
            // 비공개 구간 정비
            lblMaxYear.Text = DateTime.Now.Year.ToString();
            lblMinYear.Text = DateTime.Now.AddYears(-1).AddMonths(-6).Year.ToString();

            lblMaxYear2.Text = years.Max().ToString();
            int max = years.Max();
            lblMinYear2.Text = years.Min().ToString();
            int min = years.Min();

            for (int i = years.Min(); i <= years.Max(); i++)
            {
                comboBox2.Items.Add(i);
            }
            comboBox2.SelectedIndex = (max - min) / 2;

            // ComboBox 정립
            DataTable dtComboBox = new DataTable();

            dtComboBox.Columns.Add("display_headText");
            dtComboBox.Columns.Add("value_name");

            dtComboBox.Rows.Add("전체", "");

            for (int i = 5; i < dgvAfter.Columns.Count-1; i++)
            {
                dtComboBox.Rows.Add(dgvAfter.Columns[i].HeaderText, dgvAfter.Columns[i].Name);
            }

            cmbColumns.DisplayMember = dtComboBox.Columns[0].ColumnName;
            cmbColumns.ValueMember = dtComboBox.Columns[1].ColumnName;

            cmbColumns.DataSource = dtComboBox;
            cmbColumns.SelectedIndex = 0;

            // 구간 판넬 데이터 정비 2
            // 비공개 구간 정비
            lblMaxYear3.Text = DateTime.Now.Year.ToString();
            lblMinYear3.Text = DateTime.Now.AddYears(-1).AddMonths(-6).Year.ToString();

            lblMaxYear4.Text = years.Max().ToString();
            
            lblMinYear4.Text = years.Min().ToString();
            

            // 출원인 판넬

            // 내외국인 판넬

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////
            ///
              //콤보 박스 선택에 따른 데이터 보이는 컬럼 및 옆 화면
            for (int i = 0; i < dgvAfter.Columns.Count-2; i++)
            {
                if(i == 2) continue;
                dgvAfter.Columns[i].Visible = true;
            }

            if (cmbColumns.SelectedIndex == 0)
            {
                pnlDivision1.Visible = pnlDivision2.Visible = pnlApplicant.Visible = pnlInOut.Visible = pnlIP4.Visible = false;

                for (int i = 0; i < dgvAfter.Columns.Count-1; i++)
                {
                    if (i == 2) continue;
                    dgvAfter.Columns[i].Visible = true;
                }
                return;
            }
            
            for (int i = 2; i < dgvAfter.Columns.Count - 1; i++)
            {
                if (dgvAfter.Columns[i].Name != cmbColumns.SelectedValue.ToString())
                {
                    dgvAfter.Columns[i].Visible = false;
                }
            }

            switch (cmbColumns.SelectedValue.ToString())
            {

                case "_DateDivision1":
                    lblNullCount1.Text = Countnull(dgvAfter, cmbColumns.SelectedValue.ToString()).ToString();
                    pnlDivision1.Visible = true;
                    pnlDivision2.Visible = pnlInOut.Visible = pnlApplicant.Visible = pnlIP4.Visible = false;
                    pnlDivision1.BringToFront();

                    break;
                case "_DateDivision2":
                    lblNullCount2.Text = Countnull(dgvAfter, cmbColumns.SelectedValue.ToString()).ToString();
                    pnlDivision2.Visible = true;
                    pnlDivision1.Visible = pnlInOut.Visible = pnlApplicant.Visible = pnlIP4.Visible = false;
                    pnlDivision2.BringToFront();
                    lsbDivider.SelectedIndex = 0;

                    //출원인
                    // 출원인 판넬 정리
                    // 모두 Upper
                    // 대표 코드가 동일한 값은 동일한 출원인이 되어야 함
                    // 출원 국적 KR > 한국어
                    // 출원 국적 KR 외 > 영어
                    // (주), 주식회사, 유한회사 등 삭제
                    // . , ; 기호 삭제
                    // kkk In Co IN CO emd tkrwpr
                    // trim


                    break;
                case "_Applicant":
                    lblNullCount3.Text = Countnull(dgvAfter, cmbColumns.SelectedValue.ToString()).ToString();
                    pnlApplicant.Visible = true;
                    pnlDivision1.Visible = pnlInOut.Visible = pnlDivision2.Visible = pnlIP4.Visible = false;
                    pnlApplicant.BringToFront();

                    //내외국인
                    // 내외국인 판넬 정리
                    // 한국, 일본, 중국, 미국 의경우 출원인 국적 있으면 비교
                    // 유럽 > 유럽 기준이면 내국 switch  아니면 외국
                    // 빈값인경우 빨간색 보여주고 포커스
                    // 빨간색인 경우(출원인 국적이 없는 경우) > 발명자 국적 또는 없으면 어쩔수 ?
                    break;
                case "_Applicant_FD":
                    lblNullCount4.Text = Countnull(dgvAfter, cmbColumns.SelectedValue.ToString()).ToString();
                    pnlInOut.Visible = true;
                    pnlDivision1.Visible = pnlDivision2.Visible = pnlApplicant.Visible = pnlIP4.Visible = false;
                    pnlInOut.BringToFront();

                    break;
                case "4IP":
                    lblNullCount5.Text = Countnull(dgvAfter, cmbColumns.SelectedValue.ToString()).ToString();
                    pnlIP4.Visible = true;
                    pnlDivision1.Visible = pnlDivision2.Visible = pnlApplicant.Visible = pnlInOut.Visible = false;
                    pnlIP4.BringToFront();

                    break;
                default:
                    pnlIP4.Visible = pnlDivision1.Visible = pnlDivision2.Visible = pnlApplicant.Visible = pnlInOut.Visible = false;

                    break;
            }
        }

        public int Countnull(DataGridView dgv, string ColumName)
        {
            int result = 0;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
               if (string.IsNullOrWhiteSpace(dgv[ColumName, i].Value.ToString()))
                {
                    result++;
                }
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAfter.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvAfter["_ApplicantDate", i].Value.ToString()) >= Convert.ToInt32(lblMinYear.Text))
                {
                    dgvAfter["_DateDivision1", i].Value = "비공개";
                }
                else if (Convert.ToInt32(dgvAfter["_ApplicantDate", i].Value.ToString()) > Convert.ToInt32(comboBox2.SelectedItem.ToString()))
                {
                    dgvAfter["_DateDivision1", i].Value = "최근";
                }
                else
                {
                    dgvAfter["_DateDivision1", i].Value = "과거";
                }
            }

            lblNullCount1.Text = Countnull(dgvAfter, cmbColumns.SelectedValue.ToString()).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 구분 나누기....
            int divider = Convert.ToInt32(lsbDivider.SelectedItem.ToString());
            int max = Convert.ToInt32(lblMaxYear4.Text);
            int min = Convert.ToInt32(lblMinYear4.Text);
            int mm = (max - min + 1) % divider;
            int n = (max-min+1) / divider;
            int[] d = new int[divider-1];

            for (int i = 0; i < d.Length; i++)
            {
                d[i] = min + (n*(i+1));
            }

            for (int i = 0; i < mm; i++)
            {
                for (int j = i; j < d.Length; j++)
                {
                    d[j] = d[j] + 1;
                }
            }

            for (int r = 0; r < dgvAfter.Rows.Count; r++)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    if (Convert.ToInt32(dgvAfter["_ApplicantDate", r].Value.ToString()) >= Convert.ToInt32(lblMinYear3.Text) && Convert.ToInt32(dgvAfter["_ApplicantDate", r].Value.ToString()) <= Convert.ToInt32(lblMaxYear3.Text))
                    {
                        dgvAfter["_DateDivision2", r].Value = "비공개";
                        continue;
                    }

                    if (Convert.ToInt32(dgvAfter["_ApplicantDate", r].Value.ToString()) < d[i])
                    {
                        dgvAfter["_DateDivision2", r].Value = $"{i + 1}구간";
                        break;
                    }
                    else
                    {
                        dgvAfter["_DateDivision2", r].Value = $"{i + 2}구간";
                    }
                }
            }
            lblNullCount2.Text = Countnull(dgvAfter, cmbColumns.SelectedValue.ToString()).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 출원인(최종 보스)
            for (int r = 0; r < dgvAfter.Rows.Count; r++)
            {
                if (lsbRemoveList.Items.Count == 0)
                {
                    MessageBox.Show("삭제할 단어가 없습니다.");
                    return;
                }

                for (int i = 0; i < lsbRemoveList.Items.Count; i++)
                {
                    dgvAfter["_Applicant", r].Value = dgvAfter["_Applicant", r].Value.ToString().Split('|')[0].Trim();
                    dgvAfter["_Applicant", r].Value = dgvAfter["_Applicant", r].Value.ToString().Replace(lsbRemoveList.Items[i].ToString(), "").Trim();
                    dgvAfter["_Applicant", r].Value = dgvAfter["_Applicant", r].Value.ToString().Trim();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 내외국인

            string check;

            for (int r = 0; r < dgvAfter.Rows.Count; r++)
            {
                check = dgvBefore["isInOut", r].Value.ToString().Split('|')[0].Trim();

                if (string.IsNullOrWhiteSpace(check))
                {
                    check = IsInOut(r);
                }
                
                dgvAfter["_Applicant_FD", r].Value = check;
                   
            }
            lblNullCount4.Text = Countnull(dgvAfter, cmbColumns.SelectedValue.ToString()).ToString();
        }

        public string IsInOut(int rowNum)
        {

            if (string.IsNullOrWhiteSpace(dgvBefore["ApplicantCountry", rowNum].Value.ToString()))
            {
                if (string.IsNullOrWhiteSpace(dgvBefore["isInOut", rowNum].Value.ToString()))
                {
                    return "내국";
                }
                else
                {
                    if ((dgvBefore["isEP", rowNum].Value.ToString().Trim() == "유럽") && (dgvBefore["country", rowNum].Value.ToString().Trim() == "EP"))
                    {
                        return "내국";
                    }
                    else
                    {
                        return "외국";
                    }
                }
            }
            else
            {
                if (dgvBefore["isEP", rowNum].Value.ToString().Split('|')[0].Trim() == dgvBefore["country", rowNum].Value.ToString().Trim())
                {
                    return "내국";
                }
                else
                {
                    return "외국";
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string yesOrNo;
            for (int r = 0; r < dgvAfter.Rows.Count; r++)
            {
                if (string.IsNullOrWhiteSpace(dgvBefore["4IP", r].Value.ToString().Split('|')[0].Trim()))
                {
                    yesOrNo = "N";
                }
                else
                {
                    yesOrNo = dgvBefore["4IP", r].Value.ToString().Split('|')[0].Trim();
                }
                dgvAfter["4IP", r].Value = yesOrNo;
            }
            lblNullCount5.Text = Countnull(dgvAfter, cmbColumns.SelectedValue.ToString()).ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            RationalDT = new DataTable();
            for (int r = 0; r < dgvAfter.Rows.Count; r++)
            {
                for (int c = 0; c < dgvAfter.Columns.Count; c++)
                {
                    if (string.IsNullOrWhiteSpace(dgvAfter[c, r].Value.ToString()))
                    {
                        dgvAfter[c, r].Style.BackColor = Color.Red;
                        nullCount++;
                    }
                }
            }

            if (nullCount != 0)
            {
                MessageBox.Show($"정비되지 않은 데이터가 {nullCount}개 있습니다.");
                nullCount = 0;
                return;
            }
            


            // DataTable 변환
            for (int c = 0; c < dgvAfter.Columns.Count; c++)
            {
                DataColumn dtCol = new DataColumn();
                dtCol.ColumnName = dgvAfter.Columns[c].Name;
                if (dgvAfter.Columns[c].Name == "no")
                {
                    dtCol.DataType = typeof(int);
                }
                else
                {
                    dtCol.DataType = typeof(string);
                }
                
                RationalDT.Columns.Add(dtCol);
            }


            for (int r = 0; r < dgvAfter.Rows.Count; r++)
            {
                DataRow dataRow = RationalDT.NewRow();
                dataRow["no"] = dgvAfter["no", r].Value;
                dataRow["ReportNum"] = dgvAfter["ReportNum", r].Value;
                dataRow["RCode"] = dgvAfter["RCode", r].Value;
                dataRow["country"] = dgvAfter["country", r].Value;
                dataRow["_ApplicantDate"] = dgvAfter["_ApplicantDate", r].Value;
                dataRow["_DateDivision1"] = dgvAfter["_DateDivision1", r].Value;
                dataRow["_DateDivision2"] = dgvAfter["_DateDivision2", r].Value;
                dataRow["_Applicant"] = dgvAfter["_Applicant", r].Value;
                dataRow["_Applicant_FD"] = dgvAfter["_Applicant_FD", r].Value;
                dataRow["4IP"] = dgvAfter["4IP", r].Value;
                dataRow["ApplicantNum"] = dgvAfter["ApplicantNum", r].Value;
                dataRow["_ApplicantCountry"] = dgvAfter["_ApplicantCountry", r].Value;

                RationalDT.Rows.Add(dataRow);
            }


            // 메인 화면 DGV에 넣기
            ((Form_Main)Owner).R_DataTable = RationalDT;



            // 디비에 저장
            manager = new Manager();
            
            
            //bool result = manager.StoreRationalData(dgvAfter);

            //if (result)
            //{
            //    MessageBox.Show("정비된 데이터를 저장하였습니다.");
            //}
            //else
            //{
            //    MessageBox.Show("정비된 데이터를 저장하는데 실패하였습니다.");
            //}



            

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void dgvAfter_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dgvAfter[e.ColumnIndex, e.RowIndex].Value.ToString()))
            {
                dgvAfter[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
            }
        }

        private void btnApplicantAuto_Click(object sender, EventArgs e)
        {
            Regex regex;

            for (int r = 0; r < dgvAfter.Rows.Count; r++)
            {
                // 코드 유무
                
                if (!string.IsNullOrWhiteSpace(dgvBefore["Code1", r].Value.ToString()))
                {
                    // 코드 유
                    // 한국인 외국인 확인
                    if (dgvBefore["ApplicantCountry", r].Value.ToString().Split('|')[0].Trim() == "KR") 
                    {
                        // 한국 > RK
                        dgvAfter["_Applicant", r].Value = dgvBefore["RK_Applicant", r].Value.ToString().Trim();
                    }
                    else
                    {
                        // 외국 > EK
                        dgvAfter["_Applicant", r].Value = dgvBefore["RE_Applicant", r].Value.ToString().ToUpper().Trim();
                    }
                }
                else
                {
                    //코드 무
                    // 1 출원인 ( 또는 한글인 경우 > 1출원인
                    regex = new Regex(@"^[ㄱ-ㅎ가-힣]");
                    if (regex.IsMatch(dgvBefore["1_Applicant", r].Value.ToString()))
                    {
                        // 한글
                        dgvAfter["_Applicant", r].Value = dgvBefore["1_Applicant", r].Value.ToString().Trim();
                    }
                    else
                    {
                        // 한글이 아님
                        dgvAfter["_Applicant", r].Value = dgvBefore["1E_Applicant", r].Value.ToString().ToUpper().Trim();
                    }
                }

                if (string.IsNullOrWhiteSpace(dgvAfter["_Applicant", r].Value.ToString()))
                {
                    dgvAfter["_Applicant", r].Value = dgvBefore["E_Applicant", r].Value.ToString().ToUpper().Trim();
                }

            }
            lblNullCount3.Text = Countnull(dgvAfter, cmbColumns.SelectedValue.ToString()).ToString();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRWord.Text.ToUpper().Trim()))
            {
                MessageBox.Show($"{txtRWord.Text.ToUpper().Trim()}추가할 단어가 없습니다.");
                return;
            }
            lsbRemoveList.Items.Add(txtRWord.Text);
            lsbRemoveList.ClearSelected();
            MessageBox.Show("추가 했습니다.");
        }

        private void btnDellWord_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(lsbRemoveList.SelectedItem.ToString()))
            {
                MessageBox.Show("선택된 단어가 없습니다.");
                return;
            }
            MessageBox.Show($"{lsbRemoveList.SelectedItem.ToString()}삭제 했습니다.");
            lsbRemoveList.Items.Remove(lsbRemoveList.SelectedItem);
            lsbRemoveList.ClearSelected();
        }

        private void dgvAfter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                dgvAfter[e.ColumnIndex, e.RowIndex].ReadOnly = false;
            
        }
    }
}
