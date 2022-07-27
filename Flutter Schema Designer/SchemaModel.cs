using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutter_Schema_Designer
{
    public class SchemaModel
    {
        public string schemaName { get; set; }
        public List<SchemaProperty> schemaProperties { get; set; }
    }
}
