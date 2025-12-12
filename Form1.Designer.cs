namespace ResponsiJunpro_Olivia
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.cmbPilihProyek = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelPilihProyek = new System.Windows.Forms.Label();
            this.labelStatusKontrak = new System.Windows.Forms.Label();
            this.cmbStatusKontrak = new System.Windows.Forms.ComboBox();
            this.labelFiturSelesai = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtFiturSelesai = new System.Windows.Forms.TextBox();
            this.txtJumlahBug = new System.Windows.Forms.TextBox();
            this.labelJumlahBug = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPilihProyek
            // 
            this.cmbPilihProyek.FormattingEnabled = true;
            this.cmbPilihProyek.Location = new System.Drawing.Point(137, 124);
            this.cmbPilihProyek.Name = "cmbPilihProyek";
            this.cmbPilihProyek.Size = new System.Drawing.Size(201, 21);
            this.cmbPilihProyek.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightGray;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnInsert.Location = new System.Drawing.Point(178, 313);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(79, 26);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(271, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 26);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(375, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 26);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Location = new System.Drawing.Point(108, 358);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(459, 110);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(46, 94);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(87, 13);
            this.labelNama.TabIndex = 8;
            this.labelNama.Text = "Nama Developer";
            // 
            // labelPilihProyek
            // 
            this.labelPilihProyek.AutoSize = true;
            this.labelPilihProyek.Location = new System.Drawing.Point(46, 127);
            this.labelPilihProyek.Name = "labelPilihProyek";
            this.labelPilihProyek.Size = new System.Drawing.Size(62, 13);
            this.labelPilihProyek.TabIndex = 7;
            this.labelPilihProyek.Text = "Pilih Proyek";
            // 
            // labelStatusKontrak
            // 
            this.labelStatusKontrak.AutoSize = true;
            this.labelStatusKontrak.Location = new System.Drawing.Point(46, 164);
            this.labelStatusKontrak.Name = "labelStatusKontrak";
            this.labelStatusKontrak.Size = new System.Drawing.Size(77, 13);
            this.labelStatusKontrak.TabIndex = 5;
            this.labelStatusKontrak.Text = "Status Kontrak";
            // 
            // cmbStatusKontrak
            // 
            this.cmbStatusKontrak.FormattingEnabled = true;
            this.cmbStatusKontrak.Location = new System.Drawing.Point(137, 161);
            this.cmbStatusKontrak.Name = "cmbStatusKontrak";
            this.cmbStatusKontrak.Size = new System.Drawing.Size(201, 21);
            this.cmbStatusKontrak.TabIndex = 6;
            // 
            // labelFiturSelesai
            // 
            this.labelFiturSelesai.AutoSize = true;
            this.labelFiturSelesai.Location = new System.Drawing.Point(46, 233);
            this.labelFiturSelesai.Name = "labelFiturSelesai";
            this.labelFiturSelesai.Size = new System.Drawing.Size(64, 13);
            this.labelFiturSelesai.TabIndex = 4;
            this.labelFiturSelesai.Text = "Fitur Selesai";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(137, 91);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(201, 20);
            this.txtNama.TabIndex = 14;
            // 
            // txtFiturSelesai
            // 
            this.txtFiturSelesai.Location = new System.Drawing.Point(137, 230);
            this.txtFiturSelesai.Name = "txtFiturSelesai";
            this.txtFiturSelesai.Size = new System.Drawing.Size(201, 20);
            this.txtFiturSelesai.TabIndex = 3;
            // 
            // txtJumlahBug
            // 
            this.txtJumlahBug.Location = new System.Drawing.Point(137, 261);
            this.txtJumlahBug.Name = "txtJumlahBug";
            this.txtJumlahBug.Size = new System.Drawing.Size(201, 20);
            this.txtJumlahBug.TabIndex = 1;
            // 
            // labelJumlahBug
            // 
            this.labelJumlahBug.AutoSize = true;
            this.labelJumlahBug.Location = new System.Drawing.Point(46, 264);
            this.labelJumlahBug.Name = "labelJumlahBug";
            this.labelJumlahBug.Size = new System.Drawing.Size(62, 13);
            this.labelJumlahBug.TabIndex = 2;
            this.labelJumlahBug.Text = "Jumlah Bug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(225, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "DeTracker";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(133, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "The Developer Team Performance Tracker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label3.Location = new System.Drawing.Point(43, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = ":D";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(390, 91);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(201, 20);
            this.txtID.TabIndex = 17;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(603, 479);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJumlahBug);
            this.Controls.Add(this.labelJumlahBug);
            this.Controls.Add(this.txtFiturSelesai);
            this.Controls.Add(this.labelFiturSelesai);
            this.Controls.Add(this.labelStatusKontrak);
            this.Controls.Add(this.cmbStatusKontrak);
            this.Controls.Add(this.labelPilihProyek);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cmbPilihProyek);
            this.Controls.Add(this.txtNama);
            this.Name = "Form1";
            this.Text = "Developer Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPilihProyek;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelPilihProyek;
        private System.Windows.Forms.Label labelStatusKontrak;
        private System.Windows.Forms.ComboBox cmbStatusKontrak;
        private System.Windows.Forms.Label labelFiturSelesai;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtFiturSelesai;
        private System.Windows.Forms.TextBox txtJumlahBug;
        private System.Windows.Forms.Label labelJumlahBug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
    }
}
