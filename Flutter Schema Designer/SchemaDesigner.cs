using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutter_Schema_Designer
{
    internal class SchemaDesigner
    {
        SchemaModel model;
        public SchemaDesigner(SchemaModel model) => this.model = model;
        public string Design()
        {
            string _data =
$@"import 'dart:convert';

class {this.model.schemaName}
{"{"}
{"\n"}"
+ DesignProperties()
+ System.Environment.NewLine
+ DesignConstructor()
+ System.Environment.NewLine
+ DesignToMap()
+ System.Environment.NewLine
+ DesignFromMap()
+ System.Environment.NewLine
+ DesignToJson()
+ System.Environment.NewLine
+ DesignFromJson()
+ $@"{"}"}";
            return _data;
        }
        private string DesignProperties()
        {
            string result = string.Empty;
            foreach(var property in this.model.schemaProperties)
            {
                result += $"{new String(' ', 4)}final {property.variable}? {property.name};";
                result += System.Environment.NewLine;
            }
            return result;
        }
        private string DesignConstructor()
        {
            string result = string.Empty;
            result += $"{new String(' ', 4)}{this.model.schemaName}";
            result += "({";
            result += System.Environment.NewLine;
            foreach (var property in this.model.schemaProperties)
            {
                result += $"{new String(' ', 8)}this.{property.name},";
                result += System.Environment.NewLine;
            }
            result += new String(' ', 4) + "});";
            result += System.Environment.NewLine;

            return result;
        }
        private string DesignToMap()
        {
            string result = string.Empty;
            result += $"{new String(' ', 4)}Map<String, dynamic> toMap()";


            result += "{";
            result += System.Environment.NewLine;
            result += $"{new String(' ', 4)} return " + "{";
            result += System.Environment.NewLine;
            foreach (var property in this.model.schemaProperties)
            {
                result += $"{new String(' ', 8)}'{property.name}': {property.name},";
                result += System.Environment.NewLine;
            }
            result += new String(' ', 4) + "};";
            result += System.Environment.NewLine;

            return result;
        }

        private string DesignFromMap()
        {
            string result = string.Empty;
            result += $"{new String(' ', 4)}factory {this.model.schemaName}.fromMap(Map<String, dynamic> map)";


            result += "{";
            result += System.Environment.NewLine;
            result += $"{new String(' ', 4)} return " + "{";
            result += System.Environment.NewLine;
            foreach (var property in this.model.schemaProperties)
            {
                result += $"{new String(' ', 8)}{property.name}: map['{property.name}'],";
                result += System.Environment.NewLine;
            }
            result += new String(' ', 4) + "};";
            result += System.Environment.NewLine;

            return result;
        }

        private string DesignToJson()
        {
            string result = $"{new String(' ', 4)}String toJson() => json.encode(toMap());";
            result += System.Environment.NewLine;
            return result;
        }
        private string DesignFromJson()
        {
            string result = $"{new String(' ', 4)}factory {this.model.schemaName}.fromJson(String source) => {this.model.schemaName}.fromMap(json.decode(source));";
            result += System.Environment.NewLine;
            return result;
        }
    }
}
