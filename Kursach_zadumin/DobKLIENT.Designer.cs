namespace Kursach_zadumin
{
    partial class DobKLIENT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kurs1DataSet1 = new Kursach_zadumin.kurs1DataSet1();
            this.sport_invTableAdapter = new Kursach_zadumin.kurs1DataSet1TableAdapters.sport_invTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.klientTableAdapter = new Kursach_zadumin.kurs1DataSetTableAdapters.KlientTableAdapter();
            this.sportinvBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sport_invTableAdapter1 = new Kursach_zadumin.kurs1DataSetTableAdapters.sport_invTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kurs1DataSet = new Kursach_zadumin.kurs1DataSet();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurs1DataSet11 = new Kursach_zadumin.kurs1DataSet1();
            this.klientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter1 = new Kursach_zadumin.kurs1DataSet1TableAdapters.KlientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kurs1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportinvBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurs1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurs1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя человека";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ДО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Аренда чего";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // kurs1DataSet1
            // 
            this.kurs1DataSet1.DataSetName = "kurs1DataSet1";
            this.kurs1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sport_invTableAdapter
            // 
            this.sport_invTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kurs1DataSet1, "sport_inv.id", true));
            this.comboBox1.DataSource = this.klientBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "name";
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // sport_invTableAdapter1
            // 
            this.sport_invTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // kurs1DataSet
            // 
            this.kurs1DataSet.DataSetName = "kurs1DataSet";
            this.kurs1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.kurs1DataSet;
            // 
            // kurs1DataSet11
            // 
            this.kurs1DataSet11.DataSetName = "kurs1DataSet1";
            this.kurs1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource1
            // 
            this.klientBindingSource1.DataMember = "Klient";
            this.klientBindingSource1.DataSource = this.kurs1DataSet11;
            // 
            // klientTableAdapter1
            // 
            this.klientTableAdapter1.ClearBeforeFill = true;
            // 
            // DobKLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DobKLIENT";
            this.Text = "DobKLIENT";
            this.Load += new System.EventHandler(this.DobKLIENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kurs1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportinvBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurs1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurs1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private kurs1DataSet1 kurs1DataSet1;
        private kurs1DataSet1TableAdapters.sport_invTableAdapter sport_invTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private kurs1DataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.BindingSource sportinvBindingSource2;
        private kurs1DataSetTableAdapters.sport_invTableAdapter sport_invTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private kurs1DataSet kurs1DataSet;
        private kurs1DataSet1 kurs1DataSet11;
        private System.Windows.Forms.BindingSource klientBindingSource1;
        private kurs1DataSet1TableAdapters.KlientTableAdapter klientTableAdapter1;
    }
}