
namespace EDnevnik
{
    partial class Ocena
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
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.Grid_Ocene = new System.Windows.Forms.DataGridView();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.cmbOdeljenje = new System.Windows.Forms.ComboBox();
            this.cmbUcenik = new System.Windows.Forms.ComboBox();
            this.cmbOcena = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.lblOdeljenje = new System.Windows.Forms.Label();
            this.lblUcenik = new System.Windows.Forms.Label();
            this.lblOcena = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGodina
            // 
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(23, 33);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(121, 21);
            this.cmbGodina.TabIndex = 0;
            this.cmbGodina.SelectedValueChanged += new System.EventHandler(this.cmbGodina_SelectedValueChanged);
            // 
            // Datum
            // 
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum.Location = new System.Drawing.Point(482, 91);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(121, 20);
            this.Datum.TabIndex = 1;
            // 
            // Grid_Ocene
            // 
            this.Grid_Ocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Ocene.Location = new System.Drawing.Point(23, 171);
            this.Grid_Ocene.Name = "Grid_Ocene";
            this.Grid_Ocene.Size = new System.Drawing.Size(689, 249);
            this.Grid_Ocene.TabIndex = 2;
            this.Grid_Ocene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Ocene_CellClick);
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(176, 33);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesor.TabIndex = 3;
            this.cmbProfesor.SelectedValueChanged += new System.EventHandler(this.cmbProfesor_SelectedValueChanged);
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(329, 33);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(121, 21);
            this.cmbPredmet.TabIndex = 4;
            this.cmbPredmet.SelectedValueChanged += new System.EventHandler(this.cmbPredmet_SelectedValueChanged);
            // 
            // cmbOdeljenje
            // 
            this.cmbOdeljenje.FormattingEnabled = true;
            this.cmbOdeljenje.Location = new System.Drawing.Point(482, 33);
            this.cmbOdeljenje.Name = "cmbOdeljenje";
            this.cmbOdeljenje.Size = new System.Drawing.Size(121, 21);
            this.cmbOdeljenje.TabIndex = 5;
            this.cmbOdeljenje.SelectedValueChanged += new System.EventHandler(this.cmbOdeljenje_SelectedValueChanged);
            // 
            // cmbUcenik
            // 
            this.cmbUcenik.FormattingEnabled = true;
            this.cmbUcenik.Location = new System.Drawing.Point(23, 90);
            this.cmbUcenik.Name = "cmbUcenik";
            this.cmbUcenik.Size = new System.Drawing.Size(121, 21);
            this.cmbUcenik.TabIndex = 6;
            // 
            // cmbOcena
            // 
            this.cmbOcena.FormattingEnabled = true;
            this.cmbOcena.Location = new System.Drawing.Point(176, 90);
            this.cmbOcena.Name = "cmbOcena";
            this.cmbOcena.Size = new System.Drawing.Size(121, 21);
            this.cmbOcena.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(329, 91);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 8;
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(20, 17);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(41, 13);
            this.lblGodina.TabIndex = 9;
            this.lblGodina.Text = "Godina";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(173, 17);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(46, 13);
            this.lblProfesor.TabIndex = 10;
            this.lblProfesor.Text = "Profesor";
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Location = new System.Drawing.Point(326, 17);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(46, 13);
            this.lblPredmet.TabIndex = 11;
            this.lblPredmet.Text = "Predmet";
            // 
            // lblOdeljenje
            // 
            this.lblOdeljenje.AutoSize = true;
            this.lblOdeljenje.Location = new System.Drawing.Point(479, 17);
            this.lblOdeljenje.Name = "lblOdeljenje";
            this.lblOdeljenje.Size = new System.Drawing.Size(51, 13);
            this.lblOdeljenje.TabIndex = 12;
            this.lblOdeljenje.Text = "Odeljenje";
            // 
            // lblUcenik
            // 
            this.lblUcenik.AutoSize = true;
            this.lblUcenik.Location = new System.Drawing.Point(20, 74);
            this.lblUcenik.Name = "lblUcenik";
            this.lblUcenik.Size = new System.Drawing.Size(41, 13);
            this.lblUcenik.TabIndex = 13;
            this.lblUcenik.Text = "Ucenik";
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.Location = new System.Drawing.Point(173, 74);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(39, 13);
            this.lblOcena.TabIndex = 14;
            this.lblOcena.Text = "Ocena";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(326, 72);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(479, 75);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 16;
            this.lblDatum.Text = "Datum";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(637, 31);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Dodaj";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(637, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Izmeni";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(637, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Brisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(689, 20);
            this.textBox2.TabIndex = 20;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 440);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblOcena);
            this.Controls.Add(this.lblUcenik);
            this.Controls.Add(this.lblOdeljenje);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbOcena);
            this.Controls.Add(this.cmbUcenik);
            this.Controls.Add(this.cmbOdeljenje);
            this.Controls.Add(this.cmbPredmet);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.Grid_Ocene);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.cmbGodina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.DataGridView Grid_Ocene;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.ComboBox cmbPredmet;
        private System.Windows.Forms.ComboBox cmbOdeljenje;
        private System.Windows.Forms.ComboBox cmbUcenik;
        private System.Windows.Forms.ComboBox cmbOcena;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.Label lblOdeljenje;
        private System.Windows.Forms.Label lblUcenik;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox2;
    }
}