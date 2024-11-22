namespace TicTac
{
    public partial class Form1 : Form
    {

        bool choice;
        string labelText = "Winner: ";

        public Form1()
        {
           
            InitializeComponent();
            choice = true;
            label1.Text = labelText;
        }

       

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text =="")
            {
                button.Text = choice? "X" : "O";
                choice = !choice;
            }
            string symbol = button.Text;

            bool hasWon = checkWinner(symbol);

            
            if (hasWon)
            {
                label1.Text += symbol;
                GameOver();
                return;
            }

            bool isDraw = CheckIfDraw();
            if (isDraw)
            {
                label1.Text += "Draw";
                GameOver();
                return;
            }

        }
        private bool checkWinner(string symbol)
        {
            bool hasWon = (button1.Text == symbol && button2.Text == symbol && button3.Text == symbol) ||
                (button4.Text == symbol && button5.Text == symbol && button6.Text == symbol) ||
                (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol) ||
                (button1.Text == symbol && button4.Text == symbol && button7.Text == symbol) ||
                (button2.Text == symbol && button5.Text == symbol && button8.Text == symbol) ||
                (button3.Text == symbol && button6.Text == symbol && button9.Text == symbol) ||
                (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol) ||
                (button3.Text == symbol && button5.Text == symbol && button7.Text == symbol);

            return hasWon;
        }

        public void GameOver()
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if(button != button10)
                {
                    button.Enabled = false; 
                }
           
            }
        }

        public bool CheckIfDraw()
        {
            bool isDraw = true;
            foreach (Button button in this.Controls.OfType<Button>())
            {
               if(button.Text == string.Empty)
                {
                    isDraw = false;
                }
            }
            return isDraw;
        }


        public void RestartGame(object sender, EventArgs e)
        {
            choice = true;
            label1.Text = labelText;
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if (button != button10)
                {
                    button.Text = "";
                    button.Enabled = true;
                }
            }


        }

    }
}
