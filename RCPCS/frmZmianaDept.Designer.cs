namespace RCPCS
{
    partial class frmZmianaDept
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listaDepartamentyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rCP = new RCPCS.RCP();
            this.lista_DepartamentyTableAdapter = new RCPCS.RCPTableAdapters.Lista_DepartamentyTableAdapter();
            this.Id_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edycja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Usun = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDepartamentyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Department,
            this.nameDataGridViewTextBoxColumn,
            this.Edycja,
            this.Usun});
            this.dataGridView1.DataSource = this.listaDepartamentyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // listaDepartamentyBindingSource
            // 
            this.listaDepartamentyBindingSource.DataMember = "Lista_Departamenty";
            this.listaDepartamentyBindingSource.DataSource = this.rCP;
            // 
            // rCP
            // 
            this.rCP.DataSetName = "RCP";
            this.rCP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lista_DepartamentyTableAdapter
            // 
            this.lista_DepartamentyTableAdapter.ClearBeforeFill = true;
            // 
            // Id_Department
            // 
            this.Id_Department.DataPropertyName = "Id_Department";
            this.Id_Department.HeaderText = "Id_Department";
            this.Id_Department.Name = "Id_Department";
            this.Id_Department.ReadOnly = true;
            this.Id_Department.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Edycja
            // 
            this.Edycja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edycja.HeaderText = "Edycja";
            this.Edycja.Name = "Edycja";
            this.Edycja.ReadOnly = true;
            this.Edycja.Text = "Edycja";
            this.Edycja.ToolTipText = "Edycja";
            this.Edycja.UseColumnTextForButtonValue = true;
            // 
            // Usun
            // 
            this.Usun.DataPropertyName = "Id_Department";
            this.Usun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usun.HeaderText = "Usun";
            this.Usun.Name = "Usun";
            this.Usun.ReadOnly = true;
            this.Usun.Text = "Usuń";
            this.Usun.ToolTipText = "Usuń";
            this.Usun.UseColumnTextForButtonValue = true;
            // 
            // frmZmianaDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 397);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZmianaDept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuwanie lub zmiana";
            this.Load += new System.EventHandler(this.frmZmianaDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDepartamentyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RCP rCP;
        private System.Windows.Forms.BindingSource listaDepartamentyBindingSource;
        private RCPTableAdapters.Lista_DepartamentyTableAdapter lista_DepartamentyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edycja;
        private System.Windows.Forms.DataGridViewButtonColumn Usun;
    }
}