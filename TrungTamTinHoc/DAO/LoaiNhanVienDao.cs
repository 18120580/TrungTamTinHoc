using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class LoaiNhanVienDao
	{
		public static Dictionary<string, string> AddMap(LoaiNhanVienDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaLoaiNhanVien"] = Convert.ToString(dto.ID);
			map["TenLoaiNhanVien"] = dto.TenLoai;
			return map;
		}

		public static void Insert(LoaiNhanVienDto loai)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(loai);
			string sql = DatabaseUtils<LoaiNhanVienDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<LoaiNhanVienDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(LoaiNhanVienDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<LoaiNhanVienDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
