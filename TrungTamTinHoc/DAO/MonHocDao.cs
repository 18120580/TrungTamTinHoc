using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class MonHocDao
	{
		public static Dictionary<string, string> AddMap(MonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaMonHoc"] = Convert.ToString(dto.ID);
			map["TenMonHoc"] = dto.TenMonHoc;
			map["SoTinchi"] = Convert.ToString(dto.TinChi);
			return map;
		}

		public static void Insert(MonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<MonHocDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<MonHocDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(MonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<MonHocDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
