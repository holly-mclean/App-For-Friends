using System;
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

            int newRoll = NumContainer.RollDFour();
            int currentSum = NumContainer.Sum;
            int newSum = newRoll + currentSum;
            NumContainer.Sum = newSum;
            sumDisplay.Text = newSum.ToString();
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

        public int RollDFour()
        {
            int num = rand.Next(1, 5);
            return num;
        }

    }
}
