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
	public partial class BeginForm : Form
	{
		public BeginForm()
		{
			InitializeComponent();
		}

		private void BeginForm_Load(object sender, EventArgs e)
		{
			
		}

		private void btn_xemctdt_Click(object sender, EventArgs e)
		{
			DataTable dt = DataBase.SelectQuery("Select * from ChuongTrinhDaoTao");
			dtg_chuongtrinhdaotao.DataSource = dt;
		}

		private void btn_xemlop_Click(object sender, EventArgs e)
		{
			DataTable dt = DataBase.SelectQuery("Select * from Lop");
			dtgthongtinlop.DataSource = dt;
		}

		private void btn_chuacomk_Click(object sender, EventArgs e)
		{
			MessageBox.Show("vui lòng liên hệ quản bộ phận quản lý nhân sự để đăng ký tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btn_quenmk_Click(object sender, EventArgs e)
		{
			
			ForGetPass form = new ForGetPass(this);
			this.Hide();
			form.Show();
		}

		private void btn_dangnhap_Click(object sender, EventArgs e)
		{
			try
			{
				#region Kiểm tra đăng nhập
				string loi = null;
				if (!UtilsUI.CheckLogin(txt_tendangnhap.Text, txt_mk.Text, ref loi))
				{
					MessageBox.Show("Lỗi: " + loi);
					return;
				}
				#endregion
				#region xử lý đăng nhập
				string sql = "Select * from NhanVien where Email=N'" + txt_tendangnhap.Text
					+ "' and MatKhau=N'" + txt_mk.Text + "'";
				DataTable dt = DataBase.SelectQuery(sql);
				if (dt.Rows.Count > 0)
				{
					user.nv = UtilsUI.GetNhanVienDto(dt.Rows[0]);
					#region Nhân viên tiếp tân
					if (user.nv.LoaiNhanVien == 2)
					{
						this.Hide();
						TrangChu_TiepTan form = new TrangChu_TiepTan(this);
						form.Show();
					}
					#endregion
					#region nhân viên quản lý
					else if (user.nv.LoaiNhanVien == 1)
					{
						this.Hide();
						TrangChu_QuanLy form = new TrangChu_QuanLy(this);
						form.Show();
					}
					#endregion
					#region giáo vụ
					else if (user.nv.LoaiNhanVien == 3)
					{
						this.Hide();
						TrangChu_GiaoVu form = new TrangChu_GiaoVu(this);
						form.Show();
					}
					#endregion
					#region Giảng viên
					else if (user.nv.LoaiNhanVien == 4)
					{
					}
					#endregion
				}
				else
				{
					MessageBox.Show("Tài khoản không tồn tại, vui lòng kiểm tra thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				#endregion
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			

		}
	}
}
