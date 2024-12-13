using System.ComponentModel;
using System.Windows.Forms;

namespace BasicControls
{
    public partial class cmbBox : ComboBox
    {
        public cmbBox()
        {
            InitializeComponent();
        }

        public cmbBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
