using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Button button1;     // Giriş
        private Button button2;     // Çıkış
        private TextBox textBox1;   // Kullanıcı
        private TextBox textBox2;   // Şifre
        private CheckBox checkBox1; // Şifreyi Göster
        private Label label1;       // Kullanıcı Adı :
        private Label label2;       // Şifre :
        private Panel panel1;       // Sol panel (mavi)
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1; // Kayıt Ol
        private LinkLabel linkLabel2; // Şifreni Mi Unuttun ?

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(663, 261);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 2;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(538, 261);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 3;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(540, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 34);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(540, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 34);
            textBox1.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(556, 204);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(151, 32);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Şifreyi Göster";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(378, 159);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 7;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(366, 113);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adı :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 487);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.Location = new Point(428, 396);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(81, 28);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt Ol";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F);
            linkLabel2.Location = new Point(704, 396);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(186, 28);
            linkLabel2.TabIndex = 0;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Şifreni Mi Unuttun ?";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(928, 478);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
