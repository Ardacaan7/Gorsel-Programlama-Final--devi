namespace KitapTakipApp
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
            this.components = new System.ComponentModel.Container();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.numSayfa = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listBoxKitaplar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamSayfa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerHatirlat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(175, 125);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(99, 20);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // numSayfa
            // 
            this.numSayfa.Location = new System.Drawing.Point(175, 152);
            this.numSayfa.Name = "numSayfa";
            this.numSayfa.Size = new System.Drawing.Size(99, 20);
            this.numSayfa.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(105, 182);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listBoxKitaplar
            // 
            this.listBoxKitaplar.FormattingEnabled = true;
            this.listBoxKitaplar.Location = new System.Drawing.Point(105, 211);
            this.listBoxKitaplar.Name = "listBoxKitaplar";
            this.listBoxKitaplar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxKitaplar.Size = new System.Drawing.Size(169, 43);
            this.listBoxKitaplar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayfa Sayısı:";
            // 
            // lblToplamSayfa
            // 
            this.lblToplamSayfa.AutoSize = true;
            this.lblToplamSayfa.Location = new System.Drawing.Point(101, 275);
            this.lblToplamSayfa.Name = "lblToplamSayfa";
            this.lblToplamSayfa.Size = new System.Drawing.Size(35, 13);
            this.lblToplamSayfa.TabIndex = 5;
            this.lblToplamSayfa.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kitap Adı :";
            // 
            // timerHatirlat
            // 
            this.timerHatirlat.Enabled = true;
            this.timerHatirlat.Interval = 6000;
            this.timerHatirlat.Tick += new System.EventHandler(this.timerHatirlat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToplamSayfa);
            this.Controls.Add(this.listBoxKitaplar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numSayfa);
            this.Controls.Add(this.txtKitapAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.NumericUpDown numSayfa;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBoxKitaplar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamSayfa;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerHatirlat;
    }
}

