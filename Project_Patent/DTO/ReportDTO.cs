using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Patent
{
    public class ReportDTO
    {
        public string Title { get; set; }
        public string UserID { get; set; }
        public string ReportNum { get; set; }
        public string Writer { get; set; }
        public string Tech1 { get; set; }
        public string Tech1Code { get; set; }
        public string Tech2 { get; set; }
        public string Tech2Code { get; set; }
        public DateTime FinalDate { get; set; }
    }
}
