using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.ComponentModel;
using System.Windows.Forms;

namespace HandyNetworkTool
{
    internal class PingTool
    {
        private System.Windows.Forms.Timer tmr;

        public PingTool(MaskedTextBox pingIP, Button btnPingStart, Button btnPingStop, ListBox pingOutput, NumericUpDown pingInterval)
        {
            PingIP = pingIP;
            BtnPingStart = btnPingStart;
            BtnPingStop = btnPingStop;
            PingOutput = pingOutput;
            PingInterval = pingInterval;
            BtnPingStart.Click += BtnPingStart_Click;
            BtnPingStop.Click += BtnPingStop_Click;
            this.tmr = new System.Windows.Forms.Timer();

            tmr.Tick += Tmr_Tick; 

        }

        private async void Tmr_Tick(object? sender, EventArgs e)
        {
            tmr.Stop();
         var r= await Task.Run(()=>  this.pingAsync());
            this.PingOutput.Items.AddRange(r);
            if (RunPing == true)  tmr.Start();

            PingOutput.SelectedIndex = PingOutput.Items.Count - 1;
        }

        private void BtnPingStop_Click(object? sender, EventArgs e)
        {
            BtnPingStart.Visible = true;
            BtnPingStop.Visible = false;

            this.PingIP.ReadOnly = false;
            PingInterval.ReadOnly = false; 
            this.RunPing = false;
            tmr.Stop();
     

        }


        private async Task<string[]> pingAsync()
        {
            var returner = new List<string>();

            try
            {
                
                var ipString = this.PingIP.Text.Replace(" ", "");

                var ip = System.Net.IPAddress.Parse(ipString);
                var pinger = new Ping();

                var r = pinger.Send(ip);

                if (r.Status == IPStatus.Success)
                {

                    returner.Add($@"{DateTime.Now.TimeOfDay.ToString()} : Reply from {ip} bytes={r.Buffer.Length} in {r.RoundtripTime}ms TTL={r.Options.Ttl}");

                }
                else
                {
                    returner.Add($@"{DateTime.Now.TimeOfDay.ToString()} : ERROR : {r.Status.ToString()}");
                }


            }
            catch (Exception ex)
            {
                returner.Add($@"{DateTime.Now.TimeOfDay.ToString()} : {ex.ToString()}");
                returner.Add($@"{DateTime.Now.TimeOfDay.ToString()} : Ping stopped.");
              
            }

            return returner.ToArray();
        }

        private void BtnPingStart_Click(object? sender, EventArgs e)
        {
            BtnPingStart.Visible = false;
            BtnPingStop.Visible = true;
            this.PingIP.ReadOnly = true;
            PingInterval.ReadOnly = true; 
            tmr.Interval = Convert.ToInt32( PingInterval.Value );
            tmr.Start();
            this.RunPing = true;
           

        }

        public MaskedTextBox PingIP { get; }
        public Button BtnPingStart { get; }
        public Button BtnPingStop { get; }
        public ListBox PingOutput { get; }
        public NumericUpDown PingInterval { get; }
        public bool RunPing { get; private set; }
    }
}
