using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Patent
{
    public class AnalysisDTO
    {
        public string Applicant { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Division1 { get; set; }
        public string Division2 { get; set; }
        public string InOut { get; set; }
        public string IP4 { get; set; }
        public string ApplicantCountry { get; set; }

    }

    public class Year_country
    {
        public string country { get; set; }
        public List<ValuseMember> Memeber { get; set; }
        public Year_country()
        {
            Memeber = new List<ValuseMember>();
        }
    }

    public class ChartInOut
    {
        public string Country { get; set; }
        public int Tot { get; set; }
        public List<ValuseMember> Memeber2 { get; set; }
        public ChartInOut()
        {
            Memeber2 = new List<ValuseMember>();
        }
    }


    public class BubbleChart
    {
        public string country { get; set; }
        public List<Bubble> Bubbles { get; set; }
        public BubbleChart()
        {
            Bubbles = new List<Bubble>();
        }
    }

    public class Bubble
    {
        public int Applicant { get; set; }
        public int Cnt { get; set; }
        public int BubbleSize { get; set; }
    }

    public class ValuseMember
    {
        public string xValue { get; set; }
        public int Cnt { get; set; }
    }

    public class ChartColor
    {
        public int RChart { get; set; }
        public int GChart { get; set; }
        public int BChart { get; set; }
    }
    

}
