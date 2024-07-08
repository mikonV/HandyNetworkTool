namespace HandyNetworkTool
{
    public partial class HandyNetworkToolForm : Form
    {
        public HandyNetworkToolForm()
        {
            InitializeComponent();
            this.PingTool = new PingTool(pingIP, btnPingStart, btnPingStop, pingOutput, pingInterval);
        }

        internal PingTool PingTool { get; }
    }
}
