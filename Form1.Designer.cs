namespace Testing2
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
            this.txtBXRand = new System.Windows.Forms.TextBox();
            this.txtBxAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBxS = new System.Windows.Forms.TextBox();
            this.txtBxPlayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBXRand
            // 
            this.txtBXRand.Location = new System.Drawing.Point(59, 55);
            this.txtBXRand.Name = "txtBXRand";
            this.txtBXRand.Size = new System.Drawing.Size(130, 20);
            this.txtBXRand.TabIndex = 0;
            // 
            // txtBxAnswer
            // 
            this.txtBxAnswer.Location = new System.Drawing.Point(604, 55);
            this.txtBxAnswer.Name = "txtBxAnswer";
            this.txtBxAnswer.Size = new System.Drawing.Size(130, 20);
            this.txtBxAnswer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBxS
            // 
            this.txtBxS.Location = new System.Drawing.Point(54, 303);
            this.txtBxS.Name = "txtBxS";
            this.txtBxS.Size = new System.Drawing.Size(125, 20);
            this.txtBxS.TabIndex = 3;
            // 
            // txtBxPlayer
            // 
            this.txtBxPlayer.Location = new System.Drawing.Point(604, 284);
            this.txtBxPlayer.Name = "txtBxPlayer";
            this.txtBxPlayer.Size = new System.Drawing.Size(125, 20);
            this.txtBxPlayer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tries :";
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTries.Location = new System.Drawing.Point(391, 13);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(32, 15);
            this.lblTries.TabIndex = 6;
            this.lblTries.Text = "Tries";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxPlayer);
            this.Controls.Add(this.txtBxS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBxAnswer);
            this.Controls.Add(this.txtBXRand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBXRand;
        private System.Windows.Forms.TextBox txtBxAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBxS;
        private System.Windows.Forms.TextBox txtBxPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTries;
    }
}

