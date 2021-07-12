using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class CT_PhieuThuDao
	{
		public static Dictionary<string, string> AddMap(CT_PhieuThuDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaPhieuThu"] = Convert.ToString(dto.MaPhieuThu);
			map["MaMonHoc"] = Convert.ToString(dto.MonHoc);
			map["SoTien"] = Convert.ToString(dto.SoTien);
			return map;
		}
		public static void Insert(CT_PhieuThuDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<CT_PhieuThuDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<CT_PhieuThuDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(CT_PhieuThuDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<CT_PhieuThuDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
