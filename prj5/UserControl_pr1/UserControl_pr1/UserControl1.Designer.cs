namespace UserControl_pr1
{
    partial class UserControl1
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
            this.pictureBoxMotorbike = new System.Windows.Forms.PictureBox();
            this.labelIDData = new System.Windows.Forms.Label();
            this.labelModelData = new System.Windows.Forms.Label();
            this.labelBrandData = new System.Windows.Forms.Label();
            this.labelPriceData = new System.Windows.Forms.Label();
            this.labelHorsepower = new System.Windows.Forms.Label();
            this.labelMileageData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorbike)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMotorbike
            // 
            this.pictureBoxMotorbike.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxMotorbike.Location = new System.Drawing.Point(28, 27);
            this.pictureBoxMotorbike.Name = "pictureBoxMotorbike";
            this.pictureBoxMotorbike.Size = new System.Drawing.Size(358, 242);
            this.pictureBoxMotorbike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMotorbike.TabIndex = 0;
            this.pictureBoxMotorbike.TabStop = false;
            // 
            // labelIDData
            // 
            this.labelIDData.AutoSize = true;
            this.labelIDData.Location = new System.Drawing.Point(59, 286);
            this.labelIDData.Name = "labelIDData";
            this.labelIDData.Size = new System.Drawing.Size(63, 13);
            this.labelIDData.TabIndex = 1;
            this.labelIDData.Text = "labelIDData";
            // 
            // labelModelData
            // 
            this.labelModelData.AutoSize = true;
            this.labelModelData.Location = new System.Drawing.Point(59, 317);
            this.labelModelData.Name = "labelModelData";
            this.labelModelData.Size = new System.Drawing.Size(81, 13);
            this.labelModelData.TabIndex = 2;
            this.labelModelData.Text = "labelModelData";
            // 
            // labelBrandData
            // 
            this.labelBrandData.AutoSize = true;
            this.labelBrandData.Location = new System.Drawing.Point(59, 350);
            this.labelBrandData.Name = "labelBrandData";
            this.labelBrandData.Size = new System.Drawing.Size(80, 13);
            this.labelBrandData.TabIndex = 3;
            this.labelBrandData.Text = "labelBrandData";
            // 
            // labelPriceData
            // 
            this.labelPriceData.AutoSize = true;
            this.labelPriceData.Location = new System.Drawing.Point(59, 380);
            this.labelPriceData.Name = "labelPriceData";
            this.labelPriceData.Size = new System.Drawing.Size(76, 13);
            this.labelPriceData.TabIndex = 4;
            this.labelPriceData.Text = "labelPriceData";
            // 
            // labelHorsepower
            // 
            this.labelHorsepower.AutoSize = true;
            this.labelHorsepower.Location = new System.Drawing.Point(62, 414);
            this.labelHorsepower.Name = "labelHorsepower";
            this.labelHorsepower.Size = new System.Drawing.Size(86, 13);
            this.labelHorsepower.TabIndex = 5;
            this.labelHorsepower.Text = "labelHorsepower";
            // 
            // labelMileageData
            // 
            this.labelMileageData.AutoSize = true;
            this.labelMileageData.Location = new System.Drawing.Point(62, 448);
            this.labelMileageData.Name = "labelMileageData";
            this.labelMileageData.Size = new System.Drawing.Size(89, 13);
            this.labelMileageData.TabIndex = 6;
            this.labelMileageData.Text = "labelMileageData";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMileageData);
            this.Controls.Add(this.labelHorsepower);
            this.Controls.Add(this.labelPriceData);
            this.Controls.Add(this.labelBrandData);
            this.Controls.Add(this.labelModelData);
            this.Controls.Add(this.labelIDData);
            this.Controls.Add(this.pictureBoxMotorbike);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(421, 509);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorbike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMotorbike;
        private System.Windows.Forms.Label labelIDData;
        private System.Windows.Forms.Label labelModelData;
        private System.Windows.Forms.Label labelBrandData;
        private System.Windows.Forms.Label labelPriceData;
        private System.Windows.Forms.Label labelHorsepower;
        private System.Windows.Forms.Label labelMileageData;
    }
}
