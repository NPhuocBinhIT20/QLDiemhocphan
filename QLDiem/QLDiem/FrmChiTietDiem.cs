using QLDiem.BLL;
using QLDiem.DAL;
using QLDiem.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiem
{
    public partial class FrmChiTietDiem : Form
    {
        public FrmChiTietDiem()
        {
            InitializeComponent();

            this.Text = "Thêm sinh viên";
            lbchucnang.Text = "Thêm sinh viên";
            btnxacnhan.Text = "Thêm";
            cmhocphan.DataSource = HocPhanBLL.GetList();
            cmhocphan.DisplayMember = "TenHocPhan";
            txtmasv.Enabled = true;
        }

        private void FrmChiTietDiem_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        SinhVienVM SvVM;
        public FrmChiTietDiem(SinhVienVM sinhVienVM) : this ()
        {
            this.SvVM = sinhVienVM;
            if (sinhVienVM != null) { 
                this.Text = "Cập nhật sinh viên";
                lbchucnang.Text = "Cập nhật sinh viên";
                btnxacnhan.Text = "Lưu";
                txtmasv.Enabled = false;
                txtmasv.Text = SvVM.IDStudent;
                txthoten.Text = SvVM.FullName;
                txtdiemcc.Text = SvVM.DiemCC;
                txtdiemkt.Text = SvVM.DiemKT;
                txtdiemthi.Text = SvVM.DiemThi;
            }
        }  

        private void btnxacnhan_Click_1(object sender, EventArgs e)
        {
            var masv = txtmasv.Text;
            if (String.IsNullOrEmpty(masv))
            {
                errorProvider1.SetError(txtmasv, "Mã sinh viên không được để trống");
                return;
            }

            var hoten = txthoten.Text;
            if (String.IsNullOrEmpty(hoten))
            {
                errorProvider1.SetError(txthoten, "Họ và tên không được để trống");
                return;
            }
            var diemcc = txtdiemcc.Text;
            if (String.IsNullOrEmpty(diemcc))
            {
                errorProvider1.SetError(txtdiemcc, "Điểm cc không được để trống");
                return;
            }
            var diemkt = txtdiemkt.Text;
            if (String.IsNullOrEmpty(diemkt))
            {
                errorProvider1.SetError(txtdiemkt, "Điểm kt không được để trống");
                return;
            }
            var diemthi = txtdiemthi.Text;
            if (String.IsNullOrEmpty(diemthi))
            {
                errorProvider1.SetError(txtdiemthi, "Điểm thi không được để trống");
                return;
            }
            var hocphan = cmhocphan.SelectedItem as HocPhan;
            var rs = KetQua.ThanhCong;
            if (SvVM == null)
            {
                rs = SinhVienBLL.insertsinhvien(new SinhVienVM
                {
                    IDStudent = masv,
                    FullName = hoten,
                    DiemCC = diemcc,
                    DiemKT = diemkt,
                    DiemThi = diemthi,
                    IDHocPhan = hocphan.ID
                });
            }
            else
            {
                SvVM.IDStudent = masv;
                SvVM.FullName = hoten;
                SvVM.DiemCC = diemcc;
                SvVM.DiemKT = diemkt;
                SvVM.DiemThi = diemthi;
                SvVM.IDHocPhan = hocphan.ID;
                rs = SinhVienBLL.UpdateSinhVien(SvVM);
                if (rs == KetQua.ThanhCong)
                    DialogResult = DialogResult.OK;
                if (rs == KetQua.Trungmasv)
                    MessageBox.Show("mã sinh viên không được trùng nhau");
            }
        }

        private void btntrove_Click_1(object sender, EventArgs e)
        {
            new FrmChiTietDiem();
            this.Close();
        }
    }
}
