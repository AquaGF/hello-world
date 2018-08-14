using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rex2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Rights.Text += MainRight.ToString();
            Wrongs.Text += MainWrong.ToString();
            StarsPlused.Text += Stars.ToString();
            XmlElement newNode;
            XmlDocument xml = new XmlDocument();
            if (Form1.TrainState == 1)
            {
                xml.Load(@"D:\ВЛАД\Projects VisualStudio\rex2\rex2\users.xml");
                XmlElement element = (XmlElement)xml.DocumentElement.ChildNodes[0];
                xml.DocumentElement.RemoveChild(element);
                newNode = xml.CreateElement("scoreMath");
                newNode.InnerText = (Form1.ScoreMath + Stars).ToString();
                xml.DocumentElement.InsertBefore(newNode,xml.DocumentElement.ChildNodes[0]);
            }
            else
            {
                xml.Load(@"D:\ВЛАД\Projects VisualStudio\rex2\rex2\users.xml");
                XmlElement element = (XmlElement)xml.DocumentElement.ChildNodes[1];
                xml.DocumentElement.RemoveChild(element);
                newNode = xml.CreateElement("scoreMem");
                newNode.InnerText = (Form1.ScoreMem + Stars).ToString();
                xml.DocumentElement.InsertAfter(newNode, xml.DocumentElement.ChildNodes[0]);
            }
            xml.Save(@"D:\ВЛАД\Projects VisualStudio\rex2\rex2\users.xml");
        }
        int MainRight = Form1.CountofRight;
        int MainWrong = Form1.CountofWrong;
        int Stars = Form1.CountofRight - Form1.CountofWrong;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.GoToMain(Form1.mainMenu, Form1.mathMenu, Form1.memMenu);
            Form1.GoZero();
        }


    }
}
