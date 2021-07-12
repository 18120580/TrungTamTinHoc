using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;
using System.Reflection;
using TrungTamTinHoc.DAO;

namespace TrungTamTinHoc.UI
{
	public partial class test : Form
	{
		public test()
		{
			InitializeComponent();
		}

		private void test_Load(object sender, EventArgs e)
		{
			LopDto lop1 = new LopDto();
			CaHocDto cahoc = new CaHocDto();
			LoaiLopDto loai = new LoaiLopDto();
			loai.ID = 5;
			loai.TenLoai = "chuyên đề";
			NhanVienDto nv = new NhanVienDto();
			textBox1.Text = DatabaseUtils<TableMappingAttribute>.GetTableName(loai.GetType());
			List<DTOAttribute> list = DatabaseUtils<TableMappingAttribute>.GetColumName(loai.GetType());
			string str = null;
			StringBuilder values = new StringBuilder();
			for (int i = 0; i < list.Count(); i++)
			{
				if (i == list.Count() - 1)
				{
					str = str + list[i].Column;
				}
				else
				{
					str = str + list[i].Column + ",";
				}
				values.Append("?" + list[i].Column);
			}

			textBox2.Text = "3";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	//LoaiLopDto loai = new LoaiLopDto();
			//	//loai.TenLoai = "Lớp Chuyên Đề";
			//	//LoaiLopDao.InsertLoaiLop(loai);
			//	DataTable dt = DataBase.SelectQuery("select * from LoaiLop where MaLoaiLop=" + textBox2.Text.Trim());
			//	if (dt.Rows.Count<=0)
			//	{
			//		MessageBox.Show("không tồn tại lớp");
			//		return;
			//	}
			//	else
			//	{
			//		LoaiLopDao.DeleteLoaiLop(textBox2.Text.Trim());
			//		MessageBox.Show("okeeee");
			//	}
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}
			LoaiLopDto dto = new LoaiLopDto();
			dto.ID = 2;
			dto.TenLoai = "nhan dan";
			LoaiLopDao dao = new LoaiLopDao();
			//LoaiLopDao.UpdateLoaiLop(dto);
			MessageBox.Show("Oke");
			
			
		}
	}
}
