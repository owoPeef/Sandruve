using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandruve
{
    public partial class TestBytes : Form
    {
        public TestBytes()
        {
            InitializeComponent();
        }

        private void TestBytes_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] a;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] temp = ofd.FileName.Split(new char[] { '\\' });
                    string filename = temp[temp.Length-1];
                    a = Utils.GetBytesFromFile(@ofd.FileName);
                    File.WriteAllBytes(string.Format(@"E:\GitHub\VisualStudio\Sandruve\Sandruve\bin\Debug\{0}", filename), a);
                }
            }
        }
    }
}
