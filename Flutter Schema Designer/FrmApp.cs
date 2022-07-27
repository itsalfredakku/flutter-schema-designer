using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flutter_Schema_Designer
{
    public partial class FrmApp : Form
    {
        public FrmApp()
        {
            InitializeComponent();
        }

        private void tBoxSchemaName_TextChanged(object sender, EventArgs e)
        {
            if(this.tBoxSchemaName.TextLength > 0)
            {
                this.dgvSchema.Enabled = true;
                this.tBoxCodeOutput.Enabled = true;
                ExecDesigner();
            }
            else
            {
                this.dgvSchema.Enabled = false;
                this.tBoxCodeOutput.Enabled = false;
                this.tBoxCodeOutput.Text = string.Empty;
            }
        }

        private void dgvSchema_CellValueChanged(object sender, DataGridViewCellEventArgs e) => ExecDesigner();

        private void ExecDesigner()
        {
            List<SchemaProperty> schemaProperties = new List<SchemaProperty>();
            foreach(DataGridViewRow row in this.dgvSchema.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    if (SchemaVariableExtensions.FromKeyword(row.Cells[1].Value.ToString()) == null)
                    {
                        throw new Exception("Keyword Error");
                    }

                    schemaProperties.Add(
                        new SchemaProperty()
                        {
                            name = row.Cells[0].Value.ToString(),
                            variable = (SchemaVariable)SchemaVariableExtensions.FromKeyword(row.Cells[1].Value.ToString())
                        }
                        );
                }
            }
            SchemaDesigner designer = new SchemaDesigner(new SchemaModel()
            {
                schemaName = this.tBoxSchemaName.Text,
                schemaProperties = schemaProperties
            });
            this.tBoxCodeOutput.Text = designer.Design();
        }

        private void FrmApp_Load(object sender, EventArgs e)
        {
            this.tBoxSchemaName.Text = string.Empty;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tBoxCodeOutput.Text);
        }
    }
}
