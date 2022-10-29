using AppQuanLyDanhBa.Services;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyDanhBa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsNhom();
            NapDsLienLac();
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return nhomViewModelBindingSource.Current as NhomViewModel;
            }
        }
        public LienLacViewModel selectedLienLac
        {
            get
            {
                return lienLacViewModelBindingSource.Current as LienLacViewModel;
            }
        }
        void NapDsNhom()
        {
            var ls = NhomServices.GetList();
            nhomViewModelBindingSource.DataSource = ls;
            gridNhom.DataSource = nhomViewModelBindingSource;
        }
        void NapDsLienLac()
        {
            if (selectedNhom != null)
            {
                var ls = LienLacServices.GetList(selectedNhom.ID);
                lienLacViewModelBindingSource.DataSource = ls;
                gridLienLac.DataSource = lienLacViewModelBindingSource;
            }
        }
        private void gridNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                NapDsLienLac();
            }

        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            var f = new frmNhom();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsNhom();
            }
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa!", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NhomServices.RemoveNhom(selectedNhom);
                    NapDsNhom();
                }
            }
        }

        private void btnThemLienLac_Click(object sender, EventArgs e)
        {
            var f = new frmLienLac();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsLienLac();
            }
        }

        private void btnXoaLienLac_Click(object sender, EventArgs e)
        {
            if (selectedLienLac != null)
            {
                var rs = MessageBox.Show("Bạn có chắc chắn xoá?", "Chú ý", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    LienLacServices.RemoveLienLac(selectedLienLac);
                    NapDsLienLac();
                }

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Đưa dữ liệu vào label
            txtName.Text = selectedLienLac.Ten;
            txtAddress.Text = selectedLienLac.DiaChi;
            txtEmail.Text = selectedLienLac.Email;
            txtPhone.Text = selectedLienLac.Sdt;


        }

        private void gridNhom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDsLienLac();
        }

        //Tìm kiếm liên lạc trong một nhóm
        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var ls = LienLacServices.FindLienLac(txtSearch.Text, selectedNhom);
                lienLacViewModelBindingSource.DataSource = ls;
                gridLienLac.DataSource = lienLacViewModelBindingSource;

            }
        }

    }
}
