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
using System.Diagnostics;
using System.Drawing.Imaging;

namespace WoozyBot
{
    public partial class WoozyBot : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        AutoItX3 au3 = new AutoItX3();
        public object[] pixCoord;
        public int PokeOneWindowX, PokeOneWindowY;
        public int resolutionX, resolutionY;
        public Boolean iniciobatalla;
        public string PokemonPos;
        public string waterLocation;
        public string moveDirection;

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
            resolutionCombo.SelectedItem = "1920x1080";
            waterLocationCombo.SelectedItem = "TOP";
            moveDirectionCombo.SelectedItem = "UPDOWN";
            changePKMCombo.SelectedItem = "Segundo";
        }
        public void Start()
        {
            if (checkGameOpen())
            {
                if (backgroundWorker1.IsBusy != true)
                {
                    backgroundWorker1.RunWorkerAsync();
                    StartButton.Enabled = false;
                    StopButton.Enabled = true;
                    panicButton.Enabled = true;
                    getGamePosition();
                    getGetResolutionGame();
                    PokemonPos = changePKMCombo.SelectedItem.ToString();
                    waterLocation = waterLocationCombo.SelectedItem.ToString();
                    moveDirection = moveDirectionCombo.SelectedItem.ToString();
                    au3.WinActivate("PokeOne"); //Se situa sobre el juego
                }
            }
            else
            {
                MessageBox.Show("El juego esta cerrado, abrelo antes de pulsar Start.");
            }
        }
        public void Stop()
        {
            MessageBox.Show("Si estas en medio de un combate el BOT parará al finalizar.");
            if (backgroundWorker1.IsBusy != false)
            {
                backgroundWorker1.CancelAsync();

                if (StartButton.InvokeRequired)
                {
                    StartButton.Invoke(new MethodInvoker(delegate
                    {

                        StartButton.Enabled = true;
                        StopButton.Enabled = false;
                        panicButton.Enabled = false;
                    }));
                }
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            Random r = new Random();
            BackgroundWorker worker = sender as BackgroundWorker;
            while (checkGameOpen())
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                iniciobatalla = true;
                movePlayer();
                while (PixelDetect(0x9CE799, 30, 40) == true || PixelDetect(0x69A226, 1094, 1041))
                {
                    if (PixelDetect(0xAA2826, 912, 975) == true || PixelDetect(0x69A226, 1094, 1041)) // Boton atacar o huir
                    {
                        if (iniciobatalla == true)
                        {
                            if (changePKM.Checked)
                            {
                                changePokemon();
                            }
                            iniciobatalla = false;
                        }
                        else
                        {
                            combate();
                        }
                    }

                }
            }
            if (checkGameOpen())
            {
                Stop();
            }
            else
            {
                MessageBox.Show("Has cerrado el juego, abrelo para continuar.");
            }
        }

        void combate()
        {
            if (shinyCheck())
            {
                MessageBox.Show("SHINY");
                MessageBox.Show("SHINY2");
                MessageBox.Show("SHINY3");
                MessageBox.Show("SHINY4");
                Stop();
            }
            else
            {
                if (!AlwaysRun.Checked)
                {
                    atacar();
                }
            }
        }

        void atacar()
        {
            Random r = new Random();
            //Refrescamos la posicion del juego para evitar errores
            getGamePosition();
            //1080x720
            //au3.MouseClick("LEFT", PokeOneWindowX + 691, PokeOneWindowY + 616, 1, 2);
            au3.MouseClick("LEFT", PokeOneWindowX + 993, PokeOneWindowY + 976, 1, 2);
            Thread.Sleep(r.Next(200, 500));
            if (move1.Checked)
            //if (detectarPixel(0x828282, 745, 873,1920,1080) == false && move1.Checked)
            {
                Thread.Sleep(r.Next(50, 70));
                //1080x720
                //au3.MouseClick("LEFT", PokeOneWindowX + 595, PokeOneWindowY + 553, 1, 2);//Move 1
                au3.MouseClick("LEFT", PokeOneWindowX + 884, PokeOneWindowY + 889, 1, 2);//Move 1
            }
            if (move2.Checked)
            //else if (detectarPixel(0x828282, 1160, 870,1920,1080) == false && move2.Checked)
            {
                Thread.Sleep(r.Next(50, 70));

                au3.MouseClick("LEFT", PokeOneWindowX + 1129, PokeOneWindowY + 889, 1, 2);//Move 2
                //1080x720//au3.MouseClick("LEFT", PokeOneWindowX + 806, PokeOneWindowY + 553, 1, 2);//Move 2
            }
            //else if (detectarPixel(0x828282, 752, 953,1920,1080) == false && move3.Checked)
            if (move3.Checked)
            {
                Thread.Sleep(r.Next(50, 70));
                au3.MouseClick("LEFT", PokeOneWindowX + 898, PokeOneWindowY + 982, 1, 2);//Move 3
                //1080x720//au3.MouseClick("LEFT", PokeOneWindowX + 574, PokeOneWindowY + 618, 1, 2);//Move 3
            }
            if (move4.Checked)
            {
                Thread.Sleep(r.Next(50,70));
                au3.MouseClick("LEFT", PokeOneWindowX + 1121, PokeOneWindowY + 982, 1, 2);//Move 4
                //1080x720//au3.MouseClick("LEFT", PokeOneWindowX + 824, PokeOneWindowY + 618, 1, 2);//Move 4
            }
        }

        void moveAction(string direction)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 3); i++)
            {
                au3.Send(direction);
                Thread.Sleep(r.Next(100, 300));
            }
        }

        void movePlayer()//Se encarga de comprobar el modo seleccionado y ejecutar el movimiento.
        {
            Random r = new Random();
            string[] direccion = new string[] { "www", "sss", "ddd", "aaa" };
            string[] direccion2 = new string[] { "www", "sss", "ddd", "aaa", "w", "s", "d", "a"};
            string mode = groupBoxMove2.Controls.OfType<RadioButton>().FirstOrDefault(j => j.Checked).Name;
            switch (mode)
            {
                case "randomRadio":
                    moveAction(direccion2[r.Next(8)]);
                    break;
                case "updownRadio":
                    moveAction(direccion[0]);
                    moveAction(direccion[1]);
                    break;
                case "fishModeRadio":
                    FishModeMove();
                    break;
                default:
                    moveAction(direccion[2]);
                    moveAction(direccion[3]);
                    break;

            }
        }

        void FishModeMove()
        {
            switch (waterLocation)
            {
                case "TOP":
                    fishmovement(moveDirection, 10);
                    Thread.Sleep(100);
                    au3.Send("ww");
                    au3.Send("ww");
                    Thread.Sleep(500);
                    au3.Send("1");
                    Thread.Sleep(500);
                    break;
                case "bottom":
                    fishmovement(moveDirection, 10);
                    Thread.Sleep(100);
                    au3.Send("ss");
                    au3.Send("ss");
                    Thread.Sleep(500);
                    au3.Send("1");
                    Thread.Sleep(500);
                    break;
                case "LEFT":
                    fishmovement(moveDirection, 10);
                    Thread.Sleep(100);
                    au3.Send("aa");
                    au3.Send("aa");
                    Thread.Sleep(500);
                    au3.Send("1");
                    Thread.Sleep(500);
                    break;
                case "RIGHT":
                    fishmovement(moveDirection, 10);
                    Thread.Sleep(100);
                    au3.Send("dd");
                    au3.Send("dd");
                    Thread.Sleep(500);
                    au3.Send("1");
                    Thread.Sleep(500);
                    break;
            }
        }

        void fishmovement(string direction, int steps)
        {
            Random r = new Random();
            for (int i = 0; i < steps; i++)
            {
                if(direction == "UPDOWN")
                {
                    au3.Send("ww");
                    au3.Send("ss");
                }
                else
                {
                    au3.Send("aa");
                    au3.Send("dd");
                }
                Thread.Sleep(r.Next(90,150));
            }
        }

        bool PixelDetect(int pixel, int xcima, int ycima)
        {
            //Refrescamos la posicion del juego para evitar errores
            getGamePosition();
            Object pix = au3.PixelSearch(xcima, ycima, PokeOneWindowX + resolutionX, PokeOneWindowY + resolutionY, pixel);
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
        void getGamePosition()
        {
            PokeOneWindowX = au3.WinGetPosX("PokeOne");
            PokeOneWindowY = au3.WinGetPosY("PokeOne");
        }

        void getGetResolutionGame()
        {
            string resSel = resolutionCombo.SelectedItem.ToString();
            string[] resSplit = resSel.Split('x');
            resolutionX = Int32.Parse(resSplit[0]);
            resolutionY = Int32.Parse(resSplit[1]);
        }

        bool checkGameOpen()
        {
            bool result;
            result = au3.WinExists("PokeOne") == 1 ? true : false;
            return result;

        }

        void changePokemon()
        {
            au3.MouseClick("LEFT", PokeOneWindowX + 840, PokeOneWindowY + 1041, 1, 2);
            Thread.Sleep(300);
            if (PokemonPos == "Segundo")
            {
                au3.MouseClick("LEFT", PokeOneWindowX + 971, PokeOneWindowY + 395, 1, 2);

            }
        }
        
        bool shinyCheck()
        {
            if (shinycheckbox.Checked)
            {
                object pix = au3.PixelSearch(0, 0, 1920, 1080, 0x512F00);
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
            else
            {
                return false;
            }

        }

        private void panicButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fishModeRadio_CheckedChanged(object sender, EventArgs e)
        {
            string mode = groupBoxMove2.Controls.OfType<RadioButton>().FirstOrDefault(j => j.Checked).Name;
            MessageBox.Show(mode);
            if (mode == "fishModeRadio")
            {
                waterLocationCombo.Enabled = true;
                moveDirectionCombo.Enabled = true;
            }
            else
            {
                waterLocationCombo.Enabled = false;
                moveDirectionCombo.Enabled = false;
            }
        }


        private void changePKM_CheckedChanged(object sender, EventArgs e)
        {
            if(changePKM.Checked == true)
            {
                changePKMCombo.Enabled = true;
            }
            else
            {
                changePKMCombo.Enabled = false;
            }
        }

        private void KeypressForm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
