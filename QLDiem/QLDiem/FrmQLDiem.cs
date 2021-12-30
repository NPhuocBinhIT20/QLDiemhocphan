using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDiem.BLL;
using QLDiem.ViewModel;

namespace QLDiem
{
    public partial class FrmQLDiem : Form
    {
        public FrmQLDiem()
        {
            InitializeComponent();
            NapDiemhocPhan();        }
        void NapDiemhocPhan()
        {
            var ls = SinhVienBLL.GetListVM();
            sinhVienVMBindingSource.DataSource = ls;
            DTGSinhVien.DataSource = sinhVienVMBindingSource;
        }
        public SinhVienVM selectSinhVien
        {
            get
            {
                return sinhVienVMBindingSource.Current as SinhVienVM;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectSinhVien != null)
            {
                if (MessageBox.Show(
                    "Bạn có chắc muốn xóa ?"
                    , "Chú ý"
                    , MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SinhVienBLL.DeleteSinhVien(selectSinhVien.ID);
                    MessageBox.Show("Xóa thành công");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectSinhVien != null)
            {
                FrmChiTietDiem svct = new FrmChiTietDiem(selectSinhVien);
                if (svct.ShowDialog() == DialogResult.OK)
                    NapDiemhocPhan();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            FrmChiTietDiem svct = new FrmChiTietDiem();
            if (svct.ShowDialog() == DialogResult.OK)
                NapDiemhocPhan();
        }
    }
}
