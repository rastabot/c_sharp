namespace MyPLINQWin
{
    partial class frmMain
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
            this.btnExcecute = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExcecute
            // 
            this.btnExcecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExcecute.Location = new System.Drawing.Point(55, 36);
            this.btnExcecute.Name = "btnExcecute";
            this.btnExcecute.Size = new System.Drawing.Size(166, 75);
            this.btnExcecute.TabIndex = 0;
            this.btnExcecute.Text = "Execute";
            this.btnExcecute.UseVisualStyleBackColor = true;
            this.btnExcecute.Click += new System.EventHandler(this.btnExcecute_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.Location = new System.Drawing.Point(257, 36);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 75);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 170);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExcecute);
            this.Name = "frmMain";
            this.Text = "MyPLInq Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcecute;
        private System.Windows.Forms.Button btnCancel;
    }
}

