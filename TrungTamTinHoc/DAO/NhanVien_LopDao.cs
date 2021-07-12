using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class NhanVien_LopDao
	{
		public static Dictionary<string, string> AddMap(NhanVien_LopDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaNhanVien"] = Convert.ToString(dto.Nhanvien);
			map["MaLop"] = Convert.ToString(dto.Lop);
			return map;
		}
		public static void Insert(NhanVien_LopDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<NhanVien_LopDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<NhanVien_LopDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(NhanVien_LopDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<NhanVien_LopDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
