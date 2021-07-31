using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// form 만들기 기초
// Text 기반으로 실습하기
namespace CsharpBasicChaptor1201
{
    class Chap1201 :Form
    {
        static void Main(string[] args)
        {
            Button btn1 = new Button();
            btn1.Text = "Click";
            //Application.Run(new Chap1201()); 어플리케이션 실행

            Chap1201 f1 = new Chap1201();
            f1.Text = "버튼과폼";
            f1.Width = 350;
            f1.Height = 500;
            f1.Controls.Add(btn1);
            btn1.Top = 100;
            btn1.Left = 200;
            //이벤트 처리
            btn1.Click += (object sender, EventArgs e) =>
             {
                 MessageBox.Show("메세지 상자입니다.","모달",MessageBoxButtons.AbortRetryIgnore);
                
             };
            Application.Run(f1);
        }
    }
}
