namespace CoronaTrivia
{
    partial class Gaming
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbn1 = new System.Windows.Forms.RadioButton();
            this.rbn2 = new System.Windows.Forms.RadioButton();
            this.rbn3 = new System.Windows.Forms.RadioButton();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblQuestion.Location = new System.Drawing.Point(48, 88);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(99, 26);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(171, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // rbn1
            // 
            this.rbn1.AutoSize = true;
            this.rbn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbn1.Location = new System.Drawing.Point(66, 175);
            this.rbn1.Name = "rbn1";
            this.rbn1.Size = new System.Drawing.Size(99, 28);
            this.rbn1.TabIndex = 3;
            this.rbn1.Text = "Option 1";
            this.rbn1.UseVisualStyleBackColor = true;
            // 
            // rbn2
            // 
            this.rbn2.AutoSize = true;
            this.rbn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbn2.Location = new System.Drawing.Point(66, 230);
            this.rbn2.Name = "rbn2";
            this.rbn2.Size = new System.Drawing.Size(99, 28);
            this.rbn2.TabIndex = 4;
            this.rbn2.TabStop = true;
            this.rbn2.Text = "Option 2";
            this.rbn2.UseVisualStyleBackColor = true;
            // 
            // rbn3
            // 
            this.rbn3.AutoSize = true;
            this.rbn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbn3.Location = new System.Drawing.Point(66, 284);
            this.rbn3.Name = "rbn3";
            this.rbn3.Size = new System.Drawing.Size(99, 28);
            this.rbn3.TabIndex = 5;
            this.rbn3.TabStop = true;
            this.rbn3.Text = "Option 3";
            this.rbn3.UseVisualStyleBackColor = true;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAnswer.Location = new System.Drawing.Point(312, 348);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(169, 58);
            this.btnAnswer.TabIndex = 6;
            this.btnAnswer.Text = "Confirm";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblScore.Location = new System.Drawing.Point(557, 16);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(114, 23);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Your Score:";
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtScore.Location = new System.Drawing.Point(673, 14);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(60, 30);
            this.txtScore.TabIndex = 8;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMenu.Location = new System.Drawing.Point(12, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(171, 31);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Back to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Gaming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.rbn3);
            this.Controls.Add(this.rbn2);
            this.Controls.Add(this.rbn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Gaming";
            this.Text = "Gaming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbn1;
        private System.Windows.Forms.RadioButton rbn2;
        private System.Windows.Forms.RadioButton rbn3;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnMenu;
    }
}