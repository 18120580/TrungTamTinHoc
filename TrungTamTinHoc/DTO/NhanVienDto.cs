using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("NhanVien")]
	public class NhanVienDto
	{
		[DTO(Column = "MaNhanVien", DataType = DATATYPE.GENERATED_ID,IsPrimaryKey =true)]
		public long ID { get; set; }

		[DTO(Column = "MaLoaiNhanVien", DataType = DATATYPE.LONG)]
		public long LoaiNhanVien { get; set; }

		[DTO(Column = "TenNhanVien", DataType = DATATYPE.STRING)]
		public string TenNhanVien { get; set; }

		[DTO(Column = "NgaySinh", DataType = DATATYPE.DATE)]
		public string NgaySinh { get; set; }

		[DTO(Column = "GioiTinh", DataType = DATATYPE.BOOLEAN)]
		public bool GioiTinh { get; set; }

		[DTO(Column = "CMND", DataType = DATATYPE.STRING)]
		public string Cmnd { get; set; }

		[DTO(Column = "SDT", DataType = DATATYPE.STRING)]
		public string Sdt { get; set; }

		[DTO(Column = "Email", DataType = DATATYPE.STRING)]
		public string Email { get; set; }

		[DTO(Column = "TinhTrang", DataType = DATATYPE.BOOLEAN)]
		public bool TinhTrang { get; set; }

		[DTO(Column = "MatKhau", DataType = DATATYPE.STRING)]
		public string MatKhau { get; set; }

		[DTO(Column = "Luong", DataType = DATATYPE.MONEY)]
		public long Luong { get; set; }

	}
}
