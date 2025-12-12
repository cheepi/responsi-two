namespace responsi_two
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Logo = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            status_kontrak = new ComboBox();
            nama_proyek = new ComboBox();
            nama_dev = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            jumlah_bug = new TextBox();
            label11 = new Label();
            label12 = new Label();
            fitur_selesai = new TextBox();
            label10 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.AutoSize = true;
            Logo.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logo.Location = new Point(122, 40);
            Logo.Name = "Logo";
            Logo.Size = new Size(0, 27);
            Logo.TabIndex = 0;
            Logo.Click += label1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 1;
            label1.Text = "Nama Developer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 405);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 47);
            label3.Name = "label3";
            label3.Size = new Size(233, 17);
            label3.TabIndex = 3;
            label3.Text = "Developer Team Performance Tracker";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(220, 21);
            label4.Name = "label4";
            label4.Size = new Size(115, 29);
            label4.TabIndex = 4;
            label4.Text = "DevTrack";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 9.75F);
            label5.Location = new Point(6, 90);
            label5.Name = "label5";
            label5.Size = new Size(94, 18);
            label5.TabIndex = 5;
            label5.Text = "Status Kontrak";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 9.75F);
            label6.Location = new Point(6, 58);
            label6.Name = "label6";
            label6.Size = new Size(74, 18);
            label6.TabIndex = 6;
            label6.Text = "Pilih Proyek";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(status_kontrak);
            groupBox1.Controls.Add(nama_proyek);
            groupBox1.Controls.Add(nama_dev);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(32, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 132);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATA DEVELOPER";
            // 
            // status_kontrak
            // 
            status_kontrak.FormattingEnabled = true;
            status_kontrak.Location = new Point(129, 86);
            status_kontrak.Name = "status_kontrak";
            status_kontrak.Size = new Size(213, 26);
            status_kontrak.TabIndex = 10;
            // 
            // nama_proyek
            // 
            nama_proyek.FormattingEnabled = true;
            nama_proyek.Location = new Point(129, 54);
            nama_proyek.Name = "nama_proyek";
            nama_proyek.Size = new Size(213, 26);
            nama_proyek.TabIndex = 8;
            // 
            // nama_dev
            // 
            nama_dev.Location = new Point(129, 25);
            nama_dev.Name = "nama_dev";
            nama_dev.Size = new Size(213, 23);
            nama_dev.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(114, 27);
            label7.Name = "label7";
            label7.Size = new Size(13, 18);
            label7.TabIndex = 7;
            label7.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 9.75F);
            label8.Location = new Point(114, 90);
            label8.Name = "label8";
            label8.Size = new Size(13, 18);
            label8.TabIndex = 8;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 9.75F);
            label9.Location = new Point(114, 58);
            label9.Name = "label9";
            label9.Size = new Size(13, 18);
            label9.TabIndex = 9;
            label9.Text = ":";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(jumlah_bug);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(fitur_selesai);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label13);
            groupBox2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(32, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(451, 95);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA KINERJA";
            //groupBox2.Enter += this.groupBox2_Enter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(188, 59);
            label15.Name = "label15";
            label15.Size = new Size(181, 18);
            label15.TabIndex = 13;
            label15.Text = "(Jumlah bug yang ditemukan)";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(188, 30);
            label14.Name = "label14";
            label14.Size = new Size(187, 18);
            label14.TabIndex = 12;
            label14.Text = "(Jumlah fitur yang dikerjakan)";
            // 
            // jumlah_bug
            // 
            jumlah_bug.Location = new Point(129, 54);
            jumlah_bug.Name = "jumlah_bug";
            jumlah_bug.Size = new Size(53, 23);
            jumlah_bug.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(114, 56);
            label11.Name = "label11";
            label11.Size = new Size(13, 18);
            label11.TabIndex = 10;
            label11.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 56);
            label12.Name = "label12";
            label12.Size = new Size(74, 18);
            label12.TabIndex = 9;
            label12.Text = "Jumlah bug";
            // 
            // fitur_selesai
            // 
            fitur_selesai.Location = new Point(129, 25);
            fitur_selesai.Name = "fitur_selesai";
            fitur_selesai.Size = new Size(53, 23);
            fitur_selesai.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(114, 27);
            label10.Name = "label10";
            label10.Size = new Size(13, 18);
            label10.TabIndex = 7;
            label10.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(6, 27);
            label13.Name = "label13";
            label13.Size = new Size(81, 18);
            label13.TabIndex = 1;
            label13.Text = "Fitur Selesai";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(32, 361);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(127, 25);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            //btnInsert.Click += this.btnInsert_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(196, 361);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 25);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            //btnUpdate.Click += this.btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(356, 361);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 25);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(32, 405);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(451, 132);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "DAFTAR PERFORMA TIM";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(451, 110);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 550);
            Controls.Add(groupBox3);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Logo);
            Name = "Form1";
            Text = "DevTrack";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Logo;
        private ImageList imageList1;
        private ImageList imageList2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private ComboBox nama_proyek;
        private TextBox nama_dev;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox status_kontrak;
        private GroupBox groupBox2;
        private Label label15;
        private Label label14;
        private TextBox jumlah_bug;
        private Label label11;
        private Label label12;
        private TextBox fitur_selesai;
        private Label label10;
        private Label label13;
        private PictureBox pictureBox1;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
    }
}
