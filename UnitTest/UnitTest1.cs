using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRouletteGame;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        int NumberOfPlayer = 2;
        RouletteGame objGame = new RouletteGame();
        [TestMethod]
        public void TestSpinChamberGenrateRandomNumber()
        {
            SpinChamber spin = new SpinChamber();
            spin.ChamberStart = objGame.spinChamber();
            spin.BulleteInChamber = objGame.spinChamber();
        }

        [TestMethod]
        public void TestPlayingGameMethod()
        {
            SpinChamber spin = new SpinChamber();
            spin.ChamberStart = objGame.spinChamber();
            spin.BulleteInChamber = objGame.spinChamber();
            int currentChamber = spin.ChamberStart;
            while (currentChamber != -1)
            {
                currentChamber = GamePlay(NumberOfPlayer, spin.ChamberStart, spin.BulleteInChamber);
                spin.ChamberStart = currentChamber;
            }
            if (currentChamber == -1)
            {
                Assert.AreEqual("GameEnd", "GameEnd");
            }
            else
            {

                Assert.AreEqual("NextRound", "NextRound");
            }
        }
        public int GamePlay(int numPlayers, int currentChamber, int bulletChamber)
        {
            for (int i = 1; i <= numPlayers; i++)
            {

                if (currentChamber == bulletChamber)
                {
                    if (i == 1)
                    {
                        Assert.AreEqual("LoseGame", "LoseGame");
                    }
                    else
                    {
                        Assert.AreEqual("WinGame", "WinGame");
                    }


                    return -1;

                }
                else
                {

                    if (i == 1)
                    {
                        Assert.AreEqual("You are Lucky", "You are Lucky");
                    }
                    else
                    {
                        Assert.AreEqual("Player 2 is lucky", "Player 2 is lucky");
                    }

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
    }
}
