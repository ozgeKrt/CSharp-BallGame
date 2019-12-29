namespace ob_proje_deneme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.platform = new System.Windows.Forms.Panel();
            this.top = new System.Windows.Forms.PictureBox();
            this.raket = new System.Windows.Forms.PictureBox();
            this.ustKısım = new System.Windows.Forms.Panel();
            this.yuksekSkorlar = new System.Windows.Forms.Button();
            this.Zaman = new System.Windows.Forms.Label();
            this.platform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).BeginInit();
            this.ustKısım.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.PeachPuff;
            this.platform.Controls.Add(this.top);
            this.platform.Controls.Add(this.raket);
            this.platform.Location = new System.Drawing.Point(0, 12);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(549, 390);
            this.platform.TabIndex = 0;
            this.platform.MouseClick += new System.Windows.Forms.MouseEventHandler(this.platform_MouseClick);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Transparent;
            this.top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top.BackgroundImage")));
            this.top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top.Location = new System.Drawing.Point(341, 89);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(30, 30);
            this.top.TabIndex = 2;
            this.top.TabStop = false;
            // 
            // raket
            // 
            this.raket.BackColor = System.Drawing.Color.Maroon;
            this.raket.Location = new System.Drawing.Point(185, 330);
            this.raket.Name = "raket";
            this.raket.Size = new System.Drawing.Size(153, 69);
            this.raket.TabIndex = 1;
            this.raket.TabStop = false;
            // 
            // ustKısım
            // 
            this.ustKısım.BackColor = System.Drawing.Color.Salmon;
            this.ustKısım.Controls.Add(this.yuksekSkorlar);
            this.ustKısım.Controls.Add(this.Zaman);
            this.ustKısım.Location = new System.Drawing.Point(0, 0);
            this.ustKısım.Name = "ustKısım";
            this.ustKısım.Size = new System.Drawing.Size(549, 34);
            this.ustKısım.TabIndex = 0;
            // 
            // yuksekSkorlar
            // 
            this.yuksekSkorlar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuksekSkorlar.Location = new System.Drawing.Point(176, 5);
            this.yuksekSkorlar.Name = "yuksekSkorlar";
            this.yuksekSkorlar.Size = new System.Drawing.Size(142, 26);
            this.yuksekSkorlar.TabIndex = 1;
            this.yuksekSkorlar.Text = "Yüksek Skorlar";
            this.yuksekSkorlar.UseVisualStyleBackColor = true;
            this.yuksekSkorlar.Click += new System.EventHandler(this.yuksekSkorlar_Click);
            // 
            // Zaman
            // 
            this.Zaman.AutoSize = true;
            this.Zaman.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zaman.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Zaman.Location = new System.Drawing.Point(3, 0);
            this.Zaman.Name = "Zaman";
            this.Zaman.Size = new System.Drawing.Size(83, 32);
            this.Zaman.TabIndex = 0;
            this.Zaman.Text = "Sayac:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(548, 397);
            this.Controls.Add(this.ustKısım);
            this.Controls.Add(this.platform);
            this.Name = "Form1";
            this.Text = "RAKET OYUNU";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.platform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).EndInit();
            this.ustKısım.ResumeLayout(false);
            this.ustKısım.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel platform;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox raket;
        private System.Windows.Forms.Panel ustKısım;
        private System.Windows.Forms.Label Zaman;
        private System.Windows.Forms.Button yuksekSkorlar;
    }
}

