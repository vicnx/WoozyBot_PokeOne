﻿using System;
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
        public int PokeOneWindowX;
        public int PokeOneWindowY;

        public WoozyBot()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green700, MaterialSkin.Primary.Green100, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.WHITE);
        }

        private void WoozyBot_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (checkGameOpen())
            {
                if (backgroundWorker1.IsBusy != true)
                {
                    backgroundWorker1.RunWorkerAsync();
                    StartButton.Enabled = false;
                    StopButton.Enabled = true;
                    getPokeOnePosition();
                    au3.WinActivate("PokeOne"); //Se situa sobre el juego
                }
            }
            else
            {
                MessageBox.Show("El juego esta cerrado, abrelo antes de pulsar Start.");
            }

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopBot();
        }

        void StopBot()
        {
            if (backgroundWorker1.IsBusy != false)
            {
                backgroundWorker1.CancelAsync();

                if (StartButton.InvokeRequired)
                {
                    StartButton.Invoke(new MethodInvoker(delegate
                    {

                        StartButton.Enabled = true;
                        StopButton.Enabled = false;
                    }));
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (checkGameOpen())
            {
                if (worker.CancellationPending == true)
                {
                    break;

                }
                movePlayer();
                //Mientras este en una batalla
                while (PixelDetect(0x568A1F, 864, 684, 1920, 1080) == true)
                {
                    if (PixelDetect(0x512F00, 0, 0, 1920, 1080) == true) //NOT WORKING
                    {
                        MessageBox.Show("SHINY");
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
            }
            MessageBox.Show("Has cerrado el juego, abrelo para continuar.");

            StopBot();
        }
        void atacar()
        {
            Random r = new Random();
            //Refrescamos la posicion del juego para evitar errores
            getPokeOnePosition();
            au3.MouseClick("LEFT", PokeOneWindowX + 691, PokeOneWindowY + 616, 1, 2);
            Thread.Sleep(500);
            if (move1.Checked)
            //if (detectarPixel(0x828282, 745, 873,1920,1080) == false && move1.Checked)
            {
                Thread.Sleep(r.Next(50, 70));
                au3.MouseClick("LEFT", PokeOneWindowX + 595, PokeOneWindowY + 553, 1, 2);//Move 1
            }
            else if (move2.Checked)
            //else if (detectarPixel(0x828282, 1160, 870,1920,1080) == false && move2.Checked)
            {
                Thread.Sleep(r.Next(50, 70));

                au3.MouseClick("LEFT", PokeOneWindowX + 806, PokeOneWindowY + 553, 1, 2);//Move 2
            }
            //else if (detectarPixel(0x828282, 752, 953,1920,1080) == false && move3.Checked)
            else if (move3.Checked)
            {
                Thread.Sleep(r.Next(50, 70));
                au3.MouseClick("LEFT", PokeOneWindowX + 574, PokeOneWindowY + 618, 1, 2);//Move 3
            }
            else if (move4.Checked)
            {
                Thread.Sleep(r.Next(50,70));
                au3.MouseClick("LEFT", PokeOneWindowX + 824, PokeOneWindowY + 618, 1, 2);//Move 4
            }
        }

        void moveAction(string direction)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 3); i++)
            {
                au3.Send(direction);
                Thread.Sleep(r.Next(200, 300));
            }
        }

        void movePlayer()//Se encarga de comprobar el modo seleccionado y ejecutar el movimiento.
        {
            Random r = new Random();
            string[] pasos = new string[] { "www", "sss", "ddd", "aaa" };
            string mode = groupBoxMove2.Controls.OfType<RadioButton>().FirstOrDefault(j => j.Checked).Name;
            switch (mode)
            {
                case "randomRadio":
                    moveAction(pasos[r.Next(4)]);
                    break;
                case "updownRadio":
                    moveAction(pasos[0]);
                    moveAction(pasos[1]);
                    break;
                default:
                    moveAction(pasos[2]);
                    moveAction(pasos[3]);
                    break;

            }
        }

        bool PixelDetect(int pixel, int xcima, int ycima, int xbaixo, int ybaixo)
        {
            //Refrescamos la posicion del juego para evitar errores
            getPokeOnePosition();
            //Ahora el juego tiene que estar en 1280 y 720 windowed mode para que funcione relativo
            Object pix = au3.PixelSearch(xcima, ycima, PokeOneWindowX + 1280, PokeOneWindowY +720, pixel);
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
        void getPokeOnePosition()
        {
            PokeOneWindowX = au3.WinGetPosX("PokeOne");
            PokeOneWindowY = au3.WinGetPosY("PokeOne");
        }

        bool checkGameOpen()
        {
            if(au3.WinExists("PokeOne") == 1)
            {
                return true;
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

        private void AlwaysRun_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxOptions_Enter(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }
    }
}
