using Microsoft.Data.SqlClient;
using WFA221128.Properties;

namespace WFA221128
{
    public partial class FrmMain : Form
    {
        private int selectedId = -1;

        public FrmMain() => InitializeComponent();

        private void DgvReLoad()
        {
            ClearFields();
            string where = " WHERE DATEADD(year, -18, GETDATE()) >= szul";

            dgv.Rows.Clear();
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            SqlDataReader rdr = new SqlCommand(
                "SELECT * FROM emberek" +
                $"{(cbNagykoru.Checked ? where : null)};",
                conn).ExecuteReader();

            while (rdr.Read())
                dgv.Rows.Add(
                    rdr[0],
                    rdr[1],
                    rdr.GetBoolean(2) ? "férfi" : "nõ",
                    rdr.GetDateTime(3).ToString("yyyy. MMMM dd."));
            dgv.ClearSelection();
        }

        private void FrmMain_Load(object sender, EventArgs e) => DgvReLoad();

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (KiVanToltve(tbNevInsert.Text))
            {
                string nev = tbNevInsert.Text;
                string nem = rbFFInsert.Checked ? "1" : "0";
                string szul = dtpSzulInsert.Value.ToString("yyyy-MM-dd");

                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();

                SqlDataAdapter sda = new()
                {
                    InsertCommand = new(
                        cmdText: "INSERT INTO emberek VALUES " +
                        $"('{nev}', {nem}, '{szul}');",
                        connection: conn),
                };
                sda.InsertCommand.ExecuteNonQuery();

                ///mûködik, de nem biztonságos:
                //_ = new SqlCommand("<SQL utasítás>", conn).ExecuteNonQuery();
                DgvReLoad();
            }
        }

        private void ClearFields()
        {
            tbNevInsert.Text = null;
            tbNevUpdate.Text = null;
            rbFFInsert.Checked = true;
            rbFFUpdate.Checked = true;
            dtpSzulInsert.Value = DateTime.Now;
            dtpSzulUpdate.Value = DateTime.Now;
            selectedId = -1;
            //cbNagykoru.Checked = false;
        }

        private void CbNagykoru_CheckedChanged(object sender, EventArgs e) => DgvReLoad();

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (KiVanToltve(tbNevUpdate.Text))
            {
                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();

                SqlDataAdapter sda = new()
                {
                    UpdateCommand = new(
                        cmdText: "UPDATE emberek SET " +
                        $"nev = '{tbNevUpdate.Text}', " +
                        $"nem = {(rbFFUpdate.Checked ? 1 : 0)}, " +
                        $"szul = '{dtpSzulUpdate.Value.ToString("yyyy-MM-dd")}' " +
                        $"WHERE id = {selectedId};",
                        connection: conn),
                };
                sda.UpdateCommand.ExecuteNonQuery();
                DgvReLoad();
            }
        }

        private bool KiVanToltve(string mezo)
        {
            if (string.IsNullOrWhiteSpace(mezo))
            {
                _ = MessageBox.Show(
                   caption: "HIBA",
                   text: "A 'név' mezõ kitöltése kötelezõ!",
                   buttons: MessageBoxButtons.OK,
                   icon: MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = (int)dgv[0, e.RowIndex].Value;
            tbNevUpdate.Text = $"{dgv[1, e.RowIndex].Value}";
            rbFFUpdate.Checked = $"{dgv[2, e.RowIndex].Value}" == "férfi";
            rbNOUpdate.Checked = !rbFFUpdate.Checked;
            dtpSzulUpdate.Value = DateTime.Parse($"{dgv[3, e.RowIndex].Value}");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                caption: "MEGERÕSÍTÉS",
                text: "Biztos, hogy törölni kívánod a kijelölt rekordot?",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();

                SqlDataAdapter sda = new()
                {
                    DeleteCommand = new(
                        $"DELETE FROM emberek WHERE " +
                        $"id = {selectedId};", conn),
                };
                sda.DeleteCommand.ExecuteNonQuery();
                DgvReLoad();
            }
        }
    }
}