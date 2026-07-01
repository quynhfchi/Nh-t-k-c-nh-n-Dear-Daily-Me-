namespace DearDailyMe_Nhom
{
    partial class ucDiaryCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDate = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblEmotion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(380, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label1";
            // 
            // rtbContent
            // 
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Location = new System.Drawing.Point(84, 158);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbContent.Size = new System.Drawing.Size(100, 96);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.TabStop = false;
            this.rtbContent.Text = "";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(384, 81);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(51, 20);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "label1";
            // 
            // lblEmotion
            // 
            this.lblEmotion.AutoSize = true;
            this.lblEmotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblEmotion.Location = new System.Drawing.Point(96, 55);
            this.lblEmotion.Name = "lblEmotion";
            this.lblEmotion.Size = new System.Drawing.Size(152, 55);
            this.lblEmotion.TabIndex = 3;
            this.lblEmotion.Text = "label1";
            // 
            // ucDiaryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEmotion);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.lblDate);
            this.Name = "ucDiaryCard";
            this.Size = new System.Drawing.Size(517, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblEmotion;
    }
}
