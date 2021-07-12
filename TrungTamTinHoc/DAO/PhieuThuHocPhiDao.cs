using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class PhieuThuHocPhiDao
	{
		public static Dictionary<string, string> AddMap(PhieuThuHocPhiDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaPhieuThu"] = Convert.ToString(dto.ID);
			map["NgayThu"] = dto.Ngaythu;
			map["MaHocVien"] = Convert.ToString(dto.HocVien);
			map["MaNhanVien"] = Convert.ToString(dto.NhanVien);
			map["TongTien"] = Convert.ToString(dto.TongTien);
			return map;
		}

		public static void Insert(PhieuThuHocPhiDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<PhieuThuHocPhiDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<PhieuThuHocPhiDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(PhieuThuHocPhiDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<PhieuThuHocPhiDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
