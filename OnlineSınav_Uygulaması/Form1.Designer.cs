namespace OnlineSınav_Uygulaması
{
    partial class SınavGiris
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
            this.btn_sinavagiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sinavagiris
            // 
            this.btn_sinavagiris.BackColor = System.Drawing.Color.Silver;
            this.btn_sinavagiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sinavagiris.Location = new System.Drawing.Point(116, 12);
            this.btn_sinavagiris.Name = "btn_sinavagiris";
            this.btn_sinavagiris.Size = new System.Drawing.Size(235, 107);
            this.btn_sinavagiris.TabIndex = 0;
            this.btn_sinavagiris.Text = "Sınava Gir";
            this.btn_sinavagiris.UseVisualStyleBackColor = false;
            this.btn_sinavagiris.Click += new System.EventHandler(this.btn_sinavagiris_Click);
            // 
            // SınavGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineSınav_Uygulaması.Properties.Resources.sinav;
            this.ClientSize = new System.Drawing.Size(363, 334);
            this.Controls.Add(this.btn_sinavagiris);
            this.Name = "SınavGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sinavagiris;
    }
}

