using Npgsql;
using System.Data;

namespace ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=;Database=responsijunpro";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;


        public Form1()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connString);
            loadKaryawan();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loadKaryawan()
        {
            try
            {
                conn.Open();

                sql = @"select karyawan.nama, departemen.nama_dep, jabatan.nama_jabatan, jabatan.salary, akun.nama as username, akun.saldo from karyawan
                        join departemen on departemen.id_dep = karyawan.id_dep 
                        join jabatan on jabatan.id_jabatan = karyawan.id_jabatan
                        join akun on akun.id_karyawan = karyawan.id_karyawan
                        ";

                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvKaryawan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void insertKaryawan(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from insert_karyawan(:_nama, :_id_dep, :_id_jabatan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", int.Parse(cbDepartemen.Items.ToString()));
                cmd.Parameters.AddWithValue("_id_jabatan", int.Parse(cbJabatan.Items.ToString()));


                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Karyawan inserted");
                }
                else
                {
                    throw new Exception("insert_karyawan function error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void cbDepartemen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
