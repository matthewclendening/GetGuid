using System;
using System.Windows.Forms;
using GetGuid.Properties;

namespace GetGuid
{
    public partial class GuidFormatDlg : Form
    {
        public GuidFormatDlg(string guidFormat)
        {
            InitializeComponent();
            switch (guidFormat)
            {
                case "N":
                    nFormatRadioButton.Checked = true;
                    break;
                case "D":
                    dFormatRadioButton.Checked = true;
                    break;
                case "B":
                    bFormatRadioButton.Checked = true;
                    break;
                case "P":
                    pFormatRadioButton.Checked = true;
                    break;
                default:
                    throw new ArgumentException(Resources.Invalid_GUID_Format, "guidFormat");
            }
        }

        public string GuidFormat
        {
            get
            {
                if (nFormatRadioButton.Checked)
                    return "N";
                if (dFormatRadioButton.Checked)
                    return "D";
                if (bFormatRadioButton.Checked)
                    return "B";
                if (pFormatRadioButton.Checked)
                    return "P";
                throw new InvalidOperationException("No format radio button selected.");
            }
        }


        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Close();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}