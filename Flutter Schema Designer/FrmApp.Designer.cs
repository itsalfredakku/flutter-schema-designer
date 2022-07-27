namespace Flutter_Schema_Designer
{
    partial class FrmApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApp));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvSchema = new System.Windows.Forms.DataGridView();
            this.tBoxCodeOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBoxSchemaName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemaPropertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchema)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schemaPropertyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvSchema);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tBoxCodeOutput);
            this.splitContainer1.Size = new System.Drawing.Size(776, 391);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvSchema
            // 
            this.dgvSchema.AutoGenerateColumns = false;
            this.dgvSchema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.variableDataGridViewTextBoxColumn});
            this.dgvSchema.DataSource = this.schemaPropertyBindingSource;
            this.dgvSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchema.Enabled = false;
            this.dgvSchema.Location = new System.Drawing.Point(0, 0);
            this.dgvSchema.Name = "dgvSchema";
            this.dgvSchema.Size = new System.Drawing.Size(273, 391);
            this.dgvSchema.TabIndex = 0;
            this.dgvSchema.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchema_CellValueChanged);
            // 
            // tBoxCodeOutput
            // 
            this.tBoxCodeOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBoxCodeOutput.Enabled = false;
            this.tBoxCodeOutput.Location = new System.Drawing.Point(0, 0);
            this.tBoxCodeOutput.Multiline = true;
            this.tBoxCodeOutput.Name = "tBoxCodeOutput";
            this.tBoxCodeOutput.Size = new System.Drawing.Size(499, 391);
            this.tBoxCodeOutput.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 391);
            this.panel1.TabIndex = 1;
            // 
            // tBoxSchemaName
            // 
            this.tBoxSchemaName.Location = new System.Drawing.Point(95, 12);
            this.tBoxSchemaName.Name = "tBoxSchemaName";
            this.tBoxSchemaName.Size = new System.Drawing.Size(190, 20);
            this.tBoxSchemaName.TabIndex = 2;
            this.tBoxSchemaName.TextChanged += new System.EventHandler(this.tBoxSchemaName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Schema Name";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(713, 18);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // variableDataGridViewTextBoxColumn
            // 
            this.variableDataGridViewTextBoxColumn.DataPropertyName = "variable";
            this.variableDataGridViewTextBoxColumn.HeaderText = "Variable";
            this.variableDataGridViewTextBoxColumn.Name = "variableDataGridViewTextBoxColumn";
            // 
            // schemaPropertyBindingSource
            // 
            this.schemaPropertyBindingSource.DataSource = typeof(Flutter_Schema_Designer.SchemaProperty);
            // 
            // FrmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxSchemaName);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmApp";
            this.Text = "Flutter Schema Designer | @itsalfredakku";
            this.Load += new System.EventHandler(this.FrmApp_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchema)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schemaPropertyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvSchema;
        private System.Windows.Forms.TextBox tBoxCodeOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBoxSchemaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource schemaPropertyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variableDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCopy;
    }
}

