namespace RCPCS
{
    partial class frmDodPracownik
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
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.listaDepartamentyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rCP = new RCPCS.RCP();
            this.cmbUprawnienia = new System.Windows.Forms.ComboBox();
            this.uprawnieniaListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uprawnieniaDataSet = new RCPCS.UprawnieniaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.lista_DepartamentyTableAdapter = new RCPCS.RCPTableAdapters.Lista_DepartamentyTableAdapter();
            this.uprawnienia_ListaTableAdapter = new RCPCS.UprawnieniaDataSetTableAdapters.Uprawnienia_ListaTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listaDepartamentyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uprawnieniaListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uprawnieniaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(22, 53);
            this.txtImie.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(240, 34);
            this.txtImie.TabIndex = 0;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(22, 131);
            this.txtNazwisko.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(240, 34);
            this.txtNazwisko.TabIndex = 1;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaDepartamentyBindingSource, "Id_Department", true));
            this.cmbDepartment.DataSource = this.listaDepartamentyBindingSource;
            this.cmbDepartment.DisplayMember = "Name";
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(22, 213);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(240, 36);
            this.cmbDepartment.TabIndex = 2;
            this.cmbDepartment.ValueMember = "Id_Department";
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
            // cmbUprawnienia
            // 
            this.cmbUprawnienia.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaDepartamentyBindingSource, "Id_Department", true));
            this.cmbUprawnienia.DataSource = this.uprawnieniaListaBindingSource;
            this.cmbUprawnienia.DisplayMember = "Nazwa";
            this.cmbUprawnienia.FormattingEnabled = true;
            this.cmbUprawnienia.Location = new System.Drawing.Point(22, 300);
            this.cmbUprawnienia.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbUprawnienia.Name = "cmbUprawnienia";
            this.cmbUprawnienia.Size = new System.Drawing.Size(240, 36);
            this.cmbUprawnienia.TabIndex = 3;
            this.cmbUprawnienia.ValueMember = "Id_Privillige";
            // 
            // uprawnieniaListaBindingSource
            // 
            this.uprawnieniaListaBindingSource.DataMember = "Uprawnienia_Lista";
            this.uprawnieniaListaBindingSource.DataSource = this.uprawnieniaDataSet;
            // 
            // uprawnieniaDataSet
            // 
            this.uprawnieniaDataSet.DataSetName = "UprawnieniaDataSet";
            this.uprawnieniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Uprawnienia";
            // 
            // btnZapisz
            // 
            this.btnZapisz.BackColor = System.Drawing.Color.White;
            this.btnZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapisz.Location = new System.Drawing.Point(289, 440);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(221, 49);
            this.btnZapisz.TabIndex = 8;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = false;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.BackColor = System.Drawing.Color.White;
            this.btnAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuluj.Location = new System.Drawing.Point(22, 440);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(220, 49);
            this.btnAnuluj.TabIndex = 9;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = false;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.Location = new System.Drawing.Point(18, 361);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(130, 32);
            this.rdbMale.TabIndex = 10;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Mężczyzna";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(160, 361);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(102, 32);
            this.rdbFemale.TabIndex = 11;
            this.rdbFemale.Text = "Kobieta";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // lista_DepartamentyTableAdapter
            // 
            this.lista_DepartamentyTableAdapter.ClearBeforeFill = true;
            // 
            // uprawnienia_ListaTableAdapter
            // 
            this.uprawnienia_ListaTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(289, 53);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(257, 34);
            this.txtLogin.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hasło";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(289, 131);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(257, 34);
            this.txtPass.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Powtórz hasło";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(290, 211);
            this.txtPass2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(257, 34);
            this.txtPass2.TabIndex = 16;
            // 
            // frmDodPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 538);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUprawnienia);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtImie);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmDodPracownik";
            this.Text = "Dodaj pracownika";
            this.Load += new System.EventHandler(this.frmDodPracownik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDepartamentyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uprawnieniaListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uprawnieniaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbUprawnienia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private RCP rCP;
        private System.Windows.Forms.BindingSource listaDepartamentyBindingSource;
        private RCPTableAdapters.Lista_DepartamentyTableAdapter lista_DepartamentyTableAdapter;
        private UprawnieniaDataSet uprawnieniaDataSet;
        private System.Windows.Forms.BindingSource uprawnieniaListaBindingSource;
        private UprawnieniaDataSetTableAdapters.Uprawnienia_ListaTableAdapter uprawnienia_ListaTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass2;
    }
}