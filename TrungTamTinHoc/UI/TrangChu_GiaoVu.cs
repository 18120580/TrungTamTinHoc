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
	public partial class TrangChu_GiaoVu : Form
	{
		BeginForm frm;
		public TrangChu_GiaoVu(BeginForm form)
		{
			InitializeComponent();
			frm = form;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			#region Màu button
			button2.BackColor = Color.SkyBlue;
			button3.BackColor = Color.Gray;
			button4.BackColor = Color.Gray;
			button5.BackColor = Color.Gray;
			button6.BackColor = Color.Gray;
			#endregion
			tabControl1.SelectedTab = tab_QLDiemLop;
			comboBox1.Items.Clear();
			if (comboBox1.Items.Count <= 0)
			{
				DataTable dt = DataBase.SelectQuery("Select * from Lop");
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenLop"]);
					item.value = dr["MaLop"];
					comboBox1.Items.Add(item);
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			#region Màu button
			button2.BackColor = Color.Gray;
			button3.BackColor = Color.SkyBlue;
			button4.BackColor = Color.Gray;
			button5.BackColor = Color.Gray;
			button6.BackColor = Color.Gray;
			#endregion
			cmb_QLLTNV1.Items.Clear();
			cmb_QLLTNV2.Items.Clear();
			comboBox4.Items.Clear();
			tabControl1.SelectedTab = tab_QLLichThi;
			if (cmb_QLLTNV1.Items.Count <= 0)
			{
				DataTable dt = DataBase.SelectQuery("select * from NhanVien");
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenNhanVien"]);
					item.value = dr["MaNhanVien"];
					cmb_QLLTNV1.Items.Add(item);
					cmb_QLLTNV2.Items.Add(item);
				}
			}
			if (comboBox4.Items.Count <= 0)
			{
				DataTable dt = DataBase.SelectQuery("select * from Lop");
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenLop"]);
					item.value = dr["MaLop"];
					comboBox4.Items.Add(item);
				}
			}
			dtg_QLLTLichThi.DataSource = DataBase.SelectQuery("Select * from LichThi");
			for (int i = 0; i < 24; i++)
			{
				string item = null;
				if (i < 10)
				{
					item = "0" + i.ToString();
				}
				else item = i.ToString();
				gio.Items.Add(item);
			}
			for (int i = 0; i < 60; i++)
			{
				string item = null;
				if (i < 10)
				{
					item = "0" + i.ToString();
				}
				else item = i.ToString();
				phut.Items.Add(item);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			#region Màu button
			button2.BackColor = Color.Gray;
			button3.BackColor = Color.Gray;
			button4.BackColor = Color.SkyBlue;
			button5.BackColor = Color.Gray;
			button6.BackColor = Color.Gray;
			#endregion
			tabControl1.SelectedTab = tab_QLHocVien;
			comboBox7.Items.Clear();
			comboBox6.Items.Clear();
			if (comboBox7.Items.Count <= 0)
			{
				DataTable dt = DataBase.SelectQuery("Select * from ChuongTrinhDaoTao");
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenChuongTrinh"]);
					item.value = dr["MaChuongTrinh"];
					comboBox7.Items.Add(item);
				}
			}
			if (comboBox6.Items.Count <= 0)
			{
				DataTable dt = DataBase.SelectQuery("Select * from Lop");
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenLop"]);
					item.value = dr["MaLop"];
					comboBox6.Items.Add(item);
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			#region Màu button
			button2.BackColor = Color.Gray;
			button3.BackColor = Color.Gray;
			button4.BackColor = Color.Gray;
			button5.BackColor = Color.SkyBlue;
			button6.BackColor = Color.Gray;
			#endregion
			tabControl1.SelectedTab = tab_QLMonHoc;
			comboBox8.Items.Clear();
			comboBox9.Items.Clear();
			if (comboBox8.Items.Count <= 0)
			{
				DataTable dt = DataBase.SelectQuery("select * from ChuongTrinhDaoTao");
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenChuongTrinh"]);
					item.value = dr["MaChuongTrinh"];
					comboBox8.Items.Add(item);
				}

			}
			if (comboBox9.Items.Count <= 0)
			{
				DataTable dt = DataBase.SelectQuery("select * from NhomMonHoc");
				foreach (DataRow dr in dt.Rows)
				{
					ComboBoxItem item = new ComboBoxItem();
					item.text = Convert.ToString(dr["TenNhomMonHoc"]);
					item.value = dr["MaNhomMonHoc"];
					comboBox9.Items.Add(item);
				}
			}

		}

		private void button6_Click(object sender, EventArgs e)
		{
			#region Màu button
			button2.BackColor = Color.Gray;
			button3.BackColor = Color.Gray;
			button4.BackColor = Color.Gray;
			button5.BackColor = Color.Gray;
			button6.BackColor = Color.SkyBlue;
			#endregion
			tabControl1.SelectedTab = tab_QLDiemLop;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == "" && textBox1.Text == "") return;
			string sql = null;
			if (comboBox1.Text == "")
				sql = "select lt.MaLop,lt.MaHocVien,hv.TenHocVien,lt.MaLichThi ,lt.Diem,lt.lanThi from CT_LichThi lt left join HocVien hv on lt.MaHocVien=hv.MaHocVien where lt.MaHocVien=" + textBox1.Text.Trim();
			else if (textBox1.Text != "") sql = "select lt.MaLop,lt.MaHocVien,hv.TenHocVien,lt.MaLichThi ,lt.Diem,lt.lanThi from CT_LichThi lt left join HocVien hv on lt.MaHocVien=hv.MaHocVien where lt.MaHocVien=" + textBox1.Text.Trim() + " and lt.MaLop="
					   + (comboBox1.SelectedItem as ComboBoxItem).value.ToString();
			DataTable dt = DataBase.SelectQuery(sql);
			dataGridView1.DataSource = dt;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_CTLTMaHV.DataBindings.Clear();
			txt_CTLTMaHV.DataBindings.Add("Text", dataGridView1.DataSource, "MaHocVien");
			txt_CTLTMaLop.DataBindings.Clear();
			txt_CTLTMaLop.DataBindings.Add("Text", dataGridView1.DataSource, "MaLop");
			txt_CTLTDiem.DataBindings.Clear();
			txt_CTLTDiem.DataBindings.Add("Text", dataGridView1.DataSource, "Diem");
			txt_CTLTLanThi.DataBindings.Clear();
			txt_CTLTLanThi.DataBindings.Add("Text", dataGridView1.DataSource, "LanThi");
			txt_CTLTMaLT.DataBindings.Clear();
			txt_CTLTMaLT.DataBindings.Add("Text", dataGridView1.DataSource, "MaLichThi");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			try
			{
				CT_LichThiDto dto = new CT_LichThiDto();
				dto.MaLichThi = Convert.ToInt32(txt_CTLTMaLT.Text);
				dto.Lop = Convert.ToInt32(txt_CTLTMaLop.Text);
				dto.HocVien = Convert.ToInt32(txt_CTLTMaHV.Text);
				dto.Diem = Convert.ToDouble(txt_CTLTDiem.Text);
				dto.LanThi = Convert.ToInt32(txt_CTLTLanThi.Text);
				CT_LichThiDao.Update(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void TrangChu_GiaoVu_FormClosing(object sender, FormClosingEventArgs e)
		{
			frm.Show();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "select lt.MaLop,lt.MaHocVien,hv.TenHocVien,lt.MaLichThi ,lt.Diem,lt.lanThi from CT_LichThi lt left join HocVien hv on lt.MaHocVien = hv.MaHocVien where lt.MaLop=" + (comboBox1.SelectedItem as ComboBoxItem).value.ToString();
			DataTable dt = DataBase.SelectQuery(sql);
			dataGridView1.DataSource = dt;
		}

		private void button14_Click(object sender, EventArgs e)
		{
			try
			{
				dtg_QLLTLichThi.DataSource = DataBase.SelectQuery("Select * from LichThi");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "select DISTINCT l.MaLop, l.TenLop, mh.TenMonHoc,l.NamHoc,l.Kyhoc,lt.MaLichThi from Lop l left join CT_Lichthi lt on l.MaLop=lt.MaLop  left join MonHoc mh on mh.MaMonHoc=l.MaMonHoc where l.Kyhoc="+comboBox5.Text;
			dtg_QLLTLop.DataSource = DataBase.SelectQuery(sql);
		}

		private void dtg_QLLTLop_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox7.DataBindings.Clear();
			textBox7.DataBindings.Add("Text", dtg_QLLTLop.DataSource, "MaLop");
		}

		private void dtg_QLLTLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox6.DataBindings.Clear();
			textBox6.DataBindings.Add("Text", dtg_QLLTLichThi.DataSource, "MaLichThi");
			lab_idLichThi.DataBindings.Clear();
			lab_idLichThi.DataBindings.Add("Text", dtg_QLLTLichThi.DataSource, "MaLichThi");
		}

		private void button15_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = DataBase.SelectQuery("select hv.MaHocVien, l.MaLop from HocVien hv left join HocVien_Lop hvl on hv.MaHocVien=hvl.MaHocVien left join Lop l on l.MaLop=hvl.MaLop where l.MaLop=" + textBox7.Text);
				foreach (DataRow dr in dt.Rows)
				{
					string mahv = Convert.ToString(dr["MaHocVien"]);
					string malop = Convert.ToString(dr["MaLop"]);
					DataTable dt1 = DataBase.SelectQuery("select * from CT_LichThi where MaLop=" + malop + " and MaHocVien=" + mahv + "and  MaLichThi=" + textBox6.Text);
					if (dt1.Rows.Count <= 0)
					{
						DataBase.ExcuteQuery("insert into CT_Lichthi(MaHocVien,MaLichThi,MaLop) values(" + mahv + "," + textBox6.Text + "," + malop + ")");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			try
			{
				LichThiDto dto = new LichThiDto();
				dto.thoigianbatdau = dateTimePicker1.Text + " " + gio.Text + ":" + phut.Text + ":00";
				dto.Phong = txt_QLLTPhong.Text;
				dto.ThoiGianLamBai = Convert.ToInt32(txt_QLLTTGLB.Text);
				dto.NhanVien1 = Convert.ToInt32((cmb_QLLTNV1.SelectedItem as ComboBoxItem).value);
				dto.NhanVien2 = Convert.ToInt32((cmb_QLLTNV2.SelectedItem as ComboBoxItem).value);
				LichThiDao.Insert(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			try
			{
				LichThiDto dto = new LichThiDto();
				dateTimePicker1.Format = DateTimePickerFormat.Custom;
				dateTimePicker1.CustomFormat = "dd-MM-yyyy HH:mm";
				dto.thoigianbatdau = dateTimePicker1.Value.ToString();
				dto.Phong = txt_QLLTPhong.Text;
				dto.ThoiGianLamBai = Convert.ToInt32(txt_QLLTTGLB.Text);
				dto.NhanVien1 = Convert.ToInt32((cmb_QLLTNV1.SelectedItem as ComboBoxItem).value);
				dto.NhanVien2 = Convert.ToInt32((cmb_QLLTNV2.SelectedItem as ComboBoxItem).value);
				dto.ID = Convert.ToInt32(lab_idLichThi.Text);
				LichThiDao.Update(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sql = "Select * from HocVien where MaChuongTrinh=" + (comboBox7.SelectedItem as ComboBoxItem).value.ToString();
			dataGridView6.DataSource = DataBase.SelectQuery(sql);
		}

		private void button16_Click(object sender, EventArgs e)
		{
			try
			{
				dataGridView6.DataSource = DataBase.SelectQuery("select * from HocVien where MaHocVien=" + textBox8.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox9.DataBindings.Clear();
			textBox9.DataBindings.Add("Text", dataGridView6.DataSource, "MaHocVien");
			textBox10.DataBindings.Clear();
			textBox10.DataBindings.Add("Text", dataGridView6.DataSource, "MaChuongTrinh");
		}

		private void button17_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase.ExcuteQuery("update HocVien set MaChuongTrinh=" + textBox10.Text + " where MaHocVien=" + textBox9.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void button20_Click(object sender, EventArgs e)
		{
			try
			{
				MonHocDto dto = new MonHocDto();
				dto.TenMonHoc = textBox4.Text;
				dto.TinChi = Convert.ToInt32(textBox5.Text);
				MonHocDao.Insert(dto);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			try
			{
				MonHocDto dto = new MonHocDto();
				dto.TenMonHoc = textBox4.Text;
				dto.TinChi = Convert.ToInt32(textBox5.Text);
				dto.ID = Convert.ToInt32(textBox15.Text);
				MonHocDao.Update(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView4.DataSource = DataBase.SelectQuery("select * from MonHoc mh left join CT_NhomMonHoc ctnmh on ctnmh.MaMonHoc=mh.MaMonHoc left join CT_ChuongTrinhDaoTao ctctdt on ctctdt.MaNhomMonHoc=ctnmh.MaNhomMonHoc where MaChuongTrinh=" + (comboBox8.SelectedItem as ComboBoxItem).value.ToString());
		}

		private void button19_Click(object sender, EventArgs e)
		{
			try
			{
				MonHocDao.Delete(textBox15.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox4.DataBindings.Clear();
			textBox4.DataBindings.Add("Text", dataGridView4.DataSource, "TenMonHoc");
			textBox5.DataBindings.Clear();
			textBox5.DataBindings.Add("Text",dataGridView4.DataSource,"SoTinchi");
			textBox15.DataBindings.Clear();
			textBox15.DataBindings.Add("Text", dataGridView4.DataSource, "MaMonHoc");
		}

		private void button21_Click(object sender, EventArgs e)
		{
			try
			{
				NhomMonHocDto dto = new NhomMonHocDto();
				dto.TenNhom = textBox11.Text;
				dto.ID = Convert.ToInt32(textBox12.Text);
				NhomMonHocDao.Insert(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button22_Click(object sender, EventArgs e)
		{
			try
			{
				NhomMonHocDto dto = new NhomMonHocDto();
				dto.TenNhom = textBox11.Text;
				dto.ID = Convert.ToInt32(textBox12.Text);
				NhomMonHocDao.Update(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button23_Click(object sender, EventArgs e)
		{
			try
			{
				NhomMonHocDao.Delete(textBox12.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView5.DataSource = DataBase.SelectQuery("select mh.MaMonHoc,mh.TenMonHoc,mh.SoTinchi,ct.MaNhomMonHoc from MonHoc mh left join CT_NhomMonHoc ct on ct.MaMonHoc=mh.MaMonHoc where ct.MaNhomMonHoc=" + (comboBox9.SelectedItem as ComboBoxItem).value.ToString());
		}

		private void TrangChu_GiaoVu_Load(object sender, EventArgs e)
		{

		}
	}
}
