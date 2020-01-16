using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Rock_Paper_Scissors
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Variables 
        public string pickPlayer01 = "";

        //Method set configurations of the game
        public void SetGame()
        {
            //Set the players
            string player01;
            string player02;
            player01 = txtPlayer01.Text;
            player02 = txtPlayer02.Text;

            //Set the score
            lblPlayer01.Text = txtPlayer01.Text;
            lblPlayer02.Text = player02;
            txtScorePlayer01.Text = 0.ToString();
            txtScorePlayer02.Text = 0.ToString();
            txtScoreEven.Text = 0.ToString();
            txtQntMatch.Text = ListQntGames.Text;
            txtNumberMatched.Text = 1.ToString();
            if(player02 == "Computer")
            {
                lblTurn.Text = "Turn " + player01;
            }
            else
            {
                lblTurn.Text = "Turn " + player01 + ". Please " + player02 + " looks to another way!";
            }
            lblTurn.ForeColor = Color.Blue;
            txtStatus.Clear();

            //Enabled the buttons for the player
            txtPlayer01.Enabled = false;
            txtPlayer02.Enabled = false;
            ListQntGames.Enabled = false;
            ckbComputer.Enabled = false;
            btnSalve.Enabled = false;

            //Enable the buttons for the player
            btnScissors.Enabled = true;
            btnRock.Enabled = true;
            btnPaper.Enabled = true;
        }

        public void reSetGame()
        {
            //Enabled the buttons for the player
            txtPlayer01.Enabled = true;
            ListQntGames.Enabled = true;
            ckbComputer.Enabled = true;
            btnSalve.Enabled = true;

            //Enable the buttons for the player
            btnScissors.Enabled = false;
            btnRock.Enabled = false;
            btnPaper.Enabled = false;

            if(ckbComputer.Checked == true)
            {
                txtPlayer02.Enabled = false;
            }
            else
            {
                txtPlayer02.Enabled = true;
            }
        }

        //Method update Score
        public void updateScore(string winner)
        {
            //set variables with Score's Value
            int qntMatch = Convert.ToInt32(txtQntMatch.Text);
            int qntMatched = Convert.ToInt32(txtNumberMatched.Text);
            int winPlayer01 = Convert.ToInt32(txtScorePlayer01.Text);
            int winPlayer02 = Convert.ToInt32(txtScorePlayer02.Text);
            int even = Convert.ToInt32(txtScoreEven.Text);
            string log = txtStatus.Text;

            //If the quantity of matches are lower than quantity of matches played, do teh IF
            if (qntMatched <= qntMatch)
            {
                //Verify who is the winneer of the match
                if (winner == "Player01")
                {
                    winPlayer01 = Convert.ToInt32(txtScorePlayer01.Text) + 1;
                    txtScorePlayer01.Clear();
                    txtScorePlayer01.Text = winPlayer01.ToString();
                    log += "Match " + qntMatched + " - " + txtPlayer01.Text + " was winner!";
                    txtStatus.Text = log;
                }
                else if (winner == "Player02")
                {
                    winPlayer02 = Convert.ToInt32(txtScorePlayer02.Text) + 1;
                    txtScorePlayer02.Clear();
                    txtScorePlayer02.Text = winPlayer02.ToString();
                    log += "Match " + qntMatched + " - " + txtPlayer02.Text + " was winner!";
                    txtStatus.Text = log;
                }
                else
                {
                    even = Convert.ToInt32(txtScoreEven.Text) + 1;
                    txtScoreEven.Clear();
                    txtScoreEven.Text = even.ToString();
                    log += "Match " + qntMatched + " - Nobody won!";
                    txtStatus.Text = log;
                }

                //Update number of match
                txtNumberMatched.Clear();
                qntMatched++;
                txtNumberMatched.Text = qntMatched.ToString();

                //if the quantity matched is equal the quantity of match +1, do the IF
                if (qntMatched == qntMatch + 1)
                {
                    txtNumberMatched.Text = qntMatch.ToString();
                    if (winPlayer01 > winPlayer02)
                    {
                        lblTurn.Text = "The big winner was " + txtPlayer01.Text;
                        lblTurn.ForeColor = Color.Green;
                    }
                    else if (winPlayer01 < winPlayer02)
                    {
                        lblTurn.Text = "The big winner was " + txtPlayer02.Text;
                        lblTurn.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblTurn.Text = "Nobody won!!!!";
                        lblTurn.ForeColor = Color.Blue;
                    }
                    reSetGame();
                }
                
            }
        }

        //Method agaist computer
        public void matchComputer(string pick01)
        {
            string[] typePick = { "paper", "rock", "scissor" };
            Random randomPick = new Random();
            int index = randomPick.Next(typePick.Length);
            string pick02 = typePick[index];
            string result = GameRules(pick01, pick02);

            //who won the match
            string winner;
            if (pick01 == result)
            {
                winner = "Player01";
            }else if(pick02 == result)
            {
                winner = "Player02";
            }
            else
            {
                winner = "Even";
            }
            //update Status
            string log;
            log = txtPlayer01.Text + " picked " + pick01 + Environment.NewLine;
            log += txtPlayer02.Text + " picked " + pick02 + Environment.NewLine;
            log += "Result was " + result + Environment.NewLine;
            txtStatus.Text = log;
            lblTurn.Text = "Turn " + txtPlayer01.Text;

            //Method update Score
            updateScore(winner);
        }

        //Method against player 02
        public void matchPlayer(string pick01, string pick02)
        {
            string result = GameRules(pick01, pick02);
            
            //who won the match
            string winner;
            if (pick01 == result)
            {
                winner = "Player01";
            }
            else if (pick02 == result)
            {
                winner = "Player02";
            }
            else
            {
                winner = "Even";
            }
            //update Status
            string log;
            log = txtPlayer01.Text + " picked " + pick01 + Environment.NewLine;
            log += txtPlayer02.Text + " picked " + pick02 + Environment.NewLine;
            log += "Result was " + result + Environment.NewLine;
            txtStatus.Text = log;
            

            //Clean the variable player 01 and chance de turn
            pickPlayer01 = "";
            lblTurn.Text = "Turn " + txtPlayer01.Text + ". Please " + txtPlayer02.Text + " looks to another way!";
            lblTurn.ForeColor = Color.Blue;

            //Method update Score
            updateScore(winner);
        }

        //game's Rules
        public string GameRules(string pick01, string pick02)
        {
            if ((pick01 == "paper" && pick02 == "paper") || (pick01 == "rock" && pick02 == "rock") || (pick01 == "scissor" && pick02 == "scissor"))
            {
                return "Even";
            }
            else
            {
                if ((pick01 == "paper" && pick02 == "rock") || (pick02 == "paper" && pick01 == "rock"))
                {
                    return "paper";
                }
                if ((pick01 == "paper" && pick02 == "scissor") || (pick02 == "paper" && pick01 == "scissor"))
                {
                    return "scissor";
                }
                else
                {
                    return "rock";
                }
            }
        }

        private void BtnSalvePlayer_Click(object sender, EventArgs e)
        {
            //validate if all options are choose
            bool flag;
            int qntMatch;

            flag = int.TryParse(ListQntGames.Text, out qntMatch);
            if (txtPlayer01.Text == "")
            {
                MessageBox.Show("Please, inform a player's 01 name!", "Input error");
                txtPlayer01.Focus();
            }
            else if (txtPlayer02.Text == "")
            {
                MessageBox.Show("Please, inform a player's 02 name!", "Input error");
                txtPlayer02.Focus();
            }
            else if (txtPlayer02.Text == txtPlayer01.Text)
            {
                MessageBox.Show(txtPlayer02.Text + " already was choose!", "Input error");
                txtPlayer02.Clear();
                txtPlayer02.Focus();
            }
            else if (flag == false)
            {
                MessageBox.Show("Please, choose 1, 3 or 5", "Input error");
            }
            else
            {
                //The user cannot use Computer as his name
                if(txtPlayer02.Text == "Computer" && ckbComputer.Checked == false)
                {
                    MessageBox.Show("You can't use Computer as your name", "Input error");
                    txtPlayer02.Focus();
                    txtPlayer02.Clear();
                }
                else
                {
                    SetGame();
                }
            }
        }

        private void CkbComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbComputer.Checked)
            {
                txtPlayer02.Enabled = false;
                txtPlayer02.Clear();
                txtPlayer02.Text = "Computer";
            }
            else
            {
                txtPlayer02.Enabled = true;
            }
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            //Verify who is playing
            if (txtPlayer02.Text == "Computer")
            {
                //call method Computer
                matchComputer("rock");
            }
            else
            {
                //Testing if Player 01 picked
                if (pickPlayer01 == "")
                {
                    pickPlayer01 = "rock";
                    lblTurn.Text = "Turn " + txtPlayer02.Text + ". Please " + txtPlayer01.Text + " looks to another way!";
                    lblTurn.ForeColor = Color.Indigo;
                }
                else
                {
                    //call method Human
                    matchPlayer(pickPlayer01, "rock");
                }
            }
        }

        private void BtbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            //Verify who is playing
            if (txtPlayer02.Text == "Computer")
            {
                //call method Computer
                matchComputer("scissor");
            }
            else
            {
                //Testing if Player 01 picked
                if(pickPlayer01 == "")
                {
                    pickPlayer01 = "scissor";
                    lblTurn.Text = "Turn " + txtPlayer02.Text + ". Please " + txtPlayer01.Text + " looks to another way!";
                    lblTurn.ForeColor = Color.Indigo;
                }
                else
                {
                    //call method Human
                    matchPlayer(pickPlayer01, "scissor");
                } 
            }
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            //Verify who is playing
            if (txtPlayer02.Text == "Computer")
            {
                //call method Computer
                matchComputer("paper");
            }
            else
            {
                //Testing if Player 01 picked
                if (pickPlayer01 == "")
                {
                    pickPlayer01 = "paper";
                    lblTurn.Text = "Turn " + txtPlayer02.Text + ". Please " + txtPlayer01.Text + " looks to another way!";
                    lblTurn.ForeColor = Color.Indigo;
                }
                else
                {
                    //call method Human
                    matchPlayer(pickPlayer01, "paper");
                }
            }
        }

    }
}