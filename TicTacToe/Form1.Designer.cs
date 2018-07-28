namespace TicTacToe
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
            this.A00 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.XWins = new System.Windows.Forms.Label();
            this.OWins = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(22, 29);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(85, 78);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(113, 29);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(85, 78);
            this.A01.TabIndex = 1;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(204, 29);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(85, 78);
            this.A02.TabIndex = 2;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(22, 113);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(85, 78);
            this.A10.TabIndex = 3;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(113, 113);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(85, 78);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(204, 113);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(85, 78);
            this.A12.TabIndex = 5;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(22, 197);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(85, 78);
            this.A20.TabIndex = 6;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(113, 197);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(85, 78);
            this.A21.TabIndex = 7;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(204, 197);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(85, 78);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(22, 307);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(85, 40);
            this.NGButton.TabIndex = 9;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click);
            // 
            // RButton
            // 
            this.RButton.Location = new System.Drawing.Point(113, 307);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(85, 40);
            this.RButton.TabIndex = 10;
            this.RButton.Text = "Reset";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // EButton
            // 
            this.EButton.Location = new System.Drawing.Point(284, 307);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(85, 40);
            this.EButton.TabIndex = 11;
            this.EButton.Text = "Exit";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // XWins
            // 
            this.XWins.AutoSize = true;
            this.XWins.Location = new System.Drawing.Point(296, 54);
            this.XWins.Name = "XWins";
            this.XWins.Size = new System.Drawing.Size(35, 13);
            this.XWins.TabIndex = 12;
            this.XWins.Text = "label1";
            // 
            // OWins
            // 
            this.OWins.AutoSize = true;
            this.OWins.Location = new System.Drawing.Point(296, 147);
            this.OWins.Name = "OWins";
            this.OWins.Size = new System.Drawing.Size(35, 13);
            this.OWins.TabIndex = 13;
            this.OWins.Text = "label2";
            // 
            // Draws
            // 
            this.Draws.AutoSize = true;
            this.Draws.Location = new System.Drawing.Point(296, 228);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(35, 13);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 358);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.OWins);
            this.Controls.Add(this.XWins);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Label XWins;
        private System.Windows.Forms.Label OWins;
        private System.Windows.Forms.Label Draws;
    }
}

