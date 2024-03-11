namespace Notepad__
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.prg_loading = new System.Windows.Forms.ProgressBar();
            this.tmr_loadingtime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // prg_loading
            // 
            this.prg_loading.Location = new System.Drawing.Point(12, 314);
            this.prg_loading.Name = "prg_loading";
            this.prg_loading.Size = new System.Drawing.Size(590, 20);
            this.prg_loading.TabIndex = 0;
            // 
            // tmr_loadingtime
            // 
            this.tmr_loadingtime.Interval = 1000;
            this.tmr_loadingtime.Tick += new System.EventHandler(this.tmr_loadingtime_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Notepad__.Properties.Resources.Intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 346);
            this.Controls.Add(this.prg_loading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prg_loading;
        private System.Windows.Forms.Timer tmr_loadingtime;
    }
}