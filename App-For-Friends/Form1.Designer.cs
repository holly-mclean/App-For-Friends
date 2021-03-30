namespace App_For_Friends
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RollDiceTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.d4button = new System.Windows.Forms.Button();
            this.d6button = new System.Windows.Forms.Button();
            this.d8button = new System.Windows.Forms.Button();
            this.d10button = new System.Windows.Forms.Button();
            this.d12button = new System.Windows.Forms.Button();
            this.d20button = new System.Windows.Forms.Button();
            this.dPercentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.d4display = new System.Windows.Forms.Label();
            this.d6display = new System.Windows.Forms.Label();
            this.d8display = new System.Windows.Forms.Label();
            this.d10display = new System.Windows.Forms.Label();
            this.d12display = new System.Windows.Forms.Label();
            this.d20display = new System.Windows.Forms.Label();
            this.dPercentDisplay = new System.Windows.Forms.Label();
            this.allRollsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.totalDisplay = new System.Windows.Forms.Label();
            this.sumDisplay = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.CharGenTab = new System.Windows.Forms.TabPage();
            this.MysteryTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.characterButton = new System.Windows.Forms.Button();
            this.characterDisplay = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.RollDiceTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.CharGenTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RollDiceTab);
            this.tabControl1.Controls.Add(this.CharGenTab);
            this.tabControl1.Controls.Add(this.MysteryTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // RollDiceTab
            // 
            this.RollDiceTab.Controls.Add(this.tableLayoutPanel1);
            this.RollDiceTab.Location = new System.Drawing.Point(4, 22);
            this.RollDiceTab.Name = "RollDiceTab";
            this.RollDiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.RollDiceTab.Size = new System.Drawing.Size(792, 424);
            this.RollDiceTab.TabIndex = 0;
            this.RollDiceTab.Text = "Roll Dice";
            this.RollDiceTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.allRollsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.28823F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.38995F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69322F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.11217F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.51642F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.d4button);
            this.flowLayoutPanel1.Controls.Add(this.d6button);
            this.flowLayoutPanel1.Controls.Add(this.d8button);
            this.flowLayoutPanel1.Controls.Add(this.d10button);
            this.flowLayoutPanel1.Controls.Add(this.d12button);
            this.flowLayoutPanel1.Controls.Add(this.d20button);
            this.flowLayoutPanel1.Controls.Add(this.dPercentButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(109, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 79);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // d4button
            // 
            this.d4button.BackColor = System.Drawing.Color.Transparent;
            this.d4button.Location = new System.Drawing.Point(3, 3);
            this.d4button.Name = "d4button";
            this.d4button.Size = new System.Drawing.Size(75, 23);
            this.d4button.TabIndex = 0;
            this.d4button.Text = "d4";
            this.d4button.UseVisualStyleBackColor = false;
            this.d4button.Click += new System.EventHandler(this.d4button_Click);
            // 
            // d6button
            // 
            this.d6button.Location = new System.Drawing.Point(84, 3);
            this.d6button.Name = "d6button";
            this.d6button.Size = new System.Drawing.Size(75, 23);
            this.d6button.TabIndex = 1;
            this.d6button.Text = "d6";
            this.d6button.UseVisualStyleBackColor = true;
            this.d6button.Click += new System.EventHandler(this.d6button_Click);
            // 
            // d8button
            // 
            this.d8button.Location = new System.Drawing.Point(165, 3);
            this.d8button.Name = "d8button";
            this.d8button.Size = new System.Drawing.Size(75, 23);
            this.d8button.TabIndex = 2;
            this.d8button.Text = "d8";
            this.d8button.UseVisualStyleBackColor = true;
            this.d8button.Click += new System.EventHandler(this.d8button_Click);
            // 
            // d10button
            // 
            this.d10button.Location = new System.Drawing.Point(246, 3);
            this.d10button.Name = "d10button";
            this.d10button.Size = new System.Drawing.Size(75, 23);
            this.d10button.TabIndex = 3;
            this.d10button.Text = "d10";
            this.d10button.UseVisualStyleBackColor = true;
            this.d10button.Click += new System.EventHandler(this.d10button_Click);
            // 
            // d12button
            // 
            this.d12button.Location = new System.Drawing.Point(327, 3);
            this.d12button.Name = "d12button";
            this.d12button.Size = new System.Drawing.Size(75, 23);
            this.d12button.TabIndex = 4;
            this.d12button.Text = "d12";
            this.d12button.UseVisualStyleBackColor = true;
            this.d12button.Click += new System.EventHandler(this.d12button_Click);
            // 
            // d20button
            // 
            this.d20button.Location = new System.Drawing.Point(408, 3);
            this.d20button.Name = "d20button";
            this.d20button.Size = new System.Drawing.Size(75, 23);
            this.d20button.TabIndex = 5;
            this.d20button.Text = "d20";
            this.d20button.UseVisualStyleBackColor = true;
            this.d20button.Click += new System.EventHandler(this.d20button_Click);
            // 
            // dPercentButton
            // 
            this.dPercentButton.Location = new System.Drawing.Point(489, 3);
            this.dPercentButton.Name = "dPercentButton";
            this.dPercentButton.Size = new System.Drawing.Size(75, 23);
            this.dPercentButton.TabIndex = 6;
            this.dPercentButton.Text = "d%";
            this.dPercentButton.UseVisualStyleBackColor = true;
            this.dPercentButton.Click += new System.EventHandler(this.dPercentButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll some die!";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.d4display);
            this.flowLayoutPanel2.Controls.Add(this.d6display);
            this.flowLayoutPanel2.Controls.Add(this.d8display);
            this.flowLayoutPanel2.Controls.Add(this.d10display);
            this.flowLayoutPanel2.Controls.Add(this.d12display);
            this.flowLayoutPanel2.Controls.Add(this.d20display);
            this.flowLayoutPanel2.Controls.Add(this.dPercentDisplay);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(113, 139);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(559, 42);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // d4display
            // 
            this.d4display.AutoSize = true;
            this.d4display.Location = new System.Drawing.Point(3, 0);
            this.d4display.Name = "d4display";
            this.d4display.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.d4display.Size = new System.Drawing.Size(71, 23);
            this.d4display.TabIndex = 0;
            this.d4display.Text = "__d4";
            // 
            // d6display
            // 
            this.d6display.AutoSize = true;
            this.d6display.Location = new System.Drawing.Point(80, 0);
            this.d6display.Name = "d6display";
            this.d6display.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.d6display.Size = new System.Drawing.Size(71, 23);
            this.d6display.TabIndex = 1;
            this.d6display.Text = "__d6";
            // 
            // d8display
            // 
            this.d8display.AutoSize = true;
            this.d8display.Location = new System.Drawing.Point(157, 0);
            this.d8display.Name = "d8display";
            this.d8display.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.d8display.Size = new System.Drawing.Size(71, 23);
            this.d8display.TabIndex = 2;
            this.d8display.Text = "__d8";
            // 
            // d10display
            // 
            this.d10display.AutoSize = true;
            this.d10display.Location = new System.Drawing.Point(234, 0);
            this.d10display.Name = "d10display";
            this.d10display.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.d10display.Size = new System.Drawing.Size(77, 23);
            this.d10display.TabIndex = 3;
            this.d10display.Text = "__d10";
            // 
            // d12display
            // 
            this.d12display.AutoSize = true;
            this.d12display.Location = new System.Drawing.Point(317, 0);
            this.d12display.Name = "d12display";
            this.d12display.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.d12display.Size = new System.Drawing.Size(77, 23);
            this.d12display.TabIndex = 4;
            this.d12display.Text = "__d12";
            // 
            // d20display
            // 
            this.d20display.AutoSize = true;
            this.d20display.Location = new System.Drawing.Point(400, 0);
            this.d20display.Name = "d20display";
            this.d20display.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.d20display.Size = new System.Drawing.Size(77, 23);
            this.d20display.TabIndex = 5;
            this.d20display.Text = "__d20";
            // 
            // dPercentDisplay
            // 
            this.dPercentDisplay.AutoSize = true;
            this.dPercentDisplay.Location = new System.Drawing.Point(483, 0);
            this.dPercentDisplay.Name = "dPercentDisplay";
            this.dPercentDisplay.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.dPercentDisplay.Size = new System.Drawing.Size(73, 23);
            this.dPercentDisplay.TabIndex = 6;
            this.dPercentDisplay.Text = "__d%";
            // 
            // allRollsLabel
            // 
            this.allRollsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allRollsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allRollsLabel.Location = new System.Drawing.Point(115, 184);
            this.allRollsLabel.Margin = new System.Windows.Forms.Padding(115, 0, 115, 0);
            this.allRollsLabel.Name = "allRollsLabel";
            this.allRollsLabel.Padding = new System.Windows.Forms.Padding(15);
            this.allRollsLabel.Size = new System.Drawing.Size(556, 117);
            this.allRollsLabel.TabIndex = 3;
            this.allRollsLabel.Text = "All rolls: ";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.totalDisplay);
            this.flowLayoutPanel3.Controls.Add(this.sumDisplay);
            this.flowLayoutPanel3.Controls.Add(this.clearButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(177, 304);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(431, 111);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // totalDisplay
            // 
            this.totalDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalDisplay.AutoSize = true;
            this.totalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDisplay.Location = new System.Drawing.Point(3, 15);
            this.totalDisplay.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.totalDisplay.Name = "totalDisplay";
            this.totalDisplay.Size = new System.Drawing.Size(107, 39);
            this.totalDisplay.TabIndex = 0;
            this.totalDisplay.Text = "Total: ";
            // 
            // sumDisplay
            // 
            this.sumDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sumDisplay.AutoSize = true;
            this.sumDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumDisplay.Location = new System.Drawing.Point(116, 15);
            this.sumDisplay.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.sumDisplay.Name = "sumDisplay";
            this.sumDisplay.Size = new System.Drawing.Size(44, 39);
            this.sumDisplay.TabIndex = 1;
            this.sumDisplay.Text = " 0";
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(313, 10);
            this.clearButton.Margin = new System.Windows.Forms.Padding(150, 10, 3, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 41);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // CharGenTab
            // 
            this.CharGenTab.Controls.Add(this.tableLayoutPanel2);
            this.CharGenTab.Location = new System.Drawing.Point(4, 22);
            this.CharGenTab.Name = "CharGenTab";
            this.CharGenTab.Padding = new System.Windows.Forms.Padding(3);
            this.CharGenTab.Size = new System.Drawing.Size(792, 424);
            this.CharGenTab.TabIndex = 1;
            this.CharGenTab.Text = "Character Idea Generator";
            this.CharGenTab.UseVisualStyleBackColor = true;
            // 
            // MysteryTab
            // 
            this.MysteryTab.Location = new System.Drawing.Point(4, 22);
            this.MysteryTab.Name = "MysteryTab";
            this.MysteryTab.Size = new System.Drawing.Size(792, 424);
            this.MysteryTab.TabIndex = 2;
            this.MysteryTab.Text = "Mystery Message";
            this.MysteryTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.characterButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.characterDisplay, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // characterButton
            // 
            this.characterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.characterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterButton.Location = new System.Drawing.Point(245, 27);
            this.characterButton.Name = "characterButton";
            this.characterButton.Size = new System.Drawing.Size(296, 85);
            this.characterButton.TabIndex = 0;
            this.characterButton.Text = "Give me a character idea!";
            this.characterButton.UseVisualStyleBackColor = true;
            this.characterButton.Click += new System.EventHandler(this.characterButton_Click);
            // 
            // characterDisplay
            // 
            this.characterDisplay.AutoSize = true;
            this.characterDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterDisplay.Location = new System.Drawing.Point(3, 139);
            this.characterDisplay.Name = "characterDisplay";
            this.characterDisplay.Size = new System.Drawing.Size(780, 279);
            this.characterDisplay.TabIndex = 1;
            this.characterDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "An App for D&D Friends";
            this.tabControl1.ResumeLayout(false);
            this.RollDiceTab.ResumeLayout(false);
            this.RollDiceTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.CharGenTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RollDiceTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button d4button;
        private System.Windows.Forms.Button d6button;
        private System.Windows.Forms.Button d8button;
        private System.Windows.Forms.Button d10button;
        private System.Windows.Forms.Button d12button;
        private System.Windows.Forms.Button d20button;
        private System.Windows.Forms.Button dPercentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage CharGenTab;
        private System.Windows.Forms.TabPage MysteryTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label d4display;
        private System.Windows.Forms.Label d6display;
        private System.Windows.Forms.Label d8display;
        private System.Windows.Forms.Label d10display;
        private System.Windows.Forms.Label d12display;
        private System.Windows.Forms.Label d20display;
        private System.Windows.Forms.Label dPercentDisplay;
        private System.Windows.Forms.Label allRollsLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label totalDisplay;
        private System.Windows.Forms.Label sumDisplay;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button characterButton;
        private System.Windows.Forms.Label characterDisplay;
    }
}

