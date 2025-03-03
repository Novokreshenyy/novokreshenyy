
namespace PP_Novokresheniy.Main
{
    partial class Insert1
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
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKolichestvo = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPotrebitel = new System.Windows.Forms.TextBox();
            this.tbNapitok = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelect
            // 
            this.dgvSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelect.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Location = new System.Drawing.Point(-1, 188);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.Size = new System.Drawing.Size(803, 261);
            this.dgvSelect.TabIndex = 2;
            this.dgvSelect.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelect_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество:";
            // 
            // tbKolichestvo
            // 
            this.tbKolichestvo.Location = new System.Drawing.Point(209, 10);
            this.tbKolichestvo.Name = "tbKolichestvo";
            this.tbKolichestvo.Size = new System.Drawing.Size(91, 20);
            this.tbKolichestvo.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsert.Location = new System.Drawing.Point(548, 94);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(240, 36);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Добавить заказ";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(72, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата заказа:";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(209, 42);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(91, 20);
            this.dtpData.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Номер потребителя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(46, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер напитка:";
            // 
            // tbPotrebitel
            // 
            this.tbPotrebitel.Location = new System.Drawing.Point(209, 80);
            this.tbPotrebitel.Name = "tbPotrebitel";
            this.tbPotrebitel.Size = new System.Drawing.Size(91, 20);
            this.tbPotrebitel.TabIndex = 10;
            // 
            // tbNapitok
            // 
            this.tbNapitok.Location = new System.Drawing.Point(209, 123);
            this.tbNapitok.Name = "tbNapitok";
            this.tbNapitok.Size = new System.Drawing.Size(91, 20);
            this.tbNapitok.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(548, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Редактировать заказ";
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
            this.button2.Location = new System.Drawing.Point(548, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Удалить заказ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Insert1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNapitok);
            this.Controls.Add(this.tbPotrebitel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbKolichestvo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSelect);
            this.Name = "Insert1";
            this.Text = "Добавить заказ";
            this.Load += new System.EventHandler(this.Insert1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKolichestvo;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPotrebitel;
        private System.Windows.Forms.TextBox tbNapitok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}