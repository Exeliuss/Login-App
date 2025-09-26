using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        private static readonly string DbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login.db");
        private static readonly string ConnStr = "Data Source=" + DbPath;

        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = btnKayit;
            this.CancelButton = btnIptal;

            txtSifre.UseSystemPasswordChar = true;
            txtSifreTekrar.UseSystemPasswordChar = true;

            chkGoster.CheckedChanged -= (s, e) => { };
            chkGoster.CheckedChanged += (s, e) =>
            {
                bool show = chkGoster.Checked;
                txtSifre.UseSystemPasswordChar = !show;
                txtSifreTekrar.UseSystemPasswordChar = !show;
            };

            btnKayit.Click -= btnKayit_Click;
            btnKayit.Click += btnKayit_Click;

            btnIptal.Click -= btnIptal_Click;
            btnIptal.Click += btnIptal_Click;
        }

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

        private static bool UserExists(string u)
        {
            using (var con = new SqliteConnection(ConnStr))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(1) FROM Users WHERE username=@u";
                    cmd.Parameters.AddWithValue("@u", u);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        private static void AddUser(string u, string p)
        {
            using (var con = new SqliteConnection(ConnStr))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Users(username,password) VALUES(@u,@p)";
                    cmd.Parameters.AddWithValue("@u", u);
                    cmd.Parameters.AddWithValue("@p", p);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            EnsureCreated();

            var u = txtKullanici.Text.Trim();
            var p1 = txtSifre.Text;
            var p2 = txtSifreTekrar.Text;

            if (string.IsNullOrWhiteSpace(u) || string.IsNullOrWhiteSpace(p1) || string.IsNullOrWhiteSpace(p2))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (p1 != p2)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserExists(u))
            {
                MessageBox.Show("Bu kullanıcı adı zaten kayıtlı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddUser(u, p1);
            MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e) => Close();

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
