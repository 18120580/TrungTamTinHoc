using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("ChungChiNMH")]
	public class ChungChiNMHDto
	{
		[DTO(Column = "SoHieuChungChi", DataType = DATATYPE.STRING, IsPrimaryKey =true)]
		public string ID { get; set; }

		[DTO(Column = "MaNhomMonHoc", DataType = DATATYPE.LONG)]
		public long NhomMonHoc { get; set; }

		[DTO(Column = "MaHocVien", DataType = DATATYPE.LONG)]
		public long HocVien { get; set; }

		[DTO(Column = "XepLoai", DataType = DATATYPE.STRING)]
		public string XepLoai { get; set; }

		[DTO(Column = "NgayCap", DataType = DATATYPE.DATE)]
		public string NgayCap { get; set; }

		[DTO(Column = "LoaiChungChi", DataType = DATATYPE.STRING)]
		public string LoaiChungChi { get; set; }
	}
}
