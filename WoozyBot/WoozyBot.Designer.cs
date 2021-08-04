
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StartButton = new MaterialSkin.Controls.MaterialButton();
            this.StopButton = new MaterialSkin.Controls.MaterialButton();
            this.random = new MaterialSkin.Controls.MaterialCheckbox();
            this.AlwaysRun = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.move2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.move1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.move3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.move4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckedListBox2 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.OpcionesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.movausarLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckedListBox1.SuspendLayout();
            this.materialCheckedListBox2.SuspendLayout();
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
            this.StartButton.Location = new System.Drawing.Point(12, 246);
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
            this.StopButton.Depth = 0;
            this.StopButton.DrawShadows = true;
            this.StopButton.HighEmphasis = true;
            this.StopButton.Icon = null;
            this.StopButton.Location = new System.Drawing.Point(87, 246);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(58, 36);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StopButton.UseAccentColor = false;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.Depth = 0;
            this.random.Location = new System.Drawing.Point(16, 50);
            this.random.Margin = new System.Windows.Forms.Padding(0);
            this.random.MouseLocation = new System.Drawing.Point(-1, -1);
            this.random.MouseState = MaterialSkin.MouseState.HOVER;
            this.random.Name = "random";
            this.random.Ripple = true;
            this.random.Size = new System.Drawing.Size(95, 37);
            this.random.TabIndex = 2;
            this.random.Text = "Random";
            this.random.UseVisualStyleBackColor = true;
            // 
            // AlwaysRun
            // 
            this.AlwaysRun.AutoSize = true;
            this.AlwaysRun.Depth = 0;
            this.AlwaysRun.Location = new System.Drawing.Point(16, 13);
            this.AlwaysRun.Margin = new System.Windows.Forms.Padding(0);
            this.AlwaysRun.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AlwaysRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.AlwaysRun.Name = "AlwaysRun";
            this.AlwaysRun.Ripple = true;
            this.AlwaysRun.Size = new System.Drawing.Size(126, 37);
            this.AlwaysRun.TabIndex = 3;
            this.AlwaysRun.Text = "Huir Siempre";
            this.AlwaysRun.UseVisualStyleBackColor = true;
            // 
            // materialCheckedListBox1
            // 
            this.materialCheckedListBox1.AutoScroll = true;
            this.materialCheckedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.materialCheckedListBox1.Controls.Add(this.AlwaysRun);
            this.materialCheckedListBox1.Controls.Add(this.random);
            this.materialCheckedListBox1.Depth = 0;
            this.materialCheckedListBox1.Location = new System.Drawing.Point(12, 105);
            this.materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox1.Name = "materialCheckedListBox1";
            this.materialCheckedListBox1.Size = new System.Drawing.Size(160, 101);
            this.materialCheckedListBox1.Striped = false;
            this.materialCheckedListBox1.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox1.TabIndex = 4;
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
            this.materialCheckedListBox2.Location = new System.Drawing.Point(178, 105);
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
            this.OpcionesLabel.Depth = 0;
            this.OpcionesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OpcionesLabel.Location = new System.Drawing.Point(56, 83);
            this.OpcionesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpcionesLabel.Name = "OpcionesLabel";
            this.OpcionesLabel.Size = new System.Drawing.Size(67, 19);
            this.OpcionesLabel.TabIndex = 10;
            this.OpcionesLabel.Text = "Opciones";
            this.OpcionesLabel.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // movausarLabel
            // 
            this.movausarLabel.AutoSize = true;
            this.movausarLabel.Depth = 0;
            this.movausarLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.movausarLabel.Location = new System.Drawing.Point(219, 83);
            this.movausarLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.movausarLabel.Name = "movausarLabel";
            this.movausarLabel.Size = new System.Drawing.Size(84, 19);
            this.movausarLabel.TabIndex = 11;
            this.movausarLabel.Text = "Mov. a usar";
            // 
            // WoozyBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 297);
            this.Controls.Add(this.movausarLabel);
            this.Controls.Add(this.OpcionesLabel);
            this.Controls.Add(this.materialCheckedListBox2);
            this.Controls.Add(this.materialCheckedListBox1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "WoozyBot";
            this.Text = "WoozyBot";
            this.Load += new System.EventHandler(this.WoozyBot_Load);
            this.materialCheckedListBox1.ResumeLayout(false);
            this.materialCheckedListBox1.PerformLayout();
            this.materialCheckedListBox2.ResumeLayout(false);
            this.materialCheckedListBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton StartButton;
        private MaterialSkin.Controls.MaterialButton StopButton;
        private MaterialSkin.Controls.MaterialCheckbox random;
        private MaterialSkin.Controls.MaterialCheckbox AlwaysRun;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialCheckbox move2;
        private MaterialSkin.Controls.MaterialCheckbox move1;
        private MaterialSkin.Controls.MaterialCheckbox move3;
        private MaterialSkin.Controls.MaterialCheckbox move4;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox2;
        private MaterialSkin.Controls.MaterialLabel OpcionesLabel;
        private MaterialSkin.Controls.MaterialLabel movausarLabel;
    }
}

