using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Patent
{
    public partial class LoginTextBox : TextBox
    {

        public enum InputTextType { Common, OnlyKorean, Numeric, NotKorean, PWD }
        InputTextType type = InputTextType.Common;
        public InputTextType TextType
        {
            get
            {
                return type;
            }
            // 디자이너의 속성창에서 속성을 설정할 때, Set으로 들어감
            set
            {
                type = value;
                if (type == InputTextType.OnlyKorean || type == InputTextType.Numeric 
                    || type == InputTextType.NotKorean || type == InputTextType.PWD)
                {
                    this.BackColor = Color.LemonChiffon;
                }
                else
                {
                    this.BackColor = Color.White;
                }
            }
        }
        public string Title { get; set; }

        public LoginTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (type == InputTextType.OnlyKorean)
            {
                if ((e.KeyChar < 'ㄱ' || e.KeyChar > '힣') || e.KeyChar != 8)
                    e.Handled = true;
            }
            else if (type == InputTextType.Numeric)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            else if (type == InputTextType.NotKorean)
            {
                if (e.KeyChar > 'ㄱ' && e.KeyChar < '힣')
                    e.Handled = true;
            }
            else if (type == InputTextType.PWD)
            {

            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}
