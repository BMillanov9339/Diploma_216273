namespace test4
{
    partial class fSettingsTimed
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
            this.slTempOn = new System.Windows.Forms.TrackBar();
            this.slTempOff = new System.Windows.Forms.TrackBar();
            this.labelTimeOn = new System.Windows.Forms.Label();
            this.labelTimeOff = new System.Windows.Forms.Label();
            this.bSaveTimed = new System.Windows.Forms.Button();
            this.bCancelTimed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.slHumOff = new System.Windows.Forms.TrackBar();
            this.slHumOn = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slTempOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slTempOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slHumOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slHumOn)).BeginInit();
            this.SuspendLayout();
            // 
            // slTempOn
            // 
            this.slTempOn.Location = new System.Drawing.Point(55, 170);
            this.slTempOn.Minimum = 1;
            this.slTempOn.Name = "slTempOn";
            this.slTempOn.Size = new System.Drawing.Size(136, 45);
            this.slTempOn.TabIndex = 0;
            this.slTempOn.Value = 1;
            // 
            // slTempOff
            // 
            this.slTempOff.Location = new System.Drawing.Point(53, 260);
            this.slTempOff.Minimum = 1;
            this.slTempOff.Name = "slTempOff";
            this.slTempOff.Size = new System.Drawing.Size(136, 45);
            this.slTempOff.TabIndex = 1;
            this.slTempOff.Value = 1;
            // 
            // labelTimeOn
            // 
            this.labelTimeOn.AutoSize = true;
            this.labelTimeOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeOn.Location = new System.Drawing.Point(52, 128);
            this.labelTimeOn.Name = "labelTimeOn";
            this.labelTimeOn.Size = new System.Drawing.Size(129, 25);
            this.labelTimeOn.TabIndex = 2;
            this.labelTimeOn.Text = "Time ON: 1m";
            // 
            // labelTimeOff
            // 
            this.labelTimeOff.AutoSize = true;
            this.labelTimeOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeOff.Location = new System.Drawing.Point(50, 218);
            this.labelTimeOff.Name = "labelTimeOff";
            this.labelTimeOff.Size = new System.Drawing.Size(139, 25);
            this.labelTimeOff.TabIndex = 3;
            this.labelTimeOff.Text = "Time OFF: 1m";
            // 
            // bSaveTimed
            // 
            this.bSaveTimed.Location = new System.Drawing.Point(102, 387);
            this.bSaveTimed.Name = "bSaveTimed";
            this.bSaveTimed.Size = new System.Drawing.Size(136, 43);
            this.bSaveTimed.TabIndex = 4;
            this.bSaveTimed.Text = "Save";
            this.bSaveTimed.UseVisualStyleBackColor = true;
            this.bSaveTimed.Click += new System.EventHandler(this.bSaveTimed_Click);
            // 
            // bCancelTimed
            // 
            this.bCancelTimed.Location = new System.Drawing.Point(268, 387);
            this.bCancelTimed.Name = "bCancelTimed";
            this.bCancelTimed.Size = new System.Drawing.Size(136, 43);
            this.bCancelTimed.TabIndex = 5;
            this.bCancelTimed.Text = "Cancel";
            this.bCancelTimed.UseVisualStyleBackColor = true;
            this.bCancelTimed.Click += new System.EventHandler(this.bCancelTimed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(322, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time OFF: 1m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(324, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time ON: 1m";
            // 
            // slHumOff
            // 
            this.slHumOff.Location = new System.Drawing.Point(325, 260);
            this.slHumOff.Minimum = 1;
            this.slHumOff.Name = "slHumOff";
            this.slHumOff.Size = new System.Drawing.Size(136, 45);
            this.slHumOff.TabIndex = 7;
            this.slHumOff.Value = 1;
            // 
            // slHumOn
            // 
            this.slHumOn.Location = new System.Drawing.Point(327, 170);
            this.slHumOn.Minimum = 1;
            this.slHumOn.Name = "slHumOn";
            this.slHumOn.Size = new System.Drawing.Size(136, 45);
            this.slHumOn.TabIndex = 6;
            this.slHumOn.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(56, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "HEATER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(297, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "VENTILATION";
            // 
            // fSettingsTimed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(516, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slHumOff);
            this.Controls.Add(this.slHumOn);
            this.Controls.Add(this.bCancelTimed);
            this.Controls.Add(this.bSaveTimed);
            this.Controls.Add(this.labelTimeOff);
            this.Controls.Add(this.labelTimeOn);
            this.Controls.Add(this.slTempOff);
            this.Controls.Add(this.slTempOn);
            this.Name = "fSettingsTimed";
            this.Text = "fSettingsTimed";
            ((System.ComponentModel.ISupportInitialize)(this.slTempOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slTempOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slHumOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slHumOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar slTempOn;
        private System.Windows.Forms.TrackBar slTempOff;
        private System.Windows.Forms.Label labelTimeOn;
        private System.Windows.Forms.Label labelTimeOff;
        private System.Windows.Forms.Button bSaveTimed;
        private System.Windows.Forms.Button bCancelTimed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar slHumOff;
        private System.Windows.Forms.TrackBar slHumOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}