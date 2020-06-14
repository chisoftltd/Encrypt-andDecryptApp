namespace Encrypt_andDecryptApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecrypt_Click = new System.Windows.Forms.Button();
            this.btnEncrypt_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 30);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(762, 50);
            this.txtInput.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(12, 121);
            this.txtEncrypt.Multiline = true;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(762, 50);
            this.txtEncrypt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypt";
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(12, 209);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(769, 50);
            this.txtDecrypt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decrypt";
            // 
            // btnDecrypt_Click
            // 
            this.btnDecrypt_Click.Location = new System.Drawing.Point(687, 281);
            this.btnDecrypt_Click.Name = "btnDecrypt_Click";
            this.btnDecrypt_Click.Size = new System.Drawing.Size(94, 32);
            this.btnDecrypt_Click.TabIndex = 7;
            this.btnDecrypt_Click.Text = "Decrypt";
            this.btnDecrypt_Click.UseVisualStyleBackColor = true;
            this.btnDecrypt_Click.Click += new System.EventHandler(this.btnDecrypt_Click_Click);
            // 
            // btnEncrypt_Click
            // 
            this.btnEncrypt_Click.Location = new System.Drawing.Point(552, 281);
            this.btnEncrypt_Click.Name = "btnEncrypt_Click";
            this.btnEncrypt_Click.Size = new System.Drawing.Size(94, 32);
            this.btnEncrypt_Click.TabIndex = 8;
            this.btnEncrypt_Click.Text = "Encrypt";
            this.btnEncrypt_Click.UseVisualStyleBackColor = true;
            this.btnEncrypt_Click.Click += new System.EventHandler(this.btnEncrypt_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.btnEncrypt_Click);
            this.Controls.Add(this.btnDecrypt_Click);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecrypt_Click;
        private System.Windows.Forms.Button btnEncrypt_Click;
    }
}

