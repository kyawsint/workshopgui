using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace workshopgui
{
    public partial class CatchAGenie : Form
    {
        public CatchAGenie()
        {
            InitializeComponent();
        }

        private void CatchAGenie_Load(object sender, EventArgs e)
        {
            this.picgenie.Visible = false;
        }

        private void piclamp_Click(object sender, EventArgs e)
        {
            this.picgenie.Visible = true;
        }

        private void piclamp_DoubleClick(object sender, EventArgs e)
        {
            this.picgenie.Size = new Size(200, 300);
        }

        private void Genie_MouseHover(object sender, EventArgs e)
        {
            this.picgenie.Size = new Size(50, 60);
        }
    }
}
