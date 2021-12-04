using System;
using System.Windows.Forms;
using System.Diagnostics;
using Sandruve.Github;

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
                LinkLabel.Visible = true;
                VersionLabel.Visible = true;
            }
            else
            {
                LinkLabel.Visible = false;
                VersionLabel.Visible = false;
            }
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/owoPeef/Sandruve/releases/latest");
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
