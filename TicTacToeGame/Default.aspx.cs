using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToeGame
{
    public partial class _Default : Page
    {
        public bool xIsNext { get; set; }
        public bool isGameAlive { get; set; }
        public bool tied { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Str.Enabled)
            {
                Label2.Text = "Welcome to Tick Tac Toe Game, click start to begin";
                DesableButtons();
            }
            else
            {

            }
        }

        //it enables all buttons
        protected void EnableButtons()
        {
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;
            Button7.Enabled = true;
            Button8.Enabled = true;
            Button9.Enabled = true;
        }

        //it disables all buttons
        protected void DesableButtons()
        {
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
            Button8.Enabled = false;
            Button9.Enabled = false;
        }

        //it resets the text of the buttons 
        protected void ButtonTextReseated() {
            Button1.Text = "";
            Button2.Text = "";
            Button3.Text = "";
            Button4.Text = "";
            Button5.Text = "";
            Button6.Text = "";
            Button7.Text = "";
            Button8.Text = "";
            Button9.Text = "";            
}

        //it checks wether the game is alive or not 
        protected bool CheckGameStatus()
        {

            if (Button1.Text !="" && Button1.Text == Button2.Text &&
            Button1.Text== Button3.Text)
            {
                isGameAlive = false;

                return false;
            }else
            if (Button4.Text != "" && Button4.Text == Button5.Text &&
           Button4.Text == Button6.Text)
            {
                isGameAlive = false;

                return false;
            }else
            if (Button7.Text != "" && Button7.Text == Button8.Text &&
          Button7.Text == Button9.Text)
            {
                isGameAlive = false;

                return false;
            }else
            if (Button1.Text != "" && Button1.Text == Button4.Text &&
         Button1.Text == Button7.Text)
            {
                isGameAlive = false;

                return false;
            }else
            if (Button2.Text != "" && Button2.Text == Button5.Text &&
        Button2.Text == Button8.Text)
            {
                isGameAlive = false;

                return false;
            }else
            if (Button3.Text != "" && Button3.Text == Button6.Text &&
      Button3.Text == Button9.Text)
            {
                isGameAlive = false;

                return false;
            }else
                if (Button1.Text != "" && Button1.Text == Button5.Text &&
          Button1.Text == Button9.Text)
                {
                    isGameAlive = false;

                    return false;
                }else
                if (Button3.Text != "" && Button3.Text == Button5.Text &&
        Button3.Text == Button7.Text)
                {
                    isGameAlive = false;

                    return false;
                }else if (Button1.Text != "" && Button2.Text != "" && Button3.Text != "" &&
                Button4.Text != "" && Button5.Text != "" && Button6.Text != "" && Button7.Text != "" &&
                Button8.Text != "" && Button9.Text != "")
            {
                isGameAlive = false;
                tied = true;
                Label2.Text = "It seems as we have a Tied, you can play again, click in reset";
                return false;
            }
                else
            {
                return true;
            }
        }

        //it disables the buttons when its over so they will not click again and provides winning message
        protected void setDisabled()
        {
            if (!CheckGameStatus())
            {
                DesableButtons();
                if (tied)
                {

                }
                else
                {
                    Label2.Text = "Congratulations the game is over the winer is " + GetGameValue();
                }
                
            }

            if (Button1.Text != "")
            {
                if (Button1.Text == "X")
                {
                    Button1.ForeColor = Color.Red;
                }
                Button1.Enabled = false;
            }
            if (Button2.Text != "")
            {
                if (Button2.Text == "X")
                {
                    Button2.ForeColor = Color.Red;
                }
                Button2.Enabled = false;
            }
            if (Button3.Text != "")
            {
                if (Button3.Text == "X")
                {
                    Button3.ForeColor = Color.Red;
                }
                Button3.Enabled = false;
            }
            if (Button4.Text != "")
            {
                if (Button4.Text == "X")
                {
                    Button4.ForeColor = Color.Red;
                }
                Button4.Enabled = false;
            }
            if (Button5.Text != "")
            {
                if (Button5.Text == "X")
                {
                    Button5.ForeColor = Color.Red;
                }
                Button5.Enabled = false;
            }
            if (Button6.Text != "")
            {
                if (Button6.Text == "X")
                {
                    Button6.ForeColor = Color.Red;
                }
                Button6.Enabled = false;
            }
            if (Button7.Text != "")
            {
                if (Button7.Text == "X")
                {
                    Button7.ForeColor = Color.Red;
                }
                Button7.Enabled = false;
            }
            if (Button8.Text != "")
            {
                if (Button8.Text == "X")
                {
                    Button8.ForeColor = Color.Red;
                }
                Button8.Enabled = false;
            }
            if (Button9.Text != "")
            {
                if (Button9.Text == "X")
                {
                    Button9.ForeColor = Color.Red;
                }
                Button9.Enabled = false;
            }
}

        //it changes the value of xIsNext to move to the next player
        protected void changePlayer()
        {
            isGameAlive = true;
            double number=0;
          

            if (Button1.Text != "")
            {
                number++;  
            }
            if (Button2.Text != "")
            {
                number++;             
            }
            if (Button3.Text != "")
            {
                number++;               
            }
            if (Button4.Text != "")
            {
                number++;              
            }
            if (Button5.Text != "")
            {
                number++;              
            }
            if (Button6.Text != "")
            {
                number++;             
            }
            if (Button7.Text != "")
            {
                number++;              
            }
            if (Button8.Text != "")
            {
                number++;              
            }
            if (Button9.Text != "")
            {
                number++;              
            }
            if (number!=0)
            {
                if (Math.Ceiling((number % 2)) > 0)
                {
                    xIsNext = !xIsNext;
                }   
            }
        }

        private void InitializeComponent()
        {

        }

        //return the value of the player to be the next
        protected string GetGameValue()
        {
            if (!xIsNext)
            {
                if (isGameAlive)
                {
                    Label2.Text = " Player O is next";
                    }
                return "X";
            }
            else
            {
                if (isGameAlive)
                {
                    Label2.Text = " Player X is next";
                }
                return "O";
            }
        }


        protected void Reset(object sender, EventArgs e)
        {
            ButtonTextReseated();
            Str.Enabled = true;
            Str.Text = "Start";
            Label2.Text = "Welcome to Tick Tac Toe Game, click start to begin";
        }

        //it sets ups the variables to the initial values and begins the game
        protected void Start(object sender, EventArgs e)
        {
            isGameAlive = true;
            Label2.Text = " Player " + GetGameValue() + " is next";
            Str.Text = "Started";
            Str.Enabled = false;
            EnableButtons();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            changePlayer();
            Button1.Text = GetGameValue();
            setDisabled();
        }

        //it resets all the button text to empty and enables the buttons once again
       
        protected void Button2_Click(object sender, EventArgs e)
        {
            changePlayer();
            Button2.Text = GetGameValue();
            setDisabled();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            changePlayer();
            Button3.Text = GetGameValue();
            setDisabled();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            changePlayer();
            Button4.Text = GetGameValue();
            setDisabled();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            changePlayer();
            Button5.Text = GetGameValue();
            setDisabled();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            changePlayer();
            Button6.Text = GetGameValue();
            setDisabled();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            changePlayer();
            Button7.Text = GetGameValue();
            setDisabled();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            changePlayer();
            Button8.Text = GetGameValue();
            setDisabled();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            changePlayer();
            Button9.Text = GetGameValue();
            setDisabled();
        }
    }
}