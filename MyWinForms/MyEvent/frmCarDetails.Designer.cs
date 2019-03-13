namespace MyEvent
{
    partial class frmCarDetails
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
            this.lblCarDetails = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.AutoSize = true;
            this.lblCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCarDetails.Location = new System.Drawing.Point(42, 13);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(285, 31);
            this.lblCarDetails.TabIndex = 0;
            this.lblCarDetails.Text = "Please enter car name";
            // 
            // txtCarName
            // 
            this.txtCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCarName.Location = new System.Drawing.Point(343, 14);
            this.txtCarName.Multiline = true;
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(237, 30);
            this.txtCarName.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOK.Location = new System.Drawing.Point(129, 71);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(168, 65);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.Location = new System.Drawing.Point(343, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 65);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 167);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.lblCarDetails);
            this.Name = "frmCarDetails";
            this.Text = "Enter car Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarDetails;
        public  System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}