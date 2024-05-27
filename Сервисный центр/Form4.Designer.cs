namespace Сервисный_центр
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаДоболенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеПроблемыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автоDataSet = new Сервисный_центр.АвтоDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.заявкиTableAdapter = new Сервисный_центр.АвтоDataSetTableAdapters.ЗаявкиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗаявкиDataGridViewTextBoxColumn,
            this.датаДоболенияDataGridViewTextBoxColumn,
            this.видАвтоDataGridViewTextBoxColumn,
            this.модельАвтоDataGridViewTextBoxColumn,
            this.описаниеПроблемыDataGridViewTextBoxColumn,
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.статусЗаявкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заявкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерЗаявкиDataGridViewTextBoxColumn
            // 
            this.номерЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "Номер заявки";
            this.номерЗаявкиDataGridViewTextBoxColumn.HeaderText = "Номер заявки";
            this.номерЗаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерЗаявкиDataGridViewTextBoxColumn.Name = "номерЗаявкиDataGridViewTextBoxColumn";
            this.номерЗаявкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаДоболенияDataGridViewTextBoxColumn
            // 
            this.датаДоболенияDataGridViewTextBoxColumn.DataPropertyName = "Дата доболения";
            this.датаДоболенияDataGridViewTextBoxColumn.HeaderText = "Дата доболения";
            this.датаДоболенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаДоболенияDataGridViewTextBoxColumn.Name = "датаДоболенияDataGridViewTextBoxColumn";
            this.датаДоболенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // видАвтоDataGridViewTextBoxColumn
            // 
            this.видАвтоDataGridViewTextBoxColumn.DataPropertyName = "Вид авто";
            this.видАвтоDataGridViewTextBoxColumn.HeaderText = "Вид авто";
            this.видАвтоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.видАвтоDataGridViewTextBoxColumn.Name = "видАвтоDataGridViewTextBoxColumn";
            this.видАвтоDataGridViewTextBoxColumn.Width = 125;
            // 
            // модельАвтоDataGridViewTextBoxColumn
            // 
            this.модельАвтоDataGridViewTextBoxColumn.DataPropertyName = "Модель авто";
            this.модельАвтоDataGridViewTextBoxColumn.HeaderText = "Модель авто";
            this.модельАвтоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.модельАвтоDataGridViewTextBoxColumn.Name = "модельАвтоDataGridViewTextBoxColumn";
            this.модельАвтоDataGridViewTextBoxColumn.Width = 125;
            // 
            // описаниеПроблемыDataGridViewTextBoxColumn
            // 
            this.описаниеПроблемыDataGridViewTextBoxColumn.DataPropertyName = "Описание проблемы";
            this.описаниеПроблемыDataGridViewTextBoxColumn.HeaderText = "Описание проблемы";
            this.описаниеПроблемыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеПроблемыDataGridViewTextBoxColumn.Name = "описаниеПроблемыDataGridViewTextBoxColumn";
            this.описаниеПроблемыDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОКлиентаDataGridViewTextBoxColumn
            // 
            this.фИОКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.HeaderText = "ФИО клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОКлиентаDataGridViewTextBoxColumn.Name = "фИОКлиентаDataGridViewTextBoxColumn";
            this.фИОКлиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.Width = 125;
            // 
            // статусЗаявкиDataGridViewTextBoxColumn
            // 
            this.статусЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "Статус заявки";
            this.статусЗаявкиDataGridViewTextBoxColumn.HeaderText = "Статус заявки";
            this.статусЗаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусЗаявкиDataGridViewTextBoxColumn.Name = "статусЗаявкиDataGridViewTextBoxColumn";
            this.статусЗаявкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // заявкиBindingSource
            // 
            this.заявкиBindingSource.DataMember = "Заявки";
            this.заявкиBindingSource.DataSource = this.автоDataSet;
            // 
            // автоDataSet
            // 
            this.автоDataSet.DataSetName = "АвтоDataSet";
            this.автоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(177, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 43);
            this.button2.TabIndex = 53;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(13, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 43);
            this.button3.TabIndex = 52;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(646, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 47);
            this.label5.TabIndex = 54;
            this.label5.Text = "Заявки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // заявкиTableAdapter
            // 
            this.заявкиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(338, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 55;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(420, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 56;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(565, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 57;
            this.button4.Text = "Ок";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private АвтоDataSet автоDataSet;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private АвтоDataSetTableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаДоболенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеПроблемыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}