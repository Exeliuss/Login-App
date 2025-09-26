using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
        private Button btnKayit;
        private Button btnIptal;
        private CheckBox chkGoster;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            txtKullanici = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            btnKayit = new Button();
            btnIptal = new Button();
            chkGoster = new CheckBox();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(580, 113);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(205, 34);
            txtKullanici.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(580, 155);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(205, 34);
            txtSifre.TabIndex = 4;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(580, 197);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(205, 34);
            txtSifreTekrar.TabIndex = 5;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(565, 272);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(100, 38);
            btnKayit.TabIndex = 7;
            btnKayit.Text = "Kayıt Ol";
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(685, 272);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 38);
            btnIptal.TabIndex = 8;
            btnIptal.Text = "İptal";
            // 
            // chkGoster
            // 
            chkGoster.AutoSize = true;
            chkGoster.Location = new Point(601, 234);
            chkGoster.Name = "chkGoster";
            chkGoster.Size = new Size(151, 32);
            chkGoster.TabIndex = 6;
            chkGoster.Text = "Şifreyi Göster";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(445, 116);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(129, 28);
            lbl1.TabIndex = 0;
            lbl1.Text = "Kullanıcı Adı :";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(445, 158);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(60, 28);
            lbl2.TabIndex = 1;
            lbl2.Text = "Şifre :";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(445, 200);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(129, 28);
            lbl3.TabIndex = 2;
            lbl3.Text = "Şifre (Tekrar) :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-8, -18);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 487);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(926, 454);
            Controls.Add(panel1);
            Controls.Add(lbl1);
            Controls.Add(lbl2);
            Controls.Add(lbl3);
            Controls.Add(txtKullanici);
            Controls.Add(txtSifre);
            Controls.Add(txtSifreTekrar);
            Controls.Add(chkGoster);
            Controls.Add(btnKayit);
            Controls.Add(btnIptal);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kayıt Ol";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
