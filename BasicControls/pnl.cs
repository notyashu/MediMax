using System.ComponentModel;
using System.Windows.Forms;

namespace BasicControls
{
    public partial class pnl : Panel
    {
        public pnl()
        {
            InitializeComponent();
        }

        public pnl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
