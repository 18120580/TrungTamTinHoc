using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class ChungChiCTDTDao
	{
		public static 
		public static Dictionary<string, string> AddMap(ChungChiCTDTDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["SoHieuChungChi"] = dto.ID;
			map["MaChuongTrinh"] = Convert.ToString(dto.MaChuongTrinh);
			map["XepLoai"] = dto.Loai;
			map["Ngaycap"] = dto.NgayCap;
			map["MaHocVien"] = Convert.ToString(dto.HocVien);

			return map;
		}
		public static void Insert(ChungChiCTDTDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<ChungChiCTDTDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<ChungChiCTDTDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(ChungChiCTDTDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<ChungChiCTDTDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
