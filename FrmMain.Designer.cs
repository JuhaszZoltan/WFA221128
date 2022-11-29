namespace WFA221128
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNevInsert = new System.Windows.Forms.TextBox();
            this.rbFFInsert = new System.Windows.Forms.RadioButton();
            this.dtpSzulInsert = new System.Windows.Forms.DateTimePicker();
            this.rbNOInsert = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbNagykoru = new System.Windows.Forms.CheckBox();
            this.tbNevUpdate = new System.Windows.Forms.TextBox();
            this.rbFFUpdate = new System.Windows.Forms.RadioButton();
            this.rbNOUpdate = new System.Windows.Forms.RadioButton();
            this.dtpSzulUpdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(21, 24);
            this.dgv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(846, 299);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 4F;
            this.Column2.HeaderText = "név";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 2F;
            this.Column3.HeaderText = "nem";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 4F;
            this.Column4.HeaderText = "született";
            this.Column4.Name = "Column4";
            // 
            // tbNevInsert
            // 
            this.tbNevInsert.Location = new System.Drawing.Point(131, 32);
            this.tbNevInsert.Name = "tbNevInsert";
            this.tbNevInsert.Size = new System.Drawing.Size(215, 36);
            this.tbNevInsert.TabIndex = 1;
            // 
            // rbFFInsert
            // 
            this.rbFFInsert.AutoSize = true;
            this.rbFFInsert.Checked = true;
            this.rbFFInsert.Location = new System.Drawing.Point(131, 74);
            this.rbFFInsert.Name = "rbFFInsert";
            this.rbFFInsert.Size = new System.Drawing.Size(70, 34);
            this.rbFFInsert.TabIndex = 2;
            this.rbFFInsert.TabStop = true;
            this.rbFFInsert.Text = "férfi";
            this.rbFFInsert.UseVisualStyleBackColor = true;
            // 
            // dtpSzulInsert
            // 
            this.dtpSzulInsert.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzulInsert.Location = new System.Drawing.Point(131, 114);
            this.dtpSzulInsert.Name = "dtpSzulInsert";
            this.dtpSzulInsert.Size = new System.Drawing.Size(215, 36);
            this.dtpSzulInsert.TabIndex = 3;
            // 
            // rbNOInsert
            // 
            this.rbNOInsert.AutoSize = true;
            this.rbNOInsert.Location = new System.Drawing.Point(290, 74);
            this.rbNOInsert.Name = "rbNOInsert";
            this.rbNOInsert.Size = new System.Drawing.Size(56, 34);
            this.rbNOInsert.TabIndex = 2;
            this.rbNOInsert.Text = "nő";
            this.rbNOInsert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Született:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInsert.Location = new System.Drawing.Point(6, 180);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(340, 53);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "ÚJ SZEMÉLY HOZZÁADÁSA";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // cbNagykoru
            // 
            this.cbNagykoru.AutoSize = true;
            this.cbNagykoru.Location = new System.Drawing.Point(21, 353);
            this.cbNagykoru.Name = "cbNagykoru";
            this.cbNagykoru.Size = new System.Drawing.Size(123, 34);
            this.cbNagykoru.TabIndex = 6;
            this.cbNagykoru.Text = "nagykorú";
            this.cbNagykoru.UseVisualStyleBackColor = true;
            this.cbNagykoru.CheckedChanged += new System.EventHandler(this.CbNagykoru_CheckedChanged);
            // 
            // tbNevUpdate
            // 
            this.tbNevUpdate.Location = new System.Drawing.Point(131, 33);
            this.tbNevUpdate.Name = "tbNevUpdate";
            this.tbNevUpdate.Size = new System.Drawing.Size(215, 36);
            this.tbNevUpdate.TabIndex = 1;
            // 
            // rbFFUpdate
            // 
            this.rbFFUpdate.AutoSize = true;
            this.rbFFUpdate.Checked = true;
            this.rbFFUpdate.Location = new System.Drawing.Point(131, 75);
            this.rbFFUpdate.Name = "rbFFUpdate";
            this.rbFFUpdate.Size = new System.Drawing.Size(70, 34);
            this.rbFFUpdate.TabIndex = 2;
            this.rbFFUpdate.TabStop = true;
            this.rbFFUpdate.Text = "férfi";
            this.rbFFUpdate.UseVisualStyleBackColor = true;
            // 
            // rbNOUpdate
            // 
            this.rbNOUpdate.AutoSize = true;
            this.rbNOUpdate.Location = new System.Drawing.Point(290, 71);
            this.rbNOUpdate.Name = "rbNOUpdate";
            this.rbNOUpdate.Size = new System.Drawing.Size(56, 34);
            this.rbNOUpdate.TabIndex = 2;
            this.rbNOUpdate.Text = "nő";
            this.rbNOUpdate.UseVisualStyleBackColor = true;
            // 
            // dtpSzulUpdate
            // 
            this.dtpSzulUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzulUpdate.Location = new System.Drawing.Point(131, 115);
            this.dtpSzulUpdate.Name = "dtpSzulUpdate";
            this.dtpSzulUpdate.Size = new System.Drawing.Size(215, 36);
            this.dtpSzulUpdate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Név:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Született:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Location = new System.Drawing.Point(6, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(344, 53);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "KIJELÖLT MÓDOSÍTÁSA";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.tbNevInsert);
            this.groupBox1.Controls.Add(this.rbFFInsert);
            this.groupBox1.Controls.Add(this.dtpSzulInsert);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbNOInsert);
            this.groupBox1.Location = new System.Drawing.Point(512, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 239);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbNOUpdate);
            this.groupBox2.Controls.Add(this.tbNevUpdate);
            this.groupBox2.Controls.Add(this.rbFFUpdate);
            this.groupBox2.Controls.Add(this.dtpSzulUpdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(150, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 239);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Location = new System.Drawing.Point(150, 587);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(717, 53);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "KIJELÖLT SZEMÉLY TÖRLÉSE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 667);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbNagykoru);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmMain";
            this.Text = "példa CRUDra";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tbNevInsert;
        private RadioButton rbFFInsert;
        private DateTimePicker dtpSzulInsert;
        private RadioButton rbNOInsert;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnInsert;
        private CheckBox cbNagykoru;
        private TextBox tbNevUpdate;
        private RadioButton rbFFUpdate;
        private RadioButton rbNOUpdate;
        private DateTimePicker dtpSzulUpdate;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnDelete;
    }
}