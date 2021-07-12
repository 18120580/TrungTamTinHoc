using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("CT_NhomMonHoc")]
	public class CT_NhomMonHocDto
	{
		[DTO(Column = "MaNhomMonHoc", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long NhomMonHoc { get; set; }

		[DTO(Column = "MaMonHoc", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long MonHoc { get; set; }
	}
}
