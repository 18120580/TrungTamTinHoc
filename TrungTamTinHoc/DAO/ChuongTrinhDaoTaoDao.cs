using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class ChuongTrinhDaoTaoDao
	{
		public static Dictionary<string, string> AddMap(ChuongTrinhDaoTaoDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaChuongTrinh"] = Convert.ToString(dto.ID);
			map["TenChuongTrinh"] = dto.TenChuongTrinh;
			map["SotinChi"] = Convert.ToString(dto.TinChi);
			return map;
		}
		public static void Insert(ChuongTrinhDaoTaoDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<ChuongTrinhDaoTaoDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<ChuongTrinhDaoTaoDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(ChuongTrinhDaoTaoDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<ChuongTrinhDaoTaoDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
