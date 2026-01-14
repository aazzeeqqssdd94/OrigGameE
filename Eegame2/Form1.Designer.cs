using System.Collections.Generic;
using System.Windows.Forms;

namespace Eegame2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        List<PictureBox> level1 = new List<PictureBox>(); 
        List<PictureBox> level2 = new List<PictureBox>(); 

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.key1 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.platform15 = new System.Windows.Forms.PictureBox();
            this.platform16 = new System.Windows.Forms.PictureBox();
            this.platform14 = new System.Windows.Forms.PictureBox();
            this.platform13 = new System.Windows.Forms.PictureBox();
            this.platform12 = new System.Windows.Forms.PictureBox();
            this.platform11 = new System.Windows.Forms.PictureBox();
            this.platform10 = new System.Windows.Forms.PictureBox();
            this.platform9 = new System.Windows.Forms.PictureBox();
            this.platform8 = new System.Windows.Forms.PictureBox();
            this.platform7 = new System.Windows.Forms.PictureBox();
            this.platform6 = new System.Windows.Forms.PictureBox();
            this.platform5 = new System.Windows.Forms.PictureBox();
            this.platform1234 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.coin2lvl2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.key1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1234)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2lvl2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimer);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.Location = new System.Drawing.Point(-4, 460);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(76, 20);
            this.txtScore.TabIndex = 23;
            this.txtScore.Tag = "";
            this.txtScore.Text = "Score: 0";
            this.txtScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // key1
            // 
            this.key1.Image = global::Eegame2.Properties.Resources.key;
            this.key1.Location = new System.Drawing.Point(388, 43);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(90, 47);
            this.key1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.key1.TabIndex = 22;
            this.key1.TabStop = false;
            this.key1.Tag = "key";
            // 
            // coin3
            // 
            this.coin3.Image = global::Eegame2.Properties.Resources.coin;
            this.coin3.Location = new System.Drawing.Point(1673, 233);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(35, 30);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 21;
            this.coin3.TabStop = false;
            this.coin3.Tag = "coin";
            // 
            // coin1
            // 
            this.coin1.Image = global::Eegame2.Properties.Resources.coin;
            this.coin1.Location = new System.Drawing.Point(443, 233);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(35, 30);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 19;
            this.coin1.TabStop = false;
            this.coin1.Tag = "coin";
            // 
            // player
            // 
            this.player.Image = global::Eegame2.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(0, 384);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 60);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 18;
            this.player.TabStop = false;
            this.player.Tag = "";
            // 
            // door
            // 
            this.door.Image = global::Eegame2.Properties.Resources.door_closed;
            this.door.Location = new System.Drawing.Point(1832, 0);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(60, 90);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.door.TabIndex = 17;
            this.door.TabStop = false;
            this.door.Tag = "door";
            this.door.Click += new System.EventHandler(this.door1_Click);
            // 
            // platform15
            // 
            this.platform15.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform15.Location = new System.Drawing.Point(1692, 167);
            this.platform15.Name = "platform15";
            this.platform15.Size = new System.Drawing.Size(127, 50);
            this.platform15.TabIndex = 16;
            this.platform15.TabStop = false;
            this.platform15.Tag = "platform";
            // 
            // platform16
            // 
            this.platform16.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform16.Location = new System.Drawing.Point(1765, 92);
            this.platform16.Name = "platform16";
            this.platform16.Size = new System.Drawing.Size(127, 50);
            this.platform16.TabIndex = 15;
            this.platform16.TabStop = false;
            this.platform16.Tag = "platform";
            // 
            // platform14
            // 
            this.platform14.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform14.Location = new System.Drawing.Point(1581, 261);
            this.platform14.Name = "platform14";
            this.platform14.Size = new System.Drawing.Size(127, 50);
            this.platform14.TabIndex = 14;
            this.platform14.TabStop = false;
            this.platform14.Tag = "platform";
            // 
            // platform13
            // 
            this.platform13.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform13.Location = new System.Drawing.Point(1418, 340);
            this.platform13.Name = "platform13";
            this.platform13.Size = new System.Drawing.Size(127, 50);
            this.platform13.TabIndex = 13;
            this.platform13.TabStop = false;
            this.platform13.Tag = "platform";
            this.platform13.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // platform12
            // 
            this.platform12.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform12.Location = new System.Drawing.Point(1267, 261);
            this.platform12.Name = "platform12";
            this.platform12.Size = new System.Drawing.Size(127, 50);
            this.platform12.TabIndex = 12;
            this.platform12.TabStop = false;
            this.platform12.Tag = "platform";
            // 
            // platform11
            // 
            this.platform11.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform11.Location = new System.Drawing.Point(1110, 213);
            this.platform11.Name = "platform11";
            this.platform11.Size = new System.Drawing.Size(127, 50);
            this.platform11.TabIndex = 11;
            this.platform11.TabStop = false;
            this.platform11.Tag = "platform";
            // 
            // platform10
            // 
            this.platform10.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform10.Location = new System.Drawing.Point(900, 187);
            this.platform10.Name = "platform10";
            this.platform10.Size = new System.Drawing.Size(127, 50);
            this.platform10.TabIndex = 10;
            this.platform10.TabStop = false;
            this.platform10.Tag = "platform";
            // 
            // platform9
            // 
            this.platform9.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform9.Location = new System.Drawing.Point(738, 261);
            this.platform9.Name = "platform9";
            this.platform9.Size = new System.Drawing.Size(127, 50);
            this.platform9.TabIndex = 9;
            this.platform9.TabStop = false;
            this.platform9.Tag = "platform";
            // 
            // platform8
            // 
            this.platform8.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform8.Location = new System.Drawing.Point(351, 92);
            this.platform8.Name = "platform8";
            this.platform8.Size = new System.Drawing.Size(127, 50);
            this.platform8.TabIndex = 8;
            this.platform8.TabStop = false;
            this.platform8.Tag = "platform";
            // 
            // platform7
            // 
            this.platform7.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform7.Location = new System.Drawing.Point(169, 187);
            this.platform7.Name = "platform7";
            this.platform7.Size = new System.Drawing.Size(127, 50);
            this.platform7.TabIndex = 7;
            this.platform7.TabStop = false;
            this.platform7.Tag = "platform";
            this.platform7.Click += new System.EventHandler(this.platform7_Click);
            // 
            // platform6
            // 
            this.platform6.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform6.Location = new System.Drawing.Point(351, 261);
            this.platform6.Name = "platform6";
            this.platform6.Size = new System.Drawing.Size(127, 50);
            this.platform6.TabIndex = 6;
            this.platform6.TabStop = false;
            this.platform6.Tag = "platform";
            // 
            // platform5
            // 
            this.platform5.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform5.Location = new System.Drawing.Point(553, 340);
            this.platform5.Name = "platform5";
            this.platform5.Size = new System.Drawing.Size(127, 50);
            this.platform5.TabIndex = 5;
            this.platform5.TabStop = false;
            this.platform5.Tag = "platform";
            // 
            // platform1234
            // 
            this.platform1234.BackgroundImage = global::Eegame2.Properties.Resources.platform;
            this.platform1234.Location = new System.Drawing.Point(0, 440);
            this.platform1234.Name = "platform1234";
            this.platform1234.Size = new System.Drawing.Size(1986, 40);
            this.platform1234.TabIndex = 1;
            this.platform1234.TabStop = false;
            this.platform1234.Tag = "platform";
            // 
            // background
            // 
            this.background.BackgroundImage = global::Eegame2.Properties.Resources.background;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(2000, 480);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Tag = "background";
            this.background.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // coin2lvl2
            // 
            this.coin2lvl2.Image = global::Eegame2.Properties.Resources.coin;
            this.coin2lvl2.Location = new System.Drawing.Point(1951, 404);
            this.coin2lvl2.Name = "coin2lvl2";
            this.coin2lvl2.Size = new System.Drawing.Size(35, 30);
            this.coin2lvl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2lvl2.TabIndex = 48;
            this.coin2lvl2.TabStop = false;
            this.coin2lvl2.Tag = "coin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 481);
            this.Controls.Add(this.coin2lvl2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.door);
            this.Controls.Add(this.platform15);
            this.Controls.Add(this.platform16);
            this.Controls.Add(this.platform14);
            this.Controls.Add(this.platform13);
            this.Controls.Add(this.platform12);
            this.Controls.Add(this.platform11);
            this.Controls.Add(this.platform10);
            this.Controls.Add(this.platform9);
            this.Controls.Add(this.platform8);
            this.Controls.Add(this.platform7);
            this.Controls.Add(this.platform6);
            this.Controls.Add(this.platform5);
            this.Controls.Add(this.platform1234);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.key1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1234)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2lvl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void InitializeComponent2()
        {

        }
        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox platform1234;
        private System.Windows.Forms.PictureBox platform5;
        private System.Windows.Forms.PictureBox platform6;
        private System.Windows.Forms.PictureBox platform7;
        private System.Windows.Forms.PictureBox platform8;
        private System.Windows.Forms.PictureBox platform9;
        private System.Windows.Forms.PictureBox platform10;
        private System.Windows.Forms.PictureBox platform11;
        private System.Windows.Forms.PictureBox platform12;
        private System.Windows.Forms.PictureBox platform13;
        private System.Windows.Forms.PictureBox platform14;
        private System.Windows.Forms.PictureBox platform16;
        private System.Windows.Forms.PictureBox platform15;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox key1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txtScore;
        private PictureBox coin2lvl2;
    }
}

