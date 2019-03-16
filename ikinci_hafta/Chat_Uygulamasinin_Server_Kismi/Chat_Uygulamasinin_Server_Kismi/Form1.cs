using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Chat_Uygulamasinin_Server_Kismi
{
    public partial class Form1 : Form
    {
        private TcpClient Musteri;
        public StreamReader Str;
        public StreamWriter Stw;
        public string Alici;
        public string GonderilenMetin;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] yerelIP = Dns.GetHostAddresses(Dns.GetHostName());//Kendi IP mi aldım.
            foreach (IPAddress adres in yerelIP)
            {
                if (adres.AddressFamily == AddressFamily.InterNetwork)
                {
                    TxtServerIP.Text = adres.ToString();
                }
            }
        }

        private void SunucuyuBaslat_Click(object sender, EventArgs e)//Sunucuyu başlatma.
        {
            TcpListener dinleyici = new TcpListener(IPAddress.Any, int.Parse(TxtServerPort.Text));
            dinleyici.Start();
            Musteri = dinleyici.AcceptTcpClient();
            Str = new StreamReader(Musteri.GetStream());
            Stw = new StreamWriter(Musteri.GetStream());
            Stw.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();//Arkaplanda veri alımını başlat.
            backgroundWorker2.WorkerSupportsCancellation = true;//Bu konuyu iptal etme yeteneği
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)//Alınan veri
        {
            while (Musteri.Connected)
            {
                try
                {
                    Alici = Str.ReadLine();
                    this.textBox2.Invoke(new MethodInvoker(delegate () { textBox2.AppendText("Sen: " + Alici + "\n"); }));
                    Alici = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)//Gönderilen veri
        {
            if (Musteri.Connected)
            {
                Stw.WriteLine(GonderilenMetin);
                this.textBox2.Invoke(new MethodInvoker(delegate() { textBox2.AppendText("Ben: " + GonderilenMetin + "\n"); }));
            }
            else
            {
                MessageBox.Show("Mesaj gönderilemedi!");
            }
            backgroundWorker2.CancelAsync();
        }

        private void Gonder_Click(object sender, EventArgs e)//Gönder Butonu
        {
            if (textBox1.Text != "")
            {
                GonderilenMetin = textBox1.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            textBox1.Text = "";
        }

        private void ServeraBaglan_Click(object sender, EventArgs e)//Server'a bağlanma
        {
            Musteri = new TcpClient();
            IPEndPoint SonIP = new IPEndPoint(IPAddress.Parse(TxtMusteriIP.Text), int.Parse(TxtMusteriPort.Text));
            try
            {
                Musteri.Connect(SonIP);
                if (Musteri.Connected)
                {
                    textBox2.AppendText("Sunucuya bağlandı." + "\n");
                    Stw = new StreamWriter(Musteri.GetStream());
                    Str = new StreamReader(Musteri.GetStream());
                    Stw.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync();//Arkaplanda veri alımını başlat.
                    backgroundWorker2.WorkerSupportsCancellation = true;//Bu konuyu iptal etme yeteneği
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
    }
}
