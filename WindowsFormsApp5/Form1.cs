using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.ShowBalloonTip(100);
        }

        private Process proc;
        private void button1_Click(object sender, EventArgs e)
        {
           proc = Process.Start(@"C:\Users\xyf\Desktop\abc.bat");
           Console.WriteLine("你好啊");
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (proc != null && !proc.HasExited )
                    proc.Kill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proc.HasExited.ToString());
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
