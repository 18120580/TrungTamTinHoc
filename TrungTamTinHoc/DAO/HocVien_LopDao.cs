using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class HocVien_LopDao
	{
		public static Dictionary<string, string> AddMap(HocVien_LopDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaHocVien"] = Convert.ToString(dto.HocVien);
			map["MaLop"] = Convert.ToString(dto.Lop);
		
			return map;
		}
		public static void Insert(HocVien_LopDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<HocVien_LopDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<HocVien_LopDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(HocVien_LopDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<HocVien_LopDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
