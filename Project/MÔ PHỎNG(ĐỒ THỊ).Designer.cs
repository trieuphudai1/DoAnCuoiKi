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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSoNut = new System.Windows.Forms.Label();
            this.labelDemNut = new System.Windows.Forms.Label();
            this.labelDuLieu = new System.Windows.Forms.Label();
            this.textBoxDuLieu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÔ PHỎNG ĐỒ THỊ";
            // 
            // labelSoNut
            // 
            this.labelSoNut.AutoSize = true;
            this.labelSoNut.Location = new System.Drawing.Point(114, 78);
            this.labelSoNut.Name = "labelSoNut";
            this.labelSoNut.Size = new System.Drawing.Size(47, 16);
            this.labelSoNut.TabIndex = 1;
            this.labelSoNut.Text = "Số nút:";
            // 
            // labelDemNut
            // 
            this.labelDemNut.AutoSize = true;
            this.labelDemNut.Location = new System.Drawing.Point(195, 78);
            this.labelDemNut.Name = "labelDemNut";
            this.labelDemNut.Size = new System.Drawing.Size(56, 16);
            this.labelDemNut.TabIndex = 2;
            this.labelDemNut.Text = "DemNut";
            // 
            // labelDuLieu
            // 
            this.labelDuLieu.AutoSize = true;
            this.labelDuLieu.Location = new System.Drawing.Point(114, 131);
            this.labelDuLieu.Name = "labelDuLieu";
            this.labelDuLieu.Size = new System.Drawing.Size(51, 16);
            this.labelDuLieu.TabIndex = 3;
            this.labelDuLieu.Text = "Dữ liệu:";
            // 
            // textBoxDuLieu
            // 
            this.textBoxDuLieu.Location = new System.Drawing.Point(117, 176);
            this.textBoxDuLieu.Multiline = true;
            this.textBoxDuLieu.Name = "textBoxDuLieu";
            this.textBoxDuLieu.Size = new System.Drawing.Size(214, 243);
            this.textBoxDuLieu.TabIndex = 4;
            this.textBoxDuLieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vô hướng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Có hướng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ĐỒ_THỊ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDuLieu);
            this.Controls.Add(this.labelDuLieu);
            this.Controls.Add(this.labelDemNut);
            this.Controls.Add(this.labelSoNut);
            this.Controls.Add(this.label1);
            this.Name = "ĐỒ_THỊ";
            this.Text = "MÔ PHỎNG(ĐỒ THỊ)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSoNut;
        private System.Windows.Forms.Label labelDemNut;
        private System.Windows.Forms.Label labelDuLieu;
        private System.Windows.Forms.TextBox textBoxDuLieu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}