using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectlf6
{
    public partial class GameMain : Form
    {
        private Player playerOne;
        private Player playerTwo;
        
        public GameMain(Player one, Player two)
        {
            InitializeComponent();
            this.playerOne = one;
            this.playerTwo = two;

            this.lbl_playerone.Text = playerOne.getName();
            this.lbl_playertwo.Text = playerTwo.getName();
            this.lbl_scoreplayerone.Text = playerOne.getScore().getScore().ToString();
            this.lbl_scoreplayertwo.Text = playerTwo.getScore().getScore().ToString();
        }
    }
}
