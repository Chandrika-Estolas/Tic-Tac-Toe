using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        bool XO = true;
       
        int turns = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Restart_click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void XandO(object sender, EventArgs e)
        {
            
                Button XandObtn = (Button)sender;
            if (XandObtn.Text == "")
            {
                if (XO)
                    XandObtn.Text = "X";

                else
                    XandObtn.Text = "O";

                XO = !XO;
                turns++;

                WinnerDecide();
            }
        }

        private void WinnerDecide()

        {
            bool winner = false;

            if ((tic_1.Text == tic_2.Text) && (tic_2 == tic_3)&& !tic_1.Enabled)
                winner = true;
            if ((tic_4.Text == tic_5.Text) && (tic_5 == tic_6) && !tic_4.Enabled)
                winner = true;
            if ((tic_7.Text == tic_8.Text) && (tic_8 == tic_9) && !tic_7.Enabled)
                winner = true;
            if ((tic_1.Text == tic_4.Text) && (tic_4 == tic_7) && !tic_1.Enabled)
                winner = true;
            if ((tic_2.Text == tic_5.Text) && (tic_5 == tic_8) && !tic_2.Enabled)
                winner = true;
            if ((tic_3.Text == tic_6.Text) && (tic_6 == tic_9) && !tic_3.Enabled)
                winner = true;
            if ((tic_1.Text == tic_5.Text) && (tic_5 == tic_9) && !tic_1.Enabled)
                winner = true;
            if ((tic_3.Text == tic_5.Text) && (tic_5 == tic_7) && !tic_3.Enabled)
                winner = true;

            if (winner)
            {
                string winner_is = "";

                if (XO)
                    winner_is = "O";
                else
                    winner_is = "X";

                MessageBox.Show("The winner is player " + winner_is);

            }
            else
            {
                if (turns == 9)
                    MessageBox.Show("Draw! " + "Wanna play again?");
            }

        }
    }
}

