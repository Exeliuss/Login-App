using LoginSample;
using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        // Bu formun kendi SQLite yard�mc�lar� (yaln�zca giri� i�in gerekenler)
        private static readonly string DbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login.db");
        private static readonly string ConnStr = "Data Source=" + DbPath;

        public Form1()
        {
            InitializeComponent();

            EnsureCreated(); // tablo yoksa olu�tur

            this.AcceptButton = button1; // Giri�
            this.CancelButton = button2; // ��k��

            textBox2.UseSystemPasswordChar = true;

            // Olas� �ift ba�lamay� �nlemek i�in �nce ��kar, sonra ekle
            this.checkBox1.CheckedChanged -= chkSifreyiGoster_CheckedChanged;
            this.checkBox1.CheckedChanged += chkSifreyiGoster_CheckedChanged;

            this.button1.Click -= btnGiris_Click;
            this.button1.Click += btnGiris_Click;

            this.button2.Click -= btnCikis_Click;
            this.button2.Click += btnCikis_Click;

            this.linkLabel1.LinkClicked -= lnkKayitOl_LinkClicked;
            this.linkLabel1.LinkClicked += lnkKayitOl_LinkClicked;

            this.linkLabel2.LinkClicked -= lnkSifreUnut_LinkClicked;
            this.linkLabel2.LinkClicked += lnkSifreUnut_LinkClicked;

            this.Load -= Form1_Load;
            this.Load += Form1_Load;
        }

        // --- SQLite yard�mc�lar� (sadece Form1'de kullan�lanlar) ---
        private static void EnsureCreated()
        {
            using (var con = new SqliteConnection(ConnStr))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText =
                        "CREATE TABLE IF NOT EXISTS Users(" +
                        "username TEXT PRIMARY KEY," +
                        "password TEXT NOT NULL);";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static bool ValidateUser(string username, string password)
        {
            using (var con = new SqliteConnection(ConnStr))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(1) FROM Users WHERE username=@u AND password=@p";
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        // -----------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e) => textBox1.Focus();

        private void chkSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim();
            string pass = textBox2.Text;

            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Kullan�c� ad� bo� olamaz.", "Uyar�",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("�ifre bo� olamaz.", "Uyar�",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (ValidateUser(user, pass))
            {
                MessageBox.Show("Giri� ba�ar�l�!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // �rn: new AnaForm().Show(); this.Hide();
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.SelectAll();
                textBox2.Focus();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e) => Application.Exit();

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var f = new Form2()) f.ShowDialog(this);
        }

        private void lnkSifreUnut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var f = new Form3()) f.ShowDialog(this);
        }
    }
}
