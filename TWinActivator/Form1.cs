using System.ComponentModel;
using System.Diagnostics;

namespace TWinActivator
{
    public partial class Form1 : Form
    {
        private static readonly Dictionary<string, string> _dict = new()
        {
            { "Windows 10/11 Home", "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99" },
            { "Windows 10/11 Home N", "3KHY7-WNT83-DGQKR-F7HPR-844BM" },
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
        };
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = new BindingSource(_dict, null);
        }
        public static bool Activate()
        {
            //try
            {

                new Process
                {
                    StartInfo = {
                        FileName = "cmd",
                        Arguments = "/C \"slmgr \"",
                        UseShellExecute = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                    }
                }.Start();
                return true;
            }
            /*catch
            {
            }*/
            return false;
        }

    }
}
