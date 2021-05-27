using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAudio
{
    public partial class Main : Form
    {
        private UdpClient _udpClient;
        private readonly WaveIn _waveIn;
        private readonly WaveOut _waveOut;
        private readonly int _clientPort;
        private int _serverPort;

        private BufferedWaveProvider _bufferedWaveProvider;

        private Thread _thread;

        public Main()
        {
            InitializeComponent();
            _waveIn = new WaveIn();
            _waveOut = new WaveOut();
            _clientPort = new Random().Next(61000, 65535);
            hostUdpPort.Text = _clientPort.ToString();

            _bufferedWaveProvider = new BufferedWaveProvider(_waveIn.WaveFormat);

            _waveOut.Init(_bufferedWaveProvider);

            _waveOut.Play();
            _waveIn.StartRecording();

            _thread = new Thread(receiveVoiceData);


            _udpClient = new UdpClient(_clientPort);
            udpStatusLabel.Text = "UDP Created!";
        }

        private void sendVoiceData(object sender, WaveInEventArgs waveInEventArgs)
        {
            _udpClient.SendAsync(waveInEventArgs.Buffer, waveInEventArgs.BytesRecorded, "localhost", _serverPort);
        }

        private async void receiveVoiceData()
        {
            while (true)
            {
                 var receivedBytes = await _udpClient.ReceiveAsync();
                _bufferedWaveProvider.AddSamples(receivedBytes.Buffer, 0, receivedBytes.Buffer.Length);
            };
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _serverPort = int.Parse(remoteUdpPort.Text);
            _waveIn.DataAvailable += sendVoiceData;
            _thread = new Thread(receiveVoiceData);
            _thread.Start();

            remoteConnStatusLabel.Text = "Connected!";
        }
    }
}
