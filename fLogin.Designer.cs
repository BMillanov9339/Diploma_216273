namespace diploma_216273
{
    partial class fLogin
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
            this.tPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bEnter = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.cShowText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tPassword
            // 
            this.tPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPassword.Location = new System.Drawing.Point(150, 84);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(188, 29);
            this.tPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(46, 175);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(127, 46);
            this.bEnter.TabIndex = 4;
            this.bEnter.Text = "Enter";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(211, 175);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(127, 46);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // cShowText
            // 
            this.cShowText.AutoSize = true;
            this.cShowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cShowText.Location = new System.Drawing.Point(236, 129);
            this.cShowText.Name = "cShowText";
            this.cShowText.Size = new System.Drawing.Size(102, 24);
            this.cShowText.TabIndex = 6;
            this.cShowText.Text = "Show Text";
            this.cShowText.UseVisualStyleBackColor = true;
            this.cShowText.CheckedChanged += new System.EventHandler(this.cShowText_CheckedChanged);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(384, 284);
            this.Controls.Add(this.cShowText);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.label2);
            this.Name = "fLogin";
            this.Text = "Login as Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.CheckBox cShowText;
    }
}