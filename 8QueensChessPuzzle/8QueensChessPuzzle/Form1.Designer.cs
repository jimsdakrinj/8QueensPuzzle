using System;
using System.Windows.Forms;

namespace _8QueensChessPuzzle
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.instructionsPanel = new System.Windows.Forms.Panel();
            this.howToPlayPanel = new System.Windows.Forms.Panel();
            this.lblHowTo = new System.Windows.Forms.Label();
            this.didYouKnowPanel = new System.Windows.Forms.Panel();
            this.lblDidYouKnow = new System.Windows.Forms.Label();
            this.startingPositionPanel = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.nudStartRow = new System.Windows.Forms.NumericUpDown();
            this.nudStartCol = new System.Windows.Forms.NumericUpDown();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.btnAutoSolve = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.instructionsPanel.SuspendLayout();
            this.howToPlayPanel.SuspendLayout();
            this.didYouKnowPanel.SuspendLayout();
            this.startingPositionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartCol)).BeginInit();
            this.actionsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(304, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "8 QUEENS PROBLEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(101, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 461);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // instructionsPanel
            // 
            this.instructionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionsPanel.Controls.Add(this.howToPlayPanel);
            this.instructionsPanel.Controls.Add(this.didYouKnowPanel);
            this.instructionsPanel.Controls.Add(this.startingPositionPanel);
            this.instructionsPanel.Controls.Add(this.actionsPanel);
            this.instructionsPanel.Location = new System.Drawing.Point(15, 20);
            this.instructionsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instructionsPanel.Name = "instructionsPanel";
            this.instructionsPanel.Size = new System.Drawing.Size(200, 371);
            this.instructionsPanel.TabIndex = 2;
            // 
            // howToPlayPanel
            // 
            this.howToPlayPanel.Controls.Add(this.lblHowTo);
            this.howToPlayPanel.Location = new System.Drawing.Point(8, 6);
            this.howToPlayPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.howToPlayPanel.Name = "howToPlayPanel";
            this.howToPlayPanel.Size = new System.Drawing.Size(184, 112);
            this.howToPlayPanel.TabIndex = 0;
            // 
            // lblHowTo
            // 
            this.lblHowTo.Location = new System.Drawing.Point(4, 3);
            this.lblHowTo.Name = "lblHowTo";
            this.lblHowTo.Size = new System.Drawing.Size(176, 106);
            this.lblHowTo.TabIndex = 0;
            this.lblHowTo.Text = "How to Play\n1. Click a cell\n2. Press Q to place a queen\n3. Delete/Backspace to re" +
    "move\n4. Place all 8 queens with no conflicts\n5. Queens cannot share row, column," +
    " or diagonal";
            // 
            // didYouKnowPanel
            // 
            this.didYouKnowPanel.Controls.Add(this.lblDidYouKnow);
            this.didYouKnowPanel.Location = new System.Drawing.Point(8, 122);
            this.didYouKnowPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.didYouKnowPanel.Name = "didYouKnowPanel";
            this.didYouKnowPanel.Size = new System.Drawing.Size(184, 64);
            this.didYouKnowPanel.TabIndex = 1;
            // 
            // lblDidYouKnow
            // 
            this.lblDidYouKnow.Location = new System.Drawing.Point(4, 3);
            this.lblDidYouKnow.Name = "lblDidYouKnow";
            this.lblDidYouKnow.Size = new System.Drawing.Size(176, 58);
            this.lblDidYouKnow.TabIndex = 0;
            this.lblDidYouKnow.Text = "Did You Know?\nThere are exactly 92 distinct solutions to the 8 Queens problem!";
            // 
            // startingPositionPanel
            // 
            this.startingPositionPanel.Controls.Add(this.lblStart);
            this.startingPositionPanel.Controls.Add(this.nudStartRow);
            this.startingPositionPanel.Controls.Add(this.nudStartCol);
            this.startingPositionPanel.Location = new System.Drawing.Point(8, 192);
            this.startingPositionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startingPositionPanel.Name = "startingPositionPanel";
            this.startingPositionPanel.Size = new System.Drawing.Size(184, 64);
            this.startingPositionPanel.TabIndex = 2;
            // 
            // lblStart
            // 
            this.lblStart.Location = new System.Drawing.Point(4, 3);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(176, 16);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Starting Position (Optional)\nRow (1-8)  Column (1-8)";
            // 
            // nudStartRow
            // 
            this.nudStartRow.Location = new System.Drawing.Point(8, 22);
            this.nudStartRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudStartRow.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudStartRow.Name = "nudStartRow";
            this.nudStartRow.Size = new System.Drawing.Size(70, 22);
            this.nudStartRow.TabIndex = 1;
            // 
            // nudStartCol
            // 
            this.nudStartCol.Location = new System.Drawing.Point(96, 22);
            this.nudStartCol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudStartCol.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudStartCol.Name = "nudStartCol";
            this.nudStartCol.Size = new System.Drawing.Size(70, 22);
            this.nudStartCol.TabIndex = 2;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.btnAutoSolve);
            this.actionsPanel.Controls.Add(this.btnValidate);
            this.actionsPanel.Controls.Add(this.btnClear);
            this.actionsPanel.Controls.Add(this.btnRandom);
            this.actionsPanel.Location = new System.Drawing.Point(8, 262);
            this.actionsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(184, 96);
            this.actionsPanel.TabIndex = 3;
            // 
            // btnAutoSolve
            // 
            this.btnAutoSolve.Location = new System.Drawing.Point(8, 6);
            this.btnAutoSolve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutoSolve.Name = "btnAutoSolve";
            this.btnAutoSolve.Size = new System.Drawing.Size(168, 24);
            this.btnAutoSolve.TabIndex = 0;
            this.btnAutoSolve.Text = "🔍 Auto Solve";
            this.btnAutoSolve.UseVisualStyleBackColor = true;
            this.btnAutoSolve.Click += new System.EventHandler(this.btnAutoSolve_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(8, 35);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(168, 24);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "✓ Validate Placement";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 64);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 24);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "🗑️ Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(96, 64);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(80, 24);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "🎲 Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.instructionsPanel);
            this.panel2.Location = new System.Drawing.Point(866, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 422);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "8 Queens Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.instructionsPanel.ResumeLayout(false);
            this.howToPlayPanel.ResumeLayout(false);
            this.didYouKnowPanel.ResumeLayout(false);
            this.startingPositionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStartRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartCol)).EndInit();
            this.actionsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel instructionsPanel;
        private System.Windows.Forms.Panel howToPlayPanel;
        private System.Windows.Forms.Panel didYouKnowPanel;
        private System.Windows.Forms.Panel startingPositionPanel;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.NumericUpDown nudStartRow;
        private System.Windows.Forms.NumericUpDown nudStartCol;
        private System.Windows.Forms.Button btnAutoSolve;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblHowTo;
        private System.Windows.Forms.Label lblDidYouKnow;
        private System.Windows.Forms.Label lblStart;
        private Panel panel2;
    }
}

