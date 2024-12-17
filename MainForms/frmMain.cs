using System;
using BasicControls;

namespace MainForms
{
    public partial class frmMain : frm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForms.frmMain.ActiveForm.Close();
        }
    }
}
