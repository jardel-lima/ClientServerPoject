﻿namespace ClientServerProject
{
    partial class EmployeeForm
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
            this.dataGVOrders = new System.Windows.Forms.DataGridView();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.userLastName = new System.Windows.Forms.Label();
            this.IdUser = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.dgNotPaid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDERS";
            // 
            // dataGVOrders
            // 
            this.dataGVOrders.AllowUserToAddRows = false;
            this.dataGVOrders.AllowUserToDeleteRows = false;
            this.dataGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVOrders.Location = new System.Drawing.Point(38, 116);
            this.dataGVOrders.Name = "dataGVOrders";
            this.dataGVOrders.ReadOnly = true;
            this.dataGVOrders.Size = new System.Drawing.Size(223, 241);
            this.dataGVOrders.TabIndex = 1;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(175, 363);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 3;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // userLastName
            // 
            this.userLastName.AutoSize = true;
            this.userLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLastName.Location = new System.Drawing.Point(12, 30);
            this.userLastName.Name = "userLastName";
            this.userLastName.Size = new System.Drawing.Size(113, 20);
            this.userLastName.TabIndex = 5;
            this.userLastName.Text = "userLastName";
            // 
            // IdUser
            // 
            this.IdUser.AutoSize = true;
            this.IdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUser.Location = new System.Drawing.Point(12, 50);
            this.IdUser.Name = "IdUser";
            this.IdUser.Size = new System.Drawing.Size(57, 20);
            this.IdUser.TabIndex = 7;
            this.IdUser.Text = "userID";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(35, 368);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(42, 13);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "txtTotal";
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(620, 368);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 23);
            this.btnBill.TabIndex = 9;
            this.btnBill.Text = "Generate Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // dgNotPaid
            // 
            this.dgNotPaid.AllowUserToAddRows = false;
            this.dgNotPaid.AllowUserToDeleteRows = false;
            this.dgNotPaid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNotPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNotPaid.Location = new System.Drawing.Point(284, 116);
            this.dgNotPaid.Name = "dgNotPaid";
            this.dgNotPaid.ReadOnly = true;
            this.dgNotPaid.Size = new System.Drawing.Size(397, 241);
            this.dgNotPaid.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "NOT PAID ORDERS";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgNotPaid);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.IdUser);
            this.Controls.Add(this.userLastName);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.dataGVOrders);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeOrders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeOrders_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVOrders;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label userLastName;
        private System.Windows.Forms.Label IdUser;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.DataGridView dgNotPaid;
        private System.Windows.Forms.Label label2;
    }
}