using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            button.Click += delegate
        }


    }
}
