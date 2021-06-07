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

        bool Is_there_a_winner = false;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Restart_click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void XandO(object sender, EventArgs e)
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
                draw();
            }
        }


        private void WinnerDecide()

            
        {
            

            if ((tic_1.Text == tic_2.Text) && (tic_2.Text == tic_3.Text) && (tic_1.Text != ""))
                Is_there_a_winner = true;
            if ((tic_4.Text == tic_5.Text) && (tic_5.Text == tic_6.Text) && (tic_4.Text != ""))
                Is_there_a_winner = true;
            if ((tic_7.Text == tic_8.Text) && (tic_8.Text == tic_9.Text) && (tic_7.Text != ""))
                Is_there_a_winner = true;

            if ((tic_1.Text == tic_4.Text) && (tic_4.Text == tic_7.Text) && (tic_1.Text != ""))
                Is_there_a_winner = true;
            if ((tic_2.Text == tic_5.Text) && (tic_5.Text == tic_8.Text) && (tic_5.Text != ""))
                Is_there_a_winner = true;
            if ((tic_3.Text == tic_6.Text) && (tic_6.Text == tic_9.Text) && (tic_3.Text != ""))
                Is_there_a_winner = true;

            if ((tic_1.Text == tic_5.Text) && (tic_5.Text == tic_9.Text) && (tic_1.Text != ""))
                Is_there_a_winner = true;
            if ((tic_3.Text == tic_5.Text) && (tic_5.Text == tic_7.Text) && (tic_3.Text != ""))
                Is_there_a_winner = true;

            if (Is_there_a_winner)
            {
                String winner = "";
                if (XO)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show("The winner is player " + winner +
                    "                                                                                     Please click restart to play again", "YAY" );


                
            }
        }


        private void draw()
            {
            if ((turns == 9) && (Is_there_a_winner = false))
                MessageBox.Show("Draw! " + "Wanna play again?", "Aww");
            }
        }

    }


