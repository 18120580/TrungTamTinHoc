using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("PhieuThuHocPhi")]
	public class PhieuThuHocPhiDto
	{
		[DTO(Column = "MaPhieuThu", DataType = DATATYPE.GENERATED_ID,IsPrimaryKey =true)]
		public long ID { get; set; }

		[DTO(Column = "NgayThu", DataType = DATATYPE.DATE)]
		public string Ngaythu { get; set; }

		[DTO(Column = "MaHocVien", DataType = DATATYPE.LONG)]
		public long HocVien { get; set; }

		[DTO(Column = "MaNhanVien", DataType = DATATYPE.LONG)]
		public long NhanVien { get; set; }

		[DTO(Column = "TongTien", DataType = DATATYPE.MONEY)]
		public long TongTien{ get; set; }
	}
}
