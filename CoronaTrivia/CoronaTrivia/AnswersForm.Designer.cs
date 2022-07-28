namespace CoronaTrivia
{
    partial class AnswersForm
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
            this.lblReQuestion = new System.Windows.Forms.Label();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.lblHeadQ = new System.Windows.Forms.Label();
            this.lblHeadA = new System.Windows.Forms.Label();
            this.btnNextQ = new System.Windows.Forms.Button();
            this.btnBackQ = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnBackto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReQuestion
            // 
            this.lblReQuestion.AutoSize = true;
            this.lblReQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblReQuestion.Location = new System.Drawing.Point(62, 182);
            this.lblReQuestion.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblReQuestion.Name = "lblReQuestion";
            this.lblReQuestion.Size = new System.Drawing.Size(91, 25);
            this.lblReQuestion.TabIndex = 0;
            this.lblReQuestion.Text = "Question";
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeadline.Location = new System.Drawing.Point(29, 49);
            this.lblHeadline.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(647, 62);
            this.lblHeadline.TabIndex = 1;
            this.lblHeadline.Text = "See the correct answers for the questions you had a mistake in below:";
            // 
            // lblHeadQ
            // 
            this.lblHeadQ.AutoSize = true;
            this.lblHeadQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeadQ.Location = new System.Drawing.Point(30, 126);
            this.lblHeadQ.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblHeadQ.Name = "lblHeadQ";
            this.lblHeadQ.Size = new System.Drawing.Size(209, 29);
            this.lblHeadQ.TabIndex = 2;
            this.lblHeadQ.Text = "The question was:";
            // 
            // lblHeadA
            // 
            this.lblHeadA.AutoSize = true;
            this.lblHeadA.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeadA.Location = new System.Drawing.Point(30, 287);
            this.lblHeadA.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblHeadA.Name = "lblHeadA";
            this.lblHeadA.Size = new System.Drawing.Size(223, 29);
            this.lblHeadA.TabIndex = 3;
            this.lblHeadA.Text = "The right answer is:";
            // 
            // btnNextQ
            // 
            this.btnNextQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNextQ.Location = new System.Drawing.Point(499, 355);
            this.btnNextQ.Name = "btnNextQ";
            this.btnNextQ.Size = new System.Drawing.Size(107, 51);
            this.btnNextQ.TabIndex = 5;
            this.btnNextQ.Text = "Next ";
            this.btnNextQ.UseVisualStyleBackColor = true;
            this.btnNextQ.Click += new System.EventHandler(this.btnNextQ_Click);
            // 
            // btnBackQ
            // 
            this.btnBackQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBackQ.Location = new System.Drawing.Point(197, 355);
            this.btnBackQ.Name = "btnBackQ";
            this.btnBackQ.Size = new System.Drawing.Size(107, 51);
            this.btnBackQ.TabIndex = 6;
            this.btnBackQ.Text = "Back";
            this.btnBackQ.UseVisualStyleBackColor = true;
            this.btnBackQ.Click += new System.EventHandler(this.btnBackQ_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAnswer.Location = new System.Drawing.Point(248, 291);
            this.lblAnswer.MaximumSize = new System.Drawing.Size(700, 700);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(78, 25);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Answer";
            // 
            // btnBackto
            // 
            this.btnBackto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBackto.Location = new System.Drawing.Point(21, 11);
            this.btnBackto.Name = "btnBackto";
            this.btnBackto.Size = new System.Drawing.Size(218, 35);
            this.btnBackto.TabIndex = 7;
            this.btnBackto.Text = "Back to the Previous Menu";
            this.btnBackto.UseVisualStyleBackColor = true;
            this.btnBackto.Click += new System.EventHandler(this.btnBackto_Click);
            // 
            // AnswersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackto);
            this.Controls.Add(this.btnBackQ);
            this.Controls.Add(this.btnNextQ);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblHeadA);
            this.Controls.Add(this.lblHeadQ);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.lblReQuestion);
            this.Name = "AnswersForm";
            this.Text = "AnswersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReQuestion;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label lblHeadQ;
        private System.Windows.Forms.Label lblHeadA;
        private System.Windows.Forms.Button btnNextQ;
        private System.Windows.Forms.Button btnBackQ;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnBackto;
    }
}