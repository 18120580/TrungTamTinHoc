using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrungTamTinHoc.DTO;
using System.Data.SqlClient;
using System.Reflection;

namespace TrungTamTinHoc.Utils
{
    public class DatabaseUtils<T>
    {
        // hàm lấy tên table
        // truyền vào 1 đối tượng dto lấy ra tên table tương ứng của đối tượng đó
        public static string GetTableName(Type type)
        {
            string str = ((TableMappingAttribute[])type.GetCustomAttributes(typeof(TableMappingAttribute), true))[0].Name;
            return str;
        }
        // hàm lấy danh sách tên các cột của table
        // truyền vào một đối tưởng dto để lấy ra các filed tương ứng với dto đó
        public static List<DTOAttribute> GetColumName(Type type)
        {
            List<DTOAttribute> list = new List<DTOAttribute>();
            foreach (var dtoValue in type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.DeclaredOnly))
            {
                var dtoAttrs = (DTOAttribute[])dtoValue.GetCustomAttributes(typeof(DTOAttribute), false);
                if (dtoAttrs.Count() >= 1)
                {
                    list.Add(dtoAttrs[0]);
                }
            }
            return list;
        }
        //hàm insert 1 dòng mới
        //
        public static string GenerateInsertSql (Dictionary<string,string> map)
        {
            List<DTOAttribute> list = GetColumName(typeof(T));
            string colums = null;
            string values = null;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].DataType.ToString() == "GENERATED_ID")
                {
                    continue;
                }
                if (i == list.Count() - 1)
                {
                    colums = colums + list[i].Column;
                    values = values + UtilsUI.GetValuesFromDto(list[i].DataType.ToString(), map[list[i].Column]);
                }
                else
                {
                    colums = colums + list[i].Column + ",";
                    values = values + UtilsUI.GetValuesFromDto(list[i].DataType.ToString(), map[list[i].Column])+",";
                }
            }
            string sql = "Insert into " + DatabaseUtils<T>.GetTableName(typeof(T)) + "(" + colums + ") values("+values+")";
            return sql;
        }
        //delete với table có 1 primary key
        //delete theo primary key
        //hàm genaerate ra câu lệnh delete theo key
        public static string GenerateDeleteSql(string id)
        {
            string sql = null;
            List<DTOAttribute> list = GetColumName(typeof(T));
            sql = "Delete from " + DatabaseUtils<T>.GetTableName(typeof(T)) + " where "+ list[0].Column+"="+id;
            return sql;
        }
        //hàm generate câu lệnh update
        // update toàn bộ 1 đối tượng
        public static string GenerateUpdateSql(Dictionary<string, string> map)
        {
            List<DTOAttribute> list = GetColumName(typeof(T));
            string sql = "update " + DatabaseUtils<T>.GetTableName(typeof(T)) + " set ";
            string condition = " where ";
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].IsPrimaryKey)
                {
                    condition = condition + list[i].Column + "=" + UtilsUI.GetValuesFromDto(list[i].DataType.ToString(), map[list[i].Column]) + " and ";
                }
                if (list[i].DataType.ToString() == "GENERATED_ID")
                {
                    continue;
                }
                if (i == list.Count() - 1)
                {
                    sql = sql + list[i].Column + "=" + UtilsUI.GetValuesFromDto(list[i].DataType.ToString(), map[list[i].Column]);
                }
                else
                {
                    sql = sql + list[i].Column + "=" + UtilsUI.GetValuesFromDto(list[i].DataType.ToString(), map[list[i].Column])+",";
                }
            }
            sql = sql + condition;
            sql = sql.Trim();
            int index = sql.LastIndexOf(" ");
            sql = sql.Substring(0,index);
            return sql;
        }
        //generate delete query with primary key
        public static string GenerateDeletePrimary(Dictionary<string, string> map)
        {
            List<DTOAttribute> list = GetColumName(typeof(T));
            string sql = "delete from" + DatabaseUtils<T>.GetTableName(typeof(T)) + " where ";
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsPrimaryKey)
                {
                    sql = sql + list[i].Column + "=" + UtilsUI.GetValuesFromDto(list[i].DataType.ToString(), map[list[i].Column]) + ",";
                }
            }
            int index = sql.LastIndexOf(",");
            sql = sql.Substring(0, index - 1);
            return sql;
        }
    }
}
