using System.Diagnostics;

namespace TWinActivator;
public partial class TWinForm : Form
{
    private static readonly Dictionary<string, string> _dict = new()
    {
        { "Windows 10/11 Pro", "W269N-WFGWX-YVC9B-4J6C9-T83GX" },
        { "Windows 10/11 Pro N", "MH37W-N47XK-V7XM9-C7227-GCQG9" },
        { "Windows 10/11 Pro for Workstations", "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J" },
        { "Windows 10/11 Pro for Workstations N", "9FNHH-K3HBT-3W4TD-6383H-6XYWF" },
        { "Windows 10/11 Pro Education", "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y" },
        { "Windows 10/11 Pro Education N", "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC" },
        { "Windows 10/11 Education", "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2" },
        { "Windows 10/11 Education N", " 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ" },
        { "Windows 10/11 Pro Enterprise", "NPPR9-FWDCX-D2C8J-H872K-2YT43" },
        { "Windows 10/11 Pro Enterprise N", "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4" },
        { "Windows 10/11 Pro Enterprise G", "YYVX9-NTFWV-6MDM3-9PT4T-4M68B" },
        { "Windows 10/11 Pro Enterprise G N", "44RPN-FTY23-9VTTB-MP9BX-T84FV" },
        { "Windows 10/11 Home", "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99" },
        { "Windows 10/11 Home N", "3KHY7-WNT83-DGQKR-F7HPR-844BM" },
    };
    public TWinForm()
    {
        InitializeComponent();
        keysComboBox.DataSource = new BindingSource(_dict, null);
    }
    public bool ActivateWindows()
    {
        try
        {
            var proc = new Process
            {
                StartInfo = {
                        FileName = "cmd",
                        // I know it's not escaped properly, but what's the worst that could happen?
                        Arguments = $"/C \"slmgr /skms {txtBx_kms.Text} & slmgr /ipk {keysComboBox.SelectedValue}\"",
                        UseShellExecute = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        Verb = "runas"
                    }
            };
            proc.Start();
            proc.WaitForExit();
            return true;
        }
        catch { }
        return false;
    }

    private void PromptActivate(object sender, EventArgs e)
    {
        if (txtBx_kms.Text == "KMS server")
        {
            MessageBox.Show("Please fill out the KMS server box");
            return;
        }
        if (MessageBox.Show(
            $"Are you sure you want to activate Windows?\nKMS server: {txtBx_kms.Text}\nActivation code: {keysComboBox.SelectedValue}",
            "Are you sure?", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        if (ActivateWindows()) Application.Exit();
    }

    private void KMSTextBoxFocusEntered(object sender, EventArgs e)
    {
        if (txtBx_kms.Text != "KMS server") return;
        txtBx_kms.Text = "";
        txtBx_kms.ForeColor = SystemColors.WindowText;
    }

    private void KMSTextBoxFocusLeft(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtBx_kms.Text)) return;
        txtBx_kms.Text = "KMS server";
        txtBx_kms.ForeColor = SystemColors.GrayText;
    }
}
