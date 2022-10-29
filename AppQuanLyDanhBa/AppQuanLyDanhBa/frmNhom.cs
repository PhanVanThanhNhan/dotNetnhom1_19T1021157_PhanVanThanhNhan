using AppQuanLyDanhBa.Model;
using AppQuanLyDanhBa.Services;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppQuanLyDanhBa.ViewModel.LienLacViewModel;

namespace AppQuanLyDanhBa
{
    public partial class frmNhom : Form
    {
        NhomViewModel nhom;
        public frmNhom(NhomViewModel nhom = null)
        {
            InitializeComponent();
            this.nhom = nhom;
            if(nhom != null)
            {
                txtTenNhom.Text = nhom.TenNhom;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (nhom == null)
            {
                #region Thêm Nhóm
                var l = new Nhom
                {
                    TenNhom = txtTenNhom.Text
                };
                if (NhomServices.AddNhom(l) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Nhóm đã tồn tại", "Thông báo");
                    txtTenNhom.Focus();
                }
                #endregion
            }
        }
    }
}
