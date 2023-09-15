namespace LeNguyenNhatTan_2180608005_MDI
{
    partial class ChildForm
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
            this.ptbHinhAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbHinhAnh
            // 
            this.ptbHinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbHinhAnh.Location = new System.Drawing.Point(0, 0);
            this.ptbHinhAnh.Name = "ptbHinhAnh";
            this.ptbHinhAnh.Size = new System.Drawing.Size(1063, 640);
            this.ptbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbHinhAnh.TabIndex = 0;
            this.ptbHinhAnh.TabStop = false;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 640);
            this.Controls.Add(this.ptbHinhAnh);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbHinhAnh;
    }
}