
namespace Quanlibaixe
{
    partial class Form_Driver
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
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Driver));
            this.NgaySinh_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_TenTaiXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_IDtaixe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_TenTaiXe2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_PhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_DiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Refresh = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NgaySinh_dateTimePicker
            // 
            this.NgaySinh_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh_dateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.guna2Transition1.SetDecoration(this.NgaySinh_dateTimePicker, Guna.UI2.AnimatorNS.DecorationType.None);
            this.NgaySinh_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySinh_dateTimePicker.Location = new System.Drawing.Point(141, 117);
            this.NgaySinh_dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.NgaySinh_dateTimePicker.Name = "NgaySinh_dateTimePicker";
            this.NgaySinh_dateTimePicker.Size = new System.Drawing.Size(303, 26);
            this.NgaySinh_dateTimePicker.TabIndex = 6;
            // 
            // button1
            // 
            this.guna2Transition1.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(141, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sửa ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.guna2Transition1.SetDecoration(this.button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button2.Location = new System.Drawing.Point(141, 234);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thêm ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.guna2Transition1.SetDecoration(this.button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button3.Location = new System.Drawing.Point(329, 389);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_TenTaiXe
            // 
            this.txt_TenTaiXe.BorderColor = System.Drawing.Color.Gray;
            this.txt_TenTaiXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txt_TenTaiXe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_TenTaiXe.DefaultText = "";
            this.txt_TenTaiXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenTaiXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenTaiXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenTaiXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenTaiXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenTaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TenTaiXe.ForeColor = System.Drawing.Color.Gray;
            this.txt_TenTaiXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenTaiXe.Location = new System.Drawing.Point(141, 53);
            this.txt_TenTaiXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenTaiXe.Name = "txt_TenTaiXe";
            this.txt_TenTaiXe.PasswordChar = '\0';
            this.txt_TenTaiXe.PlaceholderText = "";
            this.txt_TenTaiXe.SelectedText = "";
            this.txt_TenTaiXe.Size = new System.Drawing.Size(303, 36);
            this.txt_TenTaiXe.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(13, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tên Tài xế";
            // 
            // cb_IDtaixe
            // 
            this.cb_IDtaixe.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.cb_IDtaixe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cb_IDtaixe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_IDtaixe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IDtaixe.Enabled = false;
            this.cb_IDtaixe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_IDtaixe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_IDtaixe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_IDtaixe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_IDtaixe.ItemHeight = 30;
            this.cb_IDtaixe.Location = new System.Drawing.Point(141, 10);
            this.cb_IDtaixe.Name = "cb_IDtaixe";
            this.cb_IDtaixe.Size = new System.Drawing.Size(303, 36);
            this.cb_IDtaixe.TabIndex = 65;
            this.cb_IDtaixe.SelectedIndexChanged += new System.EventHandler(this.cb_IDtaixe_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Mã Số Tài Xế";
            // 
            // cb_TenTaiXe2
            // 
            this.cb_TenTaiXe2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.cb_TenTaiXe2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cb_TenTaiXe2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TenTaiXe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TenTaiXe2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TenTaiXe2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_TenTaiXe2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_TenTaiXe2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_TenTaiXe2.ItemHeight = 30;
            this.cb_TenTaiXe2.Location = new System.Drawing.Point(141, 304);
            this.cb_TenTaiXe2.Name = "cb_TenTaiXe2";
            this.cb_TenTaiXe2.Size = new System.Drawing.Size(303, 36);
            this.cb_TenTaiXe2.TabIndex = 65;
            this.cb_TenTaiXe2.SelectedIndexChanged += new System.EventHandler(this.cb_TenTaiXe2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(11, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ngày Sinh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_driver,
            this.Driver_name,
            this.Dateofbirth,
            this.Phone_Number,
            this.Dia_Chi});
            this.guna2Transition1.SetDecoration(this.dataGridView1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dataGridView1.Location = new System.Drawing.Point(488, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 418);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_driver
            // 
            this.Id_driver.DataPropertyName = "Id_driver";
            this.Id_driver.FillWeight = 50F;
            this.Id_driver.HeaderText = "Mã Tài Xế";
            this.Id_driver.MinimumWidth = 6;
            this.Id_driver.Name = "Id_driver";
            // 
            // Driver_name
            // 
            this.Driver_name.DataPropertyName = "Driver_name";
            this.Driver_name.FillWeight = 101.8717F;
            this.Driver_name.HeaderText = "Tên Tài Xế";
            this.Driver_name.MinimumWidth = 6;
            this.Driver_name.Name = "Driver_name";
            // 
            // Dateofbirth
            // 
            this.Dateofbirth.DataPropertyName = "Dateofbirth";
            this.Dateofbirth.FillWeight = 70F;
            this.Dateofbirth.HeaderText = "Ngày Sinh";
            this.Dateofbirth.MinimumWidth = 6;
            this.Dateofbirth.Name = "Dateofbirth";
            // 
            // Phone_Number
            // 
            this.Phone_Number.DataPropertyName = "Phone_Number";
            this.Phone_Number.FillWeight = 80F;
            this.Phone_Number.HeaderText = "Số Điện Thoại";
            this.Phone_Number.Name = "Phone_Number";
            // 
            // Dia_Chi
            // 
            this.Dia_Chi.DataPropertyName = "Dia_Chi";
            this.Dia_Chi.HeaderText = "Địa Chỉ";
            this.Dia_Chi.Name = "Dia_Chi";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.BorderColor = System.Drawing.Color.Gray;
            this.txt_PhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txt_PhoneNumber, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_PhoneNumber.DefaultText = "";
            this.txt_PhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_PhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.txt_PhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PhoneNumber.Location = new System.Drawing.Point(141, 149);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.PasswordChar = '\0';
            this.txt_PhoneNumber.PlaceholderText = "";
            this.txt_PhoneNumber.SelectedText = "";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(303, 36);
            this.txt_PhoneNumber.TabIndex = 69;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderColor = System.Drawing.Color.Gray;
            this.txt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txt_DiaChi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_DiaChi.DefaultText = "";
            this.txt_DiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_DiaChi.ForeColor = System.Drawing.Color.Gray;
            this.txt_DiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Location = new System.Drawing.Point(141, 192);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.SelectedText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(303, 36);
            this.txt_DiaChi.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(11, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(22, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Refresh";
            this.label5.Visible = false;
            // 
            // btn_Refresh
            // 
            this.guna2Transition1.SetDecoration(this.btn_Refresh, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Refresh.FillColor = System.Drawing.SystemColors.Control;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(66)))));
            this.btn_Refresh.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(28, 326);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Refresh.Size = new System.Drawing.Size(40, 40);
            this.btn_Refresh.TabIndex = 72;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            this.btn_Refresh.MouseLeave += new System.EventHandler(this.btn_Refresh_MouseLeave);
            this.btn_Refresh.MouseHover += new System.EventHandler(this.btn_Refresh_MouseHover);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Mosaic;
            this.guna2Transition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation3;
            // 
            // Form_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_TenTaiXe2);
            this.Controls.Add(this.cb_IDtaixe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TenTaiXe);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NgaySinh_dateTimePicker);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Driver";
            this.Text = "Form_Driver";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker NgaySinh_dateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenTaiXe;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cb_IDtaixe;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cb_TenTaiXe2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Chi;
        private Guna.UI2.WinForms.Guna2TextBox txt_PhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txt_DiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Refresh;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}