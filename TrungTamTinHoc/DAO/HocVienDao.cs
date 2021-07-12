using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class HocVienDao
	{
		public static Dictionary<string, string> AddMap(HocVienDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaHocVien"] = Convert.ToString(dto.ID);
			map["GioiTinh"] = Convert.ToString(dto.GioiTinh);
			map["Email"] = dto.Email;
			map["TenHocVien"] = dto.Ten;
			map["NgaySinh"] = dto.NgaySinh;
			map["SDT"] = dto.SDT;
			map["DiaChi"] = dto.DiaChi;
			map["MaChuongTrinh"] = Convert.ToString(dto.ChuongTrinh);
			return map;
		}
		public static void Insert(HocVienDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<HocVienDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<HocVienDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(HocVienDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<HocVienDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
