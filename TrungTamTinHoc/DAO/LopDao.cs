using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;

namespace TrungTamTinHoc.DAO
{
	public class LopDao
	{
		public static Dictionary<string, string> AddMap(LopDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaLop"] = Convert.ToString(dto.ID);
			map["MaLoaiLop"] = Convert.ToString(dto.LoaiLop);
			map["MaMonHoc"] = Convert.ToString(dto.MonHoc);
			map["TenLop"] = dto.TenLop;
			map["SiSoMax"] = Convert.ToString(dto.SiSo);
			map["PhongHoc"] = dto.PhongHoc;
			map["MaCaHoc"] = Convert.ToString(dto.CaHoc);
			map["NamHoc"] = Convert.ToString(dto.Nam);
			map["KyHoc"] = Convert.ToString(dto.Ky);
			return map;
		}

		public static void Insert(LopDto loai)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(loai);
			string sql = DatabaseUtils<LopDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<LopDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(LopDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<LopDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
