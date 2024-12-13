using System.ComponentModel;
using System.Windows.Forms;

namespace BasicControls
{
    public partial class menuStrip : MenuStrip
    {
        public menuStrip()
        {
            InitializeComponent();
        }

        public menuStrip(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
