using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.Const;

namespace TrungTamTinHoc.DTO
{
	[TableMapping("Lop")]
	public class LopDto
	{
		[DTO(Column = "MaLop", DataType = DATATYPE.GENERATED_ID, IsPrimaryKey = true)]
		public long ID { get; set; }
		[DTO(Column = "MaLoaiLop", DataType = DATATYPE.LONG)]
		public long LoaiLop { get; set; }
		[DTO(Column = "MaMonHoc", DataType = DATATYPE.LONG)]
		public long MonHoc { get; set; }
		[DTO(Column = "TenLop", DataType = DATATYPE.STRING)]
		public string TenLop { get; set; }
		[DTO(Column = "SiSoMax", DataType = DATATYPE.LONG)]
		public long SiSo { get; set; }
		[DTO(Column = "PhongHoc", DataType = DATATYPE.STRING)]
		public string PhongHoc { get; set; }
		[DTO(Column = "MaCaHoc", DataType = DATATYPE.STRING)]
		public string CaHoc { get; set; }

		[DTO(Column = "NamHoc", DataType = DATATYPE.LONG)]
		public string Nam { get; set; }

		[DTO(Column = "KyHoc", DataType = DATATYPE.LONG)]
		public string Ky { get; set; }
	}
}
