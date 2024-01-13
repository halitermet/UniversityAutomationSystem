namespace UniversityCodeFirst
{
    partial class DiplomaForm
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
            lblNo = new Label();
            lblDplmtrh = new Label();
            txtNo = new TextBox();
            txtTrh = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGncll = new Button();
            dgvDiploma = new DataGridView();
            lblsecilen = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDiploma).BeginInit();
            SuspendLayout();
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(98, 77);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(94, 20);
            lblNo.TabIndex = 0;
            lblNo.Text = "Diploma No:";
            // 
            // lblDplmtrh
            // 
            lblDplmtrh.AutoSize = true;
            lblDplmtrh.Location = new Point(98, 128);
            lblDplmtrh.Name = "lblDplmtrh";
            lblDplmtrh.Size = new Size(113, 20);
            lblDplmtrh.TabIndex = 1;
            lblDplmtrh.Text = "Diploma Tarihi :";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(236, 70);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(161, 27);
            txtNo.TabIndex = 2;
            // 
            // txtTrh
            // 
            txtTrh.Location = new Point(236, 121);
            txtTrh.Name = "txtTrh";
            txtTrh.Size = new Size(161, 27);
            txtTrh.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(105, 177);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(205, 177);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGncll
            // 
            btnGncll.Location = new Point(317, 177);
            btnGncll.Name = "btnGncll";
            btnGncll.Size = new Size(94, 29);
            btnGncll.TabIndex = 6;
            btnGncll.Text = "Güncelle";
            btnGncll.UseVisualStyleBackColor = true;
            btnGncll.Click += btnGncll_Click;
            // 
            // dgvDiploma
            // 
            dgvDiploma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiploma.Location = new Point(98, 227);
            dgvDiploma.Name = "dgvDiploma";
            dgvDiploma.RowHeadersWidth = 51;
            dgvDiploma.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiploma.Size = new Size(300, 188);
            dgvDiploma.TabIndex = 7;
            dgvDiploma.CellClick += dgvDiploma_CellClick;
            // 
            // lblsecilen
            // 
            lblsecilen.Location = new Point(105, 428);
            lblsecilen.Name = "lblsecilen";
            lblsecilen.Size = new Size(339, 25);
            lblsecilen.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(lblsecilen);
            Controls.Add(dgvDiploma);
            Controls.Add(btnGncll);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtTrh);
            Controls.Add(txtNo);
            Controls.Add(lblDplmtrh);
            Controls.Add(lblNo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDiploma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNo;
        private Label lblDplmtrh;
        private TextBox txtNo;
        private TextBox txtTrh;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGncll;
        private DataGridView dgvDiploma;
        private Label lblsecilen;
    }
}
