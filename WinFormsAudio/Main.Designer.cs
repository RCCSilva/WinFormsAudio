
namespace WinFormsAudio
{
    partial class Main
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
            this.hostUdpPort = new System.Windows.Forms.TextBox();
            this.remoteUdpPort = new System.Windows.Forms.TextBox();
            this.udpStatusLabel = new System.Windows.Forms.Label();
            this.remoteConnStatusLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.hostUdpPort.Location = new System.Drawing.Point(115, 36);
            this.hostUdpPort.Name = "textBox1";
            this.hostUdpPort.Size = new System.Drawing.Size(138, 23);
            this.hostUdpPort.TabIndex = 2;
            // 
            // textBox2
            // 
            this.remoteUdpPort.Location = new System.Drawing.Point(115, 197);
            this.remoteUdpPort.Name = "textBox2";
            this.remoteUdpPort.Size = new System.Drawing.Size(138, 23);
            this.remoteUdpPort.TabIndex = 3;
            // 
            // label1
            // 
            this.udpStatusLabel.AutoSize = true;
            this.udpStatusLabel.Location = new System.Drawing.Point(337, 36);
            this.udpStatusLabel.Name = "label1";
            this.udpStatusLabel.Size = new System.Drawing.Size(147, 15);
            this.udpStatusLabel.TabIndex = 4;
            this.udpStatusLabel.Text = "UDP Client - Disconnected";
            // 
            // button1
            // 
            this.connectButton.Location = new System.Drawing.Point(115, 93);
            this.connectButton.Name = "button1";
            this.connectButton.Size = new System.Drawing.Size(138, 70);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.remoteConnStatusLabel.AutoSize = true;
            this.remoteConnStatusLabel.Location = new System.Drawing.Point(337, 60);
            this.remoteConnStatusLabel.Name = "label2";
            this.remoteConnStatusLabel.Size = new System.Drawing.Size(79, 15);
            this.remoteConnStatusLabel.TabIndex = 6;
            this.remoteConnStatusLabel.Text = "Disconnected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.remoteConnStatusLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.udpStatusLabel);
            this.Controls.Add(this.remoteUdpPort);
            this.Controls.Add(this.hostUdpPort);
            this.Name = "UDP Voice Chat";
            this.Text = "UDP Voice Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hostUdpPort;
        private System.Windows.Forms.TextBox remoteUdpPort;
        private System.Windows.Forms.Label udpStatusLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label remoteConnStatusLabel;
    }
}

