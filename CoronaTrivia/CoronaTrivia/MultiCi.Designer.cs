namespace CoronaTrivia
{
    partial class MultiCi
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
            this.lblTrue = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnFAdd2 = new System.Windows.Forms.Button();
            this.btnFAdd1 = new System.Windows.Forms.Button();
            this.btnAddT = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInc2 = new System.Windows.Forms.Label();
            this.lblInc1 = new System.Windows.Forms.Label();
            this.pcbFalse1 = new System.Windows.Forms.PictureBox();
            this.pcbFalse2 = new System.Windows.Forms.PictureBox();
            this.pcbTrue = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFalse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFalse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTrue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEnter.Location = new System.Drawing.Point(26, 33);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(298, 29);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Enter your question below:";
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTrue.Location = new System.Drawing.Point(39, 248);
            this.lblTrue.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(155, 48);
            this.lblTrue.TabIndex = 4;
            this.lblTrue.Text = "Add your correct answer image:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtQuestion.Location = new System.Drawing.Point(43, 72);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(265, 136);
            this.txtQuestion.TabIndex = 6;
            // 
            // btnFAdd2
            // 
            this.btnFAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFAdd2.Location = new System.Drawing.Point(410, 265);
            this.btnFAdd2.Name = "btnFAdd2";
            this.btnFAdd2.Size = new System.Drawing.Size(88, 48);
            this.btnFAdd2.TabIndex = 7;
            this.btnFAdd2.Text = "Add";
            this.btnFAdd2.UseVisualStyleBackColor = true;
            this.btnFAdd2.Click += new System.EventHandler(this.btnFAdd2_Click);
            // 
            // btnFAdd1
            // 
            this.btnFAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFAdd1.Location = new System.Drawing.Point(410, 119);
            this.btnFAdd1.Name = "btnFAdd1";
            this.btnFAdd1.Size = new System.Drawing.Size(88, 48);
            this.btnFAdd1.TabIndex = 8;
            this.btnFAdd1.Text = "Add";
            this.btnFAdd1.UseVisualStyleBackColor = true;
            this.btnFAdd1.Click += new System.EventHandler(this.btnFAdd1_Click);
            // 
            // btnAddT
            // 
            this.btnAddT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddT.Location = new System.Drawing.Point(56, 315);
            this.btnAddT.Name = "btnAddT";
            this.btnAddT.Size = new System.Drawing.Size(88, 48);
            this.btnAddT.TabIndex = 9;
            this.btnAddT.Text = "Add";
            this.btnAddT.UseVisualStyleBackColor = true;
            this.btnAddT.Click += new System.EventHandler(this.btnAddT_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSubmit.Location = new System.Drawing.Point(554, 350);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(183, 70);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInc2
            // 
            this.lblInc2.AutoSize = true;
            this.lblInc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInc2.Location = new System.Drawing.Point(383, 180);
            this.lblInc2.MaximumSize = new System.Drawing.Size(180, 0);
            this.lblInc2.Name = "lblInc2";
            this.lblInc2.Size = new System.Drawing.Size(160, 72);
            this.lblInc2.TabIndex = 11;
            this.lblInc2.Text = "Add your second incorrect answer image:";
            // 
            // lblInc1
            // 
            this.lblInc1.AutoSize = true;
            this.lblInc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInc1.Location = new System.Drawing.Point(374, 35);
            this.lblInc1.MaximumSize = new System.Drawing.Size(170, 0);
            this.lblInc1.Name = "lblInc1";
            this.lblInc1.Size = new System.Drawing.Size(154, 72);
            this.lblInc1.TabIndex = 12;
            this.lblInc1.Text = "Add your first incorrect answer image:";
            // 
            // pcbFalse1
            // 
            this.pcbFalse1.Location = new System.Drawing.Point(544, 72);
            this.pcbFalse1.Name = "pcbFalse1";
            this.pcbFalse1.Size = new System.Drawing.Size(157, 105);
            this.pcbFalse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFalse1.TabIndex = 13;
            this.pcbFalse1.TabStop = false;
            // 
            // pcbFalse2
            // 
            this.pcbFalse2.Location = new System.Drawing.Point(544, 208);
            this.pcbFalse2.Name = "pcbFalse2";
            this.pcbFalse2.Size = new System.Drawing.Size(157, 105);
            this.pcbFalse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFalse2.TabIndex = 14;
            this.pcbFalse2.TabStop = false;
            // 
            // pcbTrue
            // 
            this.pcbTrue.Location = new System.Drawing.Point(200, 271);
            this.pcbTrue.Name = "pcbTrue";
            this.pcbTrue.Size = new System.Drawing.Size(157, 105);
            this.pcbTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTrue.TabIndex = 15;
            this.pcbTrue.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.Location = new System.Drawing.Point(378, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 54);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MultiCi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pcbTrue);
            this.Controls.Add(this.pcbFalse2);
            this.Controls.Add(this.pcbFalse1);
            this.Controls.Add(this.lblInc1);
            this.Controls.Add(this.lblInc2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAddT);
            this.Controls.Add(this.btnFAdd1);
            this.Controls.Add(this.btnFAdd2);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblTrue);
            this.Controls.Add(this.lblEnter);
            this.Name = "MultiCi";
            this.Text = "MultiCi";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFalse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFalse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTrue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblTrue;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnFAdd2;
        private System.Windows.Forms.Button btnFAdd1;
        private System.Windows.Forms.Button btnAddT;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInc2;
        private System.Windows.Forms.Label lblInc1;
        private System.Windows.Forms.PictureBox pcbFalse1;
        private System.Windows.Forms.PictureBox pcbFalse2;
        private System.Windows.Forms.PictureBox pcbTrue;
        private System.Windows.Forms.Button btnCancel;
    }
}