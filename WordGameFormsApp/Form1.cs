namespace WordGameFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            // Ask player if he really wants to exit the game.
            if (MessageBox.Show("Do you want to Close WordGame?",
                    "WordGame",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Player Clicked on game start button
        private void start_game_button_Click(object sender, EventArgs e)
        {
            Game game_form = new Game();
            game_form.Show();
            this.Hide();
        }

        private void leaderboard_button_Click(object sender, EventArgs e)
        {
            leaderboard leaderboard_form = new leaderboard();
            leaderboard_form.Show();
            this.Hide();
        }


        //END
    }
}