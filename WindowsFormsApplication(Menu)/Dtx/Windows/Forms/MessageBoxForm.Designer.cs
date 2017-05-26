namespace Dtx.Windows.Forms
{
    partial class MessageBoxForm
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
            this.textLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLable
            // 
            this.textLable.AutoSize = true;
            this.textLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textLable.ForeColor = System.Drawing.Color.White;
            this.textLable.Location = new System.Drawing.Point(66, 113);
            this.textLable.Name = "textLable";
            this.textLable.Size = new System.Drawing.Size(138, 24);
            this.textLable.TabIndex = 0;
            this.textLable.Text = "Hello , World!";
            this.textLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textLable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxForm";
            this.Text = "MessageBoxForm";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLable;
    }
}