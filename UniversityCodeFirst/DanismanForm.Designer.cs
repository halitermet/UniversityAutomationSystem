namespace UniversityCodeFirst
{
    partial class DanismanForm
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
            components = new System.ComponentModel.Container();
            txtAdi = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtSoyadi = new TextBox();
            dgvDanisman = new DataGridView();
            btnekle = new Button();
            btnsil = new Button();
            btngncll = new Button();
            lblDanismanAdi = new Label();
            lblDanismanSYD = new Label();
            lblSecilenDanisman = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDanisman).BeginInit();
            SuspendLayout();
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(150, 89);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(125, 27);
            txtAdi.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(150, 143);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(125, 27);
            txtSoyadi.TabIndex = 2;
            // 
            // dgvDanisman
            // 
            dgvDanisman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanisman.Location = new Point(381, 56);
            dgvDanisman.Name = "dgvDanisman";
            dgvDanisman.RowHeadersWidth = 51;
            dgvDanisman.Size = new Size(384, 351);
            dgvDanisman.TabIndex = 3;
            dgvDanisman.CellClick += dgvDanisman_CellClick;
            // 
            // btnekle
            // 
            btnekle.Location = new Point(28, 201);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(94, 29);
            btnekle.TabIndex = 4;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // btnsil
            // 
            btnsil.Location = new Point(128, 201);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(94, 29);
            btnsil.TabIndex = 5;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // btngncll
            // 
            btngncll.Location = new Point(245, 201);
            btngncll.Name = "btngncll";
            btngncll.Size = new Size(94, 29);
            btngncll.TabIndex = 6;
            btngncll.Text = "GÜNCELLE";
            btngncll.UseVisualStyleBackColor = true;
            btngncll.Click += btngncll_Click;
            // 
            // lblDanismanAdi
            // 
            lblDanismanAdi.AutoSize = true;
            lblDanismanAdi.Location = new Point(61, 96);
            lblDanismanAdi.Name = "lblDanismanAdi";
            lblDanismanAdi.Size = new Size(32, 20);
            lblDanismanAdi.TabIndex = 7;
            lblDanismanAdi.Text = "Adı";
            // 
            // lblDanismanSYD
            // 
            lblDanismanSYD.AutoSize = true;
            lblDanismanSYD.Location = new Point(61, 146);
            lblDanismanSYD.Name = "lblDanismanSYD";
            lblDanismanSYD.Size = new Size(54, 20);
            lblDanismanSYD.TabIndex = 8;
            lblDanismanSYD.Text = "Soyadı";
            // 
            // lblSecilenDanisman
            // 
            lblSecilenDanisman.Location = new Point(391, 18);
            lblSecilenDanisman.Name = "lblSecilenDanisman";
            lblSecilenDanisman.Size = new Size(357, 25);
            lblSecilenDanisman.TabIndex = 9;
            // 
            // Danisman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSecilenDanisman);
            Controls.Add(lblDanismanSYD);
            Controls.Add(lblDanismanAdi);
            Controls.Add(btngncll);
            Controls.Add(btnsil);
            Controls.Add(btnekle);
            Controls.Add(dgvDanisman);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Name = "Danisman";
            Text = "Danisman";
            ((System.ComponentModel.ISupportInitialize)dgvDanisman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdi;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtSoyadi;
        private DataGridView dgvDanisman;
        private Button btnekle;
        private Button btnsil;
        private Button btngncll;
        private Label lblDanismanAdi;
        private Label lblDanismanSYD;
        private Label lblSecilenDanisman;
    }
}