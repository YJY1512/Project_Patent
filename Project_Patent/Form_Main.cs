using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.IO;
using ExcelDataReader;

namespace Project_Patent
{
    public partial class Form_Main : Form
    {
        DataTableCollection dtCollection;
        Manager manager;
        List<string> selectedCols;

        public UserDTO LoginedUser { get; set; }
        public string LoginedEmployee { get; set; } // 직책 이름
        public DataTable dt { get; set; } 
        public DataTable R_DataTable { get; set; }

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            selectedCols = new List<string>();

            // panal2 제어

            Size screenSize = Screen.PrimaryScreen.Bounds.Size;
            
            panel2.Location = new Point((screenSize.Width / 2) - (panel2.Size.Width / 2), (screenSize.Height/2)-(panel2.Size.Height/2));
            dgvRawDataView.BringToFront();
            panel2.Visible = false;

            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Items.Clear();
            
            listBox2.SelectionMode = SelectionMode.MultiSimple;
            listBox2.Items.Clear();



            //버튼 제어
            btnDataChoice.Enabled = true;
            btnRationalization.Enabled = true;
            btnAnalysis.Enabled = true;


            //btnDataChoice.Enabled = false;
            //btnRationalization.Enabled = false;
            //btnAnalysis.Enabled = false;
            //btn_SaveDB.Enabled = false;



            this.Visible = false;
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog(this);

            //if (form_Login.DialogResult != DialogResult.OK)
            //{
            //    Application.Exit();
            //}

            this.Visible = true;

            //// 초기 설정
            //// 시간
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd");

            timer1.Interval = 1000;
            timer1.Enabled = true;

            // 프로젝트 정보 숨기기
            // 데이터 가져오면 그때 보여주고, 프로젝트 종료 버튼 누르면 숨기기
            pnlDataInfo.Visible = false;

            //// 일반 직원의 경우 관리자 버튼 숨기기
            //if (this.LoginedUser.ManagerName != this.LoginedEmployee.Split(' ')[1])
            //{
            //    btnAdmin.Visible = false;
            //    lblIsManager.Visible = false;
            //}

            //// 회사이름 / 로그인 직원 / 직책  / 관리자 표시 보여주기
            //lblCompanyName.Text = this.LoginedUser.UserName;
            //string r = this.LoginedEmployee.Split(' ')[0];
            //lblLoginedRank.Text = r;
            //string n = this.LoginedEmployee.Split(' ')[1];
            //lblLoginedEmployee.Text = n;

            manager = new Manager();

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            //데이터 정보 창 열어서 데이터 가져오기

            //DialogResult dialogResult = manager.OpneForm<Form_ReportInfo>(this);
            DialogResult dialogResult = manager.OpneForm<Form_ReportInfo>();
            //if (dialogResult != DialogResult.OK)
            //{
            //    MessageBox.Show("데이터가 입력 되지 않았습니다.");
            //    return;
            //}

            // 엑셀 Raw 데이터 가져오기

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 다음 순서 버튼 보여주기
                btnDataChoice.Enabled = true;

                // 보고서 정보 panal
                //lblReportTitle.Text = LoginedUser.Reportlist[0].Title;
                //lblReportTeck1.Text = LoginedUser.Reportlist[0].Tech1.ToString();
                //lblReportTeck2.Text = LoginedUser.Reportlist[0].Tech2.ToString();
                //lblReportFinalDay.Text = LoginedUser.Reportlist[0].FinalDate.ToString("yyyy-MM-dd");
                //lblReportD_Day.Text = "D_" + (LoginedUser.Reportlist[0].FinalDate.Day - DateTime.Now.Day).ToString();

                // 엑셀 데이터
                cmbDataSheet.Items.Clear();
                cmbDataSheet.Text = "";
                txtRawDataPath.Text = openFileDialog1.FileName;

                using(var stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    if (Path.GetExtension(openFileDialog1.FileName).ToUpper() == ".XLS"
                        || Path.GetExtension(openFileDialog1.FileName).ToUpper() == ".XLSX")
                    {
                        cmbDataSheet.Enabled = true;
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    EmptyColumnNamePrefix = "Colum",
                                    UseHeaderRow = true
                                }
                            });
                            // 데이터 더 가져올수 있음
                            dt = result.Tables[0];
                            dgvRawDataView.DataSource = dt;
                            dtCollection = result.Tables;

                            foreach (DataTable table in dtCollection)
                            {
                                cmbDataSheet.Items.Add(table.TableName);
                            }

                            cmbDataSheet.Enabled = true;
                            cmbDataSheet.SelectedIndex = 0;
                        }
                    }
                }
                pnlDataInfo.Visible = true;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = manager.OpneForm<Form_Manager>();
            if (result == DialogResult.OK)
            {
                btnAnalysis.Enabled = true;
                btn_SaveDB.Enabled = true;
                dgvRawDataView.DataSource = R_DataTable;
            }           
        }

        private void btnRationalization_Click(object sender, EventArgs e)
        {
            btnDataChoice.Enabled = false;
            DialogResult result = manager.OpneForm<Form_Rationalization>(this);

            if (result == DialogResult.OK)
            {
                if (R_DataTable == null)
                {
                    MessageBox.Show("정비된 파일이 없습니다.");
                    return;
                }
                dgvRawDataView.DataSource = R_DataTable;
                dgvRawDataView.Update();
            }
          
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            btnRationalization.Enabled = false;
            manager.OpneForm<Form_Analysis>(this);
            btn_SaveDB.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("t");
        }

        private void btnDataChoice_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                MessageBox.Show("데이터가 없습니다. 확인해 주세요");
                return;
            }

            List<string> colList = new List<string>();

            dt = (DataTable)(dgvRawDataView.DataSource);

            panel2.Visible = true;
            panel2.BringToFront();

            foreach (DataColumn dtcolumns in dt.Columns)
            {
                switch (dtcolumns.ToString())
                {
                    case "국가코드": listBox2.Items.Add(dtcolumns.ToString()); break; 
                    case "출원번호": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "출원인 국적": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "출원일": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "출원인": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "R_출원인(영문)": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "R_제1출원인": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "R_제1출원인(영문)": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "R_제1대표출원인명칭(국문)": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "R_제1대표출원인명칭(영문)": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "출원인 대표명화 코드": listBox2.Items.Add(dtcolumns.ToString()); break; 
                    case "R_패밀리4극여부": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "R_유럽출원여부": listBox2.Items.Add(dtcolumns.ToString()); break;
                    case "R_국내외출원여부": listBox2.Items.Add(dtcolumns.ToString()); break;
                    default: listBox1.Items.Add(dtcolumns.ToString()); break;
                }
            }

            lblLeft.Text = listBox1.Items.Count.ToString();
            lblRight.Text = listBox2.Items.Count.ToString();

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
           if (listBox1.SelectedItems.Count == 0 )
            {
                MessageBox.Show("선택된 값이 없습니다.");
                return;
            }

            for (int i = 0; i < listBox1.SelectedItems.Count;)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i].ToString());
                listBox1.Items.Remove(listBox1.SelectedItems[i].ToString());
            }
            RefreshColumns();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count != 0)
            {
                listBox1.ClearSelected();
            }

            if (listBox2.SelectedIndex >= 0 && listBox2.SelectedIndex <= 8)
            {
                MessageBox.Show($"{listBox2.SelectedItem.ToString()}는(은) 필수 영입니다.");
                listBox2.ClearSelected();
                return;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("선택된 값이 없습니다.");
                return;
            }

            for (int i = 0; i < listBox2.SelectedItems.Count;)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i].ToString());
                listBox2.Items.Remove(listBox2.SelectedItems[i].ToString());
            }
            RefreshColumns();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSelectedDataSave_Click(object sender, EventArgs e)
        {
            //설정
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            panel2.Visible = false;
            this.BringToFront();

            //데이터 정비;
            // 삭제할 ListBox1의 컬럼 명을 저장
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                dt.Columns.Remove(listBox1.Items[i].ToString());
            }
            listBox1.Dispose();

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                selectedCols.Add(listBox2.Items[i].ToString());
            }

            //    // Rationalization 폼에서 사용할수 있도록 하기



            //    // 다음 단계 보여주기
            btnRationalization.Enabled = true;

            btnAnalysis.Enabled = true;

        }

        public void RefreshColumns()
        {
            lblLeft.Text = listBox1.Items.Count.ToString();
            lblRight.Text = listBox2.Items.Count.ToString();
        }

        private void btn_SaveDB_Click(object sender, EventArgs e)
        {
            dgvRawDataView.DataSource = null;
            dgvRawDataView.DataSource = R_DataTable;

            dgvRawDataView.Update();

            string templateFile = Application.StartupPath + "\\Templates\\Rationalizwion_DB.xlsx";
            if (!File.Exists(templateFile))
            {
                MessageBox.Show("파일 양식이 존재하지 않습니다. 확인하여 주십시오.");
                return;
            }

            //
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel Files(*.xls)|*.xls";
            dlg.Title = "DB";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //DataTable dt = (DataTable)dgvList.DataSource;
                string errMsg = ExcelExportAccount(R_DataTable, templateFile, dlg.FileName);
                //dt, templateFile, dlg.FileName);
                if (string.IsNullOrEmpty(errMsg))
                {
                    MessageBox.Show("DB 저장 완료");
                }
                else
                {
                    MessageBox.Show(errMsg);
                }
            }
        }

        public string ExcelExportAccount(DataTable dt, string templateFile, string fileName)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(templateFile);
            Excel.Worksheet xlWorksheet = xlWorkBook.Worksheets.get_Item(1);

            try
            {
                //데이터를 찍어준다.
                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    xlWorksheet.Cells[r+2, 1] = dt.Rows[r]["no"].ToString();
                    xlWorksheet.Cells[r + 2, 2] = dt.Rows[r]["Country"].ToString();
                    xlWorksheet.Cells[r + 2, 3] = dt.Rows[r]["_ApplicantDate"].ToString();
                    xlWorksheet.Cells[r + 2, 4] = dt.Rows[r]["_DateDivision1"].ToString();
                    xlWorksheet.Cells[r + 2, 5] = dt.Rows[r]["_DateDivision2"].ToString();
                    xlWorksheet.Cells[r + 2, 6] = dt.Rows[r]["_Applicant"].ToString();
                    xlWorksheet.Cells[r + 2, 7] = dt.Rows[r]["_Applicant_FD"].ToString();
                    xlWorksheet.Cells[r + 2, 8] = dt.Rows[r]["4IP"].ToString();
                    xlWorksheet.Cells[r + 2, 9] = dt.Rows[r]["ApplicantNum"].ToString();
                }

                xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close();
                xlApp.Quit();

                return null;
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message);
                return err.Message;
                xlWorkBook.Close();
                xlApp.Quit();
            }
            finally
            {

                releaseObject(xlWorksheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.LoginedEmployee = null;
            this.LoginedUser = null;
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog(this);
        }

        private void cmbDataSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
