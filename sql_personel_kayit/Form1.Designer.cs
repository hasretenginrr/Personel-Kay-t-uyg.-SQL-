namespace sql_personel_kayit
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.meslektxt = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.sehirtext = new System.Windows.Forms.ComboBox();
            this.maastxt = new System.Windows.Forms.MaskedTextBox();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.istatistikbtn = new System.Windows.Forms.Button();
            this.temizlebtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new sql_personel_kayit.PersonelVeriTabaniDataSet();
            this.tbl_personelTableAdapter = new sql_personel_kayit.PersonelVeriTabaniDataSetTableAdapters.tbl_personelTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.meslektxt);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.sehirtext);
            this.groupBox1.Controls.Add(this.maastxt);
            this.groupBox1.Controls.Add(this.soyadtxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.adtxt);
            this.groupBox1.Controls.Add(this.idtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // meslektxt
            // 
            this.meslektxt.Location = new System.Drawing.Point(226, 333);
            this.meslektxt.Name = "meslektxt";
            this.meslektxt.Size = new System.Drawing.Size(147, 36);
            this.meslektxt.TabIndex = 14;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(313, 291);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 32);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(226, 291);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 32);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sehirtext
            // 
            this.sehirtext.FormattingEnabled = true;
            this.sehirtext.Location = new System.Drawing.Point(226, 201);
            this.sehirtext.Name = "sehirtext";
            this.sehirtext.Size = new System.Drawing.Size(147, 36);
            this.sehirtext.TabIndex = 11;
            // 
            // maastxt
            // 
            this.maastxt.Location = new System.Drawing.Point(226, 243);
            this.maastxt.Name = "maastxt";
            this.maastxt.Size = new System.Drawing.Size(147, 36);
            this.maastxt.TabIndex = 10;
            // 
            // soyadtxt
            // 
            this.soyadtxt.Location = new System.Drawing.Point(226, 152);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(147, 36);
            this.soyadtxt.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Meslek:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Durum:";
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(226, 108);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(147, 36);
            this.adtxt.TabIndex = 6;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(226, 63);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(147, 36);
            this.idtxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.istatistikbtn);
            this.groupBox2.Controls.Add(this.temizlebtn);
            this.groupBox2.Controls.Add(this.guncellebtn);
            this.groupBox2.Controls.Add(this.silbtn);
            this.groupBox2.Controls.Add(this.kaydetbtn);
            this.groupBox2.Controls.Add(this.listelebtn);
            this.groupBox2.Location = new System.Drawing.Point(600, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 421);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // istatistikbtn
            // 
            this.istatistikbtn.Location = new System.Drawing.Point(180, 309);
            this.istatistikbtn.Name = "istatistikbtn";
            this.istatistikbtn.Size = new System.Drawing.Size(221, 39);
            this.istatistikbtn.TabIndex = 5;
            this.istatistikbtn.Text = "İstatistik";
            this.istatistikbtn.UseVisualStyleBackColor = true;
            this.istatistikbtn.Click += new System.EventHandler(this.istatistikbtn_Click);
            // 
            // temizlebtn
            // 
            this.temizlebtn.Location = new System.Drawing.Point(180, 264);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(221, 39);
            this.temizlebtn.TabIndex = 4;
            this.temizlebtn.Text = "Temizle";
            this.temizlebtn.UseVisualStyleBackColor = true;
            this.temizlebtn.Click += new System.EventHandler(this.temizlebtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(180, 219);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(221, 39);
            this.guncellebtn.TabIndex = 3;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(180, 174);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(221, 39);
            this.silbtn.TabIndex = 2;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(180, 129);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(221, 39);
            this.kaydetbtn.TabIndex = 1;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(180, 84);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(221, 39);
            this.listelebtn.TabIndex = 0;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1157, 258);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblpersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblpersonelBindingSource
            // 
            this.tblpersonelBindingSource.DataMember = "tbl_personel";
            this.tblpersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Raporla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 713);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox meslektxt;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox sehirtext;
        private System.Windows.Forms.MaskedTextBox maastxt;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button istatistikbtn;
        private System.Windows.Forms.Button temizlebtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button listelebtn;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblpersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.tbl_personelTableAdapter tbl_personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

