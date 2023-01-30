using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Project_Patent
{
    class DataGridViewUtil
    {
        public static void SetInitDataGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;//DataSource를 기준으로 자동 컬럼을 생성 (기본값이 true)
            dgv.AllowUserToAddRows = false;//마지막에 + 행추가 삭제 (기본값이 true)
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersWidth = 30;
        }

        public static void AddGridTextBoxColumn(
            DataGridView dgv,
            string headerText,
            string propertyName,
            int colWidth = 100,
            
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft,
            bool visible = true,
            bool frosen = false)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = propertyName;
            col.HeaderText = headerText;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            col.DataPropertyName = propertyName;
            col.DefaultCellStyle.Alignment = align;
            col.Width = colWidth;
            col.ReadOnly = true;
            col.Visible = visible;
            col.Frozen = frosen;

            dgv.Columns.Add(col);
        }

        public static void AddGridButtonColumn(
            DataGridView dgv,
            string headerText,
            string propertyName,
            int colWidth = 100,

            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft,
            bool visible = true,
            bool frosen = false)
        {
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.Name = propertyName;
            bcol.Text = headerText;
            bcol.UseColumnTextForButtonValue = true;
            bcol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            bcol.DataPropertyName = propertyName;
            bcol.DefaultCellStyle.Alignment = align;
            bcol.Width = colWidth;
            bcol.ReadOnly = true;
            bcol.Visible = visible;
            bcol.Frozen = frosen;

            dgv.Columns.Add(bcol);
        }



    }
}
