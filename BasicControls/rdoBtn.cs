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
