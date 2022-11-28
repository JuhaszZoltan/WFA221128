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
            this.tbNev = new System.Windows.Forms.TextBox();
            this.rbFF = new System.Windows.Forms.RadioButton();
            this.dtpSzul = new System.Windows.Forms.DateTimePicker();
            this.rbNO = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.dgv.Size = new System.Drawing.Size(855, 299);
            this.dgv.TabIndex = 0;
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
            // textBox1
            // 
            this.tbNev.Location = new System.Drawing.Point(635, 354);
            this.tbNev.Name = "textBox1";
            this.tbNev.Size = new System.Drawing.Size(215, 36);
            this.tbNev.TabIndex = 1;
            // 
            // rbFF
            // 
            this.rbFF.AutoSize = true;
            this.rbFF.Checked = true;
            this.rbFF.Location = new System.Drawing.Point(635, 396);
            this.rbFF.Name = "rbFF";
            this.rbFF.Size = new System.Drawing.Size(70, 34);
            this.rbFF.TabIndex = 2;
            this.rbFF.TabStop = true;
            this.rbFF.Text = "férfi";
            this.rbFF.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dtpSzul.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzul.Location = new System.Drawing.Point(635, 436);
            this.dtpSzul.Name = "dateTimePicker1";
            this.dtpSzul.Size = new System.Drawing.Size(215, 36);
            this.dtpSzul.TabIndex = 3;
            // 
            // rbNO
            // 
            this.rbNO.AutoSize = true;
            this.rbNO.Location = new System.Drawing.Point(790, 396);
            this.rbNO.Name = "rbNO";
            this.rbNO.Size = new System.Drawing.Size(56, 34);
            this.rbNO.TabIndex = 2;
            this.rbNO.Text = "nő";
            this.rbNO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Született:";
            // 
            // button1
            // 
            this.btnInsert.Location = new System.Drawing.Point(479, 502);
            this.btnInsert.Name = "button1";
            this.btnInsert.Size = new System.Drawing.Size(371, 53);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "ÚJ SZEMÉLY HOZZÁADÁSA";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 583);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSzul);
            this.Controls.Add(this.rbNO);
            this.Controls.Add(this.rbFF);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tbNev;
        private RadioButton rbFF;
        private DateTimePicker dtpSzul;
        private RadioButton rbNO;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnInsert;
    }
}