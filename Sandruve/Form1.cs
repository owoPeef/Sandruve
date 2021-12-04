using System;
using System.Windows.Forms;
using System.Diagnostics;
using Sandruve.Github;
using System.IO;

namespace Sandruve
{
    public partial class Sandruve : Form
    {
        public Sandruve()
        {
            InitializeComponent();
            bool newVerAvailable = GithubParser.IsNewVersionAvailable();
            if (newVerAvailable)
            {
                Process.Start(@Directory.GetCurrentDirectory() + "/Updater.exe", string.Format("--ver{0}", GithubParser.GetLatestReleaseVersion()));
                Process.GetCurrentProcess().Kill();
            }
        }

        private void hostBtn_Click(object sender, EventArgs e)
        {
            HostForm hostForm = new HostForm();
            hostForm.Visible = true;
        }

        private void conBtn_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Visible = true;
        }
    }
}
