using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.Utils;
namespace TrungTamTinHoc.DAO
{
	public class NhanVienDao
	{
		public static Dictionary<string, string> AddMap(NhanVienDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map["MaNhanVien"] = Convert.ToString(dto.ID);
			map["MaLoaiNhanVien"] = Convert.ToString(dto.LoaiNhanVien);
			map["TenNhanVien"] = dto.TenNhanVien;
			map["GioiTinh"] = Convert.ToString(dto.GioiTinh);
			map["NgaySinh"] = dto.NgaySinh;
			map["CMND"] = dto.Cmnd;
			map["SDT"] = dto.Sdt;
			map["Email"] = dto.Email;
			map["TinhTrang"] = Convert.ToString(dto.TinhTrang);
			map["MatKhau"] = Convert.ToString(dto.MatKhau);
			map["Luong"] = Convert.ToString(dto.Luong);
			return map;
		}

		public static void Insert(NhanVienDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<NhanVienDto>.GenerateInsertSql(map);
			DataBase.ExcuteQuery(sql);
		}
		public static void Delete(string id)
		{
			string sql = DatabaseUtils<NhanVienDto>.GenerateDeleteSql(id);
			DataBase.ExcuteQuery(sql);
		}
		public static void Update(NhanVienDto dto)
		{
			Dictionary<string, string> map = new Dictionary<string, string>();
			map = AddMap(dto);
			string sql = DatabaseUtils<NhanVienDto>.GenerateUpdateSql(map);
			DataBase.ExcuteQuery(sql);
		}
	}
}
