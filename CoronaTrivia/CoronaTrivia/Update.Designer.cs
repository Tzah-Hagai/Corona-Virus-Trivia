namespace CoronaTrivia
{
    partial class Update
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
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnBackto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestion
            // 
            this.btnQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnQuestion.Location = new System.Drawing.Point(139, 251);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(163, 92);
            this.btnQuestion.TabIndex = 0;
            this.btnQuestion.Text = "Add a question";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnInfo.Location = new System.Drawing.Point(484, 251);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(163, 92);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Add an information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHead.Location = new System.Drawing.Point(49, 61);
            this.lblHead.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(663, 62);
            this.lblHead.TabIndex = 2;
            this.lblHead.Text = "Please Choose whether to add a question to the trivia game or to add information " +
    "about Coronavirus";
            // 
            // btnBackto
            // 
            this.btnBackto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBackto.Location = new System.Drawing.Point(12, 12);
            this.btnBackto.Name = "btnBackto";
            this.btnBackto.Size = new System.Drawing.Size(159, 35);
            this.btnBackto.TabIndex = 7;
            this.btnBackto.Text = "Back to Main Menu";
            this.btnBackto.UseVisualStyleBackColor = true;
            this.btnBackto.Click += new System.EventHandler(this.btnBackto_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackto);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnQuestion);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnBackto;
    }
}