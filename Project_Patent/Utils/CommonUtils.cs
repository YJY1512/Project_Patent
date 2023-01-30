using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Project_Patent
{
    class CommonUtils
    {
        public static DataView ComboBoxBinding(ComboBox cmb,DataTable dt,
                                    string category,
                                    string disPlayMember,
                                    string valueMember,
                                    bool blankItem = false, string blankText = "선택")
        {

            if (blankItem)
            {
                DataRow dr = dt.NewRow();
                dr[valueMember] = "";
                dr[disPlayMember] = blankText;
                
                dr["Category"] = category;
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }

            DataView dv = new DataView(dt);
            dv.RowFilter = $"Category = '{category}'";

            
            return dv;
        }
    }
}
