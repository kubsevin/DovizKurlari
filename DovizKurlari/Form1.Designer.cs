namespace DovizKurlari
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
            this.lstBoxDoviz = new System.Windows.Forms.ListBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDoviz = new System.Windows.Forms.DataGridView();
            this.dataGridViewDoviz2 = new System.Windows.Forms.DataGridView();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblAlis = new System.Windows.Forms.Label();
            this.lblSatis = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoviz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoviz2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBoxDoviz
            // 
            this.lstBoxDoviz.FormattingEnabled = true;
            this.lstBoxDoviz.Location = new System.Drawing.Point(34, 12);
            this.lstBoxDoviz.Name = "lstBoxDoviz";
            this.lstBoxDoviz.Size = new System.Drawing.Size(120, 160);
            this.lstBoxDoviz.TabIndex = 0;
            this.lstBoxDoviz.SelectedIndexChanged += new System.EventHandler(this.lstBoxDoviz_SelectedIndexChanged);
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(34, 238);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(75, 23);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Birim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Döv. Alış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Döv. Satış";
            // 
            // dataGridViewDoviz
            // 
            this.dataGridViewDoviz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoviz.Location = new System.Drawing.Point(317, 12);
            this.dataGridViewDoviz.Name = "dataGridViewDoviz";
            this.dataGridViewDoviz.Size = new System.Drawing.Size(371, 126);
            this.dataGridViewDoviz.TabIndex = 3;
            // 
            // dataGridViewDoviz2
            // 
            this.dataGridViewDoviz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoviz2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewDoviz2.Location = new System.Drawing.Point(317, 180);
            this.dataGridViewDoviz2.Name = "dataGridViewDoviz2";
            this.dataGridViewDoviz2.Size = new System.Drawing.Size(371, 126);
            this.dataGridViewDoviz2.TabIndex = 3;
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(235, 12);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(13, 13);
            this.lblBirim.TabIndex = 2;
            this.lblBirim.Text = "0";
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.Location = new System.Drawing.Point(235, 57);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(13, 13);
            this.lblAlis.TabIndex = 2;
            this.lblAlis.Text = "0";
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Location = new System.Drawing.Point(235, 106);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(13, 13);
            this.lblSatis.TabIndex = 2;
            this.lblSatis.Text = "0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Doviz Ad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Satış";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDoviz2);
            this.Controls.Add(this.dataGridViewDoviz);
            this.Controls.Add(this.lblSatis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAlis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.lstBoxDoviz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoviz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoviz2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxDoviz;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDoviz;
        private System.Windows.Forms.DataGridView dataGridViewDoviz2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.Label lblSatis;
    }
}

