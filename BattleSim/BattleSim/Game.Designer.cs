namespace BattleSim
{
    partial class Game
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
            this.player1text = new System.Windows.Forms.TextBox();
            this.player2text = new System.Windows.Forms.TextBox();
            this.player1Box = new System.Windows.Forms.GroupBox();
            this.player2Box = new System.Windows.Forms.GroupBox();
            this.player1CharacterName = new System.Windows.Forms.TextBox();
            this.Player2CharacterName = new System.Windows.Forms.TextBox();
            this.player1Box.SuspendLayout();
            this.player2Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1text
            // 
            this.player1text.Location = new System.Drawing.Point(45, 362);
            this.player1text.Name = "player1text";
            this.player1text.Size = new System.Drawing.Size(306, 22);
            this.player1text.TabIndex = 0;
            // 
            // player2text
            // 
            this.player2text.Location = new System.Drawing.Point(417, 362);
            this.player2text.Name = "player2text";
            this.player2text.Size = new System.Drawing.Size(306, 22);
            this.player2text.TabIndex = 1;
            // 
            // player1Box
            // 
            this.player1Box.Controls.Add(this.player1CharacterName);
            this.player1Box.Location = new System.Drawing.Point(12, 12);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(344, 323);
            this.player1Box.TabIndex = 2;
            this.player1Box.TabStop = false;
            this.player1Box.Text = "Player 1";
            // 
            // player2Box
            // 
            this.player2Box.Controls.Add(this.Player2CharacterName);
            this.player2Box.Location = new System.Drawing.Point(444, 12);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(344, 330);
            this.player2Box.TabIndex = 3;
            this.player2Box.TabStop = false;
            this.player2Box.Text = "Player 2";
            // 
            // player1CharacterName
            // 
            this.player1CharacterName.Location = new System.Drawing.Point(98, 21);
            this.player1CharacterName.Name = "player1CharacterName";
            this.player1CharacterName.Size = new System.Drawing.Size(147, 22);
            this.player1CharacterName.TabIndex = 0;
            // 
            // Player2CharacterName
            // 
            this.Player2CharacterName.Location = new System.Drawing.Point(110, 21);
            this.Player2CharacterName.Name = "Player2CharacterName";
            this.Player2CharacterName.Size = new System.Drawing.Size(147, 22);
            this.Player2CharacterName.TabIndex = 1;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player2Box);
            this.Controls.Add(this.player1Box);
            this.Controls.Add(this.player2text);
            this.Controls.Add(this.player1text);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.player1Box.ResumeLayout(false);
            this.player1Box.PerformLayout();
            this.player2Box.ResumeLayout(false);
            this.player2Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox player1text;
        private System.Windows.Forms.TextBox player2text;
        private System.Windows.Forms.GroupBox player1Box;
        private System.Windows.Forms.TextBox player1CharacterName;
        private System.Windows.Forms.GroupBox player2Box;
        private System.Windows.Forms.TextBox Player2CharacterName;
    }
}