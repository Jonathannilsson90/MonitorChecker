using System.Management;
using SharpDX.DXGI;

namespace MoniterChecker

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string FetchVideoCardInfo()
        {

            ManagementObjectSearcher searcher = new("SELECT * FROM Win32_VideoController");
            string refreshRateStatus = "Unknown";


            foreach (ManagementObject obj in searcher.Get().Cast<ManagementObject>())
            {

                int currentRefreshRate = Convert.ToInt32(obj["CurrentRefreshRate"]);
                int maxRefreshRate = Convert.ToInt32(obj["maxRefreshRate"]);

                if (currentRefreshRate == maxRefreshRate)
                {
                    refreshRateStatus = $"Current refresh rate ({currentRefreshRate} Hz) is optimal for your screen.";
                }
                else
                {
                    refreshRateStatus = $"Current refresh rate ({currentRefreshRate} Hz) is not optimal for your screen. The optimal refresh rate is {maxRefreshRate}.";
                }

            }
            return $"{refreshRateStatus}";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static string GetVideoCardInfo()
        {
            ManagementObjectSearcher searcher = new("SELECT * FROM Win32_VideoController");

            var cardDetails = "";
            // Query general card info
            foreach (ManagementObject videocardDetails in searcher.Get().Cast<ManagementObject>())
            {
                string cardName = videocardDetails["Name"]?.ToString() ?? "Not found";

                cardDetails += $"Graphics card: {cardName} {Environment.NewLine}";
            }
            // Query number of monitors showing
            ManagementObjectSearcher monitorSearcher = new("SELECT * FROM Win32_PnPEntity WHERE PNPClass = 'Monitor'");
            int connectedMonitors = 0;
            var monitorInfo = "";
            foreach (ManagementObject monitor in monitorSearcher.Get().Cast<ManagementObject>())
            {
                connectedMonitors++;
                string monitorName = monitor["Name"]?.ToString() ?? "Unknown";
                monitorInfo += $"Monitor {connectedMonitors}: {monitorName} {Environment.NewLine}";
            }
            monitorInfo += $"Total connected monitors: {connectedMonitors} {Environment.NewLine}";



            var factory = new Factory1();
            var adapter = factory.Adapters1[0];
            var desc = adapter.Description;
            long vram = desc.DedicatedVideoMemory;
            double vramInMB = vram / (1024.0 * 1024.0);
            var cardVram = $"VRAM: {vramInMB} MB";

            return $"{cardDetails}{Environment.NewLine}{cardVram}{Environment.NewLine}{monitorInfo}";
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string monitorInfo = FetchVideoCardInfo();
            TbxScreenOne.Text = monitorInfo;



            string currentInfo = GetVideoCardInfo();
            TbxGeneralInfo.Text = currentInfo;
        }
    }

}
