using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordGameFormsApp
{
    public partial class leaderboard : Form
    {
        public leaderboard()
        {
            InitializeComponent();
        }

        private void new_game_button_Click(object sender, EventArgs e)
        {
            Game game_form = new Game();
            game_form.Show();
            this.Hide();
        }

        private void main_menu_button_Click(object sender, EventArgs e)
        {

            Form1 main_menu_form = new Form1();
            main_menu_form.Show();
            this.Hide();
        }

        private async void leaderboard_Load(object sender, EventArgs e)
        {


            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (var fileStream = File.OpenText("highscores.xml"))
            using (XmlReader reader = XmlReader.Create(fileStream, settings))
            {
                while (reader.Read())
                {
                    var score = ""; var name = ""; var datetime = "";
                    int i = 0;
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.WriteLine($"Start Element: {reader.Name}. Has Attributes? : {reader.HasAttributes}");
                            break;
                        case XmlNodeType.Text:
                            if (i == 0)
                            {
                                score = reader.Value;
                                i++;
                            }
                            if (i == 1)
                            {
                                name = reader.Value;
                                i++;
                            }
                            if (i == 2)
                            {
                                datetime = reader.Value;
                                i = 0;
                                var item2 = new ListViewItem(new[] { "Score: " + score.ToString(), "Player: " + name.ToString(), "Datetime: " + datetime.ToString() });
                                leaderboard_view.Items.Add(item2);
                                score = ""; name = ""; datetime = "";
                            }
                            break;
                        case XmlNodeType.EndElement:
                            Console.WriteLine($"End Element: {reader.Name}");
                            break;
                        default:
                            Console.WriteLine($"Unknown: {reader.NodeType}");
                            break;
                    }
                }
            }
        }
        [Serializable()]
        public class HighScore
        {
            public int Score { get; set; }
            public string playerName { get; set; }
            public string dateTime { get; set; }
        }

        public List<HighScore> _highScores = new List<HighScore>();
        //END
    }
}
