using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrungTamTinHoc.UI;
using TrungTamTinHoc.DTO;

namespace TrungTamTinHoc
{
	public static class user
	{
		public static NhanVienDto nv;
	}
	static class Program
	{
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BeginForm());
		}
	}
}
