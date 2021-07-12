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
	
	public partial class TrangChu_TiepTan : Form
	{
		public BeginForm frm;
		public TrangChu_TiepTan(BeginForm form1)
		{
			InitializeComponent();
			frm = form1;

		}

		private void btn_DangKyHocVien_MouseHover(object sender, EventArgs e)
		{
			btn_DangKyHocVien.BackColor = Color.SkyBlue;
		}

		private void TrangChu_TiepTan_Load(object sender, EventArgs e)
		{
			btn_TieuDe.Text = user.nv.TenNhanVien;
		}

		private void btn_DangKyHocVien_MouseLeave(object sender, EventArgs e)
		{
			btn_DangKyHocVien.BackColor = Color.Gray;
		}

		private void TrangChu_TiepTan_FormClosing(object sender, FormClosingEventArgs e)
		{
			frm.Show();
		}

		private void btn_ThuHocPhi_MouseHover(object sender, EventArgs e)
		{
			btn_ThuHocPhi.BackColor = Color.SkyBlue;
		}

		private void btn_ThuHocPhi_MouseLeave(object sender, EventArgs e)
		{
			btn_ThuHocPhi.BackColor = Color.Gray;
		}

		private void btn_XemDanhSachLop_MouseHover(object sender, EventArgs e)
		{
			btn_XemDanhSachLop.BackColor= Color.SkyBlue;
		}

		private void btn_XemDanhSachLop_MouseLeave(object sender, EventArgs e)
		{
			btn_XemDanhSachLop.BackColor = Color.Gray;
		}

		private void btn_DanhSachCTDT_MouseHover(object sender, EventArgs e)
		{
			btn_DanhSachCTDT.BackColor = Color.SkyBlue;
		}

		private void btn_HocVien_MouseHover(object sender, EventArgs e)
		{
			btn_HocVien.BackColor = Color.SkyBlue;
		}

		private void btn_DanhSachCTDT_MouseLeave(object sender, EventArgs e)
		{
			btn_DanhSachCTDT.BackColor = Color.Gray;
		}

		private void btn_HocVien_MouseLeave(object sender, EventArgs e)
		{
			btn_HocVien.BackColor = Color.Gray;
		}

		private void btn_CaNhan_MouseHover(object sender, EventArgs e)
		{
			btn_CaNhan.BackColor = Color.SkyBlue;
		}

		private void btn_CaNhan_MouseLeave(object sender, EventArgs e)
		{
			btn_CaNhan.BackColor = Color.Gray;
		}

		private void btn_ThuHocPhi_Click(object sender, EventArgs e)
		{
			#region màu button
			btn_DangKyHocVien.BackColor = Color.Gray;
			btn_CaNhan.BackColor = Color.Gray;
			btn_HocVien.BackColor = Color.Gray;
			btn_DanhSachCTDT.BackColor = Color.Gray;
			btn_XemDanhSachLop.BackColor = Color.Gray;
			btn_ThuHocPhi.BackColor = Color.SkyBlue;
			#endregion
			tabControl1.SelectedTab = tab_thuhocphi;
		}

		private void btn_DangKyHocVien_Click(object sender, EventArgs e)
		{
			#region màu button
			btn_DangKyHocVien.BackColor = Color.SkyBlue;
			btn_CaNhan.BackColor = Color.Gray;
			btn_HocVien.BackColor = Color.Gray;
			btn_DanhSachCTDT.BackColor = Color.Gray;
			btn_XemDanhSachLop.BackColor = Color.Gray;
			btn_ThuHocPhi.BackColor = Color.Gray;
			#endregion
			# region chương trình
			tabControl1.SelectedTab = Tab_dangkyhocvien;
			DataTable dt = DataBase.SelectQuery("select * from ChuongTrinhDaoTao");
			if (cmb_dkchuongtrinh.Items.Count <= 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenChuongTrinh"]);
					item.value = dr["MaChuongTrinh"];
					cmb_dkchuongtrinh.Items.Add(item);
				}
			}
			#endregion
			#region Lớp
			dt = new DataTable();
			DateTime d = DateTime.Now;
			int y = d.Year;
			string sql = "select * from Lop where NamHoc=" + y;
			dt = DataBase.SelectQuery(sql);
			foreach (DataRow dr in dt.Rows)
			{
				ComboBoxItem item = new ComboBoxItem();
				item.text = Convert.ToString(dr["TenLop"]);
				item.value = dr["MaLop"];
				cmb_DKlop.Items.Add(item);
			}

			#endregion
		}

		private void btn_XemDanhSachLop_Click(object sender, EventArgs e)
		{
			#region màu button
			btn_DangKyHocVien.BackColor = Color.Gray;
			btn_CaNhan.BackColor = Color.Gray;
			btn_HocVien.BackColor = Color.Gray;
			btn_DanhSachCTDT.BackColor = Color.Gray;
			btn_XemDanhSachLop.BackColor = Color.SkyBlue;
			btn_ThuHocPhi.BackColor = Color.Gray;
			#endregion
			tabControl1.SelectedTab = Tab_danhsachlop;
		}

		private void btn_DanhSachCTDT_Click(object sender, EventArgs e)
		{
			#region màu button
			btn_DangKyHocVien.BackColor = Color.Gray;
			btn_CaNhan.BackColor = Color.Gray;
			btn_HocVien.BackColor = Color.Gray;
			btn_DanhSachCTDT.BackColor = Color.SkyBlue;
			btn_XemDanhSachLop.BackColor = Color.Gray;
			btn_ThuHocPhi.BackColor = Color.Gray;
			#endregion
			tabControl1.SelectedTab = tab_ctdt;
			DataTable dt = DataBase.SelectQuery("Select * from ChuongTrinhDaoTao");
			if (cmb_DSCTDT.Items.Count <= 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenChuongTrinh"]);
					item.value = dr["MaChuongTrinh"];
					cmb_DSCTDT.Items.Add(item);
				}
				
			}
			dtg_DSCTDT.DataSource = dt;
		}

		private void btn_HocVien_Click(object sender, EventArgs e)
		{
			#region màu button
			btn_DangKyHocVien.BackColor = Color.Gray;
			btn_CaNhan.BackColor = Color.Gray;
			btn_HocVien.BackColor = Color.SkyBlue;
			btn_DanhSachCTDT.BackColor = Color.Gray;
			btn_XemDanhSachLop.BackColor = Color.Gray;
			btn_ThuHocPhi.BackColor = Color.Gray;
			#endregion
			tabControl1.SelectedTab = tab_hocvien;
			DataTable dt = DataBase.SelectQuery("Select * from ChuongTrinhDaoTao");
			if (cmb_tkCTDThocvien.Items.Count <= 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenChuongTrinh"]);
					item.value = dr["MaChuongTrinh"];
					cmb_tkCTDThocvien.Items.Add(item);
				}
			}
			dt = new DataTable();
			dt = DataBase.SelectQuery("select * from Lop");
			if (cmb_tklophocvien.Items.Count <= 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item= new ComboBoxItem();
					item.text = Convert.ToString(dr["TenLop"]);
					item.value = dr["MaLop"];
					cmb_tklophocvien.Items.Add(item);
				}
			}

		}

		private void btn_CaNhan_Click(object sender, EventArgs e)
		{
			#region màu button
			btn_DangKyHocVien.BackColor = Color.Gray;
			btn_CaNhan.BackColor = Color.SkyBlue;
			btn_HocVien.BackColor = Color.Gray;
			btn_DanhSachCTDT.BackColor = Color.Gray;
			btn_XemDanhSachLop.BackColor = Color.Gray;
			btn_ThuHocPhi.BackColor = Color.Gray;
			#endregion
			tabControl1.SelectedTab = tab_canhan;
			txt_CNTennhanvien.Text = user.nv.TenNhanVien;
			txt_CNsdt.Text = user.nv.Sdt;
			txt_CNngaysinh.Text = user.nv.NgaySinh;
			txt_CNmatkhau.Text = user.nv.MatKhau;
			txt_CNemai.Text = user.nv.Email;
			txt_CNcmt.Text = user.nv.Cmnd;	
		}

		private void txt_dksdthocvien_TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(txt_dksdthocvien.Text, "  ^ [0-9]"))
			{
				txt_dksdthocvien.Text = "";
			}
		}

		private void btn_dkhocvien_Click(object sender, EventArgs e)
		{
			try
			{
				HocVienDto hv = new HocVienDto();
				hv.Ten = txt_dkTenHocVien.Text.Trim();
				hv.NgaySinh = dtp_dkngaysinh.Text.Trim();
				hv.SDT = txt_dksdthocvien.Text.Trim();
				if (rdb_Nam.Checked == true)
				{
					hv.GioiTinh = true;
				}
				else if (rdb_nu.Checked == true)
				{
					hv.GioiTinh = false;
				}
				hv.Email = txt_dkemailhocvien.Text.Trim();
				hv.DiaChi = txt_dkdiachi.Text.Trim();
				hv.ChuongTrinh = Convert.ToInt32((cmb_dkchuongtrinh.SelectedItem as ComboBoxItem).value);
				string loi = null;
				if (!UtilsUI.CheckHocVien(hv, ref loi))
				{
					MessageBox.Show("lỗi: " + loi);
					return;
				}
				HocVienDao.Insert(hv);
				MessageBox.Show("Đăng ký thành công");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBox3_TextChanged(object sender, EventArgs e)
		{
			string sql = "select hv.TenHocVien,hv.NgaySinh,hv.Email,hv.GioiTinh from HocVien_Lop hvl right join HocVien hv on hvl.MaHocVien=hv.MaHocVien where hvl.MaLop="
				+ Convert.ToInt32((cmb_DKlop.SelectedItem as ComboBoxItem).value);
			DataTable dt = DataBase.SelectQuery(sql);
			dtg_DKHocVien_lop.DataSource = dt;
		}

		private void btn_dkhocvien_lop_Click(object sender, EventArgs e)
		{
			try
			{
				HocVien_LopDto dto = new HocVien_LopDto();
				dto.HocVien = Convert.ToInt32(textBox4.Text);
				dto.Lop = Convert.ToInt32((cmb_DKlop.SelectedItem as ComboBoxItem).value);
				HocVien_LopDao.Insert(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btn_themphieuthu_Click(object sender, EventArgs e)
		{
			try
			{
				string sql = "select h.TenHocVien,l.TenLop,l.NamHoc,l.Kyhoc,mh.TenMonHoc,mh.SoTinchi from HocVien h join HocVien_lop hv on  h.MaHocVien=hv.MaHocVien join Lop l on hv.MaLop=l.MaLop join MonHoc mh on mh.MaMonHoc=l.MaMonHoc where hv.MaHocVien=" + txt_hocphi_mahv.Text.Trim() + "and l.Kyhoc=" + cmb_hocphi_hoky.Text + " and l.NamHoc=" + DateTime.Now.Year.ToString();
				DataTable dt = DataBase.SelectQuery(sql);
				dtg_hp_thongtinhp.DataSource = dt;

				#region Thêm phiếu thu học phí
				PhieuThuHocPhiDto dto = new PhieuThuHocPhiDto();
				dto.HocVien = Convert.ToInt32(txt_hocphi_mahv.Text.Trim());
				dto.Ngaythu = Convert.ToString(DateTime.Now);
				dto.NhanVien = user.nv.ID;
				dto.TongTien = 0;
				PhieuThuHocPhiDao.Insert(dto);
				dt = new DataTable();
				dt = DataBase.SelectQuery("select max(MaPhieuThu) from PhieuThuHocPhi where MaHocVien=" + txt_hocphi_mahv.Text.Trim());
				dto.ID=Convert.ToInt32(dt.Rows[0][0]);
				lab_hocPhi_maphieu.Text = dto.ID.ToString();

				#endregion
			}
			catch (Exception ex)
			{
				MessageBox.Show("lỗi: " + ex.Message);
			}

		}

		private void btn_thuhp_Click(object sender, EventArgs e)
		{
			try
			{
				string sql = "select mh.MaMonHoc,mh.SoTinchi from HocVien h join HocVien_lop hv on  h.MaHocVien=hv.MaHocVien join Lop l on hv.MaLop=l.MaLop join MonHoc mh on mh.MaMonHoc=l.MaMonHoc where hv.MaHocVien=" + txt_hocphi_mahv.Text.Trim() + "and l.Kyhoc=" + cmb_hocphi_hoky.Text + " and l.NamHoc=" + DateTime.Now.Year.ToString();
				DataTable dt = DataBase.SelectQuery(sql);
				long tongtien = 0;
				foreach (DataRow dr in dt.Rows)
				{
					CT_PhieuThuDto dto = new CT_PhieuThuDto();
					dto.MonHoc = Convert.ToInt32(dr["MaMonHoc"]);
					dto.MaPhieuThu = Convert.ToInt32(lab_hocPhi_maphieu.Text);
					dto.SoTien = Convert.ToInt32(txt_tien1chi.Text) * Convert.ToInt32(dr["SoTinchi"]);
					tongtien = tongtien + dto.SoTien;
					CT_PhieuThuDao.Insert(dto);
				}
				lab_tonghocphi.Text = tongtien.ToString();
				DataBase.ExcuteQuery("update PhieuThuHocPhi set TongTien=" + tongtien + "where MaPhieuThu=" + lab_hocPhi_maphieu.Text);
				MessageBox.Show("Hoàn thành thu học phí");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void cmb_DSCTDT_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "select mh.TenMonHoc,mh.SoTinchi,nmh.TenNhomMonHoc from ChuongTrinhDaoTao dt right join" + " CT_ChuongTrinhDaoTao ct on dt.MaChuongTrinh=ct.MaChuongTrinh right join NhomMonHoc nmh " +
				"on nmh.MaNhomMonHoc = ct.MaNhomMonHoc right join CT_NhomMonHoc ctnmh on ctnmh.MaNhomMonHoc = nmh.MaNhomMonHoc right join MonHoc mh on mh.MaMonHoc = ctnmh.MaMonHoc where dt.MaChuongTrinh=" +
				  (cmb_DSCTDT.SelectedItem as ComboBoxItem).value.ToString();
			DataTable dt = DataBase.SelectQuery(sql);
			dtg_CTCTDT.DataSource = dt;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				string sql = "Select * from Lop where NamHoc=" + txt_XemLop_nam.Text.Trim() + " and KyHoc=" + cmb_xemlop_ky.Text.Trim();
				DataTable dt = DataBase.SelectQuery(sql);
				dtg_xemlop_nam.DataSource = dt;
				if (cmb_CTDSLop.Items.Count <= 0)
				{
					foreach (DataRow dr in dt.Rows)
					{
						ComboBoxItem item = new ComboBoxItem();
						item.text = dr["TenLop"].ToString();
						item.value = dr["MaLop"];
						cmb_CTDSLop.Items.Add(item);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cmb_CTDSLop_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "select l.MaLop,l.NamHoc,l.SiSoMax,nv.TenNhanVien,mh.TenMonHoc,mh.SoTinchi from Lop l left join NhanVien_Lop nvl on l.MaLop=nvl.MaLop left join NhanVien nv on nv.MaNhanVien=nvl.MaNhanVien join MonHoc mh on mh.MaMonHoc=l.MaMonHoc where l.MaLop=" + (cmb_CTDSLop.SelectedItem as ComboBoxItem).value.ToString();
			DataTable dt = DataBase.SelectQuery(sql);
			dtg_xemlopCT.DataSource = dt;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = DataBase.SelectQuery("Select * from HocVien");
				dtg_xemhocvien.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				string sql = null;
				if (txt_tkmahocvien.Text.Trim() != "" || txtktenhocvien.Text.Trim() != "")
				{
					if (txt_tkmahocvien.Text.Trim() == "")
					{
						sql = "select * from HocVien where TenHocVien=N'" + txtktenhocvien.Text + "'";
					}
					else if (txtktenhocvien.Text.Trim() == "")
					{
						sql = "select * from HocVien where MaHocVien=" + txt_tkmahocvien.Text;
					}
					else
					{
						sql = "Select * from HocVien where MaHocVien=" + txt_tkmahocvien.Text + " and TenHocVien=N'" + txtktenhocvien.Text + "'";
					}
				}
				DataTable dt = DataBase.SelectQuery(sql);
				dtg_xemhocvien.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cmb_tklophocvien_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "select * from HocVien hv left join HocVien_Lop hvl on hv.MaHocVien=hvl.MaLop where hvl.MaLop=" + (cmb_tklophocvien.SelectedItem as ComboBoxItem).value.ToString();
			DataTable dt = DataBase.SelectQuery(sql);
			dtg_xemhocvien.DataSource = dt;
		}

		private void cmb_tkCTDThocvien_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "select * from HocVien where MaChuongTrinh=" + (cmb_tkCTDThocvien.SelectedItem as ComboBoxItem).value.ToString();
			DataTable dt = DataBase.SelectQuery(sql);
			dtg_xemhocvien.DataSource = dt;
		}

		private void dtg_xemhocvien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lab_HVmahv.DataBindings.Clear();
			lab_HVmahv.DataBindings.Add("Text", dtg_xemhocvien.DataSource, "MaHocVien");
			txt_HVtenhocvien.DataBindings.Clear();
			txt_HVtenhocvien.DataBindings.Add("Text", dtg_xemhocvien.DataSource, "TenHocVien");
			txt_HVngaysinh.DataBindings.Clear();
			txt_HVngaysinh.DataBindings.Add("Text", dtg_xemhocvien.DataSource, "NgaySinh");
			txt_HVemail.DataBindings.Clear();
			txt_HVemail.DataBindings.Add("Text", dtg_xemhocvien.DataSource, "Email");
			txt_HVsdt.DataBindings.Clear();
			txt_HVsdt.DataBindings.Add("Text", dtg_xemhocvien.DataSource, "SDT");
			txt_HVdiachi.DataBindings.Clear();
			txt_HVdiachi.DataBindings.Add("Text", dtg_xemhocvien.DataSource, "DiaChi");
			string str = dtg_xemhocvien.Rows[e.RowIndex].Cells[4].Value.ToString();
			if (str.ToLower() == "true")
			{
				radioButton1.Checked = true;
			}
			else
			{
				radioButton2.Checked = true;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				NhanVienDto dto = new NhanVienDto();
				dto.TenNhanVien = txt_CNTennhanvien.Text;
				dto.NgaySinh = txt_CNngaysinh.Text;
				dto.Sdt = txt_CNsdt.Text;
				dto.Email = txt_CNemai.Text;
				dto.Cmnd = txt_CNcmt.Text;
				dto.ID = user.nv.ID;
				dto.LoaiNhanVien = user.nv.LoaiNhanVien;
				dto.MatKhau = user.nv.MatKhau;
				dto.GioiTinh = user.nv.GioiTinh;
				dto.Luong = user.nv.Luong;
				dto.TinhTrang = user.nv.TinhTrang;
				string loi = null;
				if (!UtilsUI.CheckNhanVien(dto, ref loi))
				{
					MessageBox.Show("lỗi: " + loi);
					return;
				}
				NhanVienDao.Update(dto);
				DataTable dt = DataBase.SelectQuery("select * from Nhanvien where MaNhanVien=" + user.nv.ID);
				user.nv = UtilsUI.GetNhanVienDto(dt.Rows[0]);
				MessageBox.Show("Sửa thông tin thành công");
			}
			catch (Exception ex) 
			{ MessageBox.Show(ex.Message); }
		}
	}
}
