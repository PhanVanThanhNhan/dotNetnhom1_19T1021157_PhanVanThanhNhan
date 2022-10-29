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
    public partial class frmLienLac : Form
    {
        
        LienLacViewModel lienLac;
        public frmLienLac(LienLacViewModel lienLac=null)
        {
            InitializeComponent();
            NapDsNhom();
            this.lienLac = lienLac;
            if (lienLac != null)
            {
                cbbTenNhom.SelectedValue = lienLac.ID;
                txtTenLienLac.Text = lienLac.Ten;
                txtDiaChi.Text=lienLac.DiaChi;
                txtEmail.Text=lienLac.Email;
                txtSđt.Text = lienLac.Sdt;
            }
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return cbbTenNhom.SelectedItem as NhomViewModel;
            }
        }
        void NapDsNhom()
        {
            var ls = NhomServices.GetList();
            cbbTenNhom.DataSource = ls;
            cbbTenNhom.ValueMember = "ID";
            cbbTenNhom.DisplayMember = "TenNhom";
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (this.lienLac == null)
            {
                #region thêm mới Liên lạc
                var ll = new LienLac
                {
                    Ten = txtTenLienLac.Text,
                    IDNhom = selectedNhom.ID,
                    DiaChi = txtDiaChi.Text,
                    Email = txtEmail.Text,
                    Sdt = txtSđt.Text,
                };
                if (LienLacServices.AddLienLac(ll) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                #endregion
            }
            /*else
            {
                #region Cập nhật thông tin liên lạc
                lienLac.Email = txtEmail.Text;
                lienLac.Ten = txtTenLienLac.Text;
                lienLac.Sdt = txtSđt.Text;
                lienLac.IDNhom = selectedNhom.ID;
                LienLacServices.UpdateLienLac(lienLac);
                DialogResult = DialogResult.OK;
                #endregion
            }*/
        }

        private void btnDongY_Click_1(object sender, EventArgs e)
        {
            if(this.lienLac == null)
            {
                var ll = new LienLac
                {
                    Ten=txtTenLienLac.Text,
                    DiaChi=txtDiaChi.Text,
                    Email = txtEmail.Text,
                    IDNhom=selectedNhom.ID,
                    Sdt=txtSđt.Text,
                };
                if (LienLacServices.AddLienLac(ll) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
