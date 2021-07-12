using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using TrungTamTinHoc.Utils;
using TrungTamTinHoc.DTO;
using TrungTamTinHoc.DAO;

namespace TrungTamTinHoc.UI
{
	public partial class ForGetPass : Form
	{
		public BeginForm frm1;
		public ForGetPass(BeginForm form1)
		{
			InitializeComponent();
			frm1 = form1;
		}

		private void ForGetPass_Load(object sender, EventArgs e)
		{
		}

		private void btn_laylaimk_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = DataBase.SelectQuery("select * from NhanVien where Email=N'" + txt_email.Text.Trim() + "'");
				if (dt.Rows.Count > 0)
				{
					string mkmoi = UtilsUI.randomstring();
					MailMessage mail = new MailMessage("quangtho991@gmail.com", txt_email.Text, "[MẬT KHẨU TÀI KHOẢN TRUNG TÂM TIN HOC]", "Mật Khẩu của bạn là: " + mkmoi);
					mail.IsBodyHtml = true;
					mail.BodyEncoding = mail.SubjectEncoding = Encoding.UTF8;
					SmtpClient client = new SmtpClient();
					client.Host = "smtp.gmail.com";
					client.UseDefaultCredentials = false;
					client.Port = 587;
					client.Credentials = new System.Net.NetworkCredential("quangtho991@gmail.com", "Tho.kenvin.123.");
					client.EnableSsl = true;
					client.Send(mail);
					DataBase.ExcuteQuery("update NhanVien set MatKhau=N'" + mkmoi + "' where Email=N'" + txt_email.Text + "'");
					MessageBox.Show("Mật khẩu đã gửi qua email của bạn", "thông báo", MessageBoxButtons.OK);
					frm1.Show();
					this.Close();
				}
				else
				{
					MessageBox.Show("Tài khoản không tồn tại vui lòng kiểm tra lại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR: " + ex.Message);
			}
			
			
		}
	}
}
