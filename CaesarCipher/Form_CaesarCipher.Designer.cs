namespace CaesarCipher
{
    partial class Form_CaesarCipher
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
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txtbox_Plaintext = new System.Windows.Forms.TextBox();
            this.txtbox_Encrypted = new System.Windows.Forms.TextBox();
            this.shift_Value = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shift_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(115, 385);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(125, 53);
            this.btn_Encrypt.TabIndex = 0;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(548, 385);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(125, 53);
            this.btn_Decrypt.TabIndex = 1;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // txtbox_Plaintext
            // 
            this.txtbox_Plaintext.Location = new System.Drawing.Point(21, 23);
            this.txtbox_Plaintext.Multiline = true;
            this.txtbox_Plaintext.Name = "txtbox_Plaintext";
            this.txtbox_Plaintext.Size = new System.Drawing.Size(332, 346);
            this.txtbox_Plaintext.TabIndex = 2;
            // 
            // txtbox_Encrypted
            // 
            this.txtbox_Encrypted.Location = new System.Drawing.Point(443, 22);
            this.txtbox_Encrypted.Multiline = true;
            this.txtbox_Encrypted.Name = "txtbox_Encrypted";
            this.txtbox_Encrypted.Size = new System.Drawing.Size(332, 346);
            this.txtbox_Encrypted.TabIndex = 3;
            // 
            // shift_Value
            // 
            this.shift_Value.Location = new System.Drawing.Point(381, 349);
            this.shift_Value.Name = "shift_Value";
            this.shift_Value.Size = new System.Drawing.Size(36, 20);
            this.shift_Value.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plain Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encrypted Message";
            // 
            // Form_CaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shift_Value);
            this.Controls.Add(this.txtbox_Encrypted);
            this.Controls.Add(this.txtbox_Plaintext);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_CaesarCipher";
            this.Text = "Caesar Cipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.shift_Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox txtbox_Plaintext;
        private System.Windows.Forms.TextBox txtbox_Encrypted;
        private System.Windows.Forms.NumericUpDown shift_Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

