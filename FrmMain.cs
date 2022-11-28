using Microsoft.Data.SqlClient;
using WFA221128.Properties;

namespace WFA221128
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void DgvReLoad()
        {
            dgv.Rows.Clear();
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            SqlDataReader rdr = new SqlCommand(
                "SELECT * FROM emberek;",
                conn).ExecuteReader();

            while (rdr.Read())
            {
                dgv.Rows.Add(
                    rdr[0],
                    rdr[1],
                    rdr.GetBoolean(2) ? "f�rfi" : "n�",
                    rdr.GetDateTime(3).ToString("yyyy. MMM dd."));
            }
        }

        private void FrmMain_Load(object sender, EventArgs e) => DgvReLoad();

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNev.Text))
            {
                _ = MessageBox.Show(
                    caption: "HIBA",
                    text: "A 'n�v' mez� kit�lt�se k�telez�!",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
            else
            {
                string nev = tbNev.Text;
                string nem = rbFF.Checked ? "1" : "0";
                string szul = dtpSzul.Value.ToString("yyyy-MM-dd");

                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();

                SqlDataAdapter sda = new()
                {
                    InsertCommand = new SqlCommand(
                        cmdText: "INSERT INTO emberek VALUES " +
                        $"('{nev}', {nem}, '{szul}');",
                        connection: conn),
                };
                sda.InsertCommand.ExecuteNonQuery();

                ///m�k�dik, de nem biztons�gos:
                //_ = new SqlCommand("<SQL utas�t�s>", conn).ExecuteNonQuery();
                DgvReLoad();
            }



        }
    }
}