using TrungTamTinHoc.Const;
using System;
using System.Reflection;

namespace TrungTamTinHoc.DTO
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class DTOAttribute : Attribute
    {
        public int ChangeSetID { get; set; }
        public int DeleteChangeSetID { get; set; }
        public string Column { get; set; }
        public object DefaultValue { get; set; }
        public DATATYPE DataType { get; set; }
        public bool IsPrimaryKey { get; set; }
        public PropertyInfo PropertyInfo { get; set; }

        public DTOAttribute()
        {
            ChangeSetID = 1;
            IsPrimaryKey = false;
        }
        public DTOAttribute(int changeSetID, String column, object defaultValue, DATATYPE dataType, bool primaryKey, int deleteChangeSetId)
		{
			this.ChangeSetID = changeSetID;
			this.DeleteChangeSetID = deleteChangeSetId;
			this.Column = column;
			this.DefaultValue = defaultValue;
			this.DataType = dataType;
			this.IsPrimaryKey = primaryKey;
		}
	}
}
