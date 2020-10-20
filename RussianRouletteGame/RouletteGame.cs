using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteGame
{
    public partial class RouletteGame : Form
    {
        WinLose objResult = new WinLose();
        SpinChamber spin = new SpinChamber();
        private static Random generator = new Random();
        public int NumberOfPlayer = 2;
        bool IsGunLoad = false;
        int round = 1;
        public RouletteGame()
        {
            InitializeComponent();
        }

        private void RouletteGame_Load(object sender, EventArgs e)
        {
            buttonSpinChamber.Enabled = false;
            lblGameInfo.Visible = false;
           
        }

        private void buttonLoadBullet_Click(object sender, EventArgs e)
        {
            IsGunLoad = true;
            buttonSpinChamber.Enabled = true;
            buttonLoadBullet.Enabled = false;
            round = 1;
        }

        private void buttonSpinChamber_Click(object sender, EventArgs e)
        {
            if (IsGunLoad == true)
            {
                spin.ChamberStart = spinChamber(); //Set Chamber to start game
                spin.BulleteInChamber = spinChamber(); //Bullet is which chamber
                buttonShoot.Enabled = true;
                buttonSpinChamber.Enabled = false;
                lblGameInfo.Text = "Round 1 - Shoot";
                lblGameInfo.Visible = true;
                buttonPlayAgain.Enabled = false;
            }
            else
            {
                lblGameInfo.Text = "Please Load the bullete";
            }
        }
        public int spinChamber()
        {

            return generator.Next(1, 7);

        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            buttonShoot.Enabled = false;
            //Play the game
            int currentChamber = GamePlay(NumberOfPlayer, spin.ChamberStart, spin.BulleteInChamber);
            spin.ChamberStart = currentChamber;

            if (currentChamber == -1)
            {
                buttonShoot.Enabled = false;
                buttonPlayAgain.Enabled = true;
            }
            else
            {

                lblGameInfo.Visible = false;
                buttonShoot.Enabled = true;
                round++;
                lblGameInfo.Text = "Round " + round + "- Shoot";
                lblGameInfo.Visible = true;
            }
        }
        public int GamePlay(int numPlayers, int currentChamber, int bulletChamber)
        {
            for (int i = 1; i <= numPlayers; i++)
            {

                // chamber with bullet is fired

                if (currentChamber == bulletChamber)
                {
                    SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\gunshot.wav");
                    simpleSound.Play();
                    labelDead.Visible = true;
                    if (i == 1)
                    {
                        labelDead.Text = "You Dead!!!";
                        lblGameInfo.Text = "LOSE GAME!!!";
                        labelDead.Visible = true;
                        lblGameInfo.Visible = true;
                        objResult.LoseGame++;
                        labelLose.Text = objResult.LoseGame.ToString();
                    }
                    else
                    {

                        labelDead.Text = "Player " + i + " is dead...";
                        lblGameInfo.Text = "WIN GAME!!!";
                        labelDead.Visible = true;
                        lblGameInfo.Visible = true;
                        objResult.WinGame++;
                        labelWin.Text = objResult.WinGame.ToString();
                    }


                    return -1;

                }
                else
                {

                    if (i == 1)
                    {
                        lblGameInfo.Text = "You Are Lucky";
                    }
                    else
                    {
                        lblGameInfo.Text = "Player " + i + " is Lucky";
                    }

                    lblGameInfo.Visible = true;

                    lblGameInfo.Visible = false;


                }
                if (currentChamber == 6)
                {

                    currentChamber = 1;

                }
                else
                {

                    currentChamber++;

                }


            }
            return currentChamber;


        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            buttonSpinChamber.Enabled = false;
            buttonLoadBullet.Enabled = true;
            buttonShoot.Enabled = false;
            spin.ChamberStart = 0;
            spin.BulleteInChamber = 0;

            IsGunLoad = false;

            labelDead.Visible = false;
            lblGameInfo.Visible = false;
            round = 1;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
    public class SpinChamber
    {
        public int ChamberStart { get; set; }
        public int BulleteInChamber { get; set; }
    }
    public class WinLose
    {
        public int WinGame = 0;
        public int LoseGame = 0;
    }
}
