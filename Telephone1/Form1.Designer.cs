namespace Telephone1
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
            this.UserID = new System.Windows.Forms.Label();
            this.UserGender = new System.Windows.Forms.ComboBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchCustomerDetail = new System.Windows.Forms.CheckBox();
            this.AddCustomerDetail = new System.Windows.Forms.CheckBox();
            this.SearchCustomer = new System.Windows.Forms.CheckBox();
            this.AddCustomer = new System.Windows.Forms.CheckBox();
            this.SearchUser = new System.Windows.Forms.CheckBox();
            this.AddUser = new System.Windows.Forms.CheckBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.cb_showpass = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserID.Location = new System.Drawing.Point(211, 107);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(159, 32);
            this.UserID.TabIndex = 17;
            this.UserID.Text = "000000111111";
            this.UserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserID.Click += new System.EventHandler(this.UserID_Click);
            // 
            // UserGender
            // 
            this.UserGender.FormattingEnabled = true;
            this.UserGender.Items.AddRange(new object[] {
            "male",
            "famale"});
            this.UserGender.Location = new System.Drawing.Point(211, 164);
            this.UserGender.Name = "UserGender";
            this.UserGender.Size = new System.Drawing.Size(154, 23);
            this.UserGender.TabIndex = 16;
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(211, 257);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(154, 23);
            this.UserPassword.TabIndex = 15;
            this.UserPassword.UseSystemPasswordChar = true;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(211, 211);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(154, 23);
            this.UserName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(26, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(26, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "UserName";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Serial Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(335, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchCustomerDetail);
            this.groupBox1.Controls.Add(this.AddCustomerDetail);
            this.groupBox1.Controls.Add(this.SearchCustomer);
            this.groupBox1.Controls.Add(this.AddCustomer);
            this.groupBox1.Controls.Add(this.SearchUser);
            this.groupBox1.Controls.Add(this.AddUser);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(427, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 173);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SearchCustomerDetail
            // 
            this.SearchCustomerDetail.AutoSize = true;
            this.SearchCustomerDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchCustomerDetail.Location = new System.Drawing.Point(39, 143);
            this.SearchCustomerDetail.Name = "SearchCustomerDetail";
            this.SearchCustomerDetail.Size = new System.Drawing.Size(143, 19);
            this.SearchCustomerDetail.TabIndex = 5;
            this.SearchCustomerDetail.Text = "SearchCustomerDetail";
            this.SearchCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // AddCustomerDetail
            // 
            this.AddCustomerDetail.AutoSize = true;
            this.AddCustomerDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddCustomerDetail.Location = new System.Drawing.Point(39, 118);
            this.AddCustomerDetail.Name = "AddCustomerDetail";
            this.AddCustomerDetail.Size = new System.Drawing.Size(130, 19);
            this.AddCustomerDetail.TabIndex = 4;
            this.AddCustomerDetail.Text = "AddCustomerDetail";
            this.AddCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // SearchCustomer
            // 
            this.SearchCustomer.AutoSize = true;
            this.SearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchCustomer.Location = new System.Drawing.Point(39, 93);
            this.SearchCustomer.Name = "SearchCustomer";
            this.SearchCustomer.Size = new System.Drawing.Size(113, 19);
            this.SearchCustomer.TabIndex = 3;
            this.SearchCustomer.Text = "SearchCustomer";
            this.SearchCustomer.UseVisualStyleBackColor = true;
            this.SearchCustomer.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // AddCustomer
            // 
            this.AddCustomer.AutoSize = true;
            this.AddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddCustomer.Location = new System.Drawing.Point(39, 71);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(100, 19);
            this.AddCustomer.TabIndex = 2;
            this.AddCustomer.Text = "AddCustomer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // SearchUser
            // 
            this.SearchUser.AutoSize = true;
            this.SearchUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchUser.Location = new System.Drawing.Point(39, 51);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(84, 19);
            this.SearchUser.TabIndex = 1;
            this.SearchUser.Text = "SearchUser";
            this.SearchUser.UseVisualStyleBackColor = true;
            this.SearchUser.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // AddUser
            // 
            this.AddUser.AutoSize = true;
            this.AddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddUser.Location = new System.Drawing.Point(39, 26);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(71, 19);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "AddUser";
            this.AddUser.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Teal;
            this.btn_new.ForeColor = System.Drawing.Color.Black;
            this.btn_new.Location = new System.Drawing.Point(72, 345);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(145, 55);
            this.btn_new.TabIndex = 19;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Teal;
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(253, 345);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(145, 55);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Teal;
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(434, 345);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(145, 55);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Teal;
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(616, 345);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(145, 55);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // cb_showpass
            // 
            this.cb_showpass.AutoSize = true;
            this.cb_showpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_showpass.Location = new System.Drawing.Point(211, 286);
            this.cb_showpass.Name = "cb_showpass";
            this.cb_showpass.Size = new System.Drawing.Size(55, 19);
            this.cb_showpass.TabIndex = 6;
            this.cb_showpass.Text = "Show";
            this.cb_showpass.UseVisualStyleBackColor = true;
            this.cb_showpass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_showpass);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.UserGender);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label UserID;
        public ComboBox UserGender;
        public TextBox UserPassword;
        public TextBox UserName;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
        public Label label1;
        public GroupBox groupBox1;
        public Button btn_new;
        public Button btn_save;
        public Button btn_delete;
        public Button btn_close;
        public CheckBox SearchCustomer;
        public CheckBox AddCustomer;
        public CheckBox SearchUser;
        public CheckBox AddUser;
        public CheckBox SearchCustomerDetail;
        public CheckBox AddCustomerDetail;
        public CheckBox cb_showpass;
    }
}