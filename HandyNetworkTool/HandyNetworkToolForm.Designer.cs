namespace HandyNetworkTool
{
    partial class HandyNetworkToolForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            pingOutput = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            pingIP = new MaskedTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnPingStart = new Button();
            btnPingStop = new Button();
            label1 = new Label();
            pingInterval = new NumericUpDown();
            label2 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pingInterval).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Left;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(497, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(489, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ping";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pingOutput, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(483, 416);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // pingOutput
            // 
            pingOutput.Dock = DockStyle.Fill;
            pingOutput.FormattingEnabled = true;
            pingOutput.ItemHeight = 15;
            pingOutput.Location = new Point(3, 59);
            pingOutput.Name = "pingOutput";
            pingOutput.Size = new Size(477, 354);
            pingOutput.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(pingIP, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 4, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(pingInterval, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(477, 35);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(135, 10);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 1;
            label3.Text = "Interval: (ms)";
            // 
            // pingIP
            // 
            pingIP.Anchor = AnchorStyles.Left;
            pingIP.Culture = new System.Globalization.CultureInfo("");
            pingIP.Location = new Point(29, 6);
            pingIP.Mask = "990\\.990\\.990\\.990";
            pingIP.Name = "pingIP";
            pingIP.Size = new Size(100, 23);
            pingIP.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnPingStart);
            flowLayoutPanel1.Controls.Add(btnPingStop);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(273, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(201, 29);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnPingStart
            // 
            btnPingStart.Anchor = AnchorStyles.Left;
            btnPingStart.Location = new Point(3, 3);
            btnPingStart.Name = "btnPingStart";
            btnPingStart.Size = new Size(75, 23);
            btnPingStart.TabIndex = 2;
            btnPingStart.Text = "Start";
            btnPingStart.UseVisualStyleBackColor = true;
            // 
            // btnPingStop
            // 
            btnPingStop.Anchor = AnchorStyles.Left;
            btnPingStop.Location = new Point(84, 3);
            btnPingStop.Name = "btnPingStop";
            btnPingStop.Size = new Size(75, 23);
            btnPingStop.TabIndex = 2;
            btnPingStop.Text = "Stop";
            btnPingStop.UseVisualStyleBackColor = true;
            btnPingStop.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // pingInterval
            // 
            pingInterval.Anchor = AnchorStyles.Left;
            pingInterval.Location = new Point(217, 6);
            pingInterval.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            pingInterval.Name = "pingInterval";
            pingInterval.Size = new Size(50, 23);
            pingInterval.TabIndex = 1;
            pingInterval.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 41);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Output:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(489, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // HandyNetworkToolForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "HandyNetworkToolForm";
            Text = "HandyNetworkTool";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pingInterval).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private MaskedTextBox pingIP;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnPingStart;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPingStop;
        private ListBox pingOutput;
        private Label label3;
        private NumericUpDown pingInterval;
    }
}
