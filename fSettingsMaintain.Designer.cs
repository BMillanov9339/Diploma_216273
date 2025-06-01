namespace diploma_216273
{
    partial class fSettingsMaintain
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
            this.tTempMaintain = new System.Windows.Forms.TextBox();
            this.tHumMaintain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSaveMaintain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bCancelMaintain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tTempMaintain
            // 
            this.tTempMaintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tTempMaintain.Location = new System.Drawing.Point(221, 88);
            this.tTempMaintain.Name = "tTempMaintain";
            this.tTempMaintain.Size = new System.Drawing.Size(82, 29);
            this.tTempMaintain.TabIndex = 0;
            this.tTempMaintain.Text = "0.0";
            // 
            // tHumMaintain
            // 
            this.tHumMaintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tHumMaintain.Location = new System.Drawing.Point(221, 145);
            this.tHumMaintain.Name = "tHumMaintain";
            this.tHumMaintain.Size = new System.Drawing.Size(82, 29);
            this.tHumMaintain.TabIndex = 1;
            this.tHumMaintain.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maintain Temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maintain Humidity:";
            // 
            // bSaveMaintain
            // 
            this.bSaveMaintain.Location = new System.Drawing.Point(29, 253);
            this.bSaveMaintain.Name = "bSaveMaintain";
            this.bSaveMaintain.Size = new System.Drawing.Size(142, 33);
            this.bSaveMaintain.TabIndex = 4;
            this.bSaveMaintain.Text = "Save";
            this.bSaveMaintain.UseVisualStyleBackColor = true;
            this.bSaveMaintain.Click += new System.EventHandler(this.bSaveMaintain_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(309, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "°C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(309, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "%";
            // 
            // bCancelMaintain
            // 
            this.bCancelMaintain.Location = new System.Drawing.Point(193, 253);
            this.bCancelMaintain.Name = "bCancelMaintain";
            this.bCancelMaintain.Size = new System.Drawing.Size(142, 33);
            this.bCancelMaintain.TabIndex = 8;
            this.bCancelMaintain.Text = "Cancel";
            this.bCancelMaintain.UseVisualStyleBackColor = true;
            this.bCancelMaintain.Click += new System.EventHandler(this.bCancelMaintain_Click);
            // 
            // fSettingsMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(360, 315);
            this.Controls.Add(this.bCancelMaintain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bSaveMaintain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tHumMaintain);
            this.Controls.Add(this.tTempMaintain);
            this.Name = "fSettingsMaintain";
            this.Text = "fSettingsMaintain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tTempMaintain;
        private System.Windows.Forms.TextBox tHumMaintain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSaveMaintain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCancelMaintain;
    }
}