using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SoundPlayer sndPlayer = new SoundPlayer(Resource1.DICEUP);
            sndPlayer.Play();

            Random random1 = new Random(); //this is the library method to generate a random number
            int randno = random1.Next(1, 7);//the variable randno will get a random value between 0, 1, 2, 3, 4, 5
            label2.Text = Convert.ToString(randno);
            if (randno == 1)
            {
                pbDiceShow1.Image = Resource1.one;
            }
            if(randno == 2)
            {
                pbDiceShow1.Image = Resource1.two;
            }
            if (randno == 3)
            {
                pbDiceShow1.Image = Resource1.three;
            }
            if (randno == 4)
            {
                pbDiceShow1.Image = Resource1.four;
            }
            if (randno == 5)
            {
                pbDiceShow1.Image = Resource1.five;
            }
            if (randno == 6)
            {
                pbDiceShow1.Image = Resource1.six;
            }
            randno = random1.Next(1, 7);//the variable randno will get a random value between 0, 1, 2, 3, 4, 5
            label3.Text = Convert.ToString(randno);
            if (randno == 1)
            {
                pbDiceShow2.Image = Resource1.one;
            }
            if (randno == 2)
            {
                pbDiceShow2.Image = Resource1.two;
            }
            if (randno == 3)
            {
                pbDiceShow2.Image = Resource1.three;
            }
            if (randno == 4)
            {
                pbDiceShow2.Image = Resource1.four;
            }
            if (randno == 5)
            {
                pbDiceShow2.Image = Resource1.five;
            }
            if (randno == 6)
            {
                pbDiceShow2.Image = Resource1.six;
            }
            randno = random1.Next(1, 7);//the variable randno will get a random value between 0, 1, 2, 3, 4, 5
            label4.Text = Convert.ToString(randno);
            if (randno == 1)
            {
                pbDiceShow3.Image = Resource1.one;
            }
            if (randno == 2)
            {
                pbDiceShow3.Image = Resource1.two;
            }
            if (randno == 3)
            {
                pbDiceShow3.Image = Resource1.three;
            }
            if (randno == 4)
            {
                pbDiceShow3.Image = Resource1.four;
            }
            if (randno == 5)
            {
                pbDiceShow3.Image = Resource1.five;
            }
            if (randno == 6)
            {
                pbDiceShow3.Image = Resource1.six;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
