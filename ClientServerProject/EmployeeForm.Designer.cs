namespace ClientServerProject
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOrders)).BeginInit();
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
            this.dataGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVOrders.Location = new System.Drawing.Point(38, 116);
            this.dataGVOrders.Name = "dataGVOrders";
            this.dataGVOrders.ReadOnly = true;
            this.dataGVOrders.Size = new System.Drawing.Size(212, 241);
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
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 398);
            this.Controls.Add(this.IdUser);
            this.Controls.Add(this.userLastName);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.dataGVOrders);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeOrders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeOrders_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVOrders;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label userLastName;
        private System.Windows.Forms.Label IdUser;
    }
}