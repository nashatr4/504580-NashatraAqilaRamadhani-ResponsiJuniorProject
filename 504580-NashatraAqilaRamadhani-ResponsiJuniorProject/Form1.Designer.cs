namespace _504580_NashatraAqilaRamadhani_ResponsiJuniorProject
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
            lblLogo = new Label();
            lblNama = new Label();
            label1 = new Label();
            tbNama = new TextBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            richTextBox1 = new RichTextBox();
            cbDepartemen = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 51);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(93, 52);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(31, 15);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "logo";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(25, 113);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(99, 15);
            lblNama.TabIndex = 2;
            lblNama.Text = "Nama Karyawan :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 148);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Dep. Karyawan :";
            // 
            // tbNama
            // 
            tbNama.BorderStyle = BorderStyle.FixedSingle;
            tbNama.Location = new Point(147, 110);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(134, 23);
            tbNama.TabIndex = 4;
            tbNama.Text = "field";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(49, 201);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(196, 201);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(333, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(25, 244);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(414, 150);
            dgvData.TabIndex = 9;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.LightGray;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(309, 31);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(130, 102);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "ID Departemen :\nHR : HR\nENG : Engineer\nDEV : Developer\nPM : Product Manager\nFIN : Finance";
            // 
            // cbDepartemen
            // 
            cbDepartemen.AllowDrop = true;
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDepartemen.Location = new Point(147, 145);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(134, 23);
            cbDepartemen.TabIndex = 5;
            cbDepartemen.Text = "dropdown";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 416);
            Controls.Add(richTextBox1);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(cbDepartemen);
            Controls.Add(tbNama);
            Controls.Add(label1);
            Controls.Add(lblNama);
            Controls.Add(lblLogo);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogo;
        private Label lblNama;
        private Label label1;
        private TextBox tbNama;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private RichTextBox richTextBox1;
        private ComboBox cbDepartemen;
    }
}
