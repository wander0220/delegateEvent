using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegateEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button button = new Button();
            button.Text = "버튼";
            button.Click += delegate (object sender, EventArgs args)
            {
                MessageBox.Show("무명 델리게이터를 사용한 이벤트 연결");
            };
            button.Click += (sender, args) => MessageBox.Show("람다를 사용한 이벤트 연결");

            Controls.Add(button);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍트스파일 (*.txt)|*.txt";
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            //MessageBox.Show(saveFileDialog1.FileName);
        }
    }
}
