using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class CT_NhomMonHocDao
	{
		public static Dictionary<string, string> AddMap(CT_NhomMonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaNhomMonHoc"] = Convert.ToString(dto.NhomMonHoc);
			map["MaMonHoc"] = Convert.ToString(dto.MonHoc);
			return map;
		}
		public static void Insert(CT_NhomMonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<CT_NhomMonHocDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<CT_NhomMonHocDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(CT_NhomMonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<CT_NhomMonHocDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
