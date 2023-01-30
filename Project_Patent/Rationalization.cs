using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Patent
{
    class Rationalization
    {
        public static void AutoRationalization(DataGridView beforedgv, DataGridView afterdgv)
        {
            afterdgv["정비_DB", 0].Value = beforedgv["국가_DB", 0].Value;
            afterdgv["출원번호", 0].Value = beforedgv["출원번호", 0].Value;
            afterdgv["정비_출원일", 0].Value = beforedgv["출원일", 0].Value.ToString().Substring(0, 4);
            afterdgv["정비_4극", 0].Value = beforedgv["R_패밀리 4극여부", 0].Value;

        }
    }
}
