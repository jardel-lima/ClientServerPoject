namespace ClientServerProject
{
    partial class OrderForm
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
            this.dataGVMenu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGVOrder = new System.Windows.Forms.DataGridView();
            this.txtSubTotal = new System.Windows.Forms.Label();
            this.txtTaxes = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // dataGVMenu
            // 
            this.dataGVMenu.AllowUserToAddRows = false;
            this.dataGVMenu.AllowUserToDeleteRows = false;
            this.dataGVMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMenu.Location = new System.Drawing.Point(12, 67);
            this.dataGVMenu.MultiSelect = false;
            this.dataGVMenu.Name = "dataGVMenu";
            this.dataGVMenu.RowHeadersWidth = 25;
            this.dataGVMenu.Size = new System.Drawing.Size(497, 329);
            this.dataGVMenu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Items";
            // 
            // dataGVOrder
            // 
            this.dataGVOrder.AllowUserToAddRows = false;
            this.dataGVOrder.AllowUserToDeleteRows = false;
            this.dataGVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVOrder.Location = new System.Drawing.Point(558, 67);
            this.dataGVOrder.Name = "dataGVOrder";
            this.dataGVOrder.ReadOnly = true;
            this.dataGVOrder.RowHeadersWidth = 30;
            this.dataGVOrder.Size = new System.Drawing.Size(293, 277);
            this.dataGVOrder.TabIndex = 3;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.AutoSize = true;
            this.txtSubTotal.Location = new System.Drawing.Point(719, 351);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(53, 13);
            this.txtSubTotal.TabIndex = 4;
            this.txtSubTotal.Text = "SubTotal:";
            // 
            // txtTaxes
            // 
            this.txtTaxes.AutoSize = true;
            this.txtTaxes.Location = new System.Drawing.Point(719, 373);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(87, 13);
            this.txtTaxes.TabIndex = 5;
            this.txtTaxes.Text = "Taxes (GST 5%):";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(719, 403);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(45, 13);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.Text = "TOTAL:";
            // 
            // txtEmployee
            // 
            this.txtEmployee.AutoSize = true;
            this.txtEmployee.Location = new System.Drawing.Point(9, 9);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(56, 13);
            this.txtEmployee.TabIndex = 7;
            this.txtEmployee.Text = "Employee:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(558, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(789, 437);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(708, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(9, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(19, 13);
            this.txtId.TabIndex = 12;
            this.txtId.Text = "Id:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 463);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTaxes);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.dataGVOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGVMenu);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGVOrder;
        private System.Windows.Forms.Label txtSubTotal;
        private System.Windows.Forms.Label txtTaxes;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label txtId;
    }
}