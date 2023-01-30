using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project_Patent
{
    public partial class frmZipSearchPopup : Form
    {
        public string ZipCode { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }


        public frmZipSearchPopup()
        {
            InitializeComponent();
        }

        private void frmZipSearchPopup_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvZip);

            DataGridViewUtil.AddGridTextBoxColumn(dgvZip, "우편번호", "zipNo", 90, DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvZip, "도로명주소", "roadAddr", 350);
            DataGridViewUtil.AddGridTextBoxColumn(dgvZip, "건물명", "bdNm", 200);

            DataGridViewUtil.AddGridTextBoxColumn(dgvZip, "도주1", "roadAddrPart1", 10, visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvZip, "도주2", "roadAddrPart2", 10, visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvZip, "지번주소", "jibunAddr", 200, visible:false);
        }

        private void txtKeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyWord.Text;
            string zipAPIKey = ConfigurationManager.AppSettings["zipAPIKey"];
            string apiUrl = $"https://business.juso.go.kr/addrlink/addrLinkApi.do?confmKey={zipAPIKey}&currentPage=1&countPerPage=100&keyword={keyword}";

            try
            {
                WebClient wc = new WebClient();
                XmlReader reader = new XmlTextReader(wc.OpenRead(apiUrl));

                DataSet ds = new DataSet();
                ds.ReadXml(reader);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["errorCode"].ToString() == "0")
                    {
                        if (ds.Tables.Count > 1)
                        {
                            dgvZip.DataSource = ds.Tables[1];
                            dgvZip.ClearSelection();
                        }
                        else
                        {
                            dgvZip.DataSource = null;
                            MessageBox.Show("검색된 결과가 없습니다.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(ds.Tables[0].Rows[0]["errorMessage"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("다시 시도하여 주십시오.");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvZip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoadZip.Text = txtJibunZip.Text = dgvZip[0, e.RowIndex].Value.ToString();
            
            txtRoadAddr1.Text = dgvZip[3, e.RowIndex].Value.ToString();
            txtRoadAddr2.Text = dgvZip[4, e.RowIndex].Value.ToString(); // + " " + dgvZip[2, e.RowIndex].Value.ToString();
            txtJibunAddr1.Text = dgvZip[5, e.RowIndex].Value.ToString();
            txtJibunAddr2.Text = ""; // dgvZip[2, e.RowIndex].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtRoadZip.Text.Length < 1)
            {
                MessageBox.Show("도로명 검색을 먼저 해주세요.");
                return;
            }

            ZipCode = txtRoadZip.Text;
            Addr1 = txtRoadAddr1.Text;
            Addr2 = txtRoadAddr2.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
