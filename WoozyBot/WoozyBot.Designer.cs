
namespace WoozyBot
{
    partial class WoozyBot
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms
        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoozyBot));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StartButton = new MaterialSkin.Controls.MaterialButton();
            this.StopButton = new MaterialSkin.Controls.MaterialButton();
            this.AlwaysRun = new MaterialSkin.Controls.MaterialCheckbox();
            this.move2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.move1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.move3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.move4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckedListBox2 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.OpcionesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleMenu = new System.Windows.Forms.Label();
            this.movausarLabel = new MaterialSkin.Controls.MaterialLabel();
            this.groupBoxMoves = new System.Windows.Forms.GroupBox();
            this.randomRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.updownRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.defaultRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCheckedListBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxMoves.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // StartButton
            // 
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.Depth = 0;
            this.StartButton.DrawShadows = true;
            this.StartButton.HighEmphasis = true;
            this.StartButton.Icon = null;
            this.StartButton.Location = new System.Drawing.Point(13, 285);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(67, 36);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartButton.UseAccentColor = false;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.Depth = 0;
            this.StopButton.DrawShadows = true;
            this.StopButton.Enabled = false;
            this.StopButton.HighEmphasis = true;
            this.StopButton.Icon = null;
            this.StopButton.Location = new System.Drawing.Point(88, 285);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(58, 36);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StopButton.UseAccentColor = false;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // AlwaysRun
            // 
            this.AlwaysRun.AutoSize = true;
            this.AlwaysRun.Depth = 0;
            this.AlwaysRun.Location = new System.Drawing.Point(9, 236);
            this.AlwaysRun.Margin = new System.Windows.Forms.Padding(0);
            this.AlwaysRun.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AlwaysRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.AlwaysRun.Name = "AlwaysRun";
            this.AlwaysRun.Ripple = true;
            this.AlwaysRun.Size = new System.Drawing.Size(126, 37);
            this.AlwaysRun.TabIndex = 3;
            this.AlwaysRun.Text = "Huir Siempre";
            this.AlwaysRun.UseVisualStyleBackColor = true;
            this.AlwaysRun.CheckedChanged += new System.EventHandler(this.AlwaysRun_CheckedChanged);
            // 
            // move2
            // 
            this.move2.AutoSize = true;
            this.move2.Depth = 0;
            this.move2.Location = new System.Drawing.Point(10, 49);
            this.move2.Margin = new System.Windows.Forms.Padding(0);
            this.move2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.move2.MouseState = MaterialSkin.MouseState.HOVER;
            this.move2.Name = "move2";
            this.move2.Ripple = true;
            this.move2.Size = new System.Drawing.Size(132, 37);
            this.move2.TabIndex = 6;
            this.move2.Text = "Movimiento 2";
            this.move2.UseVisualStyleBackColor = true;
            this.move2.CheckedChanged += new System.EventHandler(this.move2_CheckedChanged);
            // 
            // move1
            // 
            this.move1.AutoSize = true;
            this.move1.Depth = 0;
            this.move1.Location = new System.Drawing.Point(10, 12);
            this.move1.Margin = new System.Windows.Forms.Padding(0);
            this.move1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.move1.MouseState = MaterialSkin.MouseState.HOVER;
            this.move1.Name = "move1";
            this.move1.Ripple = true;
            this.move1.Size = new System.Drawing.Size(132, 37);
            this.move1.TabIndex = 5;
            this.move1.Text = "Movimiento 1";
            this.move1.UseVisualStyleBackColor = true;
            // 
            // move3
            // 
            this.move3.AutoSize = true;
            this.move3.Depth = 0;
            this.move3.Location = new System.Drawing.Point(10, 86);
            this.move3.Margin = new System.Windows.Forms.Padding(0);
            this.move3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.move3.MouseState = MaterialSkin.MouseState.HOVER;
            this.move3.Name = "move3";
            this.move3.Ripple = true;
            this.move3.Size = new System.Drawing.Size(132, 37);
            this.move3.TabIndex = 7;
            this.move3.Text = "Movimiento 3";
            this.move3.UseVisualStyleBackColor = true;
            // 
            // move4
            // 
            this.move4.AutoSize = true;
            this.move4.Depth = 0;
            this.move4.Location = new System.Drawing.Point(10, 123);
            this.move4.Margin = new System.Windows.Forms.Padding(0);
            this.move4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.move4.MouseState = MaterialSkin.MouseState.HOVER;
            this.move4.Name = "move4";
            this.move4.Ripple = true;
            this.move4.Size = new System.Drawing.Size(132, 37);
            this.move4.TabIndex = 8;
            this.move4.Text = "Movimiento 4";
            this.move4.UseVisualStyleBackColor = true;
            // 
            // materialCheckedListBox2
            // 
            this.materialCheckedListBox2.AutoScroll = true;
            this.materialCheckedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.materialCheckedListBox2.Controls.Add(this.move1);
            this.materialCheckedListBox2.Controls.Add(this.move4);
            this.materialCheckedListBox2.Controls.Add(this.move2);
            this.materialCheckedListBox2.Controls.Add(this.move3);
            this.materialCheckedListBox2.Depth = 0;
            this.materialCheckedListBox2.Location = new System.Drawing.Point(182, 102);
            this.materialCheckedListBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox2.Name = "materialCheckedListBox2";
            this.materialCheckedListBox2.Size = new System.Drawing.Size(160, 177);
            this.materialCheckedListBox2.Striped = false;
            this.materialCheckedListBox2.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox2.TabIndex = 9;
            // 
            // OpcionesLabel
            // 
            this.OpcionesLabel.AutoSize = true;
            this.OpcionesLabel.BackColor = System.Drawing.Color.Transparent;
            this.OpcionesLabel.Depth = 0;
            this.OpcionesLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.OpcionesLabel.Location = new System.Drawing.Point(12, 78);
            this.OpcionesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpcionesLabel.Name = "OpcionesLabel";
            this.OpcionesLabel.Size = new System.Drawing.Size(157, 19);
            this.OpcionesLabel.TabIndex = 10;
            this.OpcionesLabel.Text = "Movimiento del player";
            this.OpcionesLabel.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // TitleMenu
            // 
            this.TitleMenu.AutoSize = true;
            this.TitleMenu.BackColor = System.Drawing.Color.Transparent;
            this.TitleMenu.Font = new System.Drawing.Font("Pricedown Bl", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleMenu.Location = new System.Drawing.Point(74, 21);
            this.TitleMenu.Name = "TitleMenu";
            this.TitleMenu.Size = new System.Drawing.Size(160, 38);
            this.TitleMenu.TabIndex = 13;
            this.TitleMenu.Text = "WoozyBot";
            // 
            // movausarLabel
            // 
            this.movausarLabel.AutoSize = true;
            this.movausarLabel.BackColor = System.Drawing.Color.Transparent;
            this.movausarLabel.Depth = 0;
            this.movausarLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.movausarLabel.Location = new System.Drawing.Point(220, 80);
            this.movausarLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.movausarLabel.Name = "movausarLabel";
            this.movausarLabel.Size = new System.Drawing.Size(92, 19);
            this.movausarLabel.TabIndex = 11;
            this.movausarLabel.Text = "Movs. a usar";
            // 
            // groupBoxMoves
            // 
            this.groupBoxMoves.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxMoves.Controls.Add(this.defaultRadio);
            this.groupBoxMoves.Controls.Add(this.updownRadio);
            this.groupBoxMoves.Controls.Add(this.randomRadio);
            this.groupBoxMoves.Location = new System.Drawing.Point(12, 101);
            this.groupBoxMoves.Name = "groupBoxMoves";
            this.groupBoxMoves.Size = new System.Drawing.Size(157, 132);
            this.groupBoxMoves.TabIndex = 14;
            this.groupBoxMoves.TabStop = false;
            // 
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Depth = 0;
            this.randomRadio.Location = new System.Drawing.Point(7, 84);
            this.randomRadio.Margin = new System.Windows.Forms.Padding(0);
            this.randomRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.randomRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.randomRadio.Name = "randomRadio";
            this.randomRadio.Ripple = true;
            this.randomRadio.Size = new System.Drawing.Size(95, 37);
            this.randomRadio.TabIndex = 0;
            this.randomRadio.TabStop = true;
            this.randomRadio.Text = "Random";
            this.randomRadio.UseVisualStyleBackColor = true;
            // 
            // updownRadio
            // 
            this.updownRadio.AutoSize = true;
            this.updownRadio.Depth = 0;
            this.updownRadio.Location = new System.Drawing.Point(7, 47);
            this.updownRadio.Margin = new System.Windows.Forms.Padding(0);
            this.updownRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.updownRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.updownRadio.Name = "updownRadio";
            this.updownRadio.Ripple = true;
            this.updownRadio.Size = new System.Drawing.Size(93, 37);
            this.updownRadio.TabIndex = 1;
            this.updownRadio.TabStop = true;
            this.updownRadio.Text = "Updown";
            this.updownRadio.UseVisualStyleBackColor = true;
            // 
            // defaultRadio
            // 
            this.defaultRadio.AutoSize = true;
            this.defaultRadio.Checked = true;
            this.defaultRadio.Depth = 0;
            this.defaultRadio.Location = new System.Drawing.Point(7, 10);
            this.defaultRadio.Margin = new System.Windows.Forms.Padding(0);
            this.defaultRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.defaultRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.defaultRadio.Name = "defaultRadio";
            this.defaultRadio.Ripple = true;
            this.defaultRadio.Size = new System.Drawing.Size(87, 37);
            this.defaultRadio.TabIndex = 2;
            this.defaultRadio.TabStop = true;
            this.defaultRadio.Text = "Default";
            this.defaultRadio.UseVisualStyleBackColor = true;
            // 
            // WoozyBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 336);
            this.Controls.Add(this.AlwaysRun);
            this.Controls.Add(this.groupBoxMoves);
            this.Controls.Add(this.TitleMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.movausarLabel);
            this.Controls.Add(this.OpcionesLabel);
            this.Controls.Add(this.materialCheckedListBox2);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.DrawerHighlightWithAccent = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WoozyBot";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WoozyBot_Load);
            this.materialCheckedListBox2.ResumeLayout(false);
            this.materialCheckedListBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxMoves.ResumeLayout(false);
            this.groupBoxMoves.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton StartButton;
        private MaterialSkin.Controls.MaterialButton StopButton;
        private MaterialSkin.Controls.MaterialCheckbox AlwaysRun;
        private MaterialSkin.Controls.MaterialCheckbox move2;
        private MaterialSkin.Controls.MaterialCheckbox move1;
        private MaterialSkin.Controls.MaterialCheckbox move3;
        private MaterialSkin.Controls.MaterialCheckbox move4;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox2;
        private MaterialSkin.Controls.MaterialLabel OpcionesLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleMenu;
        private MaterialSkin.Controls.MaterialLabel movausarLabel;
        private System.Windows.Forms.GroupBox groupBoxMoves;
        private MaterialSkin.Controls.MaterialRadioButton updownRadio;
        private MaterialSkin.Controls.MaterialRadioButton randomRadio;
        private MaterialSkin.Controls.MaterialRadioButton defaultRadio;
    }
}

