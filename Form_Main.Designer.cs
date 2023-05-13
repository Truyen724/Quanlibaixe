
namespace Quanlibaixe
{
    partial class Form_Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID_action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.In_or_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_parkinglot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desciption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_IDcar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TaiXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xe ở bên trong";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xe ở bên ngoài";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "Tất cả các xe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_action,
            this.ID_car,
            this.Image,
            this.In_or_out,
            this.Time,
            this.Id_parkinglot});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(486, 89);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(480, 396);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellMouseLeave);
            this.dataGridView2.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseMove);
            // 
            // ID_action
            // 
            this.ID_action.DataPropertyName = "ID_action";
            this.ID_action.HeaderText = "ID action";
            this.ID_action.MinimumWidth = 6;
            this.ID_action.Name = "ID_action";
            this.ID_action.ReadOnly = true;
            // 
            // ID_car
            // 
            this.ID_car.DataPropertyName = "ID_car";
            this.ID_car.FillWeight = 70F;
            this.ID_car.HeaderText = "Biển Số Xe";
            this.ID_car.MinimumWidth = 6;
            this.ID_car.Name = "ID_car";
            this.ID_car.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MaxInputLength = 1000000;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Visible = false;
            // 
            // In_or_out
            // 
            this.In_or_out.DataPropertyName = "In_or_out";
            this.In_or_out.FillWeight = 60F;
            this.In_or_out.HeaderText = "Trạng Thái";
            this.In_or_out.MinimumWidth = 6;
            this.In_or_out.Name = "In_or_out";
            this.In_or_out.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Thời Gian";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Id_parkinglot
            // 
            this.Id_parkinglot.DataPropertyName = "Id_parkinglot";
            this.Id_parkinglot.HeaderText = "Id_parkinglot";
            this.Id_parkinglot.MinimumWidth = 6;
            this.Id_parkinglot.Name = "Id_parkinglot";
            this.Id_parkinglot.ReadOnly = true;
            this.Id_parkinglot.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 195);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.Width = 177;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id_car";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 177;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Driver_name,
            this.dataGridViewTextBoxColumn3,
            this.Desciption});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 396);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_car";
            this.dataGridViewTextBoxColumn1.FillWeight = 70F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Biển Số Xe";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Driver_name
            // 
            this.Driver_name.DataPropertyName = "Driver_name";
            this.Driver_name.FillWeight = 101.8717F;
            this.Driver_name.HeaderText = "Tên Tài Xế";
            this.Driver_name.MinimumWidth = 6;
            this.Driver_name.Name = "Driver_name";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.FillWeight = 60F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Desciption
            // 
            this.Desciption.DataPropertyName = "Desciption";
            this.Desciption.HeaderText = "Mô Tả";
            this.Desciption.MinimumWidth = 6;
            this.Desciption.Name = "Desciption";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 31);
            this.button5.TabIndex = 21;
            this.button5.Text = "Xe chưa đăng kí";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(1, 199);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 195);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(106, 3);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 31);
            this.button4.TabIndex = 34;
            this.button4.Text = "Bên trong";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(210, 3);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 31);
            this.button6.TabIndex = 35;
            this.button6.Text = "Bên ngoài";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1210, 487);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_IDcar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_TaiXe, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 81);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 35);
            this.panel4.TabIndex = 36;
            // 
            // txt_IDcar
            // 
            this.txt_IDcar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_IDcar.DefaultText = "";
            this.txt_IDcar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_IDcar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_IDcar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDcar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_IDcar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_IDcar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDcar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_IDcar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_IDcar.Location = new System.Drawing.Point(3, 3);
            this.txt_IDcar.Name = "txt_IDcar";
            this.txt_IDcar.PasswordChar = '\0';
            this.txt_IDcar.PlaceholderText = "";
            this.txt_IDcar.SelectedText = "";
            this.txt_IDcar.Size = new System.Drawing.Size(161, 34);
            this.txt_IDcar.TabIndex = 36;
            // 
            // txt_TaiXe
            // 
            this.txt_TaiXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TaiXe.DefaultText = "";
            this.txt_TaiXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TaiXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TaiXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TaiXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TaiXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_TaiXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TaiXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TaiXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TaiXe.Location = new System.Drawing.Point(170, 3);
            this.txt_TaiXe.Name = "txt_TaiXe";
            this.txt_TaiXe.PasswordChar = '\0';
            this.txt_TaiXe.PlaceholderText = "";
            this.txt_TaiXe.SelectedText = "";
            this.txt_TaiXe.Size = new System.Drawing.Size(305, 34);
            this.txt_TaiXe.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(170, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 35);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(487, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 81);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.guna2CircleProgressBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(971, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 394);
            this.panel3.TabIndex = 20;
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.AnimationSpeed = 0.4F;
            this.guna2CircleProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2CircleProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(0, 205);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(66)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(66)))));
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(189, 189);
            this.guna2CircleProgressBar1.TabIndex = 23;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.Value = 65;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(971, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 81);
            this.panel5.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.17574F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.82427F));
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(478, 81);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(339, 35);
            this.panel6.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1210, 487);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản Lí Bãi Xe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_action;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn In_or_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_parkinglot;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desciption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_TaiXe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txt_IDcar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel6;
    }
}

