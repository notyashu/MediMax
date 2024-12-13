using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
