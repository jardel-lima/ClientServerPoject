namespace ClientServerProject
{
    partial class BillForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtTaxes = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 138);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(366, 142);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(45, 13);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "TOTAL:";
            // 
            // txtTaxes
            // 
            this.txtTaxes.AutoSize = true;
            this.txtTaxes.Location = new System.Drawing.Point(366, 112);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(87, 13);
            this.txtTaxes.TabIndex = 8;
            this.txtTaxes.Text = "Taxes (GST 5%):";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.AutoSize = true;
            this.txtSubTotal.Location = new System.Drawing.Point(366, 90);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(53, 13);
            this.txtSubTotal.TabIndex = 7;
            this.txtSubTotal.Text = "SubTotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Payment: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(426, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Charge: ";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(17, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(35, 13);
            this.userLabel.TabIndex = 13;
            this.userLabel.Text = "User: ";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(17, 26);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 13);
            this.idLabel.TabIndex = 14;
            this.idLabel.Text = "ID: ";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(369, 217);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 268);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTaxes);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtTaxes;
        private System.Windows.Forms.Label txtSubTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button btnPay;
    }
}