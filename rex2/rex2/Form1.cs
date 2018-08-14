using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace rex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var doc = new XmlDocument();
            doc.Load(@"D:\ВЛАД\Projects VisualStudio\rex2\rex2\users.xml");
            foreach (XmlElement elem in doc.DocumentElement.ChildNodes)
            {

                if (elem.Name == "scoreMath")
                {
                    ScoreMath = elem.InnerText.ToInt();
                }
                else if (elem.Name == "scoreMem")
                {
                    ScoreMem = elem.InnerText.ToInt();
                }
            }
            mainMenu = MenuPanel;
            mathMenu = MathPanel;
            memMenu = MemoryPanel;
        }
        //ПEPEMEHHыE
        private bool isBlack = true;
        private int Minutes, Seconds, Miliseconds;
        public static int CountofRight;
        public static int CountofWrong;
        public static int ScoreMath { get; private set; }
        public static int ScoreMem { get; private set; }
        public static short TrainState = 0;
        public static Panel mainMenu, mathMenu, memMenu;
        public int RealHidenNum = 0;
        //ПEPEMEHHыE
        void ChangeTimerValue()
        {
            Miliseconds++;
            if (Miliseconds % 10 == 0)
                Seconds--;
            if (Seconds == 0 && Minutes > 0)
            {
                Seconds = 59;
                Minutes--;
            }
            if (Minutes < 10 && Minutes >= 0)
            {
                if (Seconds < 10 && Seconds >= 0)
                    TimerLabel.Text = "0" + Minutes.ToString() + ":0" + Seconds.ToString();
                else
                    TimerLabel.Text = "0" + Minutes.ToString() + ":" + Seconds.ToString();
            }
            else
                TimerLabel.Text = Minutes.ToString() + ":" + Seconds.ToString();
            if (TimerLabel.Text == "02:40")
            {
                timer.Enabled = false;
                var MessegeForm = new Form2();
                MessegeForm.Show();
            }
            if (Seconds % 2 == 0)
                TimerLabel.ForeColor = Color.Maroon;
            else
                TimerLabel.ForeColor = Color.Green;
        }

        private bool LessTen(int checkedInt)
        {
            return checkedInt < 10 && checkedInt >= 0;
        }

        public static int Eval(string text)
        {
            return Convert.ToInt32(new DataTable().Compute(text, null));
        }
        public static void GoZero()
        {
            CountofRight = CountofWrong = TrainState = 0;
        }
        private void ChangeLinkColor(object sender, EventArgs e)
        {
            Label Link = (Label)sender;
            Link.ForeColor = (isBlack) ? Color.LightCoral : Color.Black;
            isBlack = !isBlack;
        }

        private void MathTr_Click(object sender, EventArgs e)
        {
            MathPanel.Visible = MathChild.Visible = true;
            MathMain.Visible = MenuPanel.Visible = false;
        }

        private void MemoryTr_Click(object sender, EventArgs e)
        {
            MemoryPanel.Visible = MemChild.Visible = true;
            MemMain.Visible = MenuPanel.Visible = false;
        }

        private void ToMenuLink_Click(object sender, EventArgs e)
        {
            Panel parent = (((Control)sender).Parent) as Panel;
            parent.Visible = false;
            MenuPanel.Visible = true;
            timer.Enabled = false;
            TrainState = 0;
        }

        private void GoMath_Click(object sender, EventArgs e)
        {
            Panel parent = ((Control)sender).Parent as Panel;
            parent.Visible = false;
            MathMain.Visible = true;
            timer.Enabled = true;
            TimerLabel.Text = "03:00";
            Minutes = 3;
            Seconds = 0;
            Miliseconds = 0;
            new MathWork().MakeExpresion(Question, ref RealHidenNum);
            CountofRight = CountofWrong = 0;
            TrainState = 1;
        }

        private void UserAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool a = Eval(Question.Text).ToString() == UserAnswer.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                new MathWork().CheckAnswer(ref CountofRight, ref CountofWrong, a);
                new MathWork().MakeExpresion(Question, ref RealHidenNum);
                e.Handled = true;
                UserAnswer.Text = "";
                UserAnswer.Focus();
            }
        }
        int counter = 0;
        private void HidenFromUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bool a = RealHidenNum == HidenFromUser.Text.ToInt();
                e.Handled = true;
                counter++;
                var thisobj = sender as Control;
                new MemoryWork().CheckAnswer(ref CountofRight, ref CountofWrong, a);
                new MemoryWork().MakeExpresion(HidenNum,ref RealHidenNum);
                timer1.Enabled = HidenNum.Visible = true;
                thisobj.Text = "";

            }
            if (counter == 2)
            {
                var MessageForm = new Form2();
                MessageForm.Show();
            }
        }
        int milisec = 0;

        private void UserImageMM_Click(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
            AccountPanel.Visible = true;
        }
        bool isHover = false;
        private void UserImgColorChange(object sender, EventArgs e)
        {
            var Img = sender as PictureBox;
            Img.BackColor = (!isHover) ? Color.LightGray : DefaultBackColor;
            isHover = !isHover;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milisec++;
            if (milisec > 4)
            {
                milisec = 0;
                HidenNum.Visible = timer1.Enabled = false;
            }
        }

        private void GoMem_Click(object sender, EventArgs e)
        {
            Panel parent = ((Control)sender).Parent as Panel;
            parent.Visible = false;
            MemMain.Visible = true;
            TrainState = 2;
            new MemoryWork().MakeExpresion(HidenNum,ref RealHidenNum);
            timer1.Enabled = true;
        }



        private void timer_Tick(object sender, EventArgs e)
        {
            ChangeTimerValue();
        }
        public static void GoToMain(Panel main, Panel math1, Panel mem1)
        {
            main.Visible = true;
            math1.Visible = false;
            mem1.Visible = false;
        }

    }
    public static class StatClass
    {
        public static int ToInt(this string text)
        {
            return Convert.ToInt32(text);
        }
    }
    interface IExpressionWork
    {
        void CheckAnswer(ref int CountofRight, ref int CountofWrong, bool Condititon);
        void MakeExpresion(Label Question, ref int realnum);
    }
    class MathWork : IExpressionWork
    {
        public void CheckAnswer(ref int CountofRight, ref int CountofWrong, bool Condition)
        {
            if (Condition)
                CountofRight++;
            else
                CountofWrong++;
        }
        public void MakeExpresion(Label Question, ref int realnum)
        {
            Random r = new Random();
            char operation = (r.Next(0, 2) == 0) ? '+' : '-';
            int num1, num2;
            do
            {
                num1 = r.Next(1, 51);
                num2 = r.Next(1, 51);
            } while (num1 < num2);
            Question.Text = $"{num1} {operation} {num2}";
        }
    }
    class MemoryWork : IExpressionWork
    {
        public void CheckAnswer(ref int CountofRight, ref int CountofWrong, bool Condition)
        {
            if (Condition)
                CountofRight++;
            else
                CountofWrong++;
        }
        public void MakeExpresion (Label HidenNum, ref int realnum)
        {
            Random r = new Random();
            realnum = r.Next(1000, 10000);
            string str = realnum.ToString();
            HidenNum.Text = $"{str[0] } {str[1]} {str[2] } {str[3]}";
        }
    }
}
