using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("HocVien_Lop")]
	public class HocVien_LopDto
	{
		[DTO(Column = "MaHocVien", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long HocVien { get; set; }

		[DTO(Column = "MaLop", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long Lop { get; set; }

	}
}
