using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class NhanVien_MonHocDao
	{
		public static Dictionary<string, string> AddMap(NhanVien_MonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaNhanVien"] = Convert.ToString(dto.Nhanvien);
			map["MaMonHoc"] = Convert.ToString(dto.MonHoc);
			return map;
		}
		public static void Insert(NhanVien_MonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<NhanVien_MonHocDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<NhanVien_MonHocDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(NhanVien_MonHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<NhanVien_MonHocDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
