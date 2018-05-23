namespace ProjectZ
{
    partial class Company
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.riPDataSet = new ProjectZ.RiPDataSet();
            this.riPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.riPDataSet1 = new ProjectZ.RiPDataSet1();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactTableAdapter = new ProjectZ.RiPDataSet1TableAdapters.contactTableAdapter();
            this.riPDataSet2 = new ProjectZ.RiPDataSet2();
            this.contactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactTableAdapter1 = new ProjectZ.RiPDataSet2TableAdapters.contactTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(39, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "id";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(77, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 20);
            this.textBox5.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(273, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 37);
            this.label5.TabIndex = 27;
            this.label5.Text = "Работа с компаниями";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(491, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Контракт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(254, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Имя";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contactBindingSource1, "id", true));
            this.comboBox1.DataSource = this.contactBindingSource1;
            this.comboBox1.DisplayMember = "ContractStatus";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(560, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 267);
            this.dataGridView1.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(497, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 38);
            this.button4.TabIndex = 38;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(246, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 38);
            this.button3.TabIndex = 37;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(374, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 38);
            this.button2.TabIndex = 36;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(119, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 35;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // riPDataSet
            // 
            this.riPDataSet.DataSetName = "RiPDataSet";
            this.riPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // riPDataSetBindingSource
            // 
            this.riPDataSetBindingSource.DataSource = this.riPDataSet;
            this.riPDataSetBindingSource.Position = 0;
            // 
            // riPDataSet1
            // 
            this.riPDataSet1.DataSetName = "RiPDataSet1";
            this.riPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "contact";
            this.contactBindingSource.DataSource = this.riPDataSet1;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // riPDataSet2
            // 
            this.riPDataSet2.DataSetName = "RiPDataSet2";
            this.riPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactBindingSource1
            // 
            this.contactBindingSource1.DataMember = "contact";
            this.contactBindingSource1.DataSource = this.riPDataSet2;
            // 
            // contactTableAdapter1
            // 
            this.contactTableAdapter1.ClearBeforeFill = true;
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Company";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource riPDataSetBindingSource;
        private RiPDataSet riPDataSet;
        private RiPDataSet1 riPDataSet1;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private RiPDataSet1TableAdapters.contactTableAdapter contactTableAdapter;
        private RiPDataSet2 riPDataSet2;
        private System.Windows.Forms.BindingSource contactBindingSource1;
        private RiPDataSet2TableAdapters.contactTableAdapter contactTableAdapter1;
    }
}