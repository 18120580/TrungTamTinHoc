using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class CT_LichThiDao
	{
		public static Dictionary<string, string> AddMap(CT_LichThiDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaLichThi"] = Convert.ToString(dto.MaLichThi);
			map["MaHocVien"] = Convert.ToString(dto.HocVien);
			map["MaLop"] = Convert.ToString(dto.Lop);
			map["Diem"] = Convert.ToString(dto.Diem);
			map["LanThi"] = Convert.ToString(dto.LanThi);
			return map;
		}
		public static void Insert(CT_LichThiDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<CT_LichThiDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<CT_LichThiDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(CT_LichThiDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<CT_LichThiDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
