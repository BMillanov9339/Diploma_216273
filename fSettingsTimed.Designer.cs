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
            this.labelHTimeOn = new System.Windows.Forms.Label();
            this.labelHTimeOff = new System.Windows.Forms.Label();
            this.bSaveTimed = new System.Windows.Forms.Button();
            this.bCancelTimed = new System.Windows.Forms.Button();
            this.labelVTimeOff = new System.Windows.Forms.Label();
            this.labelVTimeOn = new System.Windows.Forms.Label();
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
            this.slTempOn.Scroll += new System.EventHandler(this.slTempOn_Scroll);
            // 
            // slTempOff
            // 
            this.slTempOff.Location = new System.Drawing.Point(53, 260);
            this.slTempOff.Minimum = 1;
            this.slTempOff.Name = "slTempOff";
            this.slTempOff.Size = new System.Drawing.Size(136, 45);
            this.slTempOff.TabIndex = 1;
            this.slTempOff.Value = 1;
            this.slTempOff.Scroll += new System.EventHandler(this.slTempOff_Scroll);
            // 
            // labelHTimeOn
            // 
            this.labelHTimeOn.AutoSize = true;
            this.labelHTimeOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHTimeOn.Location = new System.Drawing.Point(52, 128);
            this.labelHTimeOn.Name = "labelHTimeOn";
            this.labelHTimeOn.Size = new System.Drawing.Size(129, 25);
            this.labelHTimeOn.TabIndex = 2;
            this.labelHTimeOn.Text = "Time ON: 1m";
            // 
            // labelHTimeOff
            // 
            this.labelHTimeOff.AutoSize = true;
            this.labelHTimeOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHTimeOff.Location = new System.Drawing.Point(50, 218);
            this.labelHTimeOff.Name = "labelHTimeOff";
            this.labelHTimeOff.Size = new System.Drawing.Size(139, 25);
            this.labelHTimeOff.TabIndex = 3;
            this.labelHTimeOff.Text = "Time OFF: 1m";
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
            // labelVTimeOff
            // 
            this.labelVTimeOff.AutoSize = true;
            this.labelVTimeOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVTimeOff.Location = new System.Drawing.Point(322, 218);
            this.labelVTimeOff.Name = "labelVTimeOff";
            this.labelVTimeOff.Size = new System.Drawing.Size(139, 25);
            this.labelVTimeOff.TabIndex = 9;
            this.labelVTimeOff.Text = "Time OFF: 1m";
            // 
            // labelVTimeOn
            // 
            this.labelVTimeOn.AutoSize = true;
            this.labelVTimeOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVTimeOn.Location = new System.Drawing.Point(324, 128);
            this.labelVTimeOn.Name = "labelVTimeOn";
            this.labelVTimeOn.Size = new System.Drawing.Size(129, 25);
            this.labelVTimeOn.TabIndex = 8;
            this.labelVTimeOn.Text = "Time ON: 1m";
            // 
            // slHumOff
            // 
            this.slHumOff.Location = new System.Drawing.Point(325, 260);
            this.slHumOff.Minimum = 1;
            this.slHumOff.Name = "slHumOff";
            this.slHumOff.Size = new System.Drawing.Size(136, 45);
            this.slHumOff.TabIndex = 7;
            this.slHumOff.Value = 1;
            this.slHumOff.Scroll += new System.EventHandler(this.slHumOff_Scroll);
            // 
            // slHumOn
            // 
            this.slHumOn.Location = new System.Drawing.Point(327, 170);
            this.slHumOn.Minimum = 1;
            this.slHumOn.Name = "slHumOn";
            this.slHumOn.Size = new System.Drawing.Size(136, 45);
            this.slHumOn.TabIndex = 6;
            this.slHumOn.Value = 1;
            this.slHumOn.Scroll += new System.EventHandler(this.slHumOn_Scroll);
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
            this.Controls.Add(this.labelVTimeOff);
            this.Controls.Add(this.labelVTimeOn);
            this.Controls.Add(this.slHumOff);
            this.Controls.Add(this.slHumOn);
            this.Controls.Add(this.bCancelTimed);
            this.Controls.Add(this.bSaveTimed);
            this.Controls.Add(this.labelHTimeOff);
            this.Controls.Add(this.labelHTimeOn);
            this.Controls.Add(this.slTempOff);
            this.Controls.Add(this.slTempOn);
            this.Name = "fSettingsTimed";
            this.Text = "Settings (Timed)";
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
        private System.Windows.Forms.Label labelHTimeOn;
        private System.Windows.Forms.Label labelHTimeOff;
        private System.Windows.Forms.Button bSaveTimed;
        private System.Windows.Forms.Button bCancelTimed;
        private System.Windows.Forms.Label labelVTimeOff;
        private System.Windows.Forms.Label labelVTimeOn;
        private System.Windows.Forms.TrackBar slHumOff;
        private System.Windows.Forms.TrackBar slHumOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}