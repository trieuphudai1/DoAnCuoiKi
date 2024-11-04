namespace Project
{
    partial class ĐỒ_THỊ
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 80);
            this.panel1.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(31, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(336, 38);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "MÔ PHỎNG ĐỒ THỊ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDinh
            // 
            this.lbDinh.AutoSize = true;
            this.lbDinh.Location = new System.Drawing.Point(12, 101);
            this.lbDinh.Name = "lbDinh";
            this.lbDinh.Size = new System.Drawing.Size(52, 16);
            this.lbDinh.TabIndex = 1;
            this.lbDinh.Text = "Số đỉnh";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lbCanh
            // 
            this.lbCanh.AutoSize = true;
            this.lbCanh.Location = new System.Drawing.Point(16, 173);
            this.lbCanh.Name = "lbCanh";
            this.lbCanh.Size = new System.Drawing.Size(38, 16);
            this.lbCanh.TabIndex = 3;
            this.lbCanh.Text = "Cạnh";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 4;
            // 
            // grBDoThi
            // 
            this.grBDoThi.Controls.Add(this.dateTimePicker1);
            this.grBDoThi.Dock = System.Windows.Forms.DockStyle.Right;
            this.grBDoThi.Location = new System.Drawing.Point(316, 80);
            this.grBDoThi.Name = "grBDoThi";
            this.grBDoThi.Size = new System.Drawing.Size(1000, 516);
            this.grBDoThi.TabIndex = 5;
            this.grBDoThi.TabStop = false;
            this.grBDoThi.Text = "Đồ thị mô phỏng";
            this.grBDoThi.Paint += new System.Windows.Forms.PaintEventHandler(this.grBDoThi_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // grbDSCanh
            // 
            this.grbDSCanh.Controls.Add(this.lsvDSCanh);
            this.grbDSCanh.Location = new System.Drawing.Point(70, 260);
            this.grbDSCanh.Name = "grbDSCanh";
            this.grbDSCanh.Size = new System.Drawing.Size(348, 311);
            this.grbDSCanh.TabIndex = 6;
            this.grbDSCanh.TabStop = false;
            this.grbDSCanh.Text = "Danh sách cạnh ";
            // 
            // lsvDSCanh
            // 
            this.lsvDSCanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDSCanh.HideSelection = false;
            this.lsvDSCanh.Location = new System.Drawing.Point(3, 18);
            this.lsvDSCanh.Name = "lsvDSCanh";
            this.lsvDSCanh.Size = new System.Drawing.Size(342, 290);
            this.lsvDSCanh.TabIndex = 0;
            this.lsvDSCanh.UseCompatibleStateImageBehavior = false;
            this.lsvDSCanh.View = System.Windows.Forms.View.List;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(226, 166);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(343, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(38, 204);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(89, 41);
            this.btnBFS.TabIndex = 9;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.Location = new System.Drawing.Point(161, 204);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(99, 41);
            this.btnDFS.TabIndex = 10;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = true;
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(285, 204);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(100, 41);
            this.btnDijkstra.TabIndex = 11;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ĐỒ_THỊ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 596);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.grBDoThi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbDSCanh);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbCanh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbDinh);
            this.Controls.Add(this.panel1);
            this.Name = "ĐỒ_THỊ";
            this.Text = "MÔ PHỎNG(ĐỒ THỊ)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grBDoThi.ResumeLayout(false);
            this.grbDSCanh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbCanh;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grBDoThi;
        private System.Windows.Forms.GroupBox grbDSCanh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView lsvDSCanh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
    }
}