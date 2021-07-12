using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrungTamTinHoc.Utils;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.DAO;

namespace TrungTamTinHoc.UI
{
	public partial class TrangChu_QuanLy : Form
	{
		BeginForm frm = new BeginForm();
		public TrangChu_QuanLy(BeginForm form)
		{
			InitializeComponent();
			frm = form;
		}

		private void TrangChu_QuanLy_Load(object sender, EventArgs e)
		{
			button1.Text = user.nv.TenNhanVien;
		}

		private void TrangChu_QuanLy_FormClosing(object sender, FormClosingEventArgs e)
		{
			frm.Show();
		}

		private void btn_qlnhanvien_Click(object sender, EventArgs e)
		{
			#region màu button
			btn_qlnhanvien.BackColor = Color.SkyBlue;
			btn_qlluong.BackColor = Color.Gray;
			btn_qlhocphi.BackColor = Color.Gray;
			btn_qlcanhan.BackColor = Color.Gray;
			#endregion
			tabControl1.SelectedTab = tab_NhanVien;
			#region select loại nhân viên
			if (cmb_NVchucvu.Items.Count <= 0)
			{
				DataTable dt = DataBase.SelectQuery("select * from LoaiNhanVien");
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenLoaiNhanVien"]);
					item.value = dr["MaLoaiNhanVien"];
					cmb_NVchucvu.Items.Add(item);
				}
			}
			if (cmb_NVloaiNV.Items.Count <= 0)
			{
				DataTable dt = DataBase.SelectQuery("select * from LoaiNhanVien");
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenLoaiNhanVien"]);
					item.value = dr["MaLoaiNhanVien"];
					cmb_NVloaiNV.Items.Add(item);
				}
				ComboBoxItem i = new ComboBoxItem();
				i.text = "tất cả";
				i.value = "";
				cmb_NVloaiNV.Items.Add(i);
			}
			#endregion
		}

		private void btn_qlluong_Click(object sender, EventArgs e)
		{

			#region màu button
			btn_qlnhanvien.BackColor = Color.Gray;
			btn_qlluong.BackColor = Color.SkyBlue;
			btn_qlhocphi.BackColor = Color.Gray;
			btn_qlcanhan.BackColor = Color.Gray;
			#endregion
			tabControl1.SelectedTab = tab_TinhLuong;
		}

		private void btn_qlhocphi_Click(object sender, EventArgs e)
		{

			#region màu button
			btn_qlnhanvien.BackColor = Color.Gray;
			btn_qlluong.BackColor = Color.Gray;
			btn_qlhocphi.BackColor = Color.SkyBlue;
			btn_qlcanhan.BackColor = Color.Gray;
			#endregion
			tabControl1.SelectedTab = tab_ThongKe;
		}

		private void btn_qlcanhan_Click(object sender, EventArgs e)
		{

			#region màu button
			btn_qlnhanvien.BackColor = Color.Gray;
			btn_qlluong.BackColor = Color.Gray;
			btn_qlhocphi.BackColor = Color.Gray;
			btn_qlcanhan.BackColor = Color.SkyBlue;
			#endregion
			tabControl1.SelectedTab = tab_CaNhan;
		}

		private void cmb_NVloaiNV_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			if ((cmb_NVloaiNV.SelectedItem as ComboBoxItem).value.ToString() != "")
			{
				dt = DataBase.SelectQuery("SELECT [MaNhanVien],[MaLoaiNhanVien],[TenNhanVien],[NgaySinh],[GioiTinh],[CMND],[SDT],[Email],[TinhTrang],[Luong] FROM [TrungTamTinHoc].[dbo].[NhanVien] where TinhTrang=1 and MaLoaiNhanVien=" + (cmb_NVloaiNV.SelectedItem as ComboBoxItem).value.ToString());
			}
			else
				dt = DataBase.SelectQuery("SELECT [MaNhanVien],[MaLoaiNhanVien],[TenNhanVien],[NgaySinh],[GioiTinh],[CMND],[SDT],[Email],[TinhTrang],[Luong] FROM [TrungTamTinHoc].[dbo].[NhanVien] where TinhTrang=1");
			dtg_NVthongtin.DataSource = dt;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				NhanVienDto dto = new NhanVienDto();
				dto.LoaiNhanVien = Convert.ToInt32((cmb_NVchucvu.SelectedItem as ComboBoxItem).value);
				dto.TenNhanVien = txt_NVhoten.Text.Trim();
				dto.NgaySinh = dtp_NVngaysinh.Text.Trim();
				dto.Sdt = txt_NVsdt.Text.Trim();
				dto.TinhTrang = true;
				dto.Luong = Convert.ToInt32(txt_nvluong.Text.Trim());
				dto.GioiTinh = rad_nam.Checked;
				dto.MatKhau = UtilsUI.randomstring();
				dto.Email = txt_NVemail.Text.Trim();
				dto.Cmnd = txt_NVcmnd.Text.Trim();
				string loi = null;
				if (UtilsUI.CheckNhanVien(dto, ref loi))
				{
					NhanVienDao.Insert(dto);
				}
				else
				{
					MessageBox.Show("Error: " + loi);
					return;
				}
				MessageBox.Show("Đã thêm nhân viên thành công");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void dtg_NVthongtin_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lab_XoaNV.DataBindings.Clear();
			lab_XoaNV.DataBindings.Add("Text", dtg_NVthongtin.DataSource, "MaNhanVien");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase.ExcuteQuery("update NhanVien set TinhTrang=0 where MaNhanVien=" + lab_XoaNV.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = DataBase.SelectQuery("select MaNhanVien,TenNhanVien,Luong from NhanVien");
				dtg_LuongNV.DataSource = dt;
				int tong = 0;
				foreach (DataRow dr in dt.Rows)
				{
					tong += Convert.ToInt32(dr["Luong"]);
				}
				lab_tongluong.Text = "tổng: " + tong.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dtg_LuongNV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_LuongMaNV.DataBindings.Clear();
			txt_LuongMaNV.DataBindings.Add("Text", dtg_LuongNV.DataSource, "MaNhanVien");
			txt_LuongTenNV.DataBindings.Clear();
			txt_LuongTenNV.DataBindings.Add("Text", dtg_LuongNV.DataSource, "TenNhanVien");
			txt_Luong.DataBindings.Clear();
			txt_Luong.DataBindings.Add("Text", dtg_LuongNV.DataSource, "Luong");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase.ExcuteQuery("update NhanVien set Luong=" + txt_Luong.Text + " where MaNhanVien=" + txt_LuongMaNV.Text);
				DataTable dt = DataBase.SelectQuery("select MaNhanVien,TenNhanVien,Luong from NhanVien");
				dtg_LuongNV.DataSource = dt;
				int tong = 0;
				foreach (DataRow dr in dt.Rows)
				{
					tong += Convert.ToInt32(dr["Luong"]);
				}
				lab_tongluong.Text = "tổng: " + tong.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
