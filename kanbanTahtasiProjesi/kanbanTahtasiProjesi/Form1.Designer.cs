
namespace kanbanTahtasiProjesi
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtNotBasligi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKalanKarakter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(86, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(51, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Not:";
            // 
            // txtNotBasligi
            // 
            this.txtNotBasligi.Location = new System.Drawing.Point(143, 42);
            this.txtNotBasligi.Multiline = true;
            this.txtNotBasligi.Name = "txtNotBasligi";
            this.txtNotBasligi.Size = new System.Drawing.Size(219, 275);
            this.txtNotBasligi.TabIndex = 1;
            this.txtNotBasligi.TextChanged += new System.EventHandler(this.txtNotBasligi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalan \r\nKarakter \r\nSayısı:";
            // 
            // lblKalanKarakter
            // 
            this.lblKalanKarakter.AutoSize = true;
            this.lblKalanKarakter.Location = new System.Drawing.Point(27, 174);
            this.lblKalanKarakter.Name = "lblKalanKarakter";
            this.lblKalanKarakter.Size = new System.Drawing.Size(48, 25);
            this.lblKalanKarakter.TabIndex = 0;
            this.lblKalanKarakter.Text = "140";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Ödev",
            "Sınav",
            "Proje",
            "Diğer"});
            this.cmbKategori.Location = new System.Drawing.Point(32, 272);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(105, 33);
            this.cmbKategori.TabIndex = 3;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 329);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotBasligi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKalanKarakter);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtNotBasligi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKalanKarakter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKategori;
    }
}