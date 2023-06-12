namespace WinFormwithBardHelp
{
    partial class EditForm
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
            this.txtFindID = new System.Windows.Forms.TextBox();
            this.updateF2Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.txtFindAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CusID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFindID
            // 
            this.txtFindID.Location = new System.Drawing.Point(338, 71);
            this.txtFindID.Name = "txtFindID";
            this.txtFindID.Size = new System.Drawing.Size(125, 27);
            this.txtFindID.TabIndex = 1;
            // 
            // updateF2Btn
            // 
            this.updateF2Btn.Location = new System.Drawing.Point(359, 296);
            this.updateF2Btn.Name = "updateF2Btn";
            this.updateF2Btn.Size = new System.Drawing.Size(94, 29);
            this.updateF2Btn.TabIndex = 2;
            this.updateF2Btn.Text = " Update";
            this.updateF2Btn.UseVisualStyleBackColor = true;
            this.updateF2Btn.Click += new System.EventHandler(this.updateF2Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // txtFindName
            // 
            this.txtFindName.Location = new System.Drawing.Point(338, 134);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(125, 27);
            this.txtFindName.TabIndex = 5;
            // 
            // txtFindAddress
            // 
            this.txtFindAddress.Location = new System.Drawing.Point(338, 198);
            this.txtFindAddress.Name = "txtFindAddress";
            this.txtFindAddress.Size = new System.Drawing.Size(125, 27);
            this.txtFindAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please Provide ID to Update";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(469, 69);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(94, 29);
            this.findBtn.TabIndex = 8;
            this.findBtn.Text = "Find ID";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFindAddress);
            this.Controls.Add(this.txtFindName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateF2Btn);
            this.Controls.Add(this.txtFindID);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFindID;
        private Button updateF2Btn;
        private Label label2;
        private Label label3;
        private TextBox txtFindName;
        private TextBox txtFindAddress;
        private Label label4;
        private Button findBtn;
    }
}