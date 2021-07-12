using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;
using System.Data;

namespace TrungTamTinHoc.DAO
{
	public class CaHocDao
	{
		public static Dictionary<string, string> AddMap(CaHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaCaHoc"] = Convert.ToString(dto.ID);
			map["Thu"] = Convert.ToString(dto.Thu);
			map["TietBatDau"] = Convert.ToString(dto.BatDau);
			map["TietKetThuc"] = Convert.ToString(dto.KetThuc);
			return map;
		}
		public static void Insert(CaHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<CaHocDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<CaHocDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(CaHocDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<CaHocDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static CaHocDto CreateCaHoc(long thu, long bd, long kt)
		{
			CaHocDto dto = new CaHocDto();
			dto.Thu = thu;
			dto.BatDau = bd;
			dto.KetThuc = kt;
			return dto;
		}
		public static DataTable SelectAll()
		{
			return DataBase.SelectQuery("Select * from CaHoc");
		}
	}
}
