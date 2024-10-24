using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Thư viện

namespace WF_TTNV
{
    public partial class frmTTNV : Form
    {
        public frmTTNV()
        {
            InitializeComponent();
        }

        //Nút thoát nè
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTTNV_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        //************************************
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;
        int donghh;
        DataTable bangnv = new DataTable();

        //Kết nối dữ liệu
        void KetNoiDuLieu()
        {
            ketnoi = new SqlConnection();
            string chuoiketnoi = "Data Source = .; Initial Catalog = QuanLyNhanVien_LT; Integrated Security = True";
            ketnoi.ConnectionString = chuoiketnoi;
        }

        //Load dữ liệu
        void LoadDuLieu()
        {
            KetNoiDuLieu();
            ketnoi.Open();
            string sql = "select * From NhanVien";
            bodocghi = new SqlDataAdapter(sql, ketnoi);
            bodocghi.Fill(bangnv);
            ketnoi.Close();
            dgvNhanVien.DataSource = bangnv;
        }

        //Hình như nút Thêm hereeee!
        private void btnThem_Click(object sender, EventArgs e)
        {
            //đk
            if(txtMaNV.Text != "" && txtHoTen.Text != "" && txtNamSinh.Text != "" && cmbGioiTinh.Text != "" && cmbDiaChi.Text != "" && txtDienThoai.Text != "")
            {
                ketnoi.Open();
                String sql = "insert into NhanVien Values('" + txtMaNV.Text + "', N'" + txtHoTen.Text + "', '" + txtNamSinh.Text + "',N'" + cmbGioiTinh.Text + "',N'" + cmbDiaChi.Text + "','" + txtDienThoai.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                ketnoi.Close();
                bangnv.Clear();
                LoadDuLieu();
            }
            else
            {
                if (txtMaNV.Text == "")
                {
                    DialogResult result = MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txtHoTen.Text == "")
                {
                    DialogResult result = MessageBox.Show("Vui lòng nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txtNamSinh.Text == "")
                {
                    DialogResult result = MessageBox.Show("Vui lòng nhập năm sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cmbGioiTinh.Text == "")
                {
                    DialogResult result = MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cmbDiaChi.Text == "")
                {
                    DialogResult result = MessageBox.Show("Vui lòng chọn địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txtDienThoai.Text == "")
                {
                    DialogResult result = MessageBox.Show("Vui lòng nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Xác định dòng được chọn
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;

            if (donghh >= 0)
            {
                txtMaNV.Text = bangnv.Rows[donghh]["MaNV"].ToString();
                txtHoTen.Text = bangnv.Rows[donghh]["HoTen"].ToString();
                txtNamSinh.Text = bangnv.Rows[donghh]["NamSinh"].ToString();
                cmbGioiTinh.Text = bangnv.Rows[donghh]["GioiTinh"].ToString();
                cmbDiaChi.Text = bangnv.Rows[donghh]["DiaChi"].ToString();
                txtDienThoai.Text = bangnv.Rows[donghh]["DienThoai"].ToString();

                //Khóa MaNV
                txtMaNV.Enabled = false;
            }
        }

        //Còn đây là xóa nè
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            String sql = "DELETE from NhanVien where MaNV = '"+txtMaNV.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            ketnoi.Close();
            bangnv.Clear();
            LoadDuLieu();
        }

        //Nút Sửa nè chaaa
        private void btnSua_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            String sql = "Update NhanVien set HoTen =N'" +txtHoTen.Text + "',NamSinh ='" + txtNamSinh.Text + "',GioiTinh = N'"+cmbGioiTinh.Text+"',DiaChi = N'"+ cmbDiaChi.Text + "',DienThoai='" + txtDienThoai.Text+ "'Where MaNV='" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            ketnoi.Close();
            bangnv.Clear();
            LoadDuLieu();
        }

        //Nút tìm mã nè
        private void btnTimMa_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            String sql = "select * from NhanVien where MaNV = '" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            String manv, ht, gt, dc, dt;
            int ns;

            if(dr.Read())
            {
                manv = dr["MaNV"].ToString();
                ht = dr["HoTen"].ToString();
                gt = dr["GioiTinh"].ToString();
                dc = dr["DiaChi"].ToString();
                dt = dr["DienThoai"].ToString();

                ns = (int)dr["NamSinh"];
                String msg = String.Format($"Mã NV: {manv} \nTên NV: {ht} \nGiới Tính: {gt} \nNăm Sinh: {ns} \nĐịa Chỉ: {dc} \nĐiện Thoại: {dt}");
                MessageBox.Show(msg, "Thông báo nè chaaa!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu nha chaaaa!");
            }
            ketnoi.Close();
        }

        //Đếm SL
        private void btnDemSL_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            String sql = "Select count(*) from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            int count = (int)cmd.ExecuteScalar();
            String msg = String.Format($"Số lượng nhân viên là: {count}");
            MessageBox.Show(msg, "Thông báo");
            ketnoi.Close();
        }

        //Tìm tên nè 
        private void btnTimTen_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            String sql = "Select * from NhanVien where HoTen like N'%" + txtHoTen.Text + "%'";
            bodocghi = new SqlDataAdapter(sql, ketnoi);
            bangnv.Clear();
            bodocghi.Fill(bangnv);
            ketnoi.Close();
            dgvNhanVien.DataSource = bangnv;
        }
    }

}
