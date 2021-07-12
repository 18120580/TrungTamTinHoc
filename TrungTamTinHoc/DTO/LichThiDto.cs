using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("LichThi")]
	public class LichThiDto
	{
		[DTO(Column = "MaLichThi", DataType = DATATYPE.GENERATED_ID,IsPrimaryKey =true)]
		public long ID { get; set; }

		[DTO(Column = "PhongThi", DataType = DATATYPE.STRING)]
		public string Phong { get; set; }

		[DTO(Column = "ThoiGianBatDau", DataType = DATATYPE.DATETIME)]
		public string thoigianbatdau  { get; set; }

		[DTO(Column = "ThoiGianLamBai", DataType = DATATYPE.LONG)]
		public long ThoiGianLamBai { get; set; }

		[DTO(Column = "NhanVien1", DataType = DATATYPE.LONG)]
		public long NhanVien1 { get; set; }

		[DTO(Column = "nhanvien2", DataType = DATATYPE.LONG)]
		public long NhanVien2 { get; set; }
	}
}
