using System;

namespace TrungTamTinHoc.DTO
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TableMappingAttribute : Attribute
    {
        public string Name { get; set; }
        public string InheritanceColumn { get; set; }

        public TableMappingAttribute() { }
        public TableMappingAttribute(string name, string inheritanceCol = "")
        {
            Name = name;
            InheritanceColumn = inheritanceCol;
        }
    }
}