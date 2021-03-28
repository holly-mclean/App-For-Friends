﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_For_Friends
{
    public partial class Form1 : Form
    {
        public NumberContainer NumContainer { get; set; }

        public Form1()
        {
            InitializeComponent();

            NumContainer = new NumberContainer { Sum = 0 , DFourRolled = 0, DSixRolled = 0, DEightRolled = 0, DTenRolled = 0, DTwelveRolled = 0, DTwentyRolled = 0, DPercentileRolled = 0};
        }

        private void d4button_Click(object sender, EventArgs e)
        {
            NumContainer.DFourRolled += 1;
            string newDisplay = NumContainer.DFourRolled + "d4";
            d4display.Text = newDisplay;

            int newRoll = NumContainer.RollDice(4);
            int currentSum = NumContainer.Sum;
            int newSum = newRoll + currentSum;
            NumContainer.Sum = newSum;
            sumDisplay.Text = newSum.ToString();

            string allRollsDisplay = newRoll + " + ";
            allRollsLabel.Text += allRollsDisplay;
        }

        private void d6button_Click(object sender, EventArgs e)
        {
            NumContainer.DSixRolled += 1;
            string newDisplay = NumContainer.DSixRolled + "d6";
            d6display.Text = newDisplay;

            int newRoll = NumContainer.RollDice(6);
            int currentSum = NumContainer.Sum;
            int newSum = newRoll + currentSum;
            NumContainer.Sum = newSum;
            sumDisplay.Text = newSum.ToString();

            string allRollsDisplay = newRoll + " + ";
            allRollsLabel.Text += allRollsDisplay;
        }

        private void d8button_Click(object sender, EventArgs e)
        {
            NumContainer.DEightRolled += 1;
            string newDisplay = NumContainer.DEightRolled + "d8";
            d8display.Text = newDisplay;

            int newRoll = NumContainer.RollDice(8);
            int currentSum = NumContainer.Sum;
            int newSum = newRoll + currentSum;
            NumContainer.Sum = newSum;
            sumDisplay.Text = newSum.ToString();

            string allRollsDisplay = newRoll + " + ";
            allRollsLabel.Text += allRollsDisplay;
        }

        private void d10button_Click(object sender, EventArgs e)
        {
            NumContainer.DTenRolled += 1;
            string newDisplay = NumContainer.DTenRolled + "d10";
            d10display.Text = newDisplay;

            int newRoll = NumContainer.RollDice(10);
            int currentSum = NumContainer.Sum;
            int newSum = newRoll + currentSum;
            NumContainer.Sum = newSum;
            sumDisplay.Text = newSum.ToString();

            string allRollsDisplay = newRoll + " + ";
            allRollsLabel.Text += allRollsDisplay;
        }

        private void d12button_Click(object sender, EventArgs e)
        {
            NumContainer.DTwelveRolled += 1;
            string newDisplay = NumContainer.DTwelveRolled + "d12";
            d12display.Text = newDisplay;

            int newRoll = NumContainer.RollDice(12);
            int currentSum = NumContainer.Sum;
            int newSum = newRoll + currentSum;
            NumContainer.Sum = newSum;
            sumDisplay.Text = newSum.ToString();

            string allRollsDisplay = newRoll + " + ";
            allRollsLabel.Text += allRollsDisplay;
        }

        private void d20button_Click(object sender, EventArgs e)
        {
            NumContainer.DTwentyRolled += 1;
            string newDisplay = NumContainer.DTwentyRolled + "d20";
            d20display.Text = newDisplay;

            int newRoll = NumContainer.RollDice(20);
            int currentSum = NumContainer.Sum;
            int newSum = newRoll + currentSum;
            NumContainer.Sum = newSum;
            sumDisplay.Text = newSum.ToString();

            string allRollsDisplay = newRoll + " + ";
            allRollsLabel.Text += allRollsDisplay;
        }

        private void dPercentButton_Click(object sender, EventArgs e)
        {
            NumContainer.DPercentileRolled += 1;
            string newDisplay = NumContainer.DPercentileRolled + "d%";
            dPercentDisplay.Text = newDisplay;

            int newRoll = NumContainer.RollDice(100);
            int currentSum = NumContainer.Sum;
            int newSum = newRoll + currentSum;
            NumContainer.Sum = newSum;
            sumDisplay.Text = newSum.ToString();

            string allRollsDisplay = newRoll + " + ";
            allRollsLabel.Text += allRollsDisplay;
        }
    }

    public class NumberContainer
    {
        public Random rand = new Random();
        public int Sum { get; set; }
        public int DFourRolled { get; set; }
        public int DSixRolled { get; set; }
        public int DEightRolled { get; set; }
        public int DTenRolled { get; set; }
        public int DTwelveRolled { get; set; }
        public int DTwentyRolled { get; set; }
        public int DPercentileRolled { get; set; }

        public int RollDice(int diceType)
        {
            int num = rand.Next(1, (diceType + 1));
            return num;
        }

        //public void UpdateSum(int newRoll)
        //{
        //    int currentSum = Sum;
        //    int newSum = newRoll + currentSum;
        //    Sum = newSum;
        //    sumDisplay.Text = newSum.ToString();

        //    string allRollsDisplay = newRoll + " + ";
        //    allRollsLabel.Text += allRollsDisplay;
        //}
    }
}
