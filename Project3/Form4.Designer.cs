namespace Project3
{
    partial class Form4
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
            this.chkDiplom = new System.Windows.Forms.CheckBox();
            this.chkPHD = new System.Windows.Forms.CheckBox();
            this.chkMS = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkDiplom
            // 
            this.chkDiplom.AutoSize = true;
            this.chkDiplom.Location = new System.Drawing.Point(139, 63);
            this.chkDiplom.Name = "chkDiplom";
            this.chkDiplom.Size = new System.Drawing.Size(73, 21);
            this.chkDiplom.TabIndex = 0;
            this.chkDiplom.Text = "Diplom";
            this.chkDiplom.UseVisualStyleBackColor = true;
            this.chkDiplom.CheckedChanged += new System.EventHandler(this.ChkDiplom_CheckedChanged);
            // 
            // chkPHD
            // 
            this.chkPHD.AutoSize = true;
            this.chkPHD.Location = new System.Drawing.Point(499, 63);
            this.chkPHD.Name = "chkPHD";
            this.chkPHD.Size = new System.Drawing.Size(59, 21);
            this.chkPHD.TabIndex = 1;
            this.chkPHD.Text = "PHD";
            this.chkPHD.UseVisualStyleBackColor = true;
            this.chkPHD.CheckedChanged += new System.EventHandler(this.ChkDiplom_CheckedChanged);
            // 
            // chkMS
            // 
            this.chkMS.AutoSize = true;
            this.chkMS.Location = new System.Drawing.Point(323, 63);
            this.chkMS.Name = "chkMS";
            this.chkMS.Size = new System.Drawing.Size(50, 21);
            this.chkMS.TabIndex = 2;
            this.chkMS.Text = "MS";
            this.chkMS.UseVisualStyleBackColor = true;
            this.chkMS.CheckedChanged += new System.EventHandler(this.ChkDiplom_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(139, 139);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(412, 56);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(139, 272);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(59, 21);
            this.rdMale.TabIndex = 4;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.RdMale_CheckedChanged);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(448, 272);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(75, 21);
            this.rdFemale.TabIndex = 5;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.RdFemale_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(139, 351);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(412, 64);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkMS);
            this.Controls.Add(this.chkPHD);
            this.Controls.Add(this.chkDiplom);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDiplom;
        private System.Windows.Forms.CheckBox chkPHD;
        private System.Windows.Forms.CheckBox chkMS;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.Button btnLogin;
    }
}