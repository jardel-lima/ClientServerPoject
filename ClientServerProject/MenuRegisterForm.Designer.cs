namespace ClientServerProject
{
    partial class MenuRegisterForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMenu = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDishe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDisheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.gbAva = new System.Windows.Forms.GroupBox();
            this.rdAva = new System.Windows.Forms.RadioButton();
            this.rdUnava = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbAva.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgMenu
            // 
            this.dgMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenu.Location = new System.Drawing.Point(12, 81);
            this.dgMenu.MultiSelect = false;
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.Size = new System.Drawing.Size(424, 281);
            this.dgMenu.TabIndex = 1;
            this.dgMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMenu_CellContentClick);
            this.dgMenu.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgMenus_CellMouseUp);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(517, 323);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(627, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dishe:";
            // 
            // txtDishe
            // 
            this.txtDishe.Location = new System.Drawing.Point(517, 77);
            this.txtDishe.Name = "txtDishe";
            this.txtDishe.Size = new System.Drawing.Size(100, 20);
            this.txtDishe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(517, 113);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(517, 161);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(222, 51);
            this.txtDesc.TabIndex = 9;
            this.txtDesc.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDisheToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 26);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseClick_1);
            // 
            // deleteDisheToolStripMenuItem
            // 
            this.deleteDisheToolStripMenuItem.Name = "deleteDisheToolStripMenuItem";
            this.deleteDisheToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteDisheToolStripMenuItem.Text = "Delete Dishe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tip: Right click on the dishe to delete";
            // 
            // gbAva
            // 
            this.gbAva.Controls.Add(this.rdUnava);
            this.gbAva.Controls.Add(this.rdAva);
            this.gbAva.Enabled = false;
            this.gbAva.Location = new System.Drawing.Point(517, 231);
            this.gbAva.Name = "gbAva";
            this.gbAva.Size = new System.Drawing.Size(200, 65);
            this.gbAva.TabIndex = 15;
            this.gbAva.TabStop = false;
            // 
            // rdAva
            // 
            this.rdAva.AutoSize = true;
            this.rdAva.Location = new System.Drawing.Point(7, 20);
            this.rdAva.Name = "rdAva";
            this.rdAva.Size = new System.Drawing.Size(68, 17);
            this.rdAva.TabIndex = 0;
            this.rdAva.TabStop = true;
            this.rdAva.Text = "Available";
            this.rdAva.UseVisualStyleBackColor = true;
            // 
            // rdUnava
            // 
            this.rdUnava.AutoSize = true;
            this.rdUnava.Location = new System.Drawing.Point(7, 42);
            this.rdUnava.Name = "rdUnava";
            this.rdUnava.Size = new System.Drawing.Size(79, 17);
            this.rdUnava.TabIndex = 1;
            this.rdUnava.TabStop = true;
            this.rdUnava.Text = "Unavalable";
            this.rdUnava.UseVisualStyleBackColor = true;
            // 
            // MenuRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 433);
            this.Controls.Add(this.gbAva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDishe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.label1);
            this.Name = "MenuRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbAva.ResumeLayout(false);
            this.gbAva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMenu;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDishe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteDisheToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbAva;
        private System.Windows.Forms.RadioButton rdUnava;
        private System.Windows.Forms.RadioButton rdAva;
    }
}