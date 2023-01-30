using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Project_Patent
{
    class ChartUtils
    {
       

        public static void GetSeries_FastLine(Chart chart ,string Name, string xMember, string yMember, int Width = 3,bool isValue = false, MarkerStyle markerStyle = MarkerStyle.Diamond, int markerWidth = 4, ChartColor chartColor = null)
        {
            Series country = new Series();
            country.ChartType = SeriesChartType.Line;
            country.Name = Name;
            country.BorderWidth = Width;
            
            country.XValueMember = xMember;
            country.YValueMembers = yMember;
            
            if (chartColor != null)
            {
                country.Color = Color.FromArgb(chartColor.RChart, chartColor.GChart, chartColor.BChart);
            }

            country.IsValueShownAsLabel = isValue;
            country.MarkerStyle = markerStyle;
            country.MarkerBorderWidth = markerWidth;
            country.MarkerBorderColor = Color.Black;

            chart.Series.Add(country);
            
        }

        public static void GetSeries_Pie(Chart chart, Series country, string xMember, int yMember, bool isValue = true)
        {
            country.ChartType = SeriesChartType.Pie;
            country.Points.AddXY(xMember, yMember);
            country.IsValueShownAsLabel = isValue;

        }

        public static void GetSeriese_Bubble(Chart chart, Series country)
        {
            country.ChartType = SeriesChartType.Bubble;
        }


    }
}
