namespace RCPCS
{
    partial class frmSchemaEdit
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
            this.rcpSchemaNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rCPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rCP = new RCPCS.RCP();
            this.rcpSchemaNameTableAdapter = new RCPCS.RCPTableAdapters.rcpSchemaNameTableAdapter();
            this.chbSob = new System.Windows.Forms.CheckBox();
            this.chbPia = new System.Windows.Forms.CheckBox();
            this.chbCzw = new System.Windows.Forms.CheckBox();
            this.chbSro = new System.Windows.Forms.CheckBox();
            this.chbWto = new System.Windows.Forms.CheckBox();
            this.chbPon = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNazwaSchematu = new System.Windows.Forms.TextBox();
            this.rcpSchemaNameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schemaDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1070_RejCzasDataSet = new RCPCS._1070_RejCzasDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtPonStop = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNieStop = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSobStop = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPiaStop = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCzwStop = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSroStop = new System.Windows.Forms.MaskedTextBox();
            this.mtxtWtoStop = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPonStart = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNieStart = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSobStart = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPiaStart = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCzwStart = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSroStart = new System.Windows.Forms.MaskedTextBox();
            this.mtxtWtoStart = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.schemaDetTableAdapter = new RCPCS._1070_RejCzasDataSetTableAdapters.SchemaDetTableAdapter();
            this.schemaDetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lstSchema = new System.Windows.Forms.ListBox();
            this.chbNie = new System.Windows.Forms.CheckBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rcpSchemaNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcpSchemaNameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1070_RejCzasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaDetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rcpSchemaNameBindingSource
            // 
            this.rcpSchemaNameBindingSource.DataMember = "rcpSchemaName";
            this.rcpSchemaNameBindingSource.DataSource = this.rCPBindingSource;
            // 
            // rCPBindingSource
            // 
            this.rCPBindingSource.DataSource = this.rCP;
            this.rCPBindingSource.Position = 0;
            // 
            // rCP
            // 
            this.rCP.DataSetName = "RCP";
            this.rCP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rcpSchemaNameTableAdapter
            // 
            this.rcpSchemaNameTableAdapter.ClearBeforeFill = true;
            // 
            // chbSob
            // 
            this.chbSob.AutoSize = true;
            this.chbSob.Location = new System.Drawing.Point(555, 420);
            this.chbSob.Name = "chbSob";
            this.chbSob.Size = new System.Drawing.Size(85, 23);
            this.chbSob.TabIndex = 64;
            this.chbSob.Text = "Aktywny";
            this.chbSob.UseVisualStyleBackColor = true;
            this.chbSob.Click += new System.EventHandler(this.chbPon_CheckedChanged);
            // 
            // chbPia
            // 
            this.chbPia.AutoSize = true;
            this.chbPia.Location = new System.Drawing.Point(555, 374);
            this.chbPia.Name = "chbPia";
            this.chbPia.Size = new System.Drawing.Size(85, 23);
            this.chbPia.TabIndex = 63;
            this.chbPia.Text = "Aktywny";
            this.chbPia.UseVisualStyleBackColor = true;
            this.chbPia.Click += new System.EventHandler(this.chbPon_CheckedChanged);
            // 
            // chbCzw
            // 
            this.chbCzw.AutoSize = true;
            this.chbCzw.Location = new System.Drawing.Point(555, 328);
            this.chbCzw.Name = "chbCzw";
            this.chbCzw.Size = new System.Drawing.Size(85, 23);
            this.chbCzw.TabIndex = 62;
            this.chbCzw.Text = "Aktywny";
            this.chbCzw.UseVisualStyleBackColor = true;
            this.chbCzw.Click += new System.EventHandler(this.chbPon_CheckedChanged);
            // 
            // chbSro
            // 
            this.chbSro.AutoSize = true;
            this.chbSro.Location = new System.Drawing.Point(555, 282);
            this.chbSro.Name = "chbSro";
            this.chbSro.Size = new System.Drawing.Size(85, 23);
            this.chbSro.TabIndex = 61;
            this.chbSro.Text = "Aktywny";
            this.chbSro.UseVisualStyleBackColor = true;
            this.chbSro.Click += new System.EventHandler(this.chbPon_CheckedChanged);
            // 
            // chbWto
            // 
            this.chbWto.AutoSize = true;
            this.chbWto.Location = new System.Drawing.Point(555, 241);
            this.chbWto.Name = "chbWto";
            this.chbWto.Size = new System.Drawing.Size(85, 23);
            this.chbWto.TabIndex = 60;
            this.chbWto.Text = "Aktywny";
            this.chbWto.UseVisualStyleBackColor = true;
            this.chbWto.Click += new System.EventHandler(this.chbPon_CheckedChanged);
            // 
            // chbPon
            // 
            this.chbPon.AutoSize = true;
            this.chbPon.Location = new System.Drawing.Point(555, 199);
            this.chbPon.Name = "chbPon";
            this.chbPon.Size = new System.Drawing.Size(85, 23);
            this.chbPon.TabIndex = 59;
            this.chbPon.Text = "Aktywny";
            this.chbPon.UseVisualStyleBackColor = true;
            this.chbPon.Click += new System.EventHandler(this.chbPon_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 19);
            this.label10.TabIndex = 58;
            this.label10.Text = "Nazwa Schematu";
            // 
            // txtNazwaSchematu
            // 
            this.txtNazwaSchematu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rcpSchemaNameBindingSource1, "Name", true));
            this.txtNazwaSchematu.Location = new System.Drawing.Point(404, 109);
            this.txtNazwaSchematu.Name = "txtNazwaSchematu";
            this.txtNazwaSchematu.Size = new System.Drawing.Size(203, 25);
            this.txtNazwaSchematu.TabIndex = 57;
            // 
            // rcpSchemaNameBindingSource1
            // 
            this.rcpSchemaNameBindingSource1.DataMember = "rcpSchemaName";
            this.rcpSchemaNameBindingSource1.DataSource = this.rCP;
            // 
            // schemaDetBindingSource
            // 
            this.schemaDetBindingSource.DataMember = "SchemaDet";
            this.schemaDetBindingSource.DataSource = this._1070_RejCzasDataSet;
            // 
            // _1070_RejCzasDataSet
            // 
            this._1070_RejCzasDataSet.DataSetName = "_1070_RejCzasDataSet";
            this._1070_RejCzasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 56;
            this.label9.Text = "Stop";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 55;
            this.label8.Text = "Start";
            // 
            // mtxtPonStop
            // 
            this.mtxtPonStop.Location = new System.Drawing.Point(465, 197);
            this.mtxtPonStop.Name = "mtxtPonStop";
            this.mtxtPonStop.Size = new System.Drawing.Size(44, 25);
            this.mtxtPonStop.TabIndex = 54;
            // 
            // mtxtNieStop
            // 
            this.mtxtNieStop.Location = new System.Drawing.Point(465, 464);
            this.mtxtNieStop.Name = "mtxtNieStop";
            this.mtxtNieStop.Size = new System.Drawing.Size(44, 25);
            this.mtxtNieStop.TabIndex = 53;
            // 
            // mtxtSobStop
            // 
            this.mtxtSobStop.Location = new System.Drawing.Point(465, 416);
            this.mtxtSobStop.Name = "mtxtSobStop";
            this.mtxtSobStop.Size = new System.Drawing.Size(44, 25);
            this.mtxtSobStop.TabIndex = 52;
            // 
            // mtxtPiaStop
            // 
            this.mtxtPiaStop.Location = new System.Drawing.Point(465, 373);
            this.mtxtPiaStop.Name = "mtxtPiaStop";
            this.mtxtPiaStop.Size = new System.Drawing.Size(44, 25);
            this.mtxtPiaStop.TabIndex = 51;
            // 
            // mtxtCzwStop
            // 
            this.mtxtCzwStop.Location = new System.Drawing.Point(465, 326);
            this.mtxtCzwStop.Name = "mtxtCzwStop";
            this.mtxtCzwStop.Size = new System.Drawing.Size(44, 25);
            this.mtxtCzwStop.TabIndex = 50;
            // 
            // mtxtSroStop
            // 
            this.mtxtSroStop.Location = new System.Drawing.Point(465, 279);
            this.mtxtSroStop.Name = "mtxtSroStop";
            this.mtxtSroStop.Size = new System.Drawing.Size(44, 25);
            this.mtxtSroStop.TabIndex = 49;
            // 
            // mtxtWtoStop
            // 
            this.mtxtWtoStop.Location = new System.Drawing.Point(465, 238);
            this.mtxtWtoStop.Name = "mtxtWtoStop";
            this.mtxtWtoStop.Size = new System.Drawing.Size(44, 25);
            this.mtxtWtoStop.TabIndex = 48;
            // 
            // mtxtPonStart
            // 
            this.mtxtPonStart.Location = new System.Drawing.Point(382, 197);
            this.mtxtPonStart.Name = "mtxtPonStart";
            this.mtxtPonStart.Size = new System.Drawing.Size(44, 25);
            this.mtxtPonStart.TabIndex = 47;
            // 
            // mtxtNieStart
            // 
            this.mtxtNieStart.Location = new System.Drawing.Point(382, 464);
            this.mtxtNieStart.Name = "mtxtNieStart";
            this.mtxtNieStart.Size = new System.Drawing.Size(44, 25);
            this.mtxtNieStart.TabIndex = 46;
            // 
            // mtxtSobStart
            // 
            this.mtxtSobStart.Location = new System.Drawing.Point(382, 416);
            this.mtxtSobStart.Name = "mtxtSobStart";
            this.mtxtSobStart.Size = new System.Drawing.Size(44, 25);
            this.mtxtSobStart.TabIndex = 45;
            // 
            // mtxtPiaStart
            // 
            this.mtxtPiaStart.Location = new System.Drawing.Point(382, 373);
            this.mtxtPiaStart.Name = "mtxtPiaStart";
            this.mtxtPiaStart.Size = new System.Drawing.Size(44, 25);
            this.mtxtPiaStart.TabIndex = 44;
            // 
            // mtxtCzwStart
            // 
            this.mtxtCzwStart.Location = new System.Drawing.Point(382, 326);
            this.mtxtCzwStart.Name = "mtxtCzwStart";
            this.mtxtCzwStart.Size = new System.Drawing.Size(44, 25);
            this.mtxtCzwStart.TabIndex = 43;
            // 
            // mtxtSroStart
            // 
            this.mtxtSroStart.Location = new System.Drawing.Point(382, 279);
            this.mtxtSroStart.Name = "mtxtSroStart";
            this.mtxtSroStart.Size = new System.Drawing.Size(44, 25);
            this.mtxtSroStart.TabIndex = 42;
            // 
            // mtxtWtoStart
            // 
            this.mtxtWtoStart.Location = new System.Drawing.Point(382, 238);
            this.mtxtWtoStart.Name = "mtxtWtoStart";
            this.mtxtWtoStart.Size = new System.Drawing.Size(44, 25);
            this.mtxtWtoStart.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Niedziela";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Sobota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Piątek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Czwartek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Środa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Wtorek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Poniedziałek";
            // 
            // schemaDetTableAdapter
            // 
            this.schemaDetTableAdapter.ClearBeforeFill = true;
            // 
            // schemaDetBindingSource1
            // 
            this.schemaDetBindingSource1.DataMember = "SchemaDet";
            this.schemaDetBindingSource1.DataSource = this._1070_RejCzasDataSet;
            // 
            // lstSchema
            // 
            this.lstSchema.DataSource = this.rcpSchemaNameBindingSource1;
            this.lstSchema.DisplayMember = "Name";
            this.lstSchema.FormattingEnabled = true;
            this.lstSchema.ItemHeight = 17;
            this.lstSchema.Location = new System.Drawing.Point(12, 44);
            this.lstSchema.Name = "lstSchema";
            this.lstSchema.Size = new System.Drawing.Size(221, 446);
            this.lstSchema.TabIndex = 65;
            this.lstSchema.ValueMember = "Id";
            this.lstSchema.Click += new System.EventHandler(this.lstBSchema_Click);
            // 
            // chbNie
            // 
            this.chbNie.AutoSize = true;
            this.chbNie.Location = new System.Drawing.Point(555, 464);
            this.chbNie.Name = "chbNie";
            this.chbNie.Size = new System.Drawing.Size(85, 23);
            this.chbNie.TabIndex = 66;
            this.chbNie.Text = "Aktywny";
            this.chbNie.UseVisualStyleBackColor = true;
            this.chbNie.Click += new System.EventHandler(this.chbPon_CheckedChanged);
            // 
            // btnZapisz
            // 
            this.btnZapisz.BackColor = System.Drawing.Color.White;
            this.btnZapisz.Enabled = false;
            this.btnZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapisz.Location = new System.Drawing.Point(699, 109);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(131, 45);
            this.btnZapisz.TabIndex = 67;
            this.btnZapisz.Text = "Zapisz zmiany";
            this.btnZapisz.UseVisualStyleBackColor = false;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.BackColor = System.Drawing.Color.White;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamknij.Location = new System.Drawing.Point(699, 232);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(131, 41);
            this.btnZamknij.TabIndex = 68;
            this.btnZamknij.Text = "Anuluj";
            this.btnZamknij.UseVisualStyleBackColor = false;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.White;
            this.btnUsun.Enabled = false;
            this.btnUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsun.Location = new System.Drawing.Point(699, 171);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(131, 41);
            this.btnUsun.TabIndex = 69;
            this.btnUsun.Text = "Usuń schemat";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // frmSchemaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 528);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.chbNie);
            this.Controls.Add(this.lstSchema);
            this.Controls.Add(this.chbSob);
            this.Controls.Add(this.chbPia);
            this.Controls.Add(this.chbCzw);
            this.Controls.Add(this.chbSro);
            this.Controls.Add(this.chbWto);
            this.Controls.Add(this.chbPon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNazwaSchematu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtPonStop);
            this.Controls.Add(this.mtxtNieStop);
            this.Controls.Add(this.mtxtSobStop);
            this.Controls.Add(this.mtxtPiaStop);
            this.Controls.Add(this.mtxtCzwStop);
            this.Controls.Add(this.mtxtSroStop);
            this.Controls.Add(this.mtxtWtoStop);
            this.Controls.Add(this.mtxtPonStart);
            this.Controls.Add(this.mtxtNieStart);
            this.Controls.Add(this.mtxtSobStart);
            this.Controls.Add(this.mtxtPiaStart);
            this.Controls.Add(this.mtxtCzwStart);
            this.Controls.Add(this.mtxtSroStart);
            this.Controls.Add(this.mtxtWtoStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmSchemaEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zarządzanie schematami";
            this.Load += new System.EventHandler(this.frmSchemaEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcpSchemaNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcpSchemaNameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1070_RejCzasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaDetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource rCPBindingSource;
        private RCP rCP;
        private System.Windows.Forms.BindingSource rcpSchemaNameBindingSource;
        private RCPTableAdapters.rcpSchemaNameTableAdapter rcpSchemaNameTableAdapter;
        public System.Windows.Forms.CheckBox chbSob;
        public System.Windows.Forms.CheckBox chbPia;
        public System.Windows.Forms.CheckBox chbCzw;
        public System.Windows.Forms.CheckBox chbSro;
        public System.Windows.Forms.CheckBox chbWto;
        public System.Windows.Forms.CheckBox chbPon;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtNazwaSchematu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox mtxtPonStop;
        public System.Windows.Forms.MaskedTextBox mtxtNieStop;
        public System.Windows.Forms.MaskedTextBox mtxtSobStop;
        public System.Windows.Forms.MaskedTextBox mtxtPiaStop;
        public System.Windows.Forms.MaskedTextBox mtxtCzwStop;
        public System.Windows.Forms.MaskedTextBox mtxtSroStop;
        public System.Windows.Forms.MaskedTextBox mtxtWtoStop;
        public System.Windows.Forms.MaskedTextBox mtxtPonStart;
        public System.Windows.Forms.MaskedTextBox mtxtNieStart;
        public System.Windows.Forms.MaskedTextBox mtxtSobStart;
        public System.Windows.Forms.MaskedTextBox mtxtPiaStart;
        public System.Windows.Forms.MaskedTextBox mtxtCzwStart;
        public System.Windows.Forms.MaskedTextBox mtxtSroStart;
        public System.Windows.Forms.MaskedTextBox mtxtWtoStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource schemaDetBindingSource;
        private _1070_RejCzasDataSet _1070_RejCzasDataSet;
        private _1070_RejCzasDataSetTableAdapters.SchemaDetTableAdapter schemaDetTableAdapter;
        private System.Windows.Forms.BindingSource schemaDetBindingSource1;
        public System.Windows.Forms.ListBox lstSchema;
        private System.Windows.Forms.BindingSource rcpSchemaNameBindingSource1;
        public System.Windows.Forms.CheckBox chbNie;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnUsun;
    }
}