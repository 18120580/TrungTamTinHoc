using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("LoaiNhanVien")]
	public class LoaiNhanVienDto
	{
		[DTO(Column = "MaLoaiNhanVien", DataType = DATATYPE.GENERATED_ID,IsPrimaryKey =true)]
		public long ID { get; set; }
		[DTO(Column = "TenLoaiNhanVien", DataType = DATATYPE.STRING)]
		public string TenLoai { get; set; }
	}
}
