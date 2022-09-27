namespace WordGameFormsApp
{
    partial class leaderboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.new_game_button = new System.Windows.Forms.Button();
            this.main_menu_button = new System.Windows.Forms.Button();
            this.leaderboard_view = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "WordGame - Leaderboard";
            // 
            // new_game_button
            // 
            this.new_game_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_game_button.Location = new System.Drawing.Point(319, 379);
            this.new_game_button.Name = "new_game_button";
            this.new_game_button.Size = new System.Drawing.Size(154, 32);
            this.new_game_button.TabIndex = 0;
            this.new_game_button.Text = "new game";
            this.new_game_button.UseVisualStyleBackColor = true;
            this.new_game_button.Click += new System.EventHandler(this.new_game_button_Click);
            // 
            // main_menu_button
            // 
            this.main_menu_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_menu_button.Location = new System.Drawing.Point(319, 417);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(154, 32);
            this.main_menu_button.TabIndex = 1;
            this.main_menu_button.Text = "main menu";
            this.main_menu_button.UseVisualStyleBackColor = true;
            this.main_menu_button.Click += new System.EventHandler(this.main_menu_button_Click);
            // 
            // leaderboard_view
            // 
            this.leaderboard_view.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.leaderboard_view.LabelEdit = true;
            this.leaderboard_view.Location = new System.Drawing.Point(124, 77);
            this.leaderboard_view.MultiSelect = false;
            this.leaderboard_view.Name = "leaderboard_view";
            this.leaderboard_view.Size = new System.Drawing.Size(545, 296);
            this.leaderboard_view.TabIndex = 4;
            this.leaderboard_view.UseCompatibleStateImageBehavior = false;
            // 
            // leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.leaderboard_view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_menu_button);
            this.Controls.Add(this.new_game_button);
            this.MaximizeBox = false;
            this.Name = "leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordGame - Leaderboard";
            this.Load += new System.EventHandler(this.leaderboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button new_game_button;
        private Button main_menu_button;
        private ListView leaderboard_view;
    }
}