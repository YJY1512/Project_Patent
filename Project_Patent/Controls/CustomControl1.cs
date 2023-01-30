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
    public partial class CustomControl1 : TextBox
    {
        // 
        // 아이디text : 한글 입력 안님, 필수 입력 (회원가입, 로그인)
        // PWDTExt : 8자 이상, 특수 문자 포함, 필수 입력, 담당자 PWD 어떻게 할것인가
        // 회사이름 : 아무 제한 없음, 필수 입력
        // 이름 : 한글 5글자 이하, 선택적 필수
        // 이메일 : 한글 안됨 필수 입력

        // 필수 입력 Text NNID, PWD, CoName, ManagerName, Email


        public enum InputTextType { Common, NNID, PWD, CoName, ManagerName, Email }

        InputTextType type = InputTextType.Common; // 전역변수로 Common을 기본값으로 설정

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
                this.BackColor = Color.LemonChiffon;
            }
        }
        public string Title { get; set; }



        public CustomControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void CustomControl1_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length == 0)
            {
                this.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        //private void CustomControl1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //if (this.type == InputTextType.NNID || this.type == InputTextType.Email || this.type == InputTextType.PWD)
        //    //{
        //        if (e.KeyChar > '가' && e.KeyChar < '힣')
        //        {
        //            e.Handled = true;
        //        }
        //    //}
        //    //else if (this.type == InputTextType.)
        //}
    }
}
