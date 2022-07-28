namespace CoronaTrivia
{
    partial class AddQuestion
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
            this.btnTorF = new System.Windows.Forms.Button();
            this.lblHeadQ = new System.Windows.Forms.Label();
            this.btnM = new System.Windows.Forms.Button();
            this.btnTorFI = new System.Windows.Forms.Button();
            this.btnMI = new System.Windows.Forms.Button();
            this.btnBackto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTorF
            // 
            this.btnTorF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnTorF.Location = new System.Drawing.Point(161, 121);
            this.btnTorF.Name = "btnTorF";
            this.btnTorF.Size = new System.Drawing.Size(159, 79);
            this.btnTorF.TabIndex = 0;
            this.btnTorF.Text = "True or False";
            this.btnTorF.UseVisualStyleBackColor = true;
            this.btnTorF.Click += new System.EventHandler(this.btnTorF_Click);
            // 
            // lblHeadQ
            // 
            this.lblHeadQ.AutoSize = true;
            this.lblHeadQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeadQ.Location = new System.Drawing.Point(54, 59);
            this.lblHeadQ.Name = "lblHeadQ";
            this.lblHeadQ.Size = new System.Drawing.Size(703, 31);
            this.lblHeadQ.TabIndex = 1;
            this.lblHeadQ.Text = "Please choose the type of question you would like to add:";
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnM.Location = new System.Drawing.Point(456, 121);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(159, 79);
            this.btnM.TabIndex = 2;
            this.btnM.Text = "Multiple Choice";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnTorFI
            // 
            this.btnTorFI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnTorFI.Location = new System.Drawing.Point(161, 269);
            this.btnTorFI.Name = "btnTorFI";
            this.btnTorFI.Size = new System.Drawing.Size(159, 79);
            this.btnTorFI.TabIndex = 3;
            this.btnTorFI.Text = "True or False with picture";
            this.btnTorFI.UseVisualStyleBackColor = true;
            this.btnTorFI.Click += new System.EventHandler(this.btnTorFI_Click);
            // 
            // btnMI
            // 
            this.btnMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMI.Location = new System.Drawing.Point(456, 269);
            this.btnMI.Name = "btnMI";
            this.btnMI.Size = new System.Drawing.Size(159, 79);
            this.btnMI.TabIndex = 4;
            this.btnMI.Text = "Multiple Choice with picture";
            this.btnMI.UseVisualStyleBackColor = true;
            this.btnMI.Click += new System.EventHandler(this.btnMI_Click);
            // 
            // btnBackto
            // 
            this.btnBackto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBackto.Location = new System.Drawing.Point(22, 10);
            this.btnBackto.Name = "btnBackto";
            this.btnBackto.Size = new System.Drawing.Size(93, 35);
            this.btnBackto.TabIndex = 8;
            this.btnBackto.Text = "Go back";
            this.btnBackto.UseVisualStyleBackColor = true;
            this.btnBackto.Click += new System.EventHandler(this.btnBackto_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackto);
            this.Controls.Add(this.btnMI);
            this.Controls.Add(this.btnTorFI);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.lblHeadQ);
            this.Controls.Add(this.btnTorF);
            this.Name = "AddQuestion";
            this.Text = "AddQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTorF;
        private System.Windows.Forms.Label lblHeadQ;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnTorFI;
        private System.Windows.Forms.Button btnMI;
        private System.Windows.Forms.Button btnBackto;
    }
}