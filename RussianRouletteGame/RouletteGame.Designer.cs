namespace RussianRouletteGame
{
    partial class RouletteGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelLose = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLoadBullet = new System.Windows.Forms.Button();
            this.buttonSpinChamber = new System.Windows.Forms.Button();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonShoot = new System.Windows.Forms.Button();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.labelDead = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RussianRouletteGame.Properties.Resources.images;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(157, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 80);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "(2 Player Game)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(130, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Russian Roulette Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RussianRouletteGame.Properties.Resources.revolver_cylinder_icon;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RussianRouletteGame.Properties.Resources.images;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelWin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(157, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 49);
            this.panel2.TabIndex = 15;
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.BackColor = System.Drawing.Color.Transparent;
            this.labelWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.ForeColor = System.Drawing.Color.White;
            this.labelWin.Location = new System.Drawing.Point(72, 14);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(19, 20);
            this.labelWin.TabIndex = 13;
            this.labelWin.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "WIN :";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::RussianRouletteGame.Properties.Resources.images;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelLose);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(653, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 49);
            this.panel3.TabIndex = 16;
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Transparent;
            this.labelLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLose.ForeColor = System.Drawing.Color.White;
            this.labelLose.Location = new System.Drawing.Point(72, 14);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(19, 20);
            this.labelLose.TabIndex = 13;
            this.labelLose.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "LOSE :";
            // 
            // buttonLoadBullet
            // 
            this.buttonLoadBullet.BackgroundImage = global::RussianRouletteGame.Properties.Resources.images;
            this.buttonLoadBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadBullet.ForeColor = System.Drawing.Color.White;
            this.buttonLoadBullet.Image = global::RussianRouletteGame.Properties.Resources.icons8_bullet_48;
            this.buttonLoadBullet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadBullet.Location = new System.Drawing.Point(475, 181);
            this.buttonLoadBullet.Name = "buttonLoadBullet";
            this.buttonLoadBullet.Size = new System.Drawing.Size(174, 64);
            this.buttonLoadBullet.TabIndex = 17;
            this.buttonLoadBullet.Text = "Load Bullet";
            this.buttonLoadBullet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLoadBullet.UseVisualStyleBackColor = true;
            this.buttonLoadBullet.Click += new System.EventHandler(this.buttonLoadBullet_Click);
            // 
            // buttonSpinChamber
            // 
            this.buttonSpinChamber.BackgroundImage = global::RussianRouletteGame.Properties.Resources.images;
            this.buttonSpinChamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpinChamber.ForeColor = System.Drawing.Color.White;
            this.buttonSpinChamber.Image = global::RussianRouletteGame.Properties.Resources.revolver;
            this.buttonSpinChamber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSpinChamber.Location = new System.Drawing.Point(473, 263);
            this.buttonSpinChamber.Name = "buttonSpinChamber";
            this.buttonSpinChamber.Size = new System.Drawing.Size(176, 64);
            this.buttonSpinChamber.TabIndex = 18;
            this.buttonSpinChamber.Text = "Spin Chamber";
            this.buttonSpinChamber.UseVisualStyleBackColor = true;
            this.buttonSpinChamber.Click += new System.EventHandler(this.buttonSpinChamber_Click);
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackgroundImage = global::RussianRouletteGame.Properties.Resources.images;
            this.buttonPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayAgain.ForeColor = System.Drawing.Color.White;
            this.buttonPlayAgain.Image = global::RussianRouletteGame.Properties.Resources.circled_play;
            this.buttonPlayAgain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayAgain.Location = new System.Drawing.Point(473, 342);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(176, 64);
            this.buttonPlayAgain.TabIndex = 19;
            this.buttonPlayAgain.Text = "Play Agian";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::RussianRouletteGame.Properties.Resources.images;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = global::RussianRouletteGame.Properties.Resources.outbox;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonExit.Location = new System.Drawing.Point(473, 421);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(176, 64);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Exit Game";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RussianRouletteGame.Properties.Resources.images1;
            this.pictureBox2.Location = new System.Drawing.Point(157, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // buttonShoot
            // 
            this.buttonShoot.BackgroundImage = global::RussianRouletteGame.Properties.Resources.images;
            this.buttonShoot.Enabled = false;
            this.buttonShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShoot.ForeColor = System.Drawing.Color.White;
            this.buttonShoot.Image = global::RussianRouletteGame.Properties.Resources.icons8_firing_gun_48;
            this.buttonShoot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShoot.Location = new System.Drawing.Point(157, 395);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(142, 64);
            this.buttonShoot.TabIndex = 22;
            this.buttonShoot.Text = "SHOOT";
            this.buttonShoot.UseVisualStyleBackColor = true;
            this.buttonShoot.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblGameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameInfo.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblGameInfo.Location = new System.Drawing.Point(381, 121);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(132, 26);
            this.lblGameInfo.TabIndex = 23;
            this.lblGameInfo.Text = "Load Bullet";
            // 
            // labelDead
            // 
            this.labelDead.AutoSize = true;
            this.labelDead.BackColor = System.Drawing.Color.Transparent;
            this.labelDead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDead.ForeColor = System.Drawing.Color.Tomato;
            this.labelDead.Location = new System.Drawing.Point(152, 219);
            this.labelDead.Name = "labelDead";
            this.labelDead.Size = new System.Drawing.Size(0, 26);
            this.labelDead.TabIndex = 24;
            // 
            // RouletteGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::RussianRouletteGame.Properties.Resources.images__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.labelDead);
            this.Controls.Add(this.lblGameInfo);
            this.Controls.Add(this.buttonShoot);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.buttonSpinChamber);
            this.Controls.Add(this.buttonLoadBullet);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "RouletteGame";
            this.Text = "RouletteGame";
            this.Load += new System.EventHandler(this.RouletteGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLoadBullet;
        private System.Windows.Forms.Button buttonSpinChamber;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonShoot;
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.Label labelDead;
    }
}