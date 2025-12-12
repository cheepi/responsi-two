using Microsoft.VisualBasic.Logging;
using Npgsql;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace responsi_two
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=5432; Username=cheepi;Password=pw; Database=DevTrack";
        public DataTable dt;
        public static NpgsqlCommand? cmd;
        private string sql = null;
        private DataGridViewRow r;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "select * from st_insert(:_name, :_alamat, :_no_handphone)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nama_dev", nama_dev.Text);
                cmd.Parameters.AddWithValue("nama_proyek", nama_proyek.Text);
                cmd.Parameters.AddWithValue("status_kontrak", status_kontrak.Text);
                cmd.Parameters.AddWithValue("fitur_selesai", fitur_selesai.Text);
                cmd.Parameters.AddWithValue("jumlah_bug", jumlah_bug.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    //btnLoaddata.PerformClick();
                    nama_dev.Text = nama_proyek.Text = status_kontrak.Text = fitur_selesai.Text = jumlah_bug.Text = null;
                }
                else
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.Open();
                dataGridView1.DataSource = null;
                sql = @"select * from get_data";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}



   