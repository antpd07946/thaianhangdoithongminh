namespace hangdoi2
{
    partial class frmMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatKhau));
            this.mainPannel = new Bunifu.UI.WinForms.BunifuPanel();
            this.SuspendLayout();
            // 
            // mainPannel
            // 
            this.mainPannel.BackgroundColor = System.Drawing.Color.Transparent;
            this.mainPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPannel.BackgroundImage")));
            this.mainPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPannel.BorderColor = System.Drawing.Color.Transparent;
            this.mainPannel.BorderRadius = 3;
            this.mainPannel.BorderThickness = 1;
            this.mainPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPannel.Location = new System.Drawing.Point(0, 0);
            this.mainPannel.Name = "mainPannel";
            this.mainPannel.ShowBorders = true;
            this.mainPannel.Size = new System.Drawing.Size(650, 450);
            this.mainPannel.TabIndex = 0;
            // 
            // frmMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.mainPannel);
            this.Name = "frmMatKhau";
            this.Text = "frmMatKhau";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel mainPannel;
    }
}