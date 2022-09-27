namespace WordGameFormsApp
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start_game_button = new System.Windows.Forms.Button();
            this.word_label = new System.Windows.Forms.Label();
            this.time_bar = new System.Windows.Forms.ProgressBar();
            this.time_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.user_input = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.life_label = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_game_button
            // 
            this.start_game_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_game_button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_game_button.Location = new System.Drawing.Point(266, 205);
            this.start_game_button.Name = "start_game_button";
            this.start_game_button.Size = new System.Drawing.Size(233, 57);
            this.start_game_button.TabIndex = 0;
            this.start_game_button.Text = "Start";
            this.start_game_button.UseVisualStyleBackColor = true;
            this.start_game_button.Click += new System.EventHandler(this.start_game_button_Click);
            // 
            // word_label
            // 
            this.word_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.word_label.AutoSize = true;
            this.word_label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.word_label.Location = new System.Drawing.Point(251, 74);
            this.word_label.Name = "word_label";
            this.word_label.Size = new System.Drawing.Size(267, 65);
            this.word_label.TabIndex = 3;
            this.word_label.Text = "WordGame";
            // 
            // time_bar
            // 
            this.time_bar.Location = new System.Drawing.Point(12, 426);
            this.time_bar.Name = "time_bar";
            this.time_bar.Size = new System.Drawing.Size(760, 23);
            this.time_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.time_bar.TabIndex = 4;
            this.time_bar.Value = 100;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(734, 408);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(36, 15);
            this.time_label.TabIndex = 5;
            this.time_label.Text = "Time:";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Location = new System.Drawing.Point(12, 408);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(39, 15);
            this.score_label.TabIndex = 6;
            this.score_label.Text = "Score:";
            // 
            // user_input
            // 
            this.user_input.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_input.Location = new System.Drawing.Point(266, 142);
            this.user_input.Name = "user_input";
            this.user_input.PlaceholderText = "Word";
            this.user_input.Size = new System.Drawing.Size(233, 57);
            this.user_input.TabIndex = 7;
            this.user_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_input_KeyPress);
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(118, 57);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // life_label
            // 
            this.life_label.AutoSize = true;
            this.life_label.Location = new System.Drawing.Point(364, 408);
            this.life_label.Name = "life_label";
            this.life_label.Size = new System.Drawing.Size(29, 15);
            this.life_label.TabIndex = 9;
            this.life_label.Text = "Life:";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(301, 265);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(156, 15);
            this.info_label.TabIndex = 10;
            this.info_label.Text = "Press start to play the Game.";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.life_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.user_input);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.time_bar);
            this.Controls.Add(this.word_label);
            this.Controls.Add(this.start_game_button);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordGame";
            this.Load += new System.EventHandler(this.Game_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button start_game_button;
        private Label word_label;
        private ProgressBar time_bar;
        private Label time_label;
        private Label score_label;
        private TextBox user_input;
        private Button back_button;
        private System.Windows.Forms.Timer timer1;
        private Label life_label;
        private Label info_label;

        }
    }