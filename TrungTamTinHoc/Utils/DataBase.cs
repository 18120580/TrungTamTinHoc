using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrungTamTinHoc.Utils
{
	public class DataBase
	{
		private static SqlConnection connect;
		private static SqlCommand command;
		private static string connect_string = @"Data Source=DESKTOP-7S8OMU5\SQLEXPRESS01;Initial Catalog=TrungTamTinHoc;Integrated Security=True";
		public static SqlConnection CreateConnection()
		{
			try
			{
				connect = new SqlConnection(connect_string);
				connect.Open();
				
			}
			catch
			{
				connect = null;
			}
			return connect;
		}
		public static SqlCommand CreateCommand(SqlConnection connect, string command_text)
		{
			try
			{
				command = new SqlCommand(command_text, CreateConnection());
			}
			catch
			{
				command = null;
			}
			return command;
		}
		public static DataTable SelectQuery(string sql)
		{
			SqlCommand db_commad = CreateCommand(null, sql);
			DataTable dt = new DataTable("TableName");
			SqlDataAdapter adt = new SqlDataAdapter(db_commad);
			adt.Fill(dt);
			adt.Dispose();
			db_commad.Dispose();
			return dt;
		}
		public static void ExcuteQuery(string sql)
		{
			SqlCommand cmd = new SqlCommand(sql, DataBase.CreateConnection());
			cmd.CommandTimeout = 360000;
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			cmd = null;
		}
	}
}
