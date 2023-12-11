namespace WinFormProductClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            btnRefresh = new Button();
            groupBox1 = new GroupBox();
            cbocat = new ComboBox();
            label3 = new Label();
            txtname = new TextBox();
            label2 = new Label();
            txtprice = new TextBox();
            txtcode = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btnCreateClear = new Button();
            btnCreateSubmit = new Button();
            btnUpdateSubmit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(18, 52);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(701, 376);
            dgvProducts.TabIndex = 0;
            dgvProducts.DoubleClick += dgvProducts_DoubleClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(1187, 73);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(123, 50);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbocat);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtprice);
            groupBox1.Controls.Add(txtcode);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(739, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 376);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "                      Coffe Management";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbocat
            // 
            cbocat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbocat.FormattingEnabled = true;
            cbocat.Location = new Point(122, 177);
            cbocat.Name = "cbocat";
            cbocat.Size = new Size(279, 39);
            cbocat.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 177);
            label3.Name = "label3";
            label3.Size = new Size(106, 31);
            label3.TabIndex = 4;
            label3.Text = "Category";
            label3.Click += label3_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(122, 123);
            txtname.Name = "txtname";
            txtname.Size = new Size(279, 38);
            txtname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 126);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtprice
            // 
            txtprice.Location = new Point(120, 227);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(281, 38);
            txtprice.TabIndex = 1;
            // 
            // txtcode
            // 
            txtcode.Location = new Point(120, 69);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(281, 38);
            txtcode.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 227);
            label4.Name = "label4";
            label4.Size = new Size(64, 31);
            label4.TabIndex = 0;
            label4.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 76);
            label1.Name = "label1";
            label1.Size = new Size(67, 31);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // btnCreateClear
            // 
            btnCreateClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateClear.Location = new Point(1187, 329);
            btnCreateClear.Name = "btnCreateClear";
            btnCreateClear.Size = new Size(123, 47);
            btnCreateClear.TabIndex = 8;
            btnCreateClear.Text = "Clear";
            btnCreateClear.UseVisualStyleBackColor = true;
            // 
            // btnCreateSubmit
            // 
            btnCreateSubmit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateSubmit.Location = new Point(1187, 137);
            btnCreateSubmit.Name = "btnCreateSubmit";
            btnCreateSubmit.Size = new Size(123, 49);
            btnCreateSubmit.TabIndex = 6;
            btnCreateSubmit.Text = "Create";
            btnCreateSubmit.UseVisualStyleBackColor = true;
            btnCreateSubmit.Click += btnCreateSubmit_Click;
            // 
            // btnUpdateSubmit
            // 
            btnUpdateSubmit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateSubmit.Location = new Point(1187, 264);
            btnUpdateSubmit.Name = "btnUpdateSubmit";
            btnUpdateSubmit.Size = new Size(123, 46);
            btnUpdateSubmit.TabIndex = 6;
            btnUpdateSubmit.Text = "Update";
            btnUpdateSubmit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(1187, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 46);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 530);
            Controls.Add(btnCreateClear);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(btnCreateSubmit);
            Controls.Add(btnRefresh);
            Controls.Add(dgvProducts);
            Controls.Add(btnUpdateSubmit);
            Name = "Form1";
            Text = "Delete";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnRefresh;
        private GroupBox groupBox1;
        private Button btnCreateSubmit;
        private Label label3;
        private TextBox txtname;
        private Label label2;
        private TextBox txtcode;
        private Label label1;
        private Button btnUpdateSubmit;
        private Button btnDelete;
        private Button btnCreateClear;
        private ComboBox cbocat;
        private TextBox txtprice;
        private Label label4;
    }
}