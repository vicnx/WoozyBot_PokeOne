
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
            MaterialSkin.Controls.MaterialLabel inFoText;
            MaterialSkin.Controls.MaterialLabel materialLabel2;
            MaterialSkin.Controls.MaterialLabel materialLabel3;
            MaterialSkin.Controls.MaterialLabel materialLabel4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoozyBot));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Info = new System.Windows.Forms.TabPage();
            this.Moves = new System.Windows.Forms.TabPage();
            this.materialCheckedListBox2 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.resolutionCombo = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.move1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.movausarLabel = new MaterialSkin.Controls.MaterialLabel();
            this.move4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.move2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.move3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.Player = new System.Windows.Forms.TabPage();
            this.StopButton = new MaterialSkin.Controls.MaterialButton();
            this.AlwaysRun = new MaterialSkin.Controls.MaterialCheckbox();
            this.StartButton = new MaterialSkin.Controls.MaterialButton();
            this.groupBoxMove2 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.randomRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.updownRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.defaultRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.OpcionesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Pokemon = new System.Windows.Forms.TabPage();
            this.shinycheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.changePKMCombo = new System.Windows.Forms.ComboBox();
            this.changePKM = new MaterialSkin.Controls.MaterialCheckbox();
            inFoText = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.Info.SuspendLayout();
            this.Moves.SuspendLayout();
            this.materialCheckedListBox2.SuspendLayout();
            this.Player.SuspendLayout();
            this.groupBoxMove2.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.Pokemon.SuspendLayout();
            this.SuspendLayout();
            // 
            // inFoText
            // 
            inFoText.Depth = 0;
            inFoText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            inFoText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            inFoText.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            inFoText.Location = new System.Drawing.Point(8, 15);
            inFoText.MouseState = MaterialSkin.MouseState.HOVER;
            inFoText.Name = "inFoText";
            inFoText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            inFoText.Size = new System.Drawing.Size(240, 66);
            inFoText.TabIndex = 1;
            inFoText.Text = "Para que el BOT funcione correctamente tienes que añadir la resolución del juego " +
    "en la pestaña de configuración.\r\n";
            inFoText.Click += new System.EventHandler(this.materialLabel1_Click_2);
            // 
            // materialLabel2
            // 
            materialLabel2.BackColor = System.Drawing.Color.Red;
            materialLabel2.Depth = 0;
            materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            materialLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            materialLabel2.HighEmphasis = true;
            materialLabel2.Location = new System.Drawing.Point(8, 224);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            materialLabel2.Size = new System.Drawing.Size(250, 44);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Este programa se ha creado con fines educativos. \r\nEn ningún caso se recomienda u" +
    "tilizar, no me hago responsable de posibles baneos/bloqueos de cuentas.";
            materialLabel2.UseAccent = true;
            materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel3
            // 
            materialLabel3.BackColor = System.Drawing.Color.Red;
            materialLabel3.Depth = 0;
            materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            materialLabel3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            materialLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            materialLabel3.HighEmphasis = true;
            materialLabel3.Location = new System.Drawing.Point(6, 231);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            materialLabel3.Size = new System.Drawing.Size(86, 20);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Coming soon...\r\n";
            materialLabel3.UseAccent = true;
            materialLabel3.Click += new System.EventHandler(this.materialLabel1_Click_3);
            // 
            // materialLabel4
            // 
            materialLabel4.BackColor = System.Drawing.Color.Red;
            materialLabel4.Depth = 0;
            materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            materialLabel4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            materialLabel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            materialLabel4.HighEmphasis = true;
            materialLabel4.Location = new System.Drawing.Point(8, 116);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            materialLabel4.Size = new System.Drawing.Size(226, 20);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "No debes estar utilizando shiny para que funcione.";
            materialLabel4.UseAccent = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
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
            this.imageList1.Images.SetKeyName(5, "pokeball.png");
            // 
            // Info
            // 
            this.Info.Controls.Add(materialLabel2);
            this.Info.Controls.Add(inFoText);
            this.Info.ImageKey = "information.png";
            this.Info.Location = new System.Drawing.Point(4, 83);
            this.Info.Name = "Info";
            this.Info.Padding = new System.Windows.Forms.Padding(3);
            this.Info.Size = new System.Drawing.Size(312, 256);
            this.Info.TabIndex = 2;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // Moves
            // 
            this.Moves.Controls.Add(this.materialCheckedListBox2);
            this.Moves.ImageKey = "settings.png";
            this.Moves.Location = new System.Drawing.Point(4, 83);
            this.Moves.Name = "Moves";
            this.Moves.Padding = new System.Windows.Forms.Padding(3);
            this.Moves.Size = new System.Drawing.Size(312, 256);
            this.Moves.TabIndex = 1;
            this.Moves.Text = "Settings";
            this.Moves.UseVisualStyleBackColor = true;
            // 
            // materialCheckedListBox2
            // 
            this.materialCheckedListBox2.AutoScroll = true;
            this.materialCheckedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.materialCheckedListBox2.Controls.Add(this.resolutionCombo);
            this.materialCheckedListBox2.Controls.Add(this.materialLabel1);
            this.materialCheckedListBox2.Controls.Add(this.move1);
            this.materialCheckedListBox2.Controls.Add(this.movausarLabel);
            this.materialCheckedListBox2.Controls.Add(this.move4);
            this.materialCheckedListBox2.Controls.Add(this.move2);
            this.materialCheckedListBox2.Controls.Add(this.move3);
            this.materialCheckedListBox2.Depth = 0;
            this.materialCheckedListBox2.Location = new System.Drawing.Point(-4, -5);
            this.materialCheckedListBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox2.Name = "materialCheckedListBox2";
            this.materialCheckedListBox2.Size = new System.Drawing.Size(331, 306);
            this.materialCheckedListBox2.Striped = false;
            this.materialCheckedListBox2.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox2.TabIndex = 9;
            // 
            // resolutionCombo
            // 
            this.resolutionCombo.DisplayMember = "resolution";
            this.resolutionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionCombo.FormattingEnabled = true;
            this.resolutionCombo.Items.AddRange(new object[] {
            "1920x1080"});
            this.resolutionCombo.Location = new System.Drawing.Point(40, 219);
            this.resolutionCombo.Name = "resolutionCombo";
            this.resolutionCombo.Size = new System.Drawing.Size(150, 21);
            this.resolutionCombo.TabIndex = 14;
            this.resolutionCombo.ValueMember = "resolution";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(43, 197);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Resolución del juego";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click_3);
            // 
            // move1
            // 
            this.move1.AutoSize = true;
            this.move1.Checked = true;
            this.move1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.move1.Depth = 0;
            this.move1.Location = new System.Drawing.Point(40, 35);
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
            // movausarLabel
            // 
            this.movausarLabel.AutoSize = true;
            this.movausarLabel.BackColor = System.Drawing.Color.Transparent;
            this.movausarLabel.Depth = 0;
            this.movausarLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.movausarLabel.Location = new System.Drawing.Point(60, 16);
            this.movausarLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.movausarLabel.Name = "movausarLabel";
            this.movausarLabel.Size = new System.Drawing.Size(92, 19);
            this.movausarLabel.TabIndex = 11;
            this.movausarLabel.Text = "Movs. a usar";
            this.movausarLabel.Click += new System.EventHandler(this.movausarLabel_Click);
            // 
            // move4
            // 
            this.move4.AutoSize = true;
            this.move4.Depth = 0;
            this.move4.Location = new System.Drawing.Point(40, 146);
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
            // move2
            // 
            this.move2.AutoSize = true;
            this.move2.Depth = 0;
            this.move2.Location = new System.Drawing.Point(40, 72);
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
            // move3
            // 
            this.move3.AutoSize = true;
            this.move3.Depth = 0;
            this.move3.Location = new System.Drawing.Point(40, 109);
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
            // Player
            // 
            this.Player.AutoScroll = true;
            this.Player.Controls.Add(this.StopButton);
            this.Player.Controls.Add(this.AlwaysRun);
            this.Player.Controls.Add(this.StartButton);
            this.Player.Controls.Add(this.groupBoxMove2);
            this.Player.ImageKey = "user.png";
            this.Player.Location = new System.Drawing.Point(4, 83);
            this.Player.Name = "Player";
            this.Player.Padding = new System.Windows.Forms.Padding(3);
            this.Player.Size = new System.Drawing.Size(312, 256);
            this.Player.TabIndex = 0;
            this.Player.Text = "Player";
            this.Player.UseVisualStyleBackColor = true;
            this.Player.Click += new System.EventHandler(this.Player_Click);
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
            this.StopButton.Location = new System.Drawing.Point(150, 227);
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
            // StartButton
            // 
            this.StartButton.AutoSize = false;
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Depth = 0;
            this.StartButton.DrawShadows = true;
            this.StartButton.HighEmphasis = true;
            this.StartButton.Icon = null;
            this.StartButton.Location = new System.Drawing.Point(75, 227);
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
            this.groupBoxMove2.Size = new System.Drawing.Size(239, 167);
            this.groupBoxMove2.Striped = false;
            this.groupBoxMove2.StripeDarkColor = System.Drawing.Color.Empty;
            this.groupBoxMove2.TabIndex = 15;
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
            // materialTabControl1
            // 
            this.materialTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.materialTabControl1.Controls.Add(this.Player);
            this.materialTabControl1.Controls.Add(this.Moves);
            this.materialTabControl1.Controls.Add(this.Pokemon);
            this.materialTabControl1.Controls.Add(this.Info);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(320, 343);
            this.materialTabControl1.TabIndex = 16;
            // 
            // Pokemon
            // 
            this.Pokemon.Controls.Add(materialLabel4);
            this.Pokemon.Controls.Add(this.shinycheckbox);
            this.Pokemon.Controls.Add(materialLabel3);
            this.Pokemon.Controls.Add(this.changePKMCombo);
            this.Pokemon.Controls.Add(this.changePKM);
            this.Pokemon.ImageKey = "pokeball.png";
            this.Pokemon.Location = new System.Drawing.Point(4, 83);
            this.Pokemon.Name = "Pokemon";
            this.Pokemon.Padding = new System.Windows.Forms.Padding(3);
            this.Pokemon.Size = new System.Drawing.Size(312, 256);
            this.Pokemon.TabIndex = 3;
            this.Pokemon.Text = "Pokemon";
            this.Pokemon.UseVisualStyleBackColor = true;
            // 
            // shinycheckbox
            // 
            this.shinycheckbox.AutoSize = true;
            this.shinycheckbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.shinycheckbox.Depth = 0;
            this.shinycheckbox.Location = new System.Drawing.Point(5, 79);
            this.shinycheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.shinycheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.shinycheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.shinycheckbox.Name = "shinycheckbox";
            this.shinycheckbox.Ripple = true;
            this.shinycheckbox.Size = new System.Drawing.Size(122, 37);
            this.shinycheckbox.TabIndex = 4;
            this.shinycheckbox.Text = "Shiny Check";
            this.shinycheckbox.UseVisualStyleBackColor = true;
            // 
            // changePKMCombo
            // 
            this.changePKMCombo.DisplayMember = "changePKMCombo";
            this.changePKMCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changePKMCombo.Enabled = false;
            this.changePKMCombo.FormattingEnabled = true;
            this.changePKMCombo.Items.AddRange(new object[] {
            "Segundo",
            "Tercero"});
            this.changePKMCombo.Location = new System.Drawing.Point(8, 43);
            this.changePKMCombo.Name = "changePKMCombo";
            this.changePKMCombo.Size = new System.Drawing.Size(163, 21);
            this.changePKMCombo.TabIndex = 1;
            this.changePKMCombo.ValueMember = "changePKMCombo";
            // 
            // changePKM
            // 
            this.changePKM.AutoSize = true;
            this.changePKM.Cursor = System.Windows.Forms.Cursors.Default;
            this.changePKM.Depth = 0;
            this.changePKM.Location = new System.Drawing.Point(5, 3);
            this.changePKM.Margin = new System.Windows.Forms.Padding(0);
            this.changePKM.MouseLocation = new System.Drawing.Point(-1, -1);
            this.changePKM.MouseState = MaterialSkin.MouseState.HOVER;
            this.changePKM.Name = "changePKM";
            this.changePKM.Ripple = true;
            this.changePKM.Size = new System.Drawing.Size(166, 37);
            this.changePKM.TabIndex = 0;
            this.changePKM.Text = "Cambiar Pokemon";
            this.changePKM.UseVisualStyleBackColor = true;
            this.changePKM.CheckedChanged += new System.EventHandler(this.changePKM_CheckedChanged);
            // 
            // WoozyBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 343);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerHighlightWithAccent = false;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "WoozyBot";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoozyBot (Beta)";
            this.Load += new System.EventHandler(this.WoozyBot_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeypressForm);
            this.Info.ResumeLayout(false);
            this.Moves.ResumeLayout(false);
            this.materialCheckedListBox2.ResumeLayout(false);
            this.materialCheckedListBox2.PerformLayout();
            this.Player.ResumeLayout(false);
            this.Player.PerformLayout();
            this.groupBoxMove2.ResumeLayout(false);
            this.groupBoxMove2.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.Pokemon.ResumeLayout(false);
            this.Pokemon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.TabPage Moves;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox2;
        private System.Windows.Forms.ComboBox resolutionCombo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox move1;
        private MaterialSkin.Controls.MaterialLabel movausarLabel;
        private MaterialSkin.Controls.MaterialCheckbox move4;
        private MaterialSkin.Controls.MaterialCheckbox move2;
        private MaterialSkin.Controls.MaterialCheckbox move3;
        private MaterialSkin.Controls.MaterialButton StopButton;
        private MaterialSkin.Controls.MaterialCheckbox AlwaysRun;
        private MaterialSkin.Controls.MaterialButton StartButton;
        private MaterialSkin.Controls.MaterialCheckedListBox groupBoxMove2;
        private MaterialSkin.Controls.MaterialRadioButton randomRadio;
        private MaterialSkin.Controls.MaterialRadioButton updownRadio;
        private MaterialSkin.Controls.MaterialRadioButton defaultRadio;
        private MaterialSkin.Controls.MaterialLabel OpcionesLabel;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Player;
        private System.Windows.Forms.TabPage Pokemon;
        private MaterialSkin.Controls.MaterialCheckbox changePKM;
        private System.Windows.Forms.ComboBox changePKMCombo;
        private MaterialSkin.Controls.MaterialCheckbox shinycheckbox;
    }
}

