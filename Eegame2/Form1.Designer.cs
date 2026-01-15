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
            this.background2 = new System.Windows.Forms.PictureBox();
            this.platform2lvl1 = new System.Windows.Forms.PictureBox();
            this.platform2lvl2 = new System.Windows.Forms.PictureBox();
            this.platform2lvl3 = new System.Windows.Forms.PictureBox();
            this.platform2lvl4 = new System.Windows.Forms.PictureBox();
            this.platform2lvl6 = new System.Windows.Forms.PictureBox();
            this.platform2lvl7 = new System.Windows.Forms.PictureBox();
            this.platform2lvl8 = new System.Windows.Forms.PictureBox();
            this.platform2lvl5 = new System.Windows.Forms.PictureBox();
            this.platform2lvl0 = new System.Windows.Forms.PictureBox();
            this.platform2lvl9 = new System.Windows.Forms.PictureBox();
            this.platform2lvl10 = new System.Windows.Forms.PictureBox();
            this.platform2lvl11 = new System.Windows.Forms.PictureBox();
            this.platform2lvl13 = new System.Windows.Forms.PictureBox();
            this.platform2lvl14 = new System.Windows.Forms.PictureBox();
            this.platform2lvl15 = new System.Windows.Forms.PictureBox();
            this.platform2lvl16 = new System.Windows.Forms.PictureBox();
            this.platform2lvl17 = new System.Windows.Forms.PictureBox();
            this.platform2lvl18 = new System.Windows.Forms.PictureBox();
            this.platform2lvl19 = new System.Windows.Forms.PictureBox();
            this.platform2lvl12 = new System.Windows.Forms.PictureBox();
            this.key2 = new System.Windows.Forms.PictureBox();
            this.door2 = new System.Windows.Forms.PictureBox();
            this.coin2lvl1 = new System.Windows.Forms.PictureBox();
            this.coin2lvl4 = new System.Windows.Forms.PictureBox();
            this.coin2lvl3 = new System.Windows.Forms.PictureBox();
            this.coin2lvl5 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2lvl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2lvl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2lvl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2lvl5)).BeginInit();
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
            // background2
            // 
            this.background2.BackgroundImage = global::Eegame2.Properties.Resources.HD_wallpaper_2d_pixel_art_background_10_sky_cloud_2d_environments_unity_asset_store;
            this.background2.Location = new System.Drawing.Point(0, 0);
            this.background2.Name = "background2";
            this.background2.Size = new System.Drawing.Size(2000, 480);
            this.background2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background2.TabIndex = 49;
            this.background2.TabStop = false;
            this.background2.Tag = "background2";
            // 
            // platform2lvl1
            // 
            this.platform2lvl1.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl1.Location = new System.Drawing.Point(0, 440);
            this.platform2lvl1.Name = "platform2lvl1";
            this.platform2lvl1.Size = new System.Drawing.Size(2000, 40);
            this.platform2lvl1.TabIndex = 50;
            this.platform2lvl1.TabStop = false;
            this.platform2lvl1.Tag = "platform";
            this.platform2lvl1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // platform2lvl2
            // 
            this.platform2lvl2.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl2.Location = new System.Drawing.Point(351, 394);
            this.platform2lvl2.Name = "platform2lvl2";
            this.platform2lvl2.Size = new System.Drawing.Size(305, 50);
            this.platform2lvl2.TabIndex = 51;
            this.platform2lvl2.TabStop = false;
            this.platform2lvl2.Tag = "platform";
            // 
            // platform2lvl3
            // 
            this.platform2lvl3.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl3.Location = new System.Drawing.Point(407, 350);
            this.platform2lvl3.Name = "platform2lvl3";
            this.platform2lvl3.Size = new System.Drawing.Size(249, 50);
            this.platform2lvl3.TabIndex = 52;
            this.platform2lvl3.TabStop = false;
            this.platform2lvl3.Tag = "platform";
            // 
            // platform2lvl4
            // 
            this.platform2lvl4.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl4.Location = new System.Drawing.Point(464, 304);
            this.platform2lvl4.Name = "platform2lvl4";
            this.platform2lvl4.Size = new System.Drawing.Size(192, 50);
            this.platform2lvl4.TabIndex = 53;
            this.platform2lvl4.TabStop = false;
            this.platform2lvl4.Tag = "platform";
            // 
            // platform2lvl6
            // 
            this.platform2lvl6.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl6.Location = new System.Drawing.Point(900, 394);
            this.platform2lvl6.Name = "platform2lvl6";
            this.platform2lvl6.Size = new System.Drawing.Size(337, 50);
            this.platform2lvl6.TabIndex = 54;
            this.platform2lvl6.TabStop = false;
            this.platform2lvl6.Tag = "platform";
            // 
            // platform2lvl7
            // 
            this.platform2lvl7.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl7.Location = new System.Drawing.Point(942, 350);
            this.platform2lvl7.Name = "platform2lvl7";
            this.platform2lvl7.Size = new System.Drawing.Size(243, 50);
            this.platform2lvl7.TabIndex = 55;
            this.platform2lvl7.TabStop = false;
            this.platform2lvl7.Tag = "platform";
            // 
            // platform2lvl8
            // 
            this.platform2lvl8.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl8.Location = new System.Drawing.Point(942, 304);
            this.platform2lvl8.Name = "platform2lvl8";
            this.platform2lvl8.Size = new System.Drawing.Size(194, 50);
            this.platform2lvl8.TabIndex = 56;
            this.platform2lvl8.TabStop = false;
            this.platform2lvl8.Tag = "platform";
            // 
            // platform2lvl5
            // 
            this.platform2lvl5.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl5.Location = new System.Drawing.Point(758, 304);
            this.platform2lvl5.Name = "platform2lvl5";
            this.platform2lvl5.Size = new System.Drawing.Size(83, 50);
            this.platform2lvl5.TabIndex = 57;
            this.platform2lvl5.TabStop = false;
            this.platform2lvl5.Tag = "platform";
            // 
            // platform2lvl0
            // 
            this.platform2lvl0.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl0.Location = new System.Drawing.Point(1376, 350);
            this.platform2lvl0.Name = "platform2lvl0";
            this.platform2lvl0.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl0.TabIndex = 58;
            this.platform2lvl0.TabStop = false;
            this.platform2lvl0.Tag = "platform";
            // 
            // platform2lvl9
            // 
            this.platform2lvl9.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl9.Location = new System.Drawing.Point(1539, 284);
            this.platform2lvl9.Name = "platform2lvl9";
            this.platform2lvl9.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl9.TabIndex = 59;
            this.platform2lvl9.TabStop = false;
            this.platform2lvl9.Tag = "platform";
            // 
            // platform2lvl10
            // 
            this.platform2lvl10.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl10.Location = new System.Drawing.Point(1714, 223);
            this.platform2lvl10.Name = "platform2lvl10";
            this.platform2lvl10.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl10.TabIndex = 60;
            this.platform2lvl10.TabStop = false;
            this.platform2lvl10.Tag = "platform";
            // 
            // platform2lvl11
            // 
            this.platform2lvl11.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl11.Location = new System.Drawing.Point(1859, 148);
            this.platform2lvl11.Name = "platform2lvl11";
            this.platform2lvl11.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl11.TabIndex = 61;
            this.platform2lvl11.TabStop = false;
            this.platform2lvl11.Tag = "platform";
            // 
            // platform2lvl13
            // 
            this.platform2lvl13.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl13.Location = new System.Drawing.Point(1448, 92);
            this.platform2lvl13.Name = "platform2lvl13";
            this.platform2lvl13.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl13.TabIndex = 62;
            this.platform2lvl13.TabStop = false;
            this.platform2lvl13.Tag = "platform";
            // 
            // platform2lvl14
            // 
            this.platform2lvl14.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl14.Location = new System.Drawing.Point(1195, 92);
            this.platform2lvl14.Name = "platform2lvl14";
            this.platform2lvl14.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl14.TabIndex = 63;
            this.platform2lvl14.TabStop = false;
            this.platform2lvl14.Tag = "platform";
            // 
            // platform2lvl15
            // 
            this.platform2lvl15.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl15.Location = new System.Drawing.Point(956, 92);
            this.platform2lvl15.Name = "platform2lvl15";
            this.platform2lvl15.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl15.TabIndex = 64;
            this.platform2lvl15.TabStop = false;
            this.platform2lvl15.Tag = "platform";
            // 
            // platform2lvl16
            // 
            this.platform2lvl16.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl16.Location = new System.Drawing.Point(714, 92);
            this.platform2lvl16.Name = "platform2lvl16";
            this.platform2lvl16.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl16.TabIndex = 65;
            this.platform2lvl16.TabStop = false;
            this.platform2lvl16.Tag = "platform";
            // 
            // platform2lvl17
            // 
            this.platform2lvl17.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl17.Location = new System.Drawing.Point(454, 92);
            this.platform2lvl17.Name = "platform2lvl17";
            this.platform2lvl17.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl17.TabIndex = 66;
            this.platform2lvl17.TabStop = false;
            this.platform2lvl17.Tag = "platform";
            // 
            // platform2lvl18
            // 
            this.platform2lvl18.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl18.Location = new System.Drawing.Point(209, 92);
            this.platform2lvl18.Name = "platform2lvl18";
            this.platform2lvl18.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl18.TabIndex = 67;
            this.platform2lvl18.TabStop = false;
            this.platform2lvl18.Tag = "platform";
            // 
            // platform2lvl19
            // 
            this.platform2lvl19.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl19.Location = new System.Drawing.Point(0, 92);
            this.platform2lvl19.Name = "platform2lvl19";
            this.platform2lvl19.Size = new System.Drawing.Size(127, 50);
            this.platform2lvl19.TabIndex = 68;
            this.platform2lvl19.TabStop = false;
            this.platform2lvl19.Tag = "platform";
            // 
            // platform2lvl12
            // 
            this.platform2lvl12.BackgroundImage = global::Eegame2.Properties.Resources.Nimetu;
            this.platform2lvl12.Location = new System.Drawing.Point(1663, 92);
            this.platform2lvl12.Name = "platform2lvl12";
            this.platform2lvl12.Size = new System.Drawing.Size(70, 50);
            this.platform2lvl12.TabIndex = 69;
            this.platform2lvl12.TabStop = false;
            this.platform2lvl12.Tag = "platform";
            // 
            // key2
            // 
            this.key2.Image = global::Eegame2.Properties.Resources.key;
            this.key2.Location = new System.Drawing.Point(25, 43);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(90, 47);
            this.key2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.key2.TabIndex = 70;
            this.key2.TabStop = false;
            this.key2.Tag = "key";
            // 
            // door2
            // 
            this.door2.Image = global::Eegame2.Properties.Resources.door_closed;
            this.door2.Location = new System.Drawing.Point(768, 354);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(60, 90);
            this.door2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.door2.TabIndex = 71;
            this.door2.TabStop = false;
            this.door2.Tag = "door";
            // 
            // coin2lvl1
            // 
            this.coin2lvl1.Image = global::Eegame2.Properties.Resources.coin;
            this.coin2lvl1.Location = new System.Drawing.Point(901, 360);
            this.coin2lvl1.Name = "coin2lvl1";
            this.coin2lvl1.Size = new System.Drawing.Size(35, 30);
            this.coin2lvl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2lvl1.TabIndex = 72;
            this.coin2lvl1.TabStop = false;
            this.coin2lvl1.Tag = "coin";
            // 
            // coin2lvl4
            // 
            this.coin2lvl4.Image = global::Eegame2.Properties.Resources.coin;
            this.coin2lvl4.Location = new System.Drawing.Point(1386, 304);
            this.coin2lvl4.Name = "coin2lvl4";
            this.coin2lvl4.Size = new System.Drawing.Size(35, 30);
            this.coin2lvl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2lvl4.TabIndex = 73;
            this.coin2lvl4.TabStop = false;
            this.coin2lvl4.Tag = "coin";
            // 
            // coin2lvl3
            // 
            this.coin2lvl3.Image = global::Eegame2.Properties.Resources.coin;
            this.coin2lvl3.Location = new System.Drawing.Point(779, 268);
            this.coin2lvl3.Name = "coin2lvl3";
            this.coin2lvl3.Size = new System.Drawing.Size(35, 30);
            this.coin2lvl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2lvl3.TabIndex = 74;
            this.coin2lvl3.TabStop = false;
            this.coin2lvl3.Tag = "coin";
            // 
            // coin2lvl5
            // 
            this.coin2lvl5.Image = global::Eegame2.Properties.Resources.coin;
            this.coin2lvl5.Location = new System.Drawing.Point(261, 56);
            this.coin2lvl5.Name = "coin2lvl5";
            this.coin2lvl5.Size = new System.Drawing.Size(35, 30);
            this.coin2lvl5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2lvl5.TabIndex = 75;
            this.coin2lvl5.TabStop = false;
            this.coin2lvl5.Tag = "coin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 481);
            this.Controls.Add(this.coin2lvl5);
            this.Controls.Add(this.coin2lvl3);
            this.Controls.Add(this.coin2lvl4);
            this.Controls.Add(this.coin2lvl1);
            this.Controls.Add(this.door2);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.platform2lvl12);
            this.Controls.Add(this.platform2lvl19);
            this.Controls.Add(this.platform2lvl18);
            this.Controls.Add(this.platform2lvl17);
            this.Controls.Add(this.platform2lvl16);
            this.Controls.Add(this.platform2lvl15);
            this.Controls.Add(this.platform2lvl14);
            this.Controls.Add(this.platform2lvl13);
            this.Controls.Add(this.platform2lvl11);
            this.Controls.Add(this.platform2lvl10);
            this.Controls.Add(this.platform2lvl9);
            this.Controls.Add(this.platform2lvl0);
            this.Controls.Add(this.platform2lvl5);
            this.Controls.Add(this.platform2lvl8);
            this.Controls.Add(this.platform2lvl7);
            this.Controls.Add(this.platform2lvl6);
            this.Controls.Add(this.platform2lvl4);
            this.Controls.Add(this.platform2lvl3);
            this.Controls.Add(this.platform2lvl2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.platform2lvl1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.background2);
            this.Controls.Add(this.coin2lvl2);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin1);
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
            ((System.ComponentModel.ISupportInitialize)(this.background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2lvl12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2lvl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2lvl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2lvl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2lvl5)).EndInit();
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
        private PictureBox background2;
        private PictureBox platform2lvl1;
        private PictureBox platform2lvl2;
        private PictureBox platform2lvl3;
        private PictureBox platform2lvl4;
        private PictureBox platform2lvl6;
        private PictureBox platform2lvl7;
        private PictureBox platform2lvl8;
        private PictureBox platform2lvl5;
        private PictureBox platform2lvl0;
        private PictureBox platform2lvl9;
        private PictureBox platform2lvl10;
        private PictureBox platform2lvl11;
        private PictureBox platform2lvl13;
        private PictureBox platform2lvl14;
        private PictureBox platform2lvl15;
        private PictureBox platform2lvl16;
        private PictureBox platform2lvl17;
        private PictureBox platform2lvl18;
        private PictureBox platform2lvl19;
        private PictureBox platform2lvl12;
        private PictureBox key2;
        private PictureBox door2;
        private PictureBox coin2lvl1;
        private PictureBox coin2lvl4;
        private PictureBox coin2lvl3;
        private PictureBox coin2lvl5;
    }
}

