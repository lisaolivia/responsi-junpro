using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace ResponsiJunpro_Olivia
{
    public partial class Form1 : Form
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=junpro_olivia;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProjects();
            LoadStatusKontrak();
            LoadData();
        }

        public void LoadProjects()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT id_proyek, nama_proyek FROM proyek ORDER BY id_proyek";


                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbPilihProyek.DataSource = dt;
                    cmbPilihProyek.DisplayMember = "nama_proyek";
                    cmbPilihProyek.ValueMember = "id_proyek";
                }
            }
        }

        public void LoadStatusKontrak()
        {
            cmbStatusKontrak.Items.Clear();
            cmbStatusKontrak.Items.Add("freelance");
            cmbStatusKontrak.Items.Add("full time");
            cmbStatusKontrak.SelectedIndex = 0;
        }

        public void LoadData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM kr_select_developer()";

                    using (var da = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT kr_insert_developer(@id_dev, @id_proyek, @nama_dev, @status_kontrak, @fitur_selesai, @jumlah_bug)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_dev", txtID.Text);
                        cmd.Parameters.AddWithValue("@id_proyek", cmbPilihProyek.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@nama_dev", txtNama.Text);
                        cmd.Parameters.AddWithValue("@status_kontrak", cmbStatusKontrak.Text);
                        cmd.Parameters.AddWithValue("@fitur_selesai", int.Parse(txtFiturSelesai.Text));
                        cmd.Parameters.AddWithValue("@jumlah_bug", int.Parse(txtJumlahBug.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data developer berhasil ditambahkan");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert error: " + ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih data terlebih dahulu!");
                    return;
                }

                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id_dev"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = $"SELECT update_developer(" +
                                   $"{id}," +
                                   $"'{txtNama.Text.Replace("'", "''")}'," +
                                   $"'{cmbPilihProyek.SelectedValue}'," +
                                   $"'{cmbStatusKontrak.Text}'," +
                                   $"{txtFiturSelesai.Text}," +
                                   $"{txtJumlahBug.Text})";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        int result = (int)cmd.ExecuteScalar();
                        MessageBox.Show(result == 1 ? "Data berhasil diupdate" : "Gagal update");
                    }
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih data terlebih dahulu!");
                    return;
                }

                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id_dev"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = $"SELECT delete_developer({id})";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        int result = (int)cmd.ExecuteScalar();
                        MessageBox.Show(result == 1 ? "Data terhapus" : "Gagal hapus");
                    }
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = dataGridView.Rows[e.RowIndex];

                    txtNama.Text = row.Cells["nama_dev"].Value.ToString();
                    cmbPilihProyek.SelectedValue = row.Cells["id_proyek"].Value;
                    cmbStatusKontrak.Text = row.Cells["status_kontrak"].Value.ToString();
                    txtFiturSelesai.Text = row.Cells["fitur_selesai"].Value.ToString();
                    txtJumlahBug.Text = row.Cells["jumlah_bug"].Value.ToString();
                }
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
