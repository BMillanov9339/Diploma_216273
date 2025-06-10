namespace diploma_216273
{
    partial class fChangePassword
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
            this.bExit = new System.Windows.Forms.Button();
            this.bEnter = new System.Windows.Forms.Button();
            this.tOldPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tNewPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(244, 287);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(144, 46);
            this.bExit.TabIndex = 9;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(66, 287);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(144, 46);
            this.bEnter.TabIndex = 8;
            this.bEnter.Text = "Enter";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // tOldPass
            // 
            this.tOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tOldPass.Location = new System.Drawing.Point(200, 62);
            this.tOldPass.Name = "tOldPass";
            this.tOldPass.Size = new System.Drawing.Size(188, 29);
            this.tOldPass.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Old Password:";
            // 
            // tNewPass
            // 
            this.tNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tNewPass.Location = new System.Drawing.Point(200, 113);
            this.tNewPass.Name = "tNewPass";
            this.tNewPass.Size = new System.Drawing.Size(188, 29);
            this.tNewPass.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "New Password:";
            // 
            // tConfirm
            // 
            this.tConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tConfirm.Location = new System.Drawing.Point(200, 170);
            this.tConfirm.Name = "tConfirm";
            this.tConfirm.Size = new System.Drawing.Size(188, 29);
            this.tConfirm.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirm:";
            // 
            // fChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(444, 377);
            this.Controls.Add(this.tConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tNewPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.tOldPass);
            this.Controls.Add(this.label2);
            this.Name = "fChangePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.TextBox tOldPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tConfirm;
        private System.Windows.Forms.Label label3;
    }
}