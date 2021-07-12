using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("NhomMonHoc")]
	public class NhomMonHocDto
	{
		[DTO(Column = "MaNhomMonHoc", DataType = DATATYPE.GENERATED_ID,IsPrimaryKey =true)]
		public long ID { get; set; }

		[DTO(Column = "TenNhomMonHoc", DataType = DATATYPE.STRING)]
		public string TenNhom { get; set; }
	}
}
