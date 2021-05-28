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
        sbyte turns = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void XandO(object sender, EventArgs e)
        {
            Button XandObtn = (Button)sender;
            if (XO)
                XandObtn.Text = "X";
            else
                XandObtn.Text = "O";

            XO = !XO;

        }


        private void Restart_click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
