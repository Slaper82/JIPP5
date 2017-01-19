namespace RCPCS
{
    partial class frmHarmoAdd
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
            this.cmbNazwa = new System.Windows.Forms.ComboBox();
            this.rcpSchemaNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rCP = new RCPCS.RCP();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rcpSchemaNameTableAdapter = new RCPCS.RCPTableAdapters.rcpSchemaNameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rcpSchemaNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCP)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNazwa
            // 
            this.cmbNazwa.DataSource = this.rcpSchemaNameBindingSource;
            this.cmbNazwa.DisplayMember = "Name";
            this.cmbNazwa.FormattingEnabled = true;
            this.cmbNazwa.Location = new System.Drawing.Point(16, 80);
            this.cmbNazwa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNazwa.Name = "cmbNazwa";
            this.cmbNazwa.Size = new System.Drawing.Size(212, 36);
            this.cmbNazwa.TabIndex = 0;
            this.cmbNazwa.ValueMember = "Id";
            // 
            // rcpSchemaNameBindingSource
            // 
            this.rcpSchemaNameBindingSource.DataMember = "rcpSchemaName";
            this.rcpSchemaNameBindingSource.DataSource = this.rCP;
            // 
            // rCP
            // 
            this.rCP.DataSetName = "RCP";
            this.rCP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyyMMdd";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(248, 80);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(150, 34);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpStop
            // 
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStop.Location = new System.Drawing.Point(433, 80);
            this.dtpStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(159, 34);
            this.dtpStop.TabIndex = 2;
            // 
            // btnZapisz
            // 
            this.btnZapisz.BackColor = System.Drawing.Color.White;
            this.btnZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapisz.Location = new System.Drawing.Point(635, 79);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(151, 37);
            this.btnZapisz.TabIndex = 3;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = false;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa schematu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stop";
            // 
            // rcpSchemaNameTableAdapter
            // 
            this.rcpSchemaNameTableAdapter.ClearBeforeFill = true;
            // 
            // frmHarmoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 173);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cmbNazwa);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHarmoAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj Harmonogram";
            this.Load += new System.EventHandler(this.frmHarmoAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcpSchemaNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNazwa;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RCP rCP;
        private System.Windows.Forms.BindingSource rcpSchemaNameBindingSource;
        private RCPTableAdapters.rcpSchemaNameTableAdapter rcpSchemaNameTableAdapter;
    }
}