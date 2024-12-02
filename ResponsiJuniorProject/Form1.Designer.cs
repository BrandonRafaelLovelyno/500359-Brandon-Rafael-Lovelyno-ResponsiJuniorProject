namespace ResponsiJuniorProject
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbNama = new TextBox();
            cbDepartemen = new ComboBox();
            cbJabatan = new ComboBox();
            btInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvKaryawan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 76);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 62);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 145);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 186);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 3;
            label3.Text = "Dep. Karyawan :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 228);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 4;
            label4.Text = "Jabatan Karyawan :";
            label4.Click += label4_Click;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(181, 142);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(100, 23);
            tbNama.TabIndex = 5;
            // 
            // cbDepartemen
            // 
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Items.AddRange(new object[] { "2", "3", "4", "5", "6" });
            cbDepartemen.Location = new Point(181, 183);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(121, 23);
            cbDepartemen.TabIndex = 6;
            cbDepartemen.SelectedIndexChanged += cbDepartemen_SelectedIndexChanged;
            // 
            // cbJabatan
            // 
            cbJabatan.FormattingEnabled = true;
            cbJabatan.Items.AddRange(new object[] { "1", "2", "3" });
            cbJabatan.Location = new Point(181, 225);
            cbJabatan.Name = "cbJabatan";
            cbJabatan.Size = new Size(121, 23);
            cbJabatan.TabIndex = 7;
            // 
            // btInsert
            // 
            btInsert.Location = new Point(29, 278);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(107, 23);
            btInsert.TabIndex = 8;
            btInsert.Text = "Insert";
            btInsert.UseVisualStyleBackColor = true;
            btInsert.Click += insertKaryawan;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(181, 278);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(332, 278);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Location = new Point(29, 332);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.Size = new Size(551, 190);
            dgvKaryawan.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 572);
            Controls.Add(dgvKaryawan);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btInsert);
            Controls.Add(cbJabatan);
            Controls.Add(cbDepartemen);
            Controls.Add(tbNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbNama;
        private ComboBox cbDepartemen;
        private ComboBox cbJabatan;
        private Button btInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvKaryawan;
    }
}
