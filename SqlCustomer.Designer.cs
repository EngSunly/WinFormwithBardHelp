namespace WinFormwithBardHelp
{
    partial class SqlCustomer
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
            txtName = new TextBox();
            txtAddress = new TextBox();
            insert = new Button();
            update = new Button();
            delete = new Button();
            txtCusId = new TextBox();
            Display = new DataGridView();
            ReloadBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtDelete = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Rule = new Label();
            CID = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            cAddress = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Display).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.Wheat;
            txtName.Location = new Point(134, 82);
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.Wheat;
            txtAddress.Location = new Point(134, 135);
            txtAddress.Name = "txtAddress";
            txtAddress.RightToLeft = RightToLeft.Yes;
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 1;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // insert
            // 
            insert.Location = new Point(153, 168);
            insert.Name = "insert";
            insert.Size = new Size(94, 29);
            insert.TabIndex = 2;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // update
            // 
            update.Location = new Point(111, 283);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 3;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(203, 391);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 4;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // txtCusId
            // 
            txtCusId.BackColor = Color.Wheat;
            txtCusId.Location = new Point(134, 21);
            txtCusId.Name = "txtCusId";
            txtCusId.RightToLeft = RightToLeft.Yes;
            txtCusId.Size = new Size(125, 27);
            txtCusId.TabIndex = 5;
            txtCusId.TextAlign = HorizontalAlignment.Center;
            // 
            // Display
            // 
            Display.AllowUserToAddRows = false;
            Display.AllowUserToDeleteRows = false;
            Display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Display.Columns.AddRange(new DataGridViewColumn[] { CID, cName, cAddress });
            Display.Location = new Point(338, 132);
            Display.Name = "Display";
            Display.ReadOnly = true;
            Display.RowHeadersWidth = 51;
            Display.RowTemplate.Height = 29;
            Display.Size = new Size(448, 249);
            Display.TabIndex = 6;
            Display.CellClick += Display_CellClick;
            // 
            // ReloadBTN
            // 
            ReloadBTN.Location = new Point(338, 97);
            ReloadBTN.Name = "ReloadBTN";
            ReloadBTN.Size = new Size(94, 29);
            ReloadBTN.TabIndex = 7;
            ReloadBTN.Text = "Reload";
            ReloadBTN.UseVisualStyleBackColor = true;
            ReloadBTN.Click += ReloadBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 21);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 8;
            label1.Text = "txtCusId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 85);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 9;
            label2.Text = "txtName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 138);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 10;
            label3.Text = "txtAddress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 248);
            label5.Name = "label5";
            label5.Size = new Size(227, 20);
            label5.TabIndex = 11;
            label5.Text = "Click the button below to update";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 361);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 12;
            label4.Text = "Input ID Below to Delete";
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(49, 393);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(125, 27);
            txtDelete.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Chocolate;
            pictureBox1.Location = new Point(32, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 208);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonShadow;
            pictureBox2.Location = new Point(32, 221);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 108);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlDark;
            pictureBox3.Location = new Point(32, 345);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(276, 93);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // Rule
            // 
            Rule.AutoSize = true;
            Rule.Location = new Point(303, 28);
            Rule.Name = "Rule";
            Rule.Size = new Size(392, 20);
            Rule.TabIndex = 17;
            Rule.Text = "ID can only be integar Name and Adress has no contrainst";
            // 
            // CID
            // 
            CID.HeaderText = "CustomerID";
            CID.MinimumWidth = 6;
            CID.Name = "CID";
            CID.ReadOnly = true;
            CID.Width = 125;
            // 
            // cName
            // 
            cName.HeaderText = "Name";
            cName.MinimumWidth = 6;
            cName.Name = "cName";
            cName.ReadOnly = true;
            cName.Width = 125;
            // 
            // cAddress
            // 
            cAddress.HeaderText = "Address";
            cAddress.MinimumWidth = 6;
            cAddress.Name = "cAddress";
            cAddress.ReadOnly = true;
            cAddress.Width = 125;
            // 
            // SqlCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Rule);
            Controls.Add(txtDelete);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReloadBTN);
            Controls.Add(Display);
            Controls.Add(txtCusId);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(insert);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Name = "SqlCustomer";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Display).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Display_CellClick1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAddress;
        private Button insert;
        private Button update;
        private Button delete;
        private TextBox txtDelete;
        private TextBox txtCusId;
        private TextBox txtCusID;
        private DataGridView Display;
        private DataGridViewTextBoxColumn cID;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn cAddress;
        private Button ReloadBTN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label Rule;
        private DataGridViewTextBoxColumn CID;
    }
}