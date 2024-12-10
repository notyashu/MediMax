using System;
using System.Windows.Forms;

namespace BasicControls
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();

            // Preview key events before controls handle them
            this.KeyPreview = true;

            // Attaching KeyDown event to the custom handler
            this.KeyDown += Frm_KeyDown;
        }

        // Custom behavior for the Enter and Tab keys.

        private void Frm_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if pressed key is Enter or Tab
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                // Move focus to the next control in the tab order

                // - ActiveControl: The control currently focused
                // - true: Move forward (false would move backward)
                // - true: Allow wrapping to the first control if at the end
                // - true: Consider only tab stops
                // - true: Include disabled controls in the search
                this.SelectNextControl(this.ActiveControl, true, true, true, true);

                // Suppress the default behavior for the Enter key
                if (e.KeyCode == Keys.Enter)
                {
                    // Prevent further processing of the key event
                    e.Handled = true;

                    // Prevent the sounds or other default Enter key action
                    e.SuppressKeyPress = true;
                }
            }
        }
    }
}
