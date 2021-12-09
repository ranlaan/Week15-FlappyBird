namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.birb = new System.Windows.Forms.PictureBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birb)).BeginInit();
            this.SuspendLayout();
            // 
            // pipetop
            // 
            this.pipetop.Image = ((System.Drawing.Image)(resources.GetObject("pipetop.Image")));
            this.pipetop.Location = new System.Drawing.Point(293, 0);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(114, 154);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 0;
            this.pipetop.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = ((System.Drawing.Image)(resources.GetObject("pipebottom.Image")));
            this.pipebottom.Location = new System.Drawing.Point(192, 310);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(114, 224);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 457);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(428, 77);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // birb
            // 
            this.birb.Image = ((System.Drawing.Image)(resources.GetObject("birb.Image")));
            this.birb.Location = new System.Drawing.Point(12, 160);
            this.birb.Name = "birb";
            this.birb.Size = new System.Drawing.Size(66, 55);
            this.birb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birb.TabIndex = 3;
            this.birb.TabStop = false;
            this.birb.Click += new System.EventHandler(this.birb_Click);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scorelabel.Location = new System.Drawing.Point(0, 45);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(151, 33);
            this.scorelabel.TabIndex = 4;
            this.scorelabel.Text = "score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playAgain
            // 
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgain.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playAgain.Location = new System.Drawing.Point(146, 160);
            this.playAgain.Name = "playAgain";
            this.playAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playAgain.Size = new System.Drawing.Size(160, 124);
            this.playAgain.TabIndex = 5;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(428, 534);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.birb);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.pipetop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox birb;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playAgain;
    }
}

