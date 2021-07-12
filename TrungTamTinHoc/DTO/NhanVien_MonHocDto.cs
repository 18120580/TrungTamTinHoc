using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("NhanVien_MonHoc")]
	public class NhanVien_MonHocDto
	{
		[DTO(Column = "MaNhanVien", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long Nhanvien { get; set; }

		[DTO(Column = "MaMonHoc", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long MonHoc { get; set; }
	}
}
