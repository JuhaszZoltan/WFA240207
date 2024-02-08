using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA240207
{
    public partial class FrmReszletek : Form
    {
        public string Nev { get; set; }

        public FrmReszletek(string nev)
        {
            Nev = nev;
            InitializeComponent();

            this.Load += FrmReszletekLoad;
        }

        private void FrmReszletekLoad(object? sender, EventArgs e)
        {
            lblNev.Text = Nev;

            using SqlConnection connection = new(Program.connectionString);
            connection.Open();

            SqlDataReader reader = new SqlCommand(
                $"SELECT id FROM szemely WHERE nev = '{Nev}';",
                connection).ExecuteReader();
            reader.Read();
            int id = reader.GetInt32(0);
            reader.Close();

            reader = new SqlCommand(
                "SELECT megnevezes FROM foglalkozas " +
                $"WHERE szemelyId = {id} " +
                $"ORDER BY megnevezes ASC;",
                connection).ExecuteReader();
            lblFoglalkozasok.Text = string.Empty;
            while (reader.Read()) lblFoglalkozasok.Text += $"[*] {reader[0]}\n";
            reader.Close();

            reader = new SqlCommand(
                "SELECT ev FROM kituntetes " +
                $"WHERE szemelyId = {id} " +
                $"ORDER BY ev ASC;",
                connection).ExecuteReader();
            lblEvek.Text = string.Empty;
            while (reader.Read()) lblEvek.Text += $"{reader[0]}, ";
            lblEvek.Text = lblEvek.Text[..^2];
        }
    }
}
