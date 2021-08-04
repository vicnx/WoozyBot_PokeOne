using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using AutoItX3Lib;
using System.Threading;



namespace WoozyBot
{
    public partial class WoozyBot : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        AutoItX3 au3 = new AutoItX3();
        public object[] pixCoord;
        public WoozyBot()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void WoozyBot_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
                StartButton.Enabled = false;
                StopButton.Enabled = true;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != false)
            {
                backgroundWorker1.CancelAsync();
                StartButton.Enabled = true;
                StopButton.Enabled = false;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Random randNum = new Random();
            string[] andar = new string[] { "www", "sss", "ddd", "aaa" };
            while (true)
            {
                if (worker.CancellationPending == true)
                {
                    break;

                }
                if (!random.Checked)
                {
                    movePlayer("ddd", 2);
                    movePlayer("aaa", 2);
                }
                else
                {
                    movePlayer(andar[randNum.Next(4)], 2);
                }
                //Mientras este en una batalla
                while (PixelDetect(0x568A1F, 1177, 1040, 1920, 1080) == true)
                {
                    MessageBox.Show("BATALLAAAAA");
                    if (PixelDetect(0x512F00, 0, 0, 1920, 1080) == true)
                    {
                        MessageBox.Show("ALGO ESPECIAL ENCONTRADO MAS NAO IDENTIFICADO :(");
                        break;
                    }
                    else
                    {
                        if (!AlwaysRun.Checked)
                        {
                            atacar();
                        }
                    }
                }
                //if (detectarPixel(0x568A1F, 1177, 1040, 1920, 1080) == true) // detecta el pixel verde de HUIR (Entocnes es que esta en una batalla)
                //{
                //    MessageBox.Show("BATALLAAAAA");
                //    if (detectarPixel(0x512F00, 0, 0, 1920, 1080) == true) 
                //    {
                //        MessageBox.Show("ALGO ESPECIAL ENCONTRADO MAS NAO IDENTIFICADO :(");
                //        break;
                //    }
                //    else
                //    {
                //        if (!fugir.Checked)
                //        {
                //            atacar();
                //        }

                //    }
                //}
            }
        }
        void atacar()
        {
            au3.MouseClick("LEFT", 963, 974, 1, 2);
            Thread.Sleep(500);
            if (move1.Checked)
            //if (detectarPixel(0x828282, 745, 873,1920,1080) == false && move1.Checked)
            {
                Thread.Sleep(50);
                au3.MouseClick("LEFT", 854, 883, 1, 2);//Move 1
            }
            else if (move2.Checked)
            //else if (detectarPixel(0x828282, 1160, 870,1920,1080) == false && move2.Checked)
            {
                Thread.Sleep(50);
                au3.MouseClick("LEFT", 1046, 883, 1, 2);//Move 2
            }
            //else if (detectarPixel(0x828282, 752, 953,1920,1080) == false && move3.Checked)
            else if (move3.Checked)
            {
                Thread.Sleep(50);
                au3.MouseClick("LEFT", 843, 969, 1, 2);//Move 3
            }
            else if (move4.Checked)
            {
                Thread.Sleep(50);
                au3.MouseClick("LEFT", 1077, 969, 1, 2);//Move 4
            }
        }

        void movePlayer(string direcao, int mover)
        {
            for (int i = 0; i < mover; i++)
            {
                au3.Send(direcao);
                Thread.Sleep(300);
            }
        }

        bool PixelDetect(int pixel, int xcima, int ycima, int xbaixo, int ybaixo)
        {
            Object pix = au3.PixelSearch(xcima, ycima, 1920, 1080, pixel);
            if (pix.ToString() != "1")
            {
                try
                {
                    pixCoord = (object[])pix;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void move2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
