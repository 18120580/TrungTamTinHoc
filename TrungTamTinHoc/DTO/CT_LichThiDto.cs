using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("CT_LichThi")]
	public class CT_LichThiDto
	{
		[DTO(Column = "MaLichThi", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long MaLichThi { get; set; }

		[DTO(Column = "MaHocVien", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long HocVien { get; set; }

		[DTO(Column = "MaLop", DataType = DATATYPE.LONG,IsPrimaryKey =true)]
		public long Lop { get; set; }

		[DTO(Column = "Diem", DataType = DATATYPE.FLOAT)]
		public double Diem { get; set; }

		[DTO(Column = "LanThi", DataType = DATATYPE.LONG)]
		public long LanThi { get; set; }
	}
}
