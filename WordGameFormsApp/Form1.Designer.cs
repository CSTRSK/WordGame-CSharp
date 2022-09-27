namespace WordGameFormsApp
{
    partial class Form1
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
            this.start_game_button = new System.Windows.Forms.Button();
            this.leaderboard_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_game_button
            // 
            this.start_game_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_game_button.Location = new System.Drawing.Point(315, 203);
            this.start_game_button.Name = "start_game_button";
            this.start_game_button.Size = new System.Drawing.Size(154, 23);
            this.start_game_button.TabIndex = 0;
            this.start_game_button.Text = "Start Game";
            this.start_game_button.UseVisualStyleBackColor = true;
            this.start_game_button.Click += new System.EventHandler(this.start_game_button_Click);
            // 
            // leaderboard_button
            // 
            this.leaderboard_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leaderboard_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderboard_button.Location = new System.Drawing.Point(315, 232);
            this.leaderboard_button.Name = "leaderboard_button";
            this.leaderboard_button.Size = new System.Drawing.Size(154, 23);
            this.leaderboard_button.TabIndex = 1;
            this.leaderboard_button.Text = "Leaderboard";
            this.leaderboard_button.UseVisualStyleBackColor = true;
            this.leaderboard_button.Click += new System.EventHandler(this.leaderboard_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(315, 261);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(154, 23);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "&Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "WordGame";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.leaderboard_button);
            this.Controls.Add(this.start_game_button);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button start_game_button;
        private Button leaderboard_button;
        private Button exit_button;
        private Label label1;
    }
}