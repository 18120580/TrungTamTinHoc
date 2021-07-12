using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class CT_ChuongTrinhDaoTaoDao
	{
		public static Dictionary<string, string> AddMap(CT_ChuongTrinhDaoTaoDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaChuongTrinh"] = Convert.ToString(dto.MaChuongTrinh);
			map["MaNhomMonHoc"] = Convert.ToString(dto.NhomMonHoc);
			return map;
		}
		public static void Insert(CT_ChuongTrinhDaoTaoDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<CT_ChuongTrinhDaoTaoDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<CT_ChuongTrinhDaoTaoDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(CT_ChuongTrinhDaoTaoDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<CT_ChuongTrinhDaoTaoDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
