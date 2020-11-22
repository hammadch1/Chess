namespace Chess
{
    partial class Chess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chess));
            this.ChessPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.STARTpanel = new System.Windows.Forms.Panel();
            this.Conditions = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BlackPieces = new System.Windows.Forms.RadioButton();
            this.WhitePieces = new System.Windows.Forms.RadioButton();
            this.START = new System.Windows.Forms.Button();
            this.PlayerTurnBox = new System.Windows.Forms.TextBox();
            this.ChessPanel.SuspendLayout();
            this.STARTpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChessPanel
            // 
            this.ChessPanel.BackColor = System.Drawing.Color.White;
            this.ChessPanel.Controls.Add(this.STARTpanel);
            this.ChessPanel.Controls.Add(this.PlayerTurnBox);
            this.ChessPanel.Controls.Add(this.Conditions);
            this.ChessPanel.Location = new System.Drawing.Point(0, 0);
            this.ChessPanel.Name = "ChessPanel";
            this.ChessPanel.Size = new System.Drawing.Size(827, 728);
            this.ChessPanel.TabIndex = 0;
            // 
            // STARTpanel
            // 
            this.STARTpanel.Controls.Add(this.panel1);
            this.STARTpanel.Controls.Add(this.START);
            this.STARTpanel.Location = new System.Drawing.Point(3, 3);
            this.STARTpanel.Name = "STARTpanel";
            this.STARTpanel.Size = new System.Drawing.Size(356, 44);
            this.STARTpanel.TabIndex = 0;
            // 
            // Conditions
            // 
            this.Conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conditions.Location = new System.Drawing.Point(617, 3);
            this.Conditions.Name = "Conditions";
            this.Conditions.Size = new System.Drawing.Size(131, 35);
            this.Conditions.TabIndex = 4;
            this.Conditions.TextChanged += new System.EventHandler(this.Conditions_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BlackPieces);
            this.panel1.Controls.Add(this.WhitePieces);
            this.panel1.Location = new System.Drawing.Point(164, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 41);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BlackPieces
            // 
            this.BlackPieces.AutoSize = true;
            this.BlackPieces.Location = new System.Drawing.Point(103, 14);
            this.BlackPieces.Name = "BlackPieces";
            this.BlackPieces.Size = new System.Drawing.Size(87, 17);
            this.BlackPieces.TabIndex = 2;
            this.BlackPieces.Text = "Black Pieces";
            this.BlackPieces.UseVisualStyleBackColor = true;
            this.BlackPieces.CheckedChanged += new System.EventHandler(this.BlackPieces_CheckedChanged);
            // 
            // WhitePieces
            // 
            this.WhitePieces.AutoSize = true;
            this.WhitePieces.Location = new System.Drawing.Point(3, 14);
            this.WhitePieces.Name = "WhitePieces";
            this.WhitePieces.Size = new System.Drawing.Size(88, 17);
            this.WhitePieces.TabIndex = 1;
            this.WhitePieces.Text = "White Pieces";
            this.WhitePieces.UseVisualStyleBackColor = true;
            this.WhitePieces.CheckedChanged += new System.EventHandler(this.WhitePieces_CheckedChanged);
            // 
            // START
            // 
            this.START.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.START.Location = new System.Drawing.Point(3, 0);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(141, 41);
            this.START.TabIndex = 1;
            this.START.Text = "Start";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click_1);
            // 
            // PlayerTurnBox
            // 
            this.PlayerTurnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTurnBox.Location = new System.Drawing.Point(365, 3);
            this.PlayerTurnBox.Name = "PlayerTurnBox";
            this.PlayerTurnBox.Size = new System.Drawing.Size(246, 35);
            this.PlayerTurnBox.TabIndex = 3;
            this.PlayerTurnBox.TextChanged += new System.EventHandler(this.PlayerTurnBox_TextChanged);
            // 
            // Chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(824, 712);
            this.Controls.Add(this.ChessPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chess";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Chess_Load);
            this.ChessPanel.ResumeLayout(false);
            this.ChessPanel.PerformLayout();
            this.STARTpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ChessPanel;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Panel STARTpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton BlackPieces;
        private System.Windows.Forms.RadioButton WhitePieces;
        private System.Windows.Forms.TextBox PlayerTurnBox;
        private System.Windows.Forms.TextBox Conditions;


    }
}

