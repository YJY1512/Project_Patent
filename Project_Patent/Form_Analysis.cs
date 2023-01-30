using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Project_Patent
{
    public partial class Form_Analysis : Form
    {
        List<AnalysisDTO> analysisList = new List<AnalysisDTO>();
        int minYear;
        List<Year_country> countryList = new List<Year_country>();

        List<ChartInOut> InOut = new List<ChartInOut>();
        List<BubbleChart> BubblesList = new List<BubbleChart>();
        Size screenSize = Screen.PrimaryScreen.Bounds.Size;
        public Form_Analysis()
        {
            InitializeComponent();
        }

        private void Form_Analysis_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // 기본 데이터를 가져옴

            if (((Form_Main)Owner).R_DataTable == null)
            {
                MessageBox.Show("분석할 DB가 없습니다.");
                this.Close();
                return;
            }

            //minYear = ylist.First((a) => a.y);
            
            for (int i = 0; i < ((Form_Main)Owner).R_DataTable.Rows.Count; i++)
            {

                AnalysisDTO Adto = new AnalysisDTO();
                Adto.Country = ((Form_Main)Owner).R_DataTable.Rows[i]["Country"].ToString();
                Adto.Year = Convert.ToInt32(((Form_Main)Owner).R_DataTable.Rows[i]["_ApplicantDate"]);
                Adto.Division1 = ((Form_Main)Owner).R_DataTable.Rows[i]["_DateDivision1"].ToString();
                Adto.Division2 = ((Form_Main)Owner).R_DataTable.Rows[i]["_DateDivision2"].ToString();
                Adto.Applicant = ((Form_Main)Owner).R_DataTable.Rows[i]["_Applicant"].ToString();
                Adto.InOut = ((Form_Main)Owner).R_DataTable.Rows[i]["_Applicant_FD"].ToString();
                Adto.IP4 = ((Form_Main)Owner).R_DataTable.Rows[i]["4IP"].ToString();
                Adto.ApplicantCountry = ((Form_Main)Owner).R_DataTable.Rows[i]["_ApplicantCountry"].ToString();

                analysisList.Add(Adto);
            }

            var list = (analysisList.OrderBy((n) => n.Year)).ToList();
            minYear = list[0].Year;
            dgvYC.ReadOnly = true;
            List<string> years = new List<string>();
            for (int i = 0; i <= (DateTime.Now.Year - minYear); i++)
            {
                years.Add((minYear + i).ToString());
            }
            
            // 국가 데이터 불러오기
            var clist = from country in analysisList
                       group new {c = country.Country}
                       by country.Country;
            Year_country chartYC = new Year_country();

            
            foreach (var ctry in clist)
            {
                BubbleChart b = new BubbleChart();
                Year_country c = new Year_country();
                ChartInOut io = new ChartInOut();
                c.country = io.Country = b.country = ctry.Key;
                 
                countryList.Add(c);
                InOut.Add(io);
                BubblesList.Add(b);
            }
            // 

            comboBox1.Items.Add("전체");
            comboBox1.SelectedIndex = 0;



            for (int i = 0; i < countryList.Count; i++)
            {
                comboBox1.Items.Add(countryList[i].country);
                for (int j = 0; j < years.Count; j++)
                {
                    

                    var dataList = (from alist in analysisList
                                    where alist.Year.ToString() == years[j] && alist.Country == countryList[i].country
                                    group alist
                                    by alist.Country into Ccnt
                                    select new { y = Ccnt.Key ,cnt = Ccnt.Count() }).ToList();

                    ValuseMember valuse = new ValuseMember();
                    valuse.xValue = years[j];
                    if (dataList == null)
                    {
                        valuse.Cnt = 0;
                    }
                    else
                    {
                        foreach (var n in dataList)
                        {
                            valuse.Cnt = n.cnt;
                        }
                         
                    }
                   
                    countryList[i].Memeber.Add(valuse);

                }
            }

            DrawingChart(chartY_C, countryList);
            //chartY_C 로드
           // chartY_C.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;
            chartY_C.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

            dgvYC.Columns.Add("country","국가");
            
            for (int i = 0; i < countryList[0].Memeber.Count; i++)
            {
                dgvYC.Columns.Add(countryList[0].Memeber[i].xValue, countryList[0].Memeber[i].xValue);
            }
            dgvYC.AllowUserToAddRows = false;
            for (int i = 0; i < countryList.Count; i++)
            {
                for (int j = 0; j <= countryList[i].Memeber.Count; j++)
                {
                    if (j == 0)
                    {
                        dgvYC.Rows.Add();
                        dgvYC.Rows[i].Cells[j].Value = countryList[i].country;
                        
                    }
                    else
                    {
                        dgvYC.Rows[i].Cells[j].Value = countryList[i].Memeber[j-1].Cnt;
                    }
                }
            }

            //chartIO 로드

            for (int i = 0; i < InOut.Count; i++)
            {
                var dataList = (from alist in analysisList
                                where alist.Country == InOut[i].Country
                                orderby alist.InOut
                                group alist
                                by alist.InOut into inout
                                select new { y = inout.Key, cnt = inout.Count() }).ToList();

                int sum = 0;
                foreach(var item in dataList)
                {
                    ValuseMember valuse = new ValuseMember();
                    valuse.xValue = item.y;
                    valuse.Cnt = item.cnt;
                    sum += item.cnt;
                    InOut[i].Memeber2.Add(valuse);
                }
                InOut[i].Tot = sum;

            }
            Series pies = new Series();
            for (int i = 0; i < InOut.Count; i++)
            {
                ChartUtils.GetSeries_Pie(chartIO, pies, InOut[i].Country, InOut[i].Tot);
                
            }
            chartIO.Series.Add(pies);

            for (int i = 0; i < InOut.Count; i++)
            {
                string chartNamesm = "chart" + $"0{i}";
                ChartArea chartArea = new ChartArea();
                Legend legends = new Legend();
                chartArea.Name = "ChartArea" + $"{i}";
                
                
                Chart charts = new Chart();
                charts.Size = new Size((screenSize.Width / InOut.Count), 350);
                charts.Location = new Point(10 + ((screenSize.Width / InOut.Count) * i), 10);
                charts.Name = chartNamesm;
                charts.ChartAreas.Add(chartArea);
                charts.Text = InOut[i].Country;
                legends.Name = "Legend" + $"{i}";
                charts.Titles.Add($"{InOut[i].Country}");
                charts.Legends.Add(legends);
                Series IOpie = new Series();
                for (int j = 0; j < InOut[i].Memeber2.Count; j++)
                {
                    ChartUtils.GetSeries_Pie(charts, IOpie, InOut[i].Memeber2[j].xValue, InOut[i].Memeber2[j].Cnt);
                }
                charts.Series.Add(IOpie);
                panel6.Controls.Add(charts);

                charts.BringToFront();

            }
            dgvIO.Columns.Add("country","국가");
            dgvIO.Columns.Add(InOut[0].Memeber2[0].xValue, InOut[0].Memeber2[0].xValue);
            dgvIO.Columns.Add(InOut[0].Memeber2[1].xValue, InOut[0].Memeber2[1].xValue);
            dgvIO.Columns.Add("Total", "종합");
            dgvIO.AllowUserToAddRows = false;
            for (int i = 0; i < InOut.Count; i++)
            {
                dgvIO.Rows.Add();
                for (int j = 0; j <= InOut[i].Memeber2.Count+1; j++)
                {
                    if (j == 0)
                    {
                        dgvIO.Rows[i].Cells[j].Value = InOut[i].Country;
                    }
                    else if (j ==3)
                    {
                        dgvIO.Rows[i].Cells[j].Value = InOut[i].Tot;
                    }
                    else
                    {
                        dgvIO.Rows[i].Cells[j].Value = InOut[i].Memeber2[j-1].Cnt;
                    }
                }
            }

            //chartDivision 로드

            //int Division = 0;

            //var division = from alist in analysisList
            //               group alist
            //               by alist.Division2 into d
            //               select new { cnt = d.Key.Count() };

            //foreach (var c in division)
            //{
            //    Division = c.cnt;
            //}


            //for (int i = 0; i < BubblesList.Count; i++)
            //{
            //    for (int j = 0; j < Division; j++)
            //    {
            //        Bubble bubble = new Bubble();
            //        bubble.BubbleSize = i + 1;
            //        var blist = from alist in analysisList
            //                    where alist.Country == BubblesList[i].country && alist.Division2 == $"{i + 1}구간"
            //                    group alist
            //                    by alist.Applicant into a
            //                    select new { Division2 = i + 1, ApplicantCnt = a.Count() };

            //        foreach (var a in blist)
            //        {
            //            bubble.Applicant = a.ApplicantCnt;
            //        }

            //        var blist2 = from alist in analysisList
            //                     where alist.Country == BubblesList[i].country && alist.Division2 == $"{i + 1}구간"
            //                     group alist
            //                     by alist.Division2 into d
            //                     select new { Division2 = i + 1, AppliyCnt = d.Count() };

            //        foreach (var d in blist2)
            //        {
            //            bubble.Applicant = d.AppliyCnt;
            //        }
            //        BubblesList[i].Bubbles.Add(bubble);
            //    }
                
            //}


            //chart2.Series[0].ChartType = SeriesChartType.Bubble;
            //chart2.Series[0].Points.AddXY(10, 20, 1);
            //chart2.Series[0].Points.AddXY(20, 30, 2);
            //chart2.Series[0].Points.AddXY(30, 30, 3);
            //chart2.Series[0].Points.AddXY(40, 50, 4);
            //chart2.Series[0].Points.AddXY(60, 70, 5);



            //ImportantApplicant 로드


            button1_Click(this, e);

        }

        public void DrawingChart(Chart chart, List<Year_country> list, string country = null, ChartColor chartcolor = null)
        {
            chart.Series.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                if ((!string.IsNullOrWhiteSpace(country)) && country == list[i].country)
                {
                    if (chartcolor == null)
                    {
                        ChartUtils.GetSeries_FastLine(chartY_C, list[i].country, "xValue", "Cnt", Width: 10, markerWidth: 8, isValue: true);
                    }
                    else
                    {
                        ChartUtils.GetSeries_FastLine(chartY_C, list[i].country, "xValue", "Cnt", Width: 10, markerWidth: 8, isValue: true, chartColor: chartcolor);
                    }
                    chart.Series[$"{list[i].country}"].Points.DataBind(countryList[i].Memeber, "xValue", "Cnt", null);
                }
                else
                {
                    ChartUtils.GetSeries_FastLine(chartY_C, list[i].country, "xValue", "Cnt");
                    chart.Series[$"{list[i].country}"].Points.DataBind(countryList[i].Memeber, "xValue", "Cnt", null);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();

        }

        private void btnApplicantIO_Click(object sender, EventArgs e)
        {
            
            panel2.Dock = DockStyle.Fill;
            panel2.BringToFront();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DrawingChart(chartY_C, countryList);
                return;
            }
            DrawingChart(chartY_C, countryList, comboBox1.SelectedItem.ToString());
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("나라를 선택해주세요");
                return;
            }

            ChartColor chartcolor = new ChartColor() 
            {
                RChart = hScrollBar1.Value,
                GChart = hScrollBar2.Value,
                BChart = hScrollBar3.Value
            };

            DrawingChart(chartY_C, countryList, comboBox1.SelectedItem.ToString(),chartcolor: chartcolor);

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

       
    }
}
