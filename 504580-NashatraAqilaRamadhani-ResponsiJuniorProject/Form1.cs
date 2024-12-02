using Npgsql;
using System.Data;

namespace _504580_NashatraAqilaRamadhani_ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=5432; Username=postgres; Database = responsi";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow row;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "select * from st_insert(:_id, _name, _id_departemen)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", row.Cells["_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_name", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_departemen", cbDepartemen.Text);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                MessageBox.Show("Mohon pilih baris yang akan diedit", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "select * from st_edit(:_id, :_name, :_id_departemen)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", row.Cells["_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_name", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_departemen", cbDepartemen.Text);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvData.Rows[e.RowIndex];
                tbNama.Text = r.Cells["_name"].Value.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah Anda Ingin Menghapus data " + row.Cells["_name"].Value.ToString() + "?", "Hapus data terkonfirmasi", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn = new NpgsqlConnection(connstring);
                    conn.Open();
                    sql = "select * from st_delete(:_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", row.Cells["_id"].Value.ToString());
                    if((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data karyawan berhasil dihapus", "well done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        row = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
