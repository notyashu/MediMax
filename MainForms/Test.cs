using System;
using System.Windows.Forms;
using Models;

namespace MainForms
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void rdoBtn1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoBtn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBox2.Text = clDatatypes.ConvertQuery(txtBox1.Text.Trim());
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
