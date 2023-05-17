namespace Kursach_zadumin
{
    partial class Klient
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
            this.kurs1DataSet = new Kursach_zadumin.kurs1DataSet();
            this.klientTableAdapter = new Kursach_zadumin.kurs1DataSetTableAdapters.KlientTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klientTableAdapter1 = new Kursach_zadumin.kurs1DataSet1TableAdapters.KlientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.kurs1DataSet1 = new Kursach_zadumin.kurs1DataSet1();
            this.klientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kurs1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurs1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // kurs1DataSet
            // 
            this.kurs1DataSet.DataSetName = "kurs1DataSet";
            this.kurs1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.thingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klientBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // klientTableAdapter1
            // 
            this.klientTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kurs1DataSet1
            // 
            this.kurs1DataSet1.DataSetName = "kurs1DataSet1";
            this.kurs1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource1
            // 
            this.klientBindingSource1.DataMember = "Klient";
            this.klientBindingSource1.DataSource = this.kurs1DataSet1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // thingDataGridViewTextBoxColumn
            // 
            this.thingDataGridViewTextBoxColumn.DataPropertyName = "Thing";
            this.thingDataGridViewTextBoxColumn.HeaderText = "Thing";
            this.thingDataGridViewTextBoxColumn.Name = "thingDataGridViewTextBoxColumn";
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Klient";
            this.Text = "Klient";
            this.Load += new System.EventHandler(this.Klient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kurs1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurs1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private kurs1DataSet kurs1DataSet;
        private kurs1DataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kurs1DataSet1TableAdapters.KlientTableAdapter klientTableAdapter1;
        private System.Windows.Forms.Button button1;
        private kurs1DataSet1 kurs1DataSet1;
        private System.Windows.Forms.BindingSource klientBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thingDataGridViewTextBoxColumn;
    }
}