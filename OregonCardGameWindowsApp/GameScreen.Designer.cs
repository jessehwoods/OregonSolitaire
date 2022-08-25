namespace OregonCardGameWindowsApp
{
    partial class GameScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deckBox = new System.Windows.Forms.PictureBox();
            this.drawnCardBox = new System.Windows.Forms.PictureBox();
            this.layoutIndex4 = new System.Windows.Forms.PictureBox();
            this.layoutIndex3 = new System.Windows.Forms.PictureBox();
            this.layoutIndex2 = new System.Windows.Forms.PictureBox();
            this.layoutIndex1 = new System.Windows.Forms.PictureBox();
            this.layoutIndex0 = new System.Windows.Forms.PictureBox();
            this.labelLayoutScore = new System.Windows.Forms.Label();
            this.labelTotalScore = new System.Windows.Forms.Label();
            this.buttonStartNewLayout = new System.Windows.Forms.Button();
            this.cardsInDeck = new System.Windows.Forms.Label();
            this.buttonToStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawnCardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIndex4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIndex3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIndex2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIndex1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIndex0)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.deckBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.drawnCardBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.layoutIndex4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.layoutIndex3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.layoutIndex2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.layoutIndex1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.layoutIndex0, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(146, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // deckBox
            // 
            this.deckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deckBox.Location = new System.Drawing.Point(3, 103);
            this.deckBox.Name = "deckBox";
            this.deckBox.Size = new System.Drawing.Size(94, 94);
            this.deckBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deckBox.TabIndex = 7;
            this.deckBox.TabStop = false;
            // 
            // drawnCardBox
            // 
            this.drawnCardBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawnCardBox.Location = new System.Drawing.Point(103, 103);
            this.drawnCardBox.Name = "drawnCardBox";
            this.drawnCardBox.Size = new System.Drawing.Size(94, 94);
            this.drawnCardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drawnCardBox.TabIndex = 6;
            this.drawnCardBox.TabStop = false;
            // 
            // layoutIndex4
            // 
            this.layoutIndex4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutIndex4.Location = new System.Drawing.Point(403, 3);
            this.layoutIndex4.Name = "layoutIndex4";
            this.layoutIndex4.Size = new System.Drawing.Size(94, 94);
            this.layoutIndex4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.layoutIndex4.TabIndex = 5;
            this.layoutIndex4.TabStop = false;
            this.layoutIndex4.Click += new System.EventHandler(this.layoutIndex4_Click);
            // 
            // layoutIndex3
            // 
            this.layoutIndex3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutIndex3.Location = new System.Drawing.Point(303, 3);
            this.layoutIndex3.Name = "layoutIndex3";
            this.layoutIndex3.Size = new System.Drawing.Size(94, 94);
            this.layoutIndex3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.layoutIndex3.TabIndex = 4;
            this.layoutIndex3.TabStop = false;
            this.layoutIndex3.Click += new System.EventHandler(this.layoutIndex3_Click);
            // 
            // layoutIndex2
            // 
            this.layoutIndex2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutIndex2.Location = new System.Drawing.Point(203, 3);
            this.layoutIndex2.Name = "layoutIndex2";
            this.layoutIndex2.Size = new System.Drawing.Size(94, 94);
            this.layoutIndex2.TabIndex = 3;
            this.layoutIndex2.TabStop = false;
            this.layoutIndex2.Click += new System.EventHandler(this.layoutIndex2_Click);
            // 
            // layoutIndex1
            // 
            this.layoutIndex1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutIndex1.Location = new System.Drawing.Point(103, 3);
            this.layoutIndex1.Name = "layoutIndex1";
            this.layoutIndex1.Size = new System.Drawing.Size(94, 94);
            this.layoutIndex1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.layoutIndex1.TabIndex = 2;
            this.layoutIndex1.TabStop = false;
            this.layoutIndex1.Click += new System.EventHandler(this.layoutIndex1_Click);
            // 
            // layoutIndex0
            // 
            this.layoutIndex0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutIndex0.Location = new System.Drawing.Point(3, 3);
            this.layoutIndex0.Name = "layoutIndex0";
            this.layoutIndex0.Size = new System.Drawing.Size(94, 94);
            this.layoutIndex0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.layoutIndex0.TabIndex = 1;
            this.layoutIndex0.TabStop = false;
            this.layoutIndex0.Click += new System.EventHandler(this.layoutIndex0_Click);
            // 
            // labelLayoutScore
            // 
            this.labelLayoutScore.AutoSize = true;
            this.labelLayoutScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLayoutScore.Location = new System.Drawing.Point(268, 251);
            this.labelLayoutScore.Name = "labelLayoutScore";
            this.labelLayoutScore.Size = new System.Drawing.Size(75, 15);
            this.labelLayoutScore.TabIndex = 1;
            this.labelLayoutScore.Text = "Layout Score";
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.AutoSize = true;
            this.labelTotalScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotalScore.Location = new System.Drawing.Point(268, 266);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(64, 15);
            this.labelTotalScore.TabIndex = 2;
            this.labelTotalScore.Text = "Total Score";
            // 
            // buttonStartNewLayout
            // 
            this.buttonStartNewLayout.AutoSize = true;
            this.buttonStartNewLayout.Location = new System.Drawing.Point(149, 251);
            this.buttonStartNewLayout.Name = "buttonStartNewLayout";
            this.buttonStartNewLayout.Size = new System.Drawing.Size(107, 25);
            this.buttonStartNewLayout.TabIndex = 3;
            this.buttonStartNewLayout.Text = "Start New Layout";
            this.buttonStartNewLayout.UseVisualStyleBackColor = true;
            this.buttonStartNewLayout.Click += new System.EventHandler(this.buttonStartNewLayout_Click);
            // 
            // cardsInDeck
            // 
            this.cardsInDeck.AutoSize = true;
            this.cardsInDeck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cardsInDeck.Location = new System.Drawing.Point(268, 281);
            this.cardsInDeck.Name = "cardsInDeck";
            this.cardsInDeck.Size = new System.Drawing.Size(79, 15);
            this.cardsInDeck.TabIndex = 4;
            this.cardsInDeck.Text = "Cards in Deck";
            // 
            // buttonToStart
            // 
            this.buttonToStart.AutoSize = true;
            this.buttonToStart.Location = new System.Drawing.Point(571, 253);
            this.buttonToStart.Name = "buttonToStart";
            this.buttonToStart.Size = new System.Drawing.Size(83, 25);
            this.buttonToStart.TabIndex = 5;
            this.buttonToStart.Text = "Back to Start";
            this.buttonToStart.UseVisualStyleBackColor = true;
            this.buttonToStart.Click += new System.EventHandler(this.buttonToStart_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.buttonToStart);
            this.Controls.Add(this.cardsInDeck);
            this.Controls.Add(this.buttonStartNewLayout);
            this.Controls.Add(this.labelTotalScore);
            this.Controls.Add(this.labelLayoutScore);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameScreen";
            this.Text = "Oregon Solitaire Game";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawnCardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIndex4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIndex3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIndex2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIndex1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIndex0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox drawnCardBox;
        private PictureBox layoutIndex4;
        private PictureBox layoutIndex3;
        private PictureBox layoutIndex2;
        private PictureBox layoutIndex1;
        private PictureBox layoutIndex0;
        private PictureBox deckBox;
        private Label labelLayoutScore;
        private Label labelTotalScore;
        private Button buttonStartNewLayout;
        private Label cardsInDeck;
        private Button buttonToStart;
    }
}