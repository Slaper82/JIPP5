namespace RCPCS
{
    partial class frmZmiana
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
            this.cmbWybor = new System.Windows.Forms.ComboBox();
            this.btnWybierz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbWybor
            // 
            this.cmbWybor.FormattingEnabled = true;
            this.cmbWybor.Location = new System.Drawing.Point(22, 68);
            this.cmbWybor.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbWybor.Name = "cmbWybor";
            this.cmbWybor.Size = new System.Drawing.Size(301, 36);
            this.cmbWybor.TabIndex = 0;
            // 
            // btnWybierz
            // 
            this.btnWybierz.BackColor = System.Drawing.Color.White;
            this.btnWybierz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWybierz.Location = new System.Drawing.Point(337, 68);
            this.btnWybierz.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnWybierz.Name = "btnWybierz";
            this.btnWybierz.Size = new System.Drawing.Size(150, 36);
            this.btnWybierz.TabIndex = 1;
            this.btnWybierz.Text = "Wybierz";
            this.btnWybierz.UseVisualStyleBackColor = false;
            this.btnWybierz.Click += new System.EventHandler(this.btnWybierz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz z listy nową wartość";
            // 
            // frmZmiana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWybierz);
            this.Controls.Add(this.cmbWybor);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZmiana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zmiana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbWybor;
        private System.Windows.Forms.Button btnWybierz;
        private System.Windows.Forms.Label label1;
    }
}