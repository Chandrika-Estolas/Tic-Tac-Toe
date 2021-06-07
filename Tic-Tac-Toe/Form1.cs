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


            if ((tic_1.Text == tic_2.Text) && (tic_2.Text == tic_3.Text) && (tic_1.Text != ""))
                MessageBox.Show("The Winner is player " + tic_1.Text );
            if ((tic_4.Text == tic_5.Text) && (tic_5.Text == tic_6.Text) && (tic_4.Text != ""))
                MessageBox.Show("The Winner is player " + tic_4.Text);
            if ((tic_7.Text == tic_8.Text) && (tic_8.Text == tic_9.Text) && (tic_7.Text != ""))
                MessageBox.Show("The Winner is player " + tic_7.Text);

            if ((tic_1.Text == tic_4.Text) && (tic_4.Text == tic_7.Text) && (tic_1.Text != ""))
                MessageBox.Show("The Winner is player " + tic_1.Text);
            if ((tic_2.Text == tic_5.Text) && (tic_5.Text == tic_8.Text) && (tic_5.Text != ""))
                MessageBox.Show("The Winner is player " + tic_5.Text);
            if ((tic_3.Text == tic_6.Text) && (tic_6.Text == tic_9.Text) && (tic_3.Text != ""))
                MessageBox.Show("The Winner is player " + tic_3.Text);

            if ((tic_1.Text == tic_5.Text) && (tic_5.Text == tic_9.Text) && (tic_1.Text != ""))
                MessageBox.Show("The Winner is player " + tic_1.Text);
            if ((tic_3.Text == tic_5.Text) && (tic_5.Text == tic_7.Text) && (tic_3.Text != ""))
                MessageBox.Show("The Winner is player " + tic_3.Text);

            else
            {
                if (turns == 9)
                    MessageBox.Show("Draw! " + "Wanna play again?");
            }

        }
    }
}

