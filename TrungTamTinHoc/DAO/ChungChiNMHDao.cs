using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class ChungChiNMHDao
	{
		public static Dictionary<string, string> AddMap(ChungChiNMHDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["SoHieuChungChi"] = dto.ID;
			map["MaNhomMonHoc"] = Convert.ToString(dto.NhomMonHoc);
			map["MaHocVien"] = Convert.ToString(dto.HocVien);
			map["XepLoai"] = dto.XepLoai;
			map["Ngaycap"] = dto.NgayCap;
			map["LoaiChungChi"] = dto.LoaiChungChi;
			return map;
		}
		public static void Insert(ChungChiNMHDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<ChungChiNMHDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<ChungChiNMHDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(ChungChiNMHDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<ChungChiNMHDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
