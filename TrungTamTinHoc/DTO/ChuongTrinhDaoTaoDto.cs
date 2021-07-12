using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("ChuongTrinhDaoTao")]
	public class ChuongTrinhDaoTaoDto
	{
		[DTO(Column = "MaChuongTrinh", DataType = DATATYPE.GENERATED_ID, IsPrimaryKey =true)]
		public long ID { get; set; }

		[DTO(Column = "TenChuongTrinh", DataType = DATATYPE.STRING)]
		public string TenChuongTrinh { get; set; }

		[DTO(Column = "SotinChi", DataType = DATATYPE.LONG)]
		public long TinChi { get; set; }
	}
}
