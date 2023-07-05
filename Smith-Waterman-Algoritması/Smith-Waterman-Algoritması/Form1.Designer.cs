namespace Smith_Waterman_Algoritması
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_alignment = new System.Windows.Forms.TextBox();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_seq2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_seq1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mismatch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_match = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_insert_data = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_write_list = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 30);
            this.label4.TabIndex = 36;
            this.label4.Text = "Hizalama Puanı : ";
            // 
            // txt_alignment
            // 
            this.txt_alignment.Location = new System.Drawing.Point(232, 564);
            this.txt_alignment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_alignment.Name = "txt_alignment";
            this.txt_alignment.Size = new System.Drawing.Size(151, 38);
            this.txt_alignment.TabIndex = 35;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(660, 563);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(17, 30);
            this.lbl_timer.TabIndex = 34;
            this.lbl_timer.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 30);
            this.label9.TabIndex = 33;
            this.label9.Text = "Çalışma Süresi: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 30);
            this.label6.TabIndex = 32;
            this.label6.Text = "Dizi 2:";
            // 
            // txt_seq2
            // 
            this.txt_seq2.Location = new System.Drawing.Point(485, 14);
            this.txt_seq2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_seq2.Name = "txt_seq2";
            this.txt_seq2.Size = new System.Drawing.Size(151, 38);
            this.txt_seq2.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Dizi 1: ";
            // 
            // txt_seq1
            // 
            this.txt_seq1.Location = new System.Drawing.Point(193, 13);
            this.txt_seq1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_seq1.Name = "txt_seq1";
            this.txt_seq1.Size = new System.Drawing.Size(151, 38);
            this.txt_seq1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Gap Değeri :";
            // 
            // txt_gap
            // 
            this.txt_gap.Location = new System.Drawing.Point(232, 507);
            this.txt_gap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_gap.Name = "txt_gap";
            this.txt_gap.Size = new System.Drawing.Size(151, 38);
            this.txt_gap.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mismatch Değeri :";
            // 
            // txt_mismatch
            // 
            this.txt_mismatch.Location = new System.Drawing.Point(232, 451);
            this.txt_mismatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mismatch.Name = "txt_mismatch";
            this.txt_mismatch.Size = new System.Drawing.Size(151, 38);
            this.txt_mismatch.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Match Değeri :";
            // 
            // txt_match
            // 
            this.txt_match.Location = new System.Drawing.Point(232, 395);
            this.txt_match.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_match.Name = "txt_match";
            this.txt_match.Size = new System.Drawing.Size(151, 38);
            this.txt_match.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 312);
            this.dataGridView1.TabIndex = 22;
            // 
            // btn_insert_data
            // 
            this.btn_insert_data.Location = new System.Drawing.Point(510, 391);
            this.btn_insert_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_insert_data.Name = "btn_insert_data";
            this.btn_insert_data.Size = new System.Drawing.Size(148, 79);
            this.btn_insert_data.TabIndex = 21;
            this.btn_insert_data.Text = "Tabloyu Doldur";
            this.btn_insert_data.UseVisualStyleBackColor = true;
            this.btn_insert_data.Click += new System.EventHandler(this.btn_insert_data_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 30);
            this.label7.TabIndex = 38;
            this.label7.Text = "Eşleşen değerler :";
            // 
            // txt_write_list
            // 
            this.txt_write_list.Location = new System.Drawing.Point(586, 493);
            this.txt_write_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_write_list.Name = "txt_write_list";
            this.txt_write_list.Size = new System.Drawing.Size(151, 38);
            this.txt_write_list.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(790, 611);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_write_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_alignment);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_seq2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_seq1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_gap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mismatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_match);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_insert_data);
            this.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_alignment;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_seq2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_seq1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_gap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mismatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_match;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_insert_data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_write_list;
    }
}

