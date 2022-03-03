namespace Project2
{
    partial class Form2
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
            this.btnShow = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(188, 121);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(212, 33);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(188, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(188, 207);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(93, 17);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "-----------------";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnShow);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblResult;
    }
}