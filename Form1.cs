using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 测试委托
{
    public partial class Form1 : Form
    {
        Task task = new Task();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            task.EventTxFarms += Task_EventTxFarms;
        }

        private void Task_EventTxFarms(object sender, EventArgs e)
        {
            double time = (task.st.ElapsedTicks / (double)Stopwatch.Frequency * 1000);
            Console.WriteLine(time);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task.start();
        }
    }
}
