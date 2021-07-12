using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("CT_ChuongTrinhDaoTao")]
	public class CT_ChuongTrinhDaoTaoDto
	{
		[DTO(Column = "MaChuongTrinh", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long MaChuongTrinh { get; set; }

		[DTO(Column = "MaNhomMonHoc", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long NhomMonHoc { get; set; }
	}
}
