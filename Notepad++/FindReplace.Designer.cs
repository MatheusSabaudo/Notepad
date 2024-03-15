namespace Notepad__
{
    partial class FindReplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindReplace));
            this.btn_action = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_find = new System.Windows.Forms.Label();
            this.lbl_replace = new System.Windows.Forms.Label();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.txt_replace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_action
            // 
            this.btn_action.Location = new System.Drawing.Point(91, 105);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(111, 41);
            this.btn_action.TabIndex = 0;
            this.btn_action.Text = "Find/Replace";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(226, 105);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 41);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_find
            // 
            this.lbl_find.AutoSize = true;
            this.lbl_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_find.Location = new System.Drawing.Point(46, 26);
            this.lbl_find.Name = "lbl_find";
            this.lbl_find.Size = new System.Drawing.Size(36, 16);
            this.lbl_find.TabIndex = 2;
            this.lbl_find.Text = "Find:";
            // 
            // lbl_replace
            // 
            this.lbl_replace.AutoSize = true;
            this.lbl_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_replace.Location = new System.Drawing.Point(46, 63);
            this.lbl_replace.Name = "lbl_replace";
            this.lbl_replace.Size = new System.Drawing.Size(62, 16);
            this.lbl_replace.TabIndex = 3;
            this.lbl_replace.Text = "Replace:";
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(130, 25);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(256, 20);
            this.txt_find.TabIndex = 4;
            // 
            // txt_replace
            // 
            this.txt_replace.Location = new System.Drawing.Point(130, 59);
            this.txt_replace.Name = "txt_replace";
            this.txt_replace.Size = new System.Drawing.Size(256, 20);
            this.txt_replace.TabIndex = 5;
            // 
            // FindReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 168);
            this.Controls.Add(this.txt_replace);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.lbl_replace);
            this.Controls.Add(this.lbl_find);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_action);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FindReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindReplace";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindReplace_FormClosed);
            this.Load += new System.EventHandler(this.FindReplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_find;
        private System.Windows.Forms.Label lbl_replace;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.TextBox txt_replace;
    }
}