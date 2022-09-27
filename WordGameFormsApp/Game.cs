using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WordGame;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using static WordGameFormsApp.leaderboard;

namespace WordGameFormsApp
{
    public partial class Game : Form
    {
        // Navigation
        Form1 form1 = new Form1();
        leaderboard leaderboard = new leaderboard();
        // Random
        Random random = new Random();
        // Wordlist.txt
        const string f = "wordlist.txt";
        string selected_word = "";
        int time;
        int score;
        int life;
        string player_name = "";

        public Game()
        {
            InitializeComponent();
        }

        // Load first Game
        private void Game_LoadAsync(object sender, EventArgs e)
        {
            ShowInputDialogBox(ref player_name, "What is your name?", "Player Name", 300, 200);

            time = 100;
            score = 0;
            life = 3;
            score_label.Text = "Score: " + score.ToString();
            time_label.Text = "Time: " + time.ToString();
            life_label.Text = "Life: " + life.ToString();
        }

        private async void getARandomWord()
        {
            timer1.Stop();
            int position = random.Next(0, 172823);
            int lineNumber = 0;
            word_label.Text = "";
            using (var streamReader = File.OpenText(f))
            {
                string inputString = null;
                do
                {
                    inputString = streamReader.ReadLine();
                    lineNumber++;
                    if (lineNumber == position)
                    {
                        selected_word = inputString.ToLower();
                        word_label.Text = inputString.ToLower();
                        timer1.Start();
                        start_game_button.Text = "Next word";
                        break;
                    }

                } while (inputString != null);
            }


        }
        private void start_game_button_Click(object sender, EventArgs e)
        {
            info_label.Visible = false;
            checkWord();
        }

        private void user_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            // DETECT ENTER KEY
            if (e.KeyChar == (char)13)
            {
                info_label.Visible = false;
                checkWord();
            }
        }

        private void checkWord()
        {
            if (user_input.Text == selected_word)
            {
                score++;
                score_label.Text = "Score: " + score.ToString();
                getARandomWord();
                user_input.Text = "";
            }
            else if (user_input.Text != selected_word && life > 0)
            {
                life--;
                getARandomWord();
                life_label.Text = "Life: " + life.ToString();
                user_input.Text = "";
            }
            else if (life == 0 || life < 1)
            {
                // END GAME SET HIGHSCORE
                var user_score = new HighScore() { Score = score, playerName = player_name, dateTime = DateTime.Now.ToString() };
                _highScores.Add(user_score);
                var serializer = new XmlSerializer(_highScores.GetType(), "HighScores.Scores");
                using (var writer = new StreamWriter("highscores.xml", false))
                {
                    serializer.Serialize(writer.BaseStream, _highScores);
                }
                // Load leaderboard
                leaderboard.Show();
                this.Hide();
                //end Game
            }
            else
            {
                // END GAME SET HIGHSCORE
                var user_score = new HighScore() { Score = score, playerName = player_name, dateTime = DateTime.Now.ToString() };
                _highScores.Add(user_score);
                var serializer = new XmlSerializer(_highScores.GetType(), "HighScores.Scores");
                using (var writer = new StreamWriter("highscores.xml", false))
                {
                    serializer.Serialize(writer.BaseStream, _highScores);
                }
                // Load leaderboard
                leaderboard.Show();
                this.Hide();
                //end Game
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            var user_score = new HighScore() { Score = score, playerName = player_name, dateTime = DateTime.Now.ToString() };
            _highScores.Add(user_score);
            var serializer = new XmlSerializer(_highScores.GetType());
            using (var writer = new StreamWriter("highscores.xml", false))
            {
                serializer.Serialize(writer.BaseStream, _highScores);
            }

            form1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            int timepast = 100 - time;
            time_label.Text = "Time: " + timepast.ToString();
            time_bar.Value--;
        }

        [Serializable()]
        public class HighScore
        {
            public int Score { get; set; }
            public string playerName { get; set; }
            public string dateTime { get; set; }
        }

        public List<HighScore> _highScores = new List<HighScore>();



        private static DialogResult ShowInputDialogBox(ref string input, string prompt, string title = "Title", int width = 300, int height = 200)
        {
            //Specify the size of the window using the parameters passed
            Size size = new Size(width, height);
            //Create a new form using a System.Windows Form
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.ClientSize = size;
            //Set the window title using the parameter passed
            inputBox.Text = title;

            //Create a new label to hold the prompt
            Label label = new Label();
            label.Text = prompt;
            label.Location = new Point(5, 5);
            label.Width = size.Width - 10;
            inputBox.Controls.Add(label);

            //Create a textbox to accept the user's input
            TextBox textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, label.Location.Y + 20);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            //Create an OK Button 
            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, size.Height - 30);
            inputBox.Controls.Add(okButton);

            //Create a Cancel Button
            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, size.Height - 30);
            inputBox.Controls.Add(cancelButton);

            //Set the input box's buttons to the created OK and Cancel Buttons respectively so the window appropriately behaves with the button clicks
            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            //Show the window dialog box 
            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;

            //After input has been submitted, return the input value
            return result;
        }

        //END
    }
}
