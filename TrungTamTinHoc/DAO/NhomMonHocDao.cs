using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class NhomMonHocDao
	{
		public static Dictionary<string, string> AddMap(NhomMonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaNhomMonHoc"] = Convert.ToString(dto.ID);
			map["TenNhomMonHoc"] = dto.TenNhom;
			return map;
		}

		public static void Insert(NhomMonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<NhomMonHocDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<NhomMonHocDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(NhomMonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<NhomMonHocDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
