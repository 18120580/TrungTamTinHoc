using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("CT_PhieuThu")]
	public class CT_PhieuThuDto
	{
		[DTO(Column = "MaPhieuThu", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long MaPhieuThu { get; set; }

		[DTO(Column = "MaMonHoc", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long MonHoc { get; set; }

		[DTO(Column = "SoTien", DataType = DATATYPE.MONEY)]
		public long SoTien { get; set; }
	}
}
