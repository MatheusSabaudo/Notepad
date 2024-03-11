namespace Notepad__
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_preferences = new System.Windows.Forms.Label();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.cmb_theme = new System.Windows.Forms.ComboBox();
            this.cmb_language = new System.Windows.Forms.ComboBox();
            this.lbl_language = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenceToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // licenceToolStripMenuItem
            // 
            this.licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            this.licenceToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.licenceToolStripMenuItem.Text = "Licence";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Notepad__.Properties.Resources.preferences;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_preferences
            // 
            this.lbl_preferences.Font = new System.Drawing.Font("Cascadia Mono Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preferences.ForeColor = System.Drawing.Color.White;
            this.lbl_preferences.Location = new System.Drawing.Point(298, 48);
            this.lbl_preferences.Name = "lbl_preferences";
            this.lbl_preferences.Size = new System.Drawing.Size(502, 43);
            this.lbl_preferences.TabIndex = 2;
            this.lbl_preferences.Text = "PREFERENCES";
            this.lbl_preferences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_theme
            // 
            this.lbl_theme.Font = new System.Drawing.Font("Cascadia Mono ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_theme.ForeColor = System.Drawing.Color.White;
            this.lbl_theme.Location = new System.Drawing.Point(298, 121);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(490, 33);
            this.lbl_theme.TabIndex = 4;
            this.lbl_theme.Text = "THEME";
            this.lbl_theme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_theme
            // 
            this.cmb_theme.FormattingEnabled = true;
            this.cmb_theme.Location = new System.Drawing.Point(298, 157);
            this.cmb_theme.Name = "cmb_theme";
            this.cmb_theme.Size = new System.Drawing.Size(490, 21);
            this.cmb_theme.TabIndex = 5;
            // 
            // cmb_language
            // 
            this.cmb_language.FormattingEnabled = true;
            this.cmb_language.Location = new System.Drawing.Point(298, 250);
            this.cmb_language.Name = "cmb_language";
            this.cmb_language.Size = new System.Drawing.Size(490, 21);
            this.cmb_language.TabIndex = 7;
            this.cmb_language.SelectedIndexChanged += new System.EventHandler(this.cmb_language_SelectedIndexChanged);
            // 
            // lbl_language
            // 
            this.lbl_language.Font = new System.Drawing.Font("Cascadia Mono ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_language.ForeColor = System.Drawing.Color.White;
            this.lbl_language.Location = new System.Drawing.Point(298, 214);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(490, 33);
            this.lbl_language.TabIndex = 6;
            this.lbl_language.Text = "LANGUAGE";
            this.lbl_language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(381, 333);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(143, 56);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "CONFIRM";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(559, 333);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(143, 56);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.cmb_language);
            this.Controls.Add(this.lbl_language);
            this.Controls.Add(this.cmb_theme);
            this.Controls.Add(this.lbl_theme);
            this.Controls.Add(this.lbl_preferences);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.DoubleClick += new System.EventHandler(this.Preferences_DoubleClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenceToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_preferences;
        private System.Windows.Forms.Label lbl_theme;
        private System.Windows.Forms.ComboBox cmb_theme;
        private System.Windows.Forms.ComboBox cmb_language;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
    }
}