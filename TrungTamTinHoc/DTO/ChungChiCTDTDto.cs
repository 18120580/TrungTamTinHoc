using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("ChungChiCTDT")]
	public class ChungChiCTDTDto
	{
		[DTO(Column = "SoHieuChungChi", DataType = DATATYPE.STRING,IsPrimaryKey =true)]
		public string ID { get; set; }

		[DTO(Column = "MaChuongTrinh", DataType = DATATYPE.LONG)]
		public long MaChuongTrinh { get; set; }

		[DTO(Column = "MaHocVien", DataType = DATATYPE.LONG)]
		public long HocVien { get; set; }

		[DTO(Column = "XepLoai", DataType = DATATYPE.STRING)]
		public string Loai { get; set; }

		[DTO(Column = "NgayCap", DataType = DATATYPE.DATE)]
		public string NgayCap { get; set; }
	}
}
