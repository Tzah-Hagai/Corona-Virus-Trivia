namespace CoronaTrivia
{
    partial class TorFi
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblFalse = new System.Windows.Forms.Label();
            this.lblTrue = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnIncorrect = new System.Windows.Forms.Button();
            this.pcbTrue = new System.Windows.Forms.PictureBox();
            this.pcbFalse = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFalse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEnter.Location = new System.Drawing.Point(30, 70);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(298, 29);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter your question below:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtQuestion.Location = new System.Drawing.Point(29, 112);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(299, 167);
            this.txtQuestion.TabIndex = 1;
            // 
            // lblFalse
            // 
            this.lblFalse.AutoSize = true;
            this.lblFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFalse.Location = new System.Drawing.Point(432, 243);
            this.lblFalse.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(194, 52);
            this.lblFalse.TabIndex = 2;
            this.lblFalse.Text = "Add your incorrect answer image:";
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTrue.Location = new System.Drawing.Point(432, 66);
            this.lblTrue.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(177, 52);
            this.lblTrue.TabIndex = 3;
            this.lblTrue.Text = "Add your correct answer image:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSubmit.Location = new System.Drawing.Point(236, 343);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(183, 70);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCorrect.Location = new System.Drawing.Point(461, 140);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(88, 48);
            this.btnCorrect.TabIndex = 6;
            this.btnCorrect.Text = "Add";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnIncorrect
            // 
            this.btnIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnIncorrect.Location = new System.Drawing.Point(461, 319);
            this.btnIncorrect.Name = "btnIncorrect";
            this.btnIncorrect.Size = new System.Drawing.Size(88, 46);
            this.btnIncorrect.TabIndex = 7;
            this.btnIncorrect.Text = "Add";
            this.btnIncorrect.UseVisualStyleBackColor = true;
            this.btnIncorrect.Click += new System.EventHandler(this.btnIncorrect_Click);
            // 
            // pcbTrue
            // 
            this.pcbTrue.Location = new System.Drawing.Point(615, 100);
            this.pcbTrue.Name = "pcbTrue";
            this.pcbTrue.Size = new System.Drawing.Size(157, 105);
            this.pcbTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTrue.TabIndex = 8;
            this.pcbTrue.TabStop = false;
            // 
            // pcbFalse
            // 
            this.pcbFalse.Location = new System.Drawing.Point(615, 281);
            this.pcbFalse.Name = "pcbFalse";
            this.pcbFalse.Size = new System.Drawing.Size(157, 105);
            this.pcbFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFalse.TabIndex = 9;
            this.pcbFalse.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.Location = new System.Drawing.Point(35, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 62);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TorFi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pcbFalse);
            this.Controls.Add(this.pcbTrue);
            this.Controls.Add(this.btnIncorrect);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTrue);
            this.Controls.Add(this.lblFalse);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblEnter);
            this.Name = "TorFi";
            this.Text = "TorFi";
            ((System.ComponentModel.ISupportInitialize)(this.pcbTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFalse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblFalse;
        private System.Windows.Forms.Label lblTrue;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnIncorrect;
        private System.Windows.Forms.PictureBox pcbTrue;
        private System.Windows.Forms.PictureBox pcbFalse;
        private System.Windows.Forms.Button btnCancel;
    }
}