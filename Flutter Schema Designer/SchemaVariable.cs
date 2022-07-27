using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutter_Schema_Designer
{
    public enum SchemaVariable
    {
        String,
        Integer,
        Double,
        Boolean,
    }
    public static class SchemaVariableExtensions
    {
        public static string ToKeyword(this SchemaVariable me)
        {
            switch (me)
            {
                case SchemaVariable.String:
                    return "String";
                case SchemaVariable.Integer:
                    return "int";
                case SchemaVariable.Double:
                    return "double";
                case SchemaVariable.Boolean:
                    return "bool";
                default:
                    return null;
            }
        }
        public static SchemaVariable? FromKeyword(this string me)
        {
            switch (me)
            {
                case "String":
                    return SchemaVariable.String;
                case "int":
                    return SchemaVariable.Integer;
                case "double":
                    return SchemaVariable.Double;
                case "bool":
                    return SchemaVariable.Boolean;
                default:
                    return null;
            }
        }
    }
}
