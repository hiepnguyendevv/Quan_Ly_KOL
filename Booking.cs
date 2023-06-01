using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTk
{

    public partial class Booking : Form
    {
        public static Booking instance;
        public DataGridView tableData;
        public int index_TTKOL;
        int index = -1;
        public Booking()
        {
            InitializeComponent();
            instance = this;
            tableData = dataGridView_DsKOL;
            
        }
        Modify modify = new Modify();
        private void Form2_Load(object sender, EventArgs e)
        {
            string query = "select * from KOL";
            dataGridView_DsKOL.DataSource =  modify.BindData(query);
            btnThongTin.Enabled = false;
            btnBooking.Enabled = false;
            
        }

        private void dataGridView_DsKOL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            FormTT_KOL tt_kol = new FormTT_KOL();

            FormTT_KOL.instance.lbMa.Text = dataGridView_DsKOL.Rows[index].Cells[0].Value.ToString();
            FormTT_KOL.instance.lbTenKOL.Text = dataGridView_DsKOL.Rows[index].Cells[1].Value.ToString();
            FormTT_KOL.instance.lbGt.Text = dataGridView_DsKOL.Rows[index].Cells[2].Value.ToString();
            FormTT_KOL.instance.lbNs.Text = dataGridView_DsKOL.Rows[index].Cells[3].Value.ToString();
            FormTT_KOL.instance.lbDc.Text = dataGridView_DsKOL.Rows[index].Cells[4].Value.ToString();
            FormTT_KOL.instance.lbSoDt.Text = dataGridView_DsKOL.Rows[index].Cells[5].Value.ToString();
            FormTT_KOL.instance.lbCoc.Text = dataGridView_DsKOL.Rows[index].Cells[6].Value.ToString();
            tt_kol.Show();
        }

        private void dataGridView_DsKOL_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormTT_KOL tt_kol = new FormTT_KOL();

            FormTT_KOL.instance.lbMa.Text = dataGridView_DsKOL.Rows[index].Cells[0].Value.ToString();
            FormTT_KOL.instance.lbTenKOL.Text = dataGridView_DsKOL.Rows[index].Cells[1].Value.ToString();
            FormTT_KOL.instance.lbGt.Text = dataGridView_DsKOL.Rows[index].Cells[2].Value.ToString();
            FormTT_KOL.instance.lbNs.Text = dataGridView_DsKOL.Rows[index].Cells[3].Value.ToString();
            FormTT_KOL.instance.lbDc.Text = dataGridView_DsKOL.Rows[index].Cells[4].Value.ToString();
            FormTT_KOL.instance.lbSoDt.Text = dataGridView_DsKOL.Rows[index].Cells[5].Value.ToString();
            FormTT_KOL.instance.lbCoc.Text = dataGridView_DsKOL.Rows[index].Cells[6].Value.ToString();
            tt_kol.Show();
        }

      

        private void dataGridView_DsKOL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView_DsKOL.CurrentCell.RowIndex;
            btnThongTin.Enabled = true;
            btnBooking.Enabled = true;

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {

        }
    }
}
