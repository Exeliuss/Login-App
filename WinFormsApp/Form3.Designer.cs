using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtKullanici;
        private Button btnGoster;
        private Button btnKapat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            txtKullanici = new TextBox();
            btnGoster = new Button();
            btnKapat = new Button();
            lbl = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtKullanici
            // 
            txtKullanici.Font = new Font("Segoe UI", 12F);
            txtKullanici.Location = new Point(695, 161);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(193, 34);
            txtKullanici.TabIndex = 1;
            // 
            // btnGoster
            // 
            btnGoster.Font = new Font("Segoe UI", 12F);
            btnGoster.Location = new Point(672, 203);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(120, 43);
            btnGoster.TabIndex = 2;
            btnGoster.Text = "Şifreyi Göster";
            // 
            // btnKapat
            // 
            btnKapat.Font = new Font("Segoe UI", 12F);
            btnKapat.Location = new Point(798, 203);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(90, 43);
            btnKapat.TabIndex = 3;
            btnKapat.Text = "Kapat";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F);
            lbl.Location = new Point(560, 164);
            lbl.Name = "lbl";
            lbl.Size = new Size(129, 28);
            lbl.TabIndex = 0;
            lbl.Text = "Kullanıcı Adı :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-9, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 509);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(940, 439);
            Controls.Add(panel1);
            Controls.Add(lbl);
            Controls.Add(txtKullanici);
            Controls.Add(btnGoster);
            Controls.Add(btnKapat);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Şifremi Unuttum";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lbl;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
