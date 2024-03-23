namespace Notepad__
{
    partial class ToolsMD5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsMD5));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxt_encrypted = new System.Windows.Forms.RichTextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtxt_orginal = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxt_encrypted);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encrypted Text";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rtxt_encrypted
            // 
            this.rtxt_encrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_encrypted.Location = new System.Drawing.Point(7, 29);
            this.rtxt_encrypted.Name = "rtxt_encrypted";
            this.rtxt_encrypted.Size = new System.Drawing.Size(635, 152);
            this.rtxt_encrypted.TabIndex = 1;
            this.rtxt_encrypted.Text = "";
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(141, 404);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(161, 57);
            this.btn_encrypt.TabIndex = 2;
            this.btn_encrypt.Text = "ENCRYPT";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(363, 404);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(161, 57);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtxt_orginal);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Original Text";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rtxt_orginal
            // 
            this.rtxt_orginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_orginal.Location = new System.Drawing.Point(7, 29);
            this.rtxt_orginal.Name = "rtxt_orginal";
            this.rtxt_orginal.Size = new System.Drawing.Size(635, 152);
            this.rtxt_orginal.TabIndex = 1;
            this.rtxt_orginal.Text = "";
            // 
            // ToolsMD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 473);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolsMD5";
            this.Text = "Criptography";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.RichTextBox rtxt_encrypted;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtxt_orginal;
    }
}