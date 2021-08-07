
namespace RicardoMilosTrap
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_Principal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Principal
            // 
            this.pb_Principal.BackColor = System.Drawing.Color.Black;
            this.pb_Principal.Image = global::RicardoMilosTrap.Properties.Resources.RicardoMilos;
            this.pb_Principal.Location = new System.Drawing.Point(0, 0);
            this.pb_Principal.Name = "pb_Principal";
            this.pb_Principal.Size = new System.Drawing.Size(1280, 720);
            this.pb_Principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Principal.TabIndex = 0;
            this.pb_Principal.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.pb_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Icon = Properties.Resources.logo_Ricardo;
            this.Name = "Principal";
            this.ShowInTaskbar = false;
            this.Text = "RicardoMilusTrap";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Principal;
    }
}

