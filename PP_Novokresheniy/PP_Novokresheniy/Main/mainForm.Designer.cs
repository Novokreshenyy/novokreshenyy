
namespace PP_Novokresheniy.Main
{
    partial class mainForm
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
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect1
            // 
            this.btnSelect1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelect1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect1.Location = new System.Drawing.Point(892, 12);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(287, 58);
            this.btnSelect1.TabIndex = 0;
            this.btnSelect1.Text = "Потребители сделавших заказы в указанную дату";
            this.btnSelect1.UseVisualStyleBackColor = false;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // btnSelect2
            // 
            this.btnSelect2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelect2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect2.Location = new System.Drawing.Point(892, 76);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(290, 58);
            this.btnSelect2.TabIndex = 1;
            this.btnSelect2.Text = "Потребители и количество их заказов";
            this.btnSelect2.UseVisualStyleBackColor = false;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsert.Location = new System.Drawing.Point(892, 204);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(290, 58);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Добавить заказ";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(892, 380);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(287, 58);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Отчёт";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgvSelect
            // 
            this.dgvSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelect.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSelect.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Location = new System.Drawing.Point(-2, -2);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.Size = new System.Drawing.Size(888, 449);
            this.dgvSelect.TabIndex = 1;
            this.dgvSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelect_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(892, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Склад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(630, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить потребителя";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(741, 365);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(741, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(648, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Магазин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(530, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Владельца магазина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Название напитка";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(219, 274);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 22);
            this.textBox3.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(108, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 45);
            this.button3.TabIndex = 14;
            this.button3.Text = "Добавить напиток";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(83, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(146, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(55, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Срок годности";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(8, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Дата производства";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(219, 244);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(130, 22);
            this.textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(219, 361);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(130, 22);
            this.textBox9.TabIndex = 23;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(219, 335);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(130, 22);
            this.dtpData.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 303);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelect1);
            this.Controls.Add(this.dgvSelect);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSelect2);
            this.Name = "mainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}