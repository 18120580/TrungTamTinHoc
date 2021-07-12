using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class LoaiLopDao
	{
		public static Dictionary<string, string> AddMap(LoaiLopDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaLoaiLop"] = Convert.ToString(dto.ID);
			map["TenLoaiLop"] = dto.TenLoai;
			return map;
		}

		public static void Insert(LoaiLopDto loai)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map=AddMap(loai);
			string sql = DatabaseUtils<LoaiLopDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<LoaiLopDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(LoaiLopDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<LoaiLopDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
