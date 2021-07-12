using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("MonHoc")]
	public class MonHocDto
	{
		[DTO(Column = "MaMonHoc", DataType = DATATYPE.GENERATED_ID,IsPrimaryKey =true)]
		public long ID { get; set; }

		[DTO(Column = "TenMonHoc", DataType = DATATYPE.STRING)]
		public string TenMonHoc{ get; set; }

		[DTO(Column = "SoTinchi", DataType = DATATYPE.LONG)]
		public long TinChi { get; set; }
	}
}
