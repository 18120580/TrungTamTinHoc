using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("NhanVien_Lop")]
	public class NhanVien_LopDto
	{
		[DTO(Column = "MaNhanVien", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long Nhanvien { get; set; }

		[DTO(Column = "MaLop", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long Lop { get; set; }
	}
}
