using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using System.Data;

namespace TrungTamTinHoc.Utils
{
	public class ComboBoxItem
	{
		public string text { get; set; }
		public object value { get; set; }
		public override string ToString()
		{
			return text;
		}
	}
	public class UtilsUI
	{
		public static string randomstring()
		{
			var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			var stringChars = new char[8];
			var random = new Random();

			for (int i = 0; i < stringChars.Length; i++)
			{
				stringChars[i] = chars[random.Next(chars.Length)];
			}

			var finalString = new String(stringChars);
			return finalString;
		}
		public static string GetValuesFromDto(string test, string source)
		{
			if (test == "STRING")
				return "N'" + source + "'";
			if (test == "DATE" || test == "DATETIME"||test=="BOOLEAN")
				return "'" + source + "'";
			return source;
		}
		public static NhanVienDto GetNhanVienDto(DataRow dr)
		{
			NhanVienDto nv = new NhanVienDto();
			nv.ID = Convert.ToInt32(dr["MaNhanVien"]);
			nv.LoaiNhanVien = Convert.ToInt32(dr["MaLoaiNhanVien"]);
			nv.TenNhanVien = Convert.ToString(dr["TenNhanVien"]);
			nv.NgaySinh = Convert.ToString(dr["NgaySinh"]);
			nv.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
			nv.Cmnd = Convert.ToString(dr["CMND"]);
			nv.Sdt = Convert.ToString(dr["SDT"]);
			nv.Email = Convert.ToString(dr["Email"]);
			nv.TinhTrang = Convert.ToBoolean(dr["TinhTrang"]);
			nv.MatKhau = Convert.ToString(dr["MatKhau"]);
			nv.Luong = Convert.ToInt32(dr["Luong"]);
			return nv;
		}
		public static HocVienDto GetHocVienDto(DataRow dr)
		{
			HocVienDto hv = new HocVienDto();
			hv.ID = Convert.ToInt32(dr["MaHocVien"]);
			hv.Ten = Convert.ToString(dr["TenHocVien"]).Trim();
			hv.NgaySinh = Convert.ToString(dr["NgaySinh"]).Trim();
			hv.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
			hv.SDT = Convert.ToString(dr["SDT"]).Trim();
			hv.Email = Convert.ToString(dr["Email"]).Trim();
			hv.DiaChi = Convert.ToString(dr["DiaChi"]).Trim();
			hv.ChuongTrinh = Convert.ToInt32(dr["MaChuongTrinh"]);
			return hv;
		}
		public static bool KiemTraKiTuDacBiet(string input)
		{
			string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
			foreach (var item in specialChar)
			{
				if (input.Contains(item)) return true;
			}

			return false;
		}
		public static bool checkso(string str)
		{
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] < 49 || str[i] > 57)
					return false;
			}
			return true;
		}
		public static bool CheckHocVien(HocVienDto dto, ref string loi)
		{
			if (dto.Email.Length < 8 | "@".Contains(dto.Email))
			{
				loi = "Địa chỉ email không hợp lệ vui lòng kiểm tra lại";
				return false;
			}
			if (dto.Ten == "" )
			{
				loi = "Tên học viên không hợp lệ vui lòng kiểm tra lại";
				return false;
			}
			if (dto.SDT.Length > 10 | dto.SDT.Length < 9|checkso(dto.SDT))
			{
				loi = "Số điện thoại không hợp lệ vui lòng kiểm tra lại";
				return false;
			}
			return true;
		}
		public static bool CheckNhanVien(NhanVienDto dto, ref string loi)
		{
			if (dto.Email.Length < 8 | "@".Contains(dto.Email))
			{
				loi = "Địa chỉ email không hợp lệ vui lòng kiểm tra lại";
				return false;
			}
			if (dto.TenNhanVien == "" )
			{
				loi = "Tên nhân viên không hợp lệ vui lòng kiểm tra lại";
				return false;
			}
			if (dto.Sdt.Length > 10 | dto.Sdt.Length < 9| checkso(dto.Sdt))
			{
				loi = "Số điện thoại không hợp lệ vui lòng kiểm tra lại";
				return false;
			}
			if (dto.Cmnd.Length != 9|!checkso(dto.Cmnd))
			{
				loi = "chứng minh thư không hợp lệ, vui lòng kiểm tra lại";
				return false;
			}
			return true;
		}
		public static bool CheckLogin(string email,string pass,ref string loi)
		{
			if (email.Length < 8 | "@".Contains(email))
			{
				loi = "Địa chỉ email không hợp lệ vui lòng kiểm tra lại";
				return false;
			}
			if (pass == "")
			{
				loi = "password không được rỗng";
				return false;
			}
			return true;
		}
	}
}
