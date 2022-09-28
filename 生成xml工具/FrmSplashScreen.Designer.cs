namespace 生成xml工具
{
    partial class FrmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashScreen));
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.panelProgressbarContainer = new System.Windows.Forms.Panel();
            this.panelProgressbar = new System.Windows.Forms.Panel();
            this.timerProgressbar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.panelProgressbarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.Image")));
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(682, 353);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            this.pictureBoxBackground.Click += new System.EventHandler(this.pictureBoxBackground_Click);
            // 
            // panelProgressbarContainer
            // 
            this.panelProgressbarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(193)))), ((int)(((byte)(59)))));
            this.panelProgressbarContainer.Controls.Add(this.panelProgressbar);
            this.panelProgressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProgressbarContainer.Location = new System.Drawing.Point(0, 333);
            this.panelProgressbarContainer.Name = "panelProgressbarContainer";
            this.panelProgressbarContainer.Size = new System.Drawing.Size(682, 20);
            this.panelProgressbarContainer.TabIndex = 1;
            // 
            // panelProgressbar
            // 
            this.panelProgressbar.BackColor = System.Drawing.Color.LawnGreen;
            this.panelProgressbar.Location = new System.Drawing.Point(0, 0);
            this.panelProgressbar.Name = "panelProgressbar";
            this.panelProgressbar.Size = new System.Drawing.Size(42, 20);
            this.panelProgressbar.TabIndex = 2;
            // 
            // timerProgressbar
            // 
            this.timerProgressbar.Enabled = true;
            this.timerProgressbar.Interval = 30;
            this.timerProgressbar.Tick += new System.EventHandler(this.timerProgressbar_Tick);
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.panelProgressbarContainer);
            this.Controls.Add(this.pictureBoxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.panelProgressbarContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxBackground;
        private Panel panelProgressbarContainer;
        private Panel panel1;
        private Panel panelProgressbar;
        private System.Windows.Forms.Timer timerProgressbar;
    }
}