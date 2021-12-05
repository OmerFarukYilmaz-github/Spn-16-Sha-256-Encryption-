
namespace Encryption
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPText = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.checkBoxSPN = new System.Windows.Forms.CheckBox();
            this.checkBoxSHA = new System.Windows.Forms.CheckBox();
            this.labelCipher = new System.Windows.Forms.Label();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPText
            // 
            this.labelPText.AutoSize = true;
            this.labelPText.Location = new System.Drawing.Point(41, 58);
            this.labelPText.Name = "labelPText";
            this.labelPText.Size = new System.Drawing.Size(70, 17);
            this.labelPText.TabIndex = 0;
            this.labelPText.Text = "Plain Text";
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(44, 78);
            this.txtPlain.MinimumSize = new System.Drawing.Size(100, 100);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(294, 100);
            this.txtPlain.TabIndex = 1;
            // 
            // checkBoxSPN
            // 
            this.checkBoxSPN.AutoSize = true;
            this.checkBoxSPN.Location = new System.Drawing.Point(371, 78);
            this.checkBoxSPN.Name = "checkBoxSPN";
            this.checkBoxSPN.Size = new System.Drawing.Size(79, 21);
            this.checkBoxSPN.TabIndex = 2;
            this.checkBoxSPN.Text = "SPN-16";
            this.checkBoxSPN.UseVisualStyleBackColor = true;
            this.checkBoxSPN.CheckedChanged += new System.EventHandler(this.checkBoxSPN_CheckedChanged);
            // 
            // checkBoxSHA
            // 
            this.checkBoxSHA.AutoSize = true;
            this.checkBoxSHA.Location = new System.Drawing.Point(371, 114);
            this.checkBoxSHA.Name = "checkBoxSHA";
            this.checkBoxSHA.Size = new System.Drawing.Size(87, 21);
            this.checkBoxSHA.TabIndex = 3;
            this.checkBoxSHA.Text = "SHA-256";
            this.checkBoxSHA.UseVisualStyleBackColor = true;
            this.checkBoxSHA.CheckedChanged += new System.EventHandler(this.checkBoxSHA_CheckedChanged);
            // 
            // labelCipher
            // 
            this.labelCipher.AutoSize = true;
            this.labelCipher.Location = new System.Drawing.Point(41, 226);
            this.labelCipher.Name = "labelCipher";
            this.labelCipher.Size = new System.Drawing.Size(80, 17);
            this.labelCipher.TabIndex = 4;
            this.labelCipher.Text = "Cipher Text";
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(44, 246);
            this.txtCipher.MinimumSize = new System.Drawing.Size(100, 100);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(294, 100);
            this.txtCipher.TabIndex = 5;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(362, 184);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(105, 40);
            this.btn_Encrypt.TabIndex = 6;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(503, 78);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 22);
            this.txtKey.TabIndex = 8;
            this.txtKey.Text = "security";
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(503, 184);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(105, 40);
            this.btn_Decrypt.TabIndex = 9;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.labelCipher);
            this.Controls.Add(this.checkBoxSHA);
            this.Controls.Add(this.checkBoxSPN);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.labelPText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPText;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.CheckBox checkBoxSPN;
        private System.Windows.Forms.CheckBox checkBoxSHA;
        private System.Windows.Forms.Label labelCipher;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btn_Decrypt;
    }
}

