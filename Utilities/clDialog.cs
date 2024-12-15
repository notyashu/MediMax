using System.Windows.Forms;

namespace Utilities
{
    public class clDialog
    {
        public static void msgBox(string msgText, string msgType = null)
        {
            if (msgType == null)
            {
                msgType = "I";
            }

            switch (msgType)
            {
                case "E":
                    MessageBox.Show(msgText, "MediMax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "I":
                    MessageBox.Show(msgText, "MediMax Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    MessageBox.Show(msgText, "MediMax Message", MessageBoxButtons.OK);
                    break;
            }
        }
    }
}
