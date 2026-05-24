```csharp
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace MinecraftAFKClicker
{
    public partial class MainForm : Form
    {
        private Timer clickTimer;
        private bool isClicking;
        private string targetProcessName = "Minecraft"; // Process name for Minecraft
        private int clickInterval = 100; // Click interval in milliseconds

        public MainForm()
        {
            InitializeComponent();
            InitializeClickTimer();
        }

        private void InitializeComponent()
        {
            this.startButton = new Button();
            this.stopButton = new Button();
            this.statusLabel = new Label();
            this.SuspendLayout();
            
            // Start Button
            this.startButton.Location = new System.Drawing.Point(30, 30);
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.Text = "Start";
            this.startButton.Click += new EventHandler(this.StartButton_Click);

            // Stop Button
            this.stopButton.Location = new System.Drawing.Point(120, 30);
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new EventHandler(this.StopButton_Click);

            // Status Label
            this.statusLabel.Location = new System.Drawing.Point(30, 70);
            this.statusLabel.Size = new System.Drawing.Size(200, 23);
            this.statusLabel.Text = "Status: Idle";

            // MainForm
            this.ClientSize = new System.Drawing.Size(250, 120);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.statusLabel);
            this.Text = "Minecraft AFK Clicker";
            this.ResumeLayout(false);
        }

        private void InitializeClickTimer()
        {
            clickTimer = new Timer();
            clickTimer.Interval = clickInterval;
            clickTimer.Tick += new EventHandler(ClickTimer_Tick);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (IsMinecraftRunning())
            {
                isClicking = true;
                clickTimer.Start();
                statusLabel.Text = "Status: Clicking...";
            }
            else
            {
                MessageBox.Show("Minecraft is not running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            isClicking = false;
            clickTimer.Stop();
            statusLabel.Text = "Status: Idle";
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            if (isClicking)
            {
                // Simulate mouse click (implement the click logic here)
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
                mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                Thread.Sleep(10); // Add slight delay between down and up
                mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            }
        }