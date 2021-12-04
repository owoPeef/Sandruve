using System;
using System.Windows.Forms;

namespace Sandruve
{
    public partial class Sandruve : Form
    {
        public Sandruve()
        {
            InitializeComponent();
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
