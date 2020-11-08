namespace BattleSim
{
    partial class CharacterSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player1GroupBox = new System.Windows.Forms.GroupBox();
            this.player2GroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.player1CharacterChoose = new System.Windows.Forms.ComboBox();
            this.player2CharacterChoose = new System.Windows.Forms.ComboBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.player1GroupBox.SuspendLayout();
            this.player2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1GroupBox
            // 
            this.player1GroupBox.Controls.Add(this.player1CharacterChoose);
            this.player1GroupBox.Location = new System.Drawing.Point(12, 12);
            this.player1GroupBox.Name = "player1GroupBox";
            this.player1GroupBox.Size = new System.Drawing.Size(371, 325);
            this.player1GroupBox.TabIndex = 0;
            this.player1GroupBox.TabStop = false;
            this.player1GroupBox.Text = "Player 1";
            // 
            // player2GroupBox
            // 
            this.player2GroupBox.Controls.Add(this.player2CharacterChoose);
            this.player2GroupBox.Location = new System.Drawing.Point(417, 12);
            this.player2GroupBox.Name = "player2GroupBox";
            this.player2GroupBox.Size = new System.Drawing.Size(371, 325);
            this.player2GroupBox.TabIndex = 1;
            this.player2GroupBox.TabStop = false;
            this.player2GroupBox.Text = "Player 2";
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // backgroundWorker6
            // 
            this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker6_DoWork);
            // 
            // player1CharacterChoose
            // 
            this.player1CharacterChoose.FormattingEnabled = true;
            this.player1CharacterChoose.Items.AddRange(new object[] {
            "Knight",
            "Wizard"});
            this.player1CharacterChoose.Location = new System.Drawing.Point(6, 61);
            this.player1CharacterChoose.Name = "player1CharacterChoose";
            this.player1CharacterChoose.Size = new System.Drawing.Size(274, 24);
            this.player1CharacterChoose.TabIndex = 0;
            // 
            // player2CharacterChoose
            // 
            this.player2CharacterChoose.FormattingEnabled = true;
            this.player2CharacterChoose.Items.AddRange(new object[] {
            "Knight",
            "Wizard"});
            this.player2CharacterChoose.Location = new System.Drawing.Point(6, 61);
            this.player2CharacterChoose.Name = "player2CharacterChoose";
            this.player2CharacterChoose.Size = new System.Drawing.Size(274, 24);
            this.player2CharacterChoose.TabIndex = 1;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(259, 343);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(288, 79);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // CharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.player2GroupBox);
            this.Controls.Add(this.player1GroupBox);
            this.Name = "CharacterSelect";
            this.Text = "Character Select";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.player1GroupBox.ResumeLayout(false);
            this.player2GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox player1GroupBox;
        private System.Windows.Forms.ComboBox player1CharacterChoose;
        private System.Windows.Forms.GroupBox player2GroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.Windows.Forms.ComboBox player2CharacterChoose;
        private System.Windows.Forms.Button startGameButton;
    }
}

