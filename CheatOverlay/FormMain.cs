using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatOverlay
{
    public partial class FormMain : Form
    {
        Overlay frm = new Overlay();

        public FormMain()
        {
            InitializeComponent();
        }

        private void DisplayOverlay_CheckedChanged(object sender, EventArgs e)
        {
            if( DisplayOverlay.Checked == true )
            {
                frm.Show();
            }
            else
            {
                frm.Hide();
            }
        }
    }
}
