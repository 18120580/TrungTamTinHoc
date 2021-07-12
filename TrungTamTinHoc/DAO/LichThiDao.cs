using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;
namespace TrungTamTinHoc.DAO
{
	public class LichThiDao
	{
		public static Dictionary<string, string> AddMap(LichThiDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaLichThi"] = Convert.ToString(dto.ID);
			map["NhanVien1"] = Convert.ToString(dto.NhanVien1);
			map["PhongThi"] = dto.Phong;
			map["ThoiGianBatDau"] = dto.thoigianbatdau;
			map["ThoiGianLamBai"] = Convert.ToString(dto.ThoiGianLamBai);
			map["nhanvien2"] = Convert.ToString(dto.NhanVien2);

			return map;
		}
		public static void Insert(LichThiDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<LichThiDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<LichThiDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(LichThiDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<LichThiDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
