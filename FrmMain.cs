using Microsoft.Data.SqlClient;

namespace WFA240207
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMainLoad;
        }

        private void FrmMainLoad(object? sender, EventArgs e)
        {
            using SqlConnection connection = new(Program.connectionString);
            connection.Open();

            SqlCommand command = new(
                "SELECT ev, nev FROM kituntetes " +
                "INNER JOIN szemely " +
                "ON kituntetes.szemelyID = szemely.ID " +
                "ORDER BY ev DESC, nev ASC;", connection);

            SqlDataReader reader = command.ExecuteReader();


            int index = 0;
            while (reader.Read())
            {
                int ev = reader.GetInt32(0);
                dgvDijazottak.Rows.Add(ev, reader[1]);

                if (ev % 2 == 0)
                {
                    dgvDijazottak.Rows[index].DefaultCellStyle.BackColor
                        = Color.LightCoral;
                }
                index++;
            }

        }
    }
}
