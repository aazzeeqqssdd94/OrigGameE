using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Eegame2
{
    public partial class Form1 : Form
    {
        bool goleft = false; // boolean which will control players going left
        bool goright = false; // boolean which will control players going right
        bool jumping = false; // boolean to check if player is jumping or not
        bool hasKey = false; // default value of whether the player has the key
        int jumpSpeed = 10; // integer to set jump speed
        int force = 8; // force of the jump in an integer
        int score = 0; // default score integer set to 0
        int playSpeed = 18; //this integer will set players speed to 18
        int backLeft = 8; // this integer will set the background moving speed to 8
        int levelNumber = 1;

        public Form1()
        {
            InitializeComponent();
            levl1();
            levl2();

            // Удаляем контролы второго уровня из формы, чтобы они появились только после перехода
            RemoveControlsFromForm(level2);

            // Убеждаемся, что первый уровень видим
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void door1_Click(object sender, EventArgs e)
        {

        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            txtScore.Text = "Score " +
                 score;
            // linking the jumpspeed integer with the player picture boxes to location
            player.Top += jumpSpeed;
            // refresh the player picture box consistently
            player.Refresh();
            // if jumping is true and force is less than 0
            // then change jumping to false
            if (jumping && force < 0)
            {
                jumping = false;
            }
            // if jumping is true
            // then change jump speed to -12 
            // reduce force by 1
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                // else change the jump speed to 12
                jumpSpeed = 12;
            }
            // if go left is true and players left is greater than 100 pixels
            // only then move player towards left of the 
            if (goleft && player.Left > 100)
            {
                player.Left -= playSpeed;
            }
            // by doing the if statement above, the player picture will stop on the forms left
            // if go right Boolean is true
            // player left plus players width plus 100 is less than the forms width
            // then we move the player towards the right by adding to the players left
            if (goright && player.Left + (player.Width + 100) < this.ClientSize.Width)
            {
                player.Left += playSpeed;
            }
            // by doing the if statement above, the player picture will stop on the forms right
            // if go right is true and the background picture left is greater 1352
            // then we move the background picture towards the left
            if (goright && background.Left > -1353)
            {
                background.Left -= backLeft;
                // the for loop below is checking to see the platforms and coins in the level
                // when they are found it will move them towards the left
                foreach (Control x in this.Controls)
                {
                    if ((x is PictureBox) && (x.Tag == "platform" || x.Tag == "coin" || x.Tag == "door" || x.Tag == "key"))
                    {
                        x.Left -= backLeft;
                    }
                }
            }
            // if go left is true and the background pictures left is less than 2
            // then we move the background picture towards the right
            if (goleft && background.Left < 2)
            {
                background.Left += backLeft;
                // below the is the for loop thats checking to see the platforms and coins in the level
                // when they are found in the level it will move them all towards the right with the background
                foreach (Control x in this.Controls)
                {
                    if ((x is PictureBox) && (x.Tag == "platform" || x.Tag == "coin" || x.Tag == "door" || x.Tag == "key"))
                    {
                        x.Left += backLeft;
                    }
                }
            }
            // below if the for loop thats checking for all of the controls in this form
            foreach (Control x in this.Controls)
            {
                // is X is a picture box and it has a tag of platform
                if (x is PictureBox && x.Tag == "platform")
                {
                    // then we are checking if the player is colliding with the platform
                    // and jumping is set to false
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        // then we do the following
                        force = 8; // set the force to 8
                        player.Top = x.Top - player.Height; // also we place the player on top of the picture box
                        jumpSpeed = 0; // set the jump speed to 0
                    }
                }
            }

            // Переход между уровнями: если игрок пересек дверь текущего уровня и имеет ключ
            if (levelNumber == 1)
            {
                if (door != null && player.Bounds.IntersectsWith(door.Bounds) && hasKey)
                {
                    // удаляем элементы первого уровня из формы
                    RemoveControlsFromForm(level1);

                    // добавляем элементы второго уровня в форму
                    AddControlsToForm(level2);

                    // показываем второй уровень и обновляем состояние
                    
                    levelNumber = 2;
                    player.Location = new Point(27, 50);
                    hasKey = false;
                }
            }
            else if (levelNumber == 2)
            {
                // при необходимости можно обработать дверь второго уровня (door2) отдельно
                if (door2 != null && player.Bounds.IntersectsWith(door2.Bounds) && hasKey)
                {
                    // пример: перейти на следующий уровень (если есть)
                    door2.Image = Properties.Resources.door_open;
                    levelNumber++;
                    player.Location = new Point(27, 50);
                }
            }

            // если игрок пересек ключ (проверяем null)
            if (key1 != null && player.Bounds.IntersectsWith(key1.Bounds))
            {
                // then we remove the key from the  game
                if (this.Controls.Contains(key1))
                    this.Controls.Remove(key1);
                // change the has key boolean to true
                hasKey = true;
            }

            // если ключ второго уровня
            if (key2 != null && player.Bounds.IntersectsWith(key2.Bounds))
            {
                if (this.Controls.Contains(key2))
                    this.Controls.Remove(key2);
                hasKey = true;
            }

            // this is where the player dies
            // if the player goes below the forms height then we will end the game
            if (player.Top + player.Height > this.ClientSize.Height + 60)
            {
                gameTimer.Stop(); // stop the timer
                MessageBox.Show("You Died!!!"); // show the message box
            }
        }


        private void keyisdown(object sender, KeyEventArgs e)
        {
            //if the player pressed the left key AND the player is inside the panel
            // then we set the car left boolean to true
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            // if player pressed the right key and the player left plus player width is less then the panel1 width          

            if (e.KeyCode == Keys.Right)
            {
                // then we set the player right to true
                goright = true;
            }
            //if the player pressed the space key and jumping boolean is false

            if (e.KeyCode == Keys.Space && !jumping)
            {
                // then we set jumping to true
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            // if the LEFT key is up we set the car left to false
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            // if the RIGHT key is up we set the car right to false
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            //when the keys are released we check if jumping is true
            // if so we need to set it back to false so the player can jump again
            if (jumping)
            {
                jumping = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void levl1()
        {
            level1.Add(platform1234);
            level1.Add(platform5);
            level1.Add(platform6);
            level1.Add(platform7);
            level1.Add(platform8);
            level1.Add(platform9);
            level1.Add(platform10);
            level1.Add(platform11);
            level1.Add(platform12);
            level1.Add(platform13);
            level1.Add(platform14);
            level1.Add(platform15);
            level1.Add(platform16);
            level1.Add(key1);
            level1.Add(coin1);
            level1.Add(coin2);
            level1.Add(coin3);
            level1.Add(door);
            level1.Add(background);

            // Конфигурация key1 остаётся при инициализации контролов в InitializeComponent
            // Здесь можно корректировать свойства, если нужно
            if (key1 != null)
            {
                this.key1.Image = global::Eegame2.Properties.Resources.key;
                this.key1.Location = new System.Drawing.Point(388, 43);
                this.key1.Name = "key1";
                this.key1.Size = new System.Drawing.Size(90, 47);
                this.key1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                this.key1.TabIndex = 22;
                this.key1.TabStop = false;
                this.key1.Tag = "key";
            }
        }

        public void levl2()
        {
            level2.Add(platform2lvl1);
            level2.Add(platform2lvl2);
            level2.Add(platform2lvl3);
            level2.Add(platform2lvl4);
            level2.Add(platform2lvl5);
            level2.Add(platform2lvl6);
            level2.Add(platform2lvl7);
            level2.Add(platform2lvl8);
            level2.Add(platform2lvl9);
            level2.Add(platform2lvl10);
            level2.Add(platform2lvl11);
            level2.Add(platform2lvl12);
            level2.Add(platform2lvl13);
            level2.Add(platform2lvl14);
            level2.Add(platform2lvl15);
            level2.Add(platform2lvl16);
            level2.Add(platform2lvl17);
            level2.Add(platform2lvl18);
            level2.Add(door2);
            level2.Add(coin2lvl1);
            level2.Add(coin2lvl2);
            level2.Add(coin2lvl3);
            level2.Add(background1);
            level2.Add(key2);
        }
 


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

 

        // Добавленные утилиты для управления контролами уровней
        private void AddControlsToForm(List<PictureBox> list)
        {
            foreach (PictureBox pb in list)
            {
                if (pb == null) continue;
                if (!this.Controls.Contains(pb))
                {
                    this.Controls.Add(pb);
                }
            }
            // расположение порядка элементов: выводим игрока и текст поверх
            player.BringToFront();
            txtScore.BringToFront();
        }

        private void RemoveControlsFromForm(List<PictureBox> list)
        {
            foreach (PictureBox pb in list)
            {
                if (pb == null) continue;
                if (this.Controls.Contains(pb))
                {
                    this.Controls.Remove(pb);
                }
            }
        }
    }
}
