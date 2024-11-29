namespace РГР
{
    partial class GameForm
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
            this.btnTrue_Click = new System.Windows.Forms.Button();
            this.btnFalse_Click = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnTrue_Click
            // 
            this.btnTrue_Click.Location = new System.Drawing.Point(12, 22);
            this.btnTrue_Click.Name = "btnTrue_Click";
            this.btnTrue_Click.Size = new System.Drawing.Size(75, 23);
            this.btnTrue_Click.TabIndex = 0;
            this.btnTrue_Click.Text = "1";
            this.btnTrue_Click.UseVisualStyleBackColor = true;
            this.btnTrue_Click.Click += new System.EventHandler(this.btnTrue_Click_Click);
            // 
            // btnFalse_Click
            // 
            this.btnFalse_Click.Location = new System.Drawing.Point(12, 62);
            this.btnFalse_Click.Name = "btnFalse_Click";
            this.btnFalse_Click.Size = new System.Drawing.Size(75, 23);
            this.btnFalse_Click.TabIndex = 1;
            this.btnFalse_Click.Text = "0";
            this.btnFalse_Click.UseVisualStyleBackColor = true;
            this.btnFalse_Click.Click += new System.EventHandler(this.btnFalse_Click_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(106, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 230);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFalse_Click);
            this.Controls.Add(this.btnTrue_Click);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrue_Click;
        private System.Windows.Forms.Button btnFalse_Click;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}