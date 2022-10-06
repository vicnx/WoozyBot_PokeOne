
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoozyBot));
            MaterialSkin.Controls.MaterialLabel inFoText;
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
            this.movausarLabel = new MaterialSkin.Controls.MaterialLabel();
            this.defaultRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.updownRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.randomRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBoxMove2 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Player = new System.Windows.Forms.TabPage();
            this.Moves = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Info = new System.Windows.Forms.TabPage();
            inFoText = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckedListBox2.SuspendLayout();
            this.groupBoxMove2.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.Player.SuspendLayout();
            this.Moves.SuspendLayout();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = false;
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Depth = 0;
            this.StartButton.DrawShadows = true;
            this.StartButton.HighEmphasis = true;
            this.StartButton.Icon = null;
            this.StartButton.Location = new System.Drawing.Point(115, 227);
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
            this.StopButton.AutoSize = false;
            this.StopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Depth = 0;
            this.StopButton.DrawShadows = true;
            this.StopButton.Enabled = false;
            this.StopButton.HighEmphasis = true;
            this.StopButton.Icon = null;
            this.StopButton.Location = new System.Drawing.Point(190, 227);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(67, 36);
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
            this.AlwaysRun.Location = new System.Drawing.Point(5, 173);
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
            this.move1.Checked = true;
            this.move1.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.materialCheckedListBox2.Location = new System.Drawing.Point(28, 50);
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
            this.OpcionesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OpcionesLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.OpcionesLabel.Location = new System.Drawing.Point(23, 17);
            this.OpcionesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpcionesLabel.Name = "OpcionesLabel";
            this.OpcionesLabel.Size = new System.Drawing.Size(146, 19);
            this.OpcionesLabel.TabIndex = 10;
            this.OpcionesLabel.Text = "Dirección al caminar";
            this.OpcionesLabel.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // movausarLabel
            // 
            this.movausarLabel.AutoSize = true;
            this.movausarLabel.BackColor = System.Drawing.Color.Transparent;
            this.movausarLabel.Depth = 0;
            this.movausarLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.movausarLabel.Location = new System.Drawing.Point(25, 28);
            this.movausarLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.movausarLabel.Name = "movausarLabel";
            this.movausarLabel.Size = new System.Drawing.Size(92, 19);
            this.movausarLabel.TabIndex = 11;
            this.movausarLabel.Text = "Movs. a usar";
            // 
            // defaultRadio
            // 
            this.defaultRadio.AutoSize = true;
            this.defaultRadio.Checked = true;
            this.defaultRadio.Depth = 0;
            this.defaultRadio.Location = new System.Drawing.Point(15, 43);
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
            // updownRadio
            // 
            this.updownRadio.AutoSize = true;
            this.updownRadio.Depth = 0;
            this.updownRadio.Location = new System.Drawing.Point(15, 80);
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
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Depth = 0;
            this.randomRadio.Location = new System.Drawing.Point(15, 117);
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
            // groupBoxMove2
            // 
            this.groupBoxMove2.AutoScroll = true;
            this.groupBoxMove2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMove2.Controls.Add(this.randomRadio);
            this.groupBoxMove2.Controls.Add(this.updownRadio);
            this.groupBoxMove2.Controls.Add(this.defaultRadio);
            this.groupBoxMove2.Controls.Add(this.OpcionesLabel);
            this.groupBoxMove2.Depth = 0;
            this.groupBoxMove2.Location = new System.Drawing.Point(-4, 0);
            this.groupBoxMove2.MouseState = MaterialSkin.MouseState.HOVER;
            this.groupBoxMove2.Name = "groupBoxMove2";
            this.groupBoxMove2.Size = new System.Drawing.Size(272, 167);
            this.groupBoxMove2.Striped = false;
            this.groupBoxMove2.StripeDarkColor = System.Drawing.Color.Empty;
            this.groupBoxMove2.TabIndex = 15;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.materialTabControl1.Controls.Add(this.Player);
            this.materialTabControl1.Controls.Add(this.Moves);
            this.materialTabControl1.Controls.Add(this.Info);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(331, 343);
            this.materialTabControl1.TabIndex = 16;
            // 
            // Player
            // 
            this.Player.AutoScroll = true;
            this.Player.Controls.Add(this.StopButton);
            this.Player.Controls.Add(this.AlwaysRun);
            this.Player.Controls.Add(this.StartButton);
            this.Player.Controls.Add(this.groupBoxMove2);
            this.Player.ImageKey = "user.png";
            this.Player.Location = new System.Drawing.Point(4, 42);
            this.Player.Name = "Player";
            this.Player.Padding = new System.Windows.Forms.Padding(3);
            this.Player.Size = new System.Drawing.Size(323, 297);
            this.Player.TabIndex = 0;
            this.Player.Text = "Player";
            this.Player.UseVisualStyleBackColor = true;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // Moves
            // 
            this.Moves.Controls.Add(this.materialCheckedListBox2);
            this.Moves.Controls.Add(this.movausarLabel);
            this.Moves.ImageKey = "settings.png";
            this.Moves.Location = new System.Drawing.Point(4, 42);
            this.Moves.Name = "Moves";
            this.Moves.Padding = new System.Windows.Forms.Padding(3);
            this.Moves.Size = new System.Drawing.Size(323, 297);
            this.Moves.TabIndex = 1;
            this.Moves.Text = "Settings";
            this.Moves.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "settings.png");
            this.imageList1.Images.SetKeyName(1, "user.png");
            this.imageList1.Images.SetKeyName(2, "settings_16px.png");
            this.imageList1.Images.SetKeyName(3, "user_16px.png");
            this.imageList1.Images.SetKeyName(4, "information.png");
            // 
            // Info
            // 
            this.Info.Controls.Add(inFoText);
            this.Info.ImageKey = "information.png";
            this.Info.Location = new System.Drawing.Point(4, 42);
            this.Info.Name = "Info";
            this.Info.Padding = new System.Windows.Forms.Padding(3);
            this.Info.Size = new System.Drawing.Size(323, 297);
            this.Info.TabIndex = 2;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // inFoText
            // 
            inFoText.Depth = 0;
            inFoText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            inFoText.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inFoText.Location = new System.Drawing.Point(8, 14);
            inFoText.MouseState = MaterialSkin.MouseState.HOVER;
            inFoText.Name = "inFoText";
            inFoText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            inFoText.Size = new System.Drawing.Size(261, 138);
            inFoText.TabIndex = 1;
            inFoText.Text = "Para que el BOT funcione correctamente tienes que aplicar la siguiente configurac" +
    "ión:\n\nResolución: 1280x720\nModo: Ventana completa sin bordes (windowed mode)\n";
            inFoText.Click += new System.EventHandler(this.materialLabel1_Click_2);
            // 
            // WoozyBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 343);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerHighlightWithAccent = false;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WoozyBot";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoozyBot (Beta)";
            this.Load += new System.EventHandler(this.WoozyBot_Load);
            this.materialCheckedListBox2.ResumeLayout(false);
            this.materialCheckedListBox2.PerformLayout();
            this.groupBoxMove2.ResumeLayout(false);
            this.groupBoxMove2.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.Player.ResumeLayout(false);
            this.Player.PerformLayout();
            this.Moves.ResumeLayout(false);
            this.Moves.PerformLayout();
            this.Info.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private MaterialSkin.Controls.MaterialLabel movausarLabel;
        private MaterialSkin.Controls.MaterialRadioButton updownRadio;
        private MaterialSkin.Controls.MaterialRadioButton randomRadio;
        private MaterialSkin.Controls.MaterialRadioButton defaultRadio;
        private MaterialSkin.Controls.MaterialCheckedListBox groupBoxMove2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Player;
        private System.Windows.Forms.TabPage Moves;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage Info;
    }
}

