using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace WinFormsApp
{
    public partial class Form3 : Form
    {
        private static readonly string DbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login.db");
        private static readonly string ConnStr = "Data Source=" + DbPath;

        public Form3()
        {
            InitializeComponent();
            this.AcceptButton = btnGoster;
            this.CancelButton = btnKapat;

            btnGoster.Click -= btnGoster_Click;
            btnGoster.Click += btnGoster_Click;

            btnKapat.Click -= btnKapat_Click;
            btnKapat.Click += btnKapat_Click;
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

        private static string GetPassword(string u)
        {
            using (var con = new SqliteConnection(ConnStr))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT password FROM Users WHERE username=@u LIMIT 1";
                    cmd.Parameters.AddWithValue("@u", u);
                    object obj = cmd.ExecuteScalar();
                    return obj == null || obj == DBNull.Value ? null : Convert.ToString(obj);
                }
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            EnsureCreated();

            var u = txtKullanici.Text.Trim();
            if (string.IsNullOrWhiteSpace(u))
            {
                MessageBox.Show("Kullanıcı adını girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pwd = GetPassword(u);
            if (pwd == null)
                MessageBox.Show("Kullanıcı bulunamadı.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Kayıtlı şifreniz: " + pwd, "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKapat_Click(object sender, EventArgs e) => Close();
    }
}
