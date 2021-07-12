using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("HocVien")]
	public class HocVienDto
	{
		[DTO(Column = "MaHocVien", DataType = DATATYPE.GENERATED_ID, IsPrimaryKey = true)]
		public long ID { get; set; }

		[DTO(Column = "TenHocVien", DataType = DATATYPE.STRING)]
		public string Ten { get; set; }
		[DTO(Column = "NgaySinh", DataType = DATATYPE.DATE)]
		public string NgaySinh { get; set; }

		[DTO(Column = "Email", DataType = DATATYPE.STRING)]
		public string Email { get; set; }
		[DTO(Column = "GioiTinh", DataType = DATATYPE.BOOLEAN)]
		public bool GioiTinh { get; set; }
		[DTO(Column = "SDT", DataType = DATATYPE.STRING)]
		public string SDT { get; set; }
		[DTO(Column = "DiaChi", DataType = DATATYPE.STRING)]
		public string DiaChi { get; set; }

		[DTO(Column = "MaChuongTrinh", DataType = DATATYPE.LONG)]
		public long ChuongTrinh { get; set; }
	}
}
