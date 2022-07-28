namespace CoronaTrivia
{
    partial class MultiC
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
            this.lblPlease = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong2 = new System.Windows.Forms.Label();
            this.lblWrong1 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtCAnswer = new System.Windows.Forms.TextBox();
            this.txtInc2 = new System.Windows.Forms.TextBox();
            this.txtInc1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlease
            // 
            this.lblPlease.AutoSize = true;
            this.lblPlease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlease.Location = new System.Drawing.Point(27, 33);
            this.lblPlease.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblPlease.Name = "lblPlease";
            this.lblPlease.Size = new System.Drawing.Size(235, 24);
            this.lblPlease.TabIndex = 0;
            this.lblPlease.Text = "Enter your question below:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCorrect.Location = new System.Drawing.Point(361, 33);
            this.lblCorrect.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(296, 24);
            this.lblCorrect.TabIndex = 1;
            this.lblCorrect.Text = "Enter your correct answser below:";
            // 
            // lblWrong2
            // 
            this.lblWrong2.AutoSize = true;
            this.lblWrong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWrong2.Location = new System.Drawing.Point(361, 223);
            this.lblWrong2.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblWrong2.Name = "lblWrong2";
            this.lblWrong2.Size = new System.Drawing.Size(248, 48);
            this.lblWrong2.TabIndex = 2;
            this.lblWrong2.Text = "Enter your second incorrect answer below:";
            // 
            // lblWrong1
            // 
            this.lblWrong1.AutoSize = true;
            this.lblWrong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWrong1.Location = new System.Drawing.Point(28, 223);
            this.lblWrong1.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblWrong1.Name = "lblWrong1";
            this.lblWrong1.Size = new System.Drawing.Size(278, 48);
            this.lblWrong1.TabIndex = 3;
            this.lblWrong1.Text = "Enter your first incorrect answer below:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtQuestion.Location = new System.Drawing.Point(32, 75);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(213, 121);
            this.txtQuestion.TabIndex = 4;
            // 
            // txtCAnswer
            // 
            this.txtCAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCAnswer.Location = new System.Drawing.Point(366, 75);
            this.txtCAnswer.Multiline = true;
            this.txtCAnswer.Name = "txtCAnswer";
            this.txtCAnswer.Size = new System.Drawing.Size(213, 121);
            this.txtCAnswer.TabIndex = 5;
            // 
            // txtInc2
            // 
            this.txtInc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtInc2.Location = new System.Drawing.Point(365, 283);
            this.txtInc2.Multiline = true;
            this.txtInc2.Name = "txtInc2";
            this.txtInc2.Size = new System.Drawing.Size(223, 121);
            this.txtInc2.TabIndex = 6;
            // 
            // txtInc1
            // 
            this.txtInc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtInc1.Location = new System.Drawing.Point(32, 283);
            this.txtInc1.Multiline = true;
            this.txtInc1.Name = "txtInc1";
            this.txtInc1.Size = new System.Drawing.Size(213, 121);
            this.txtInc1.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(642, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 76);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.Location = new System.Drawing.Point(642, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 76);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MultiC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInc1);
            this.Controls.Add(this.txtInc2);
            this.Controls.Add(this.txtCAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblWrong1);
            this.Controls.Add(this.lblWrong2);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblPlease);
            this.Name = "MultiC";
            this.Text = "MultiC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlease;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong2;
        private System.Windows.Forms.Label lblWrong1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtCAnswer;
        private System.Windows.Forms.TextBox txtInc2;
        private System.Windows.Forms.TextBox txtInc1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}