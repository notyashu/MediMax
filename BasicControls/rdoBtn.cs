using System.ComponentModel;
using System.Windows.Forms;

namespace BasicControls
{
    public partial class rdoBtn : RadioButton
    {
        public rdoBtn()
        {
            InitializeComponent();
        }

        public rdoBtn(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
