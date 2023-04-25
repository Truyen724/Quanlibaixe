namespace Quanlibaixe
{
    partial class Form_Xe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desciption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TaiXe_combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Xoa_button = new Guna.UI2.WinForms.Guna2Button();
            this.Sua_button = new Guna.UI2.WinForms.Guna2Button();
            this.Them_button = new Guna.UI2.WinForms.Guna2Button();
            this.NgaySinh_combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MoTa_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TrangThai_combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDtaixe_combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BienSo_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1120, 487);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(675, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "NOTE !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Id_driver,
            this.Driver_name,
            this.dataGridViewTextBoxColumn3,
            this.Desciption});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(2, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 454);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_car";
            this.dataGridViewTextBoxColumn1.FillWeight = 96.25668F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Id_driver
            // 
            this.Id_driver.DataPropertyName = "Id_driver";
            this.Id_driver.HeaderText = "Id Driver";
            this.Id_driver.MinimumWidth = 6;
            this.Id_driver.Name = "Id_driver";
            // 
            // Driver_name
            // 
            this.Driver_name.DataPropertyName = "Driver_name";
            this.Driver_name.FillWeight = 101.8717F;
            this.Driver_name.HeaderText = "Driver_name";
            this.Driver_name.MinimumWidth = 6;
            this.Driver_name.Name = "Driver_name";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.FillWeight = 101.8717F;
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Desciption
            // 
            this.Desciption.DataPropertyName = "Desciption";
            this.Desciption.HeaderText = "Desciption";
            this.Desciption.MinimumWidth = 6;
            this.Desciption.Name = "Desciption";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(666, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "NOTE !";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TaiXe_combobox);
            this.panel1.Controls.Add(this.Xoa_button);
            this.panel1.Controls.Add(this.Sua_button);
            this.panel1.Controls.Add(this.Them_button);
            this.panel1.Controls.Add(this.NgaySinh_combobox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.MoTa_textbox);
            this.panel1.Controls.Add(this.TrangThai_combobox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.IDtaixe_combobox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BienSo_textbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(675, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 452);
            this.panel1.TabIndex = 38;
            // 
            // TaiXe_combobox
            // 
            this.TaiXe_combobox.BackColor = System.Drawing.Color.Transparent;
            this.TaiXe_combobox.BorderRadius = 3;
            this.TaiXe_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TaiXe_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaiXe_combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaiXe_combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaiXe_combobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TaiXe_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TaiXe_combobox.ItemHeight = 30;
            this.TaiXe_combobox.Location = new System.Drawing.Point(24, 150);
            this.TaiXe_combobox.Name = "TaiXe_combobox";
            this.TaiXe_combobox.Size = new System.Drawing.Size(390, 36);
            this.TaiXe_combobox.TabIndex = 67;
            this.TaiXe_combobox.SelectedIndexChanged += new System.EventHandler(this.TaiXe_combobox_SelectedIndexChanged);
            // 
            // Xoa_button
            // 
            this.Xoa_button.BorderRadius = 3;
            this.Xoa_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Xoa_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Xoa_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Xoa_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Xoa_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.Xoa_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa_button.ForeColor = System.Drawing.Color.White;
            this.Xoa_button.Location = new System.Drawing.Point(225, 399);
            this.Xoa_button.Name = "Xoa_button";
            this.Xoa_button.Size = new System.Drawing.Size(190, 45);
            this.Xoa_button.TabIndex = 19;
            this.Xoa_button.Text = "Xóa";
            this.Xoa_button.Click += new System.EventHandler(this.Xoa_button_Click);
            // 
            // Sua_button
            // 
            this.Sua_button.BorderRadius = 3;
            this.Sua_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Sua_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Sua_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sua_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Sua_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.Sua_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua_button.ForeColor = System.Drawing.Color.White;
            this.Sua_button.Location = new System.Drawing.Point(24, 399);
            this.Sua_button.Name = "Sua_button";
            this.Sua_button.Size = new System.Drawing.Size(190, 45);
            this.Sua_button.TabIndex = 18;
            this.Sua_button.Text = "Sửa";
            this.Sua_button.Click += new System.EventHandler(this.Sua_button_Click);
            // 
            // Them_button
            // 
            this.Them_button.BorderRadius = 3;
            this.Them_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Them_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Them_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Them_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Them_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.Them_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_button.ForeColor = System.Drawing.Color.White;
            this.Them_button.Location = new System.Drawing.Point(24, 348);
            this.Them_button.Name = "Them_button";
            this.Them_button.Size = new System.Drawing.Size(390, 45);
            this.Them_button.TabIndex = 17;
            this.Them_button.Text = "Thêm";
            this.Them_button.Click += new System.EventHandler(this.Them_button_Click);
            // 
            // NgaySinh_combobox
            // 
            this.NgaySinh_combobox.BackColor = System.Drawing.Color.Transparent;
            this.NgaySinh_combobox.BorderRadius = 3;
            this.NgaySinh_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NgaySinh_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NgaySinh_combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NgaySinh_combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NgaySinh_combobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NgaySinh_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.NgaySinh_combobox.ItemHeight = 30;
            this.NgaySinh_combobox.Location = new System.Drawing.Point(24, 212);
            this.NgaySinh_combobox.Name = "NgaySinh_combobox";
            this.NgaySinh_combobox.Size = new System.Drawing.Size(390, 36);
            this.NgaySinh_combobox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mô tả";
            // 
            // MoTa_textbox
            // 
            this.MoTa_textbox.BorderRadius = 3;
            this.MoTa_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MoTa_textbox.DefaultText = "";
            this.MoTa_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MoTa_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MoTa_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MoTa_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MoTa_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoTa_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MoTa_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MoTa_textbox.Location = new System.Drawing.Point(24, 275);
            this.MoTa_textbox.Name = "MoTa_textbox";
            this.MoTa_textbox.PasswordChar = '\0';
            this.MoTa_textbox.PlaceholderText = "";
            this.MoTa_textbox.SelectedText = "";
            this.MoTa_textbox.Size = new System.Drawing.Size(390, 36);
            this.MoTa_textbox.TabIndex = 13;
            // 
            // TrangThai_combobox
            // 
            this.TrangThai_combobox.BackColor = System.Drawing.Color.Transparent;
            this.TrangThai_combobox.BorderRadius = 3;
            this.TrangThai_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TrangThai_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrangThai_combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TrangThai_combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TrangThai_combobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TrangThai_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TrangThai_combobox.ItemHeight = 30;
            this.TrangThai_combobox.Location = new System.Drawing.Point(224, 87);
            this.TrangThai_combobox.Name = "TrangThai_combobox";
            this.TrangThai_combobox.Size = new System.Drawing.Size(190, 36);
            this.TrangThai_combobox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tài xế";
            // 
            // IDtaixe_combobox
            // 
            this.IDtaixe_combobox.BackColor = System.Drawing.Color.Transparent;
            this.IDtaixe_combobox.BorderRadius = 3;
            this.IDtaixe_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IDtaixe_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDtaixe_combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDtaixe_combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDtaixe_combobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IDtaixe_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.IDtaixe_combobox.ItemHeight = 30;
            this.IDtaixe_combobox.Location = new System.Drawing.Point(24, 87);
            this.IDtaixe_combobox.Name = "IDtaixe_combobox";
            this.IDtaixe_combobox.Size = new System.Drawing.Size(190, 36);
            this.IDtaixe_combobox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID tài xế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Biển số";
            // 
            // BienSo_textbox
            // 
            this.BienSo_textbox.BorderRadius = 3;
            this.BienSo_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BienSo_textbox.DefaultText = "";
            this.BienSo_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BienSo_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BienSo_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BienSo_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BienSo_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BienSo_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BienSo_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BienSo_textbox.Location = new System.Drawing.Point(24, 24);
            this.BienSo_textbox.Name = "BienSo_textbox";
            this.BienSo_textbox.PasswordChar = '\0';
            this.BienSo_textbox.PlaceholderText = "";
            this.BienSo_textbox.SelectedText = "";
            this.BienSo_textbox.Size = new System.Drawing.Size(390, 36);
            this.BienSo_textbox.TabIndex = 0;
            // 
            // Form_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 487);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Xe";
            this.Text = "Form_Xe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desciption;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox BienSo_textbox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox IDtaixe_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox TrangThai_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox MoTa_textbox;
        private Guna.UI2.WinForms.Guna2Button Sua_button;
        private Guna.UI2.WinForms.Guna2Button Them_button;
        private Guna.UI2.WinForms.Guna2ComboBox NgaySinh_combobox;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button Xoa_button;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox TaiXe_combobox;
    }
}