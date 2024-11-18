
namespace wfPr20_Var1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPostawchikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomertelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postawchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рыбный_магазинDataSet = new wfPr20_Var1.Рыбный_магазинDataSet();
            this.postawchikTableAdapter = new wfPr20_Var1.Рыбный_магазинDataSetTableAdapters.PostawchikTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idprodajiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDVidribyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaribyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieMagazinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vidRibyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postawchikProdashaRibyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodashaRibyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodasha_ribyTableAdapter = new wfPr20_Var1.Рыбный_магазинDataSetTableAdapters.Prodasha_ribyTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.vid_ribyTableAdapter = new wfPr20_Var1.Рыбный_магазинDataSetTableAdapters.Vid_ribyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postawchikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рыбный_магазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidRibyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postawchikProdashaRibyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodashaRibyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPostawchikaDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.nomertelefonaDataGridViewTextBoxColumn,
            this.firmaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postawchikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idPostawchikaDataGridViewTextBoxColumn
            // 
            this.idPostawchikaDataGridViewTextBoxColumn.DataPropertyName = "id_Postawchika";
            this.idPostawchikaDataGridViewTextBoxColumn.HeaderText = "Код поставщика";
            this.idPostawchikaDataGridViewTextBoxColumn.Name = "idPostawchikaDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // nomertelefonaDataGridViewTextBoxColumn
            // 
            this.nomertelefonaDataGridViewTextBoxColumn.DataPropertyName = "Nomer_telefona";
            this.nomertelefonaDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.nomertelefonaDataGridViewTextBoxColumn.Name = "nomertelefonaDataGridViewTextBoxColumn";
            // 
            // firmaDataGridViewTextBoxColumn
            // 
            this.firmaDataGridViewTextBoxColumn.DataPropertyName = "Firma";
            this.firmaDataGridViewTextBoxColumn.HeaderText = "Фирма";
            this.firmaDataGridViewTextBoxColumn.Name = "firmaDataGridViewTextBoxColumn";
            // 
            // postawchikBindingSource
            // 
            this.postawchikBindingSource.DataMember = "Postawchik";
            this.postawchikBindingSource.DataSource = this.рыбный_магазинDataSet;
            // 
            // рыбный_магазинDataSet
            // 
            this.рыбный_магазинDataSet.DataSetName = "Рыбный_магазинDataSet";
            this.рыбный_магазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postawchikTableAdapter
            // 
            this.postawchikTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodajiDataGridViewTextBoxColumn,
            this.iDVidribyDataGridViewTextBoxColumn,
            this.cenaribyDataGridViewTextBoxColumn,
            this.nazvanieMagazinaDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView2.DataSource = this.postawchikProdashaRibyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(453, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // idprodajiDataGridViewTextBoxColumn
            // 
            this.idprodajiDataGridViewTextBoxColumn.DataPropertyName = "id_prodaji";
            this.idprodajiDataGridViewTextBoxColumn.HeaderText = "Код продажи";
            this.idprodajiDataGridViewTextBoxColumn.Name = "idprodajiDataGridViewTextBoxColumn";
            // 
            // iDVidribyDataGridViewTextBoxColumn
            // 
            this.iDVidribyDataGridViewTextBoxColumn.DataPropertyName = "ID_Vid_riby";
            this.iDVidribyDataGridViewTextBoxColumn.HeaderText = "Код вида рыбы";
            this.iDVidribyDataGridViewTextBoxColumn.Name = "iDVidribyDataGridViewTextBoxColumn";
            this.iDVidribyDataGridViewTextBoxColumn.Visible = false;
            // 
            // cenaribyDataGridViewTextBoxColumn
            // 
            this.cenaribyDataGridViewTextBoxColumn.DataPropertyName = "Cena_riby";
            this.cenaribyDataGridViewTextBoxColumn.HeaderText = "Цена рыбы";
            this.cenaribyDataGridViewTextBoxColumn.Name = "cenaribyDataGridViewTextBoxColumn";
            // 
            // nazvanieMagazinaDataGridViewTextBoxColumn
            // 
            this.nazvanieMagazinaDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie_Magazina";
            this.nazvanieMagazinaDataGridViewTextBoxColumn.HeaderText = "Название магазина";
            this.nazvanieMagazinaDataGridViewTextBoxColumn.Name = "nazvanieMagazinaDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataSource = this.vidRibyBindingSource;
            this.Column1.DisplayMember = "Name";
            this.Column1.HeaderText = "Название рыбы";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "id_vid riby";
            // 
            // vidRibyBindingSource
            // 
            this.vidRibyBindingSource.DataMember = "Vid riby";
            this.vidRibyBindingSource.DataSource = this.рыбный_магазинDataSet;
            // 
            // postawchikProdashaRibyBindingSource
            // 
            this.postawchikProdashaRibyBindingSource.DataMember = "PostawchikProdasha riby";
            this.postawchikProdashaRibyBindingSource.DataSource = this.postawchikBindingSource;
            // 
            // prodashaRibyBindingSource
            // 
            this.prodashaRibyBindingSource.DataMember = "Prodasha riby";
            this.prodashaRibyBindingSource.DataSource = this.рыбный_магазинDataSet;
            // 
            // prodasha_ribyTableAdapter
            // 
            this.prodasha_ribyTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(546, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранение";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(546, 369);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(115, 23);
            this.btnSave1.TabIndex = 3;
            this.btnSave1.Text = "Сохранение";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // vid_ribyTableAdapter
            // 
            this.vid_ribyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(546, 178);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(115, 23);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Экспорт в Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(546, 320);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(115, 23);
            this.btnWord.TabIndex = 6;
            this.btnWord.Text = "Экспорт в Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "БД \"Рыба\"";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postawchikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рыбный_магазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidRibyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postawchikProdashaRibyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodashaRibyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Рыбный_магазинDataSet рыбный_магазинDataSet;
        private System.Windows.Forms.BindingSource postawchikBindingSource;
        private Рыбный_магазинDataSetTableAdapters.PostawchikTableAdapter postawchikTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource prodashaRibyBindingSource;
        private Рыбный_магазинDataSetTableAdapters.Prodasha_ribyTableAdapter prodasha_ribyTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.BindingSource postawchikProdashaRibyBindingSource;
        private System.Windows.Forms.BindingSource vidRibyBindingSource;
        private Рыбный_магазинDataSetTableAdapters.Vid_ribyTableAdapter vid_ribyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPostawchikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomertelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodajiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVidribyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaribyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieMagazinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
    }
}