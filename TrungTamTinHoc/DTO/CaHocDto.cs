using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("CaHoc")]
	public class CaHocDto
	{
		[DTO(Column = "MaCaHoc", DataType = DATATYPE.GENERATED_ID,IsPrimaryKey =true)]
		public long ID { get; set; }

		[DTO(Column = "Thu", DataType = DATATYPE.LONG)]
		public long Thu { get; set; }

		[DTO(Column = "TietBatDau", DataType = DATATYPE.LONG)]
		public long BatDau { get; set; }

		[DTO(Column = "TietKetThuc", DataType = DATATYPE.LONG)]
		public long KetThuc { get; set; }
	}
}
