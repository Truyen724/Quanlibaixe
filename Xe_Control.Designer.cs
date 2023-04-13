namespace Quanlibaixe
{
    partial class Xe_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desciption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCT3 = new Quanlibaixe.Custom_Toolbox.TextBoxCT();
            this.textBoxCT2 = new Quanlibaixe.Custom_Toolbox.TextBoxCT();
            this.textBoxCT1 = new Quanlibaixe.Custom_Toolbox.TextBoxCT();
            this.buttonCT1 = new Quanlibaixe.Custom_Toolbox.ButtonCT();
            this.buttonCT2 = new Quanlibaixe.Custom_Toolbox.ButtonCT();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1310, 587);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 560);
            this.dataGridView1.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_car";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
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
            this.Driver_name.FillWeight = 150F;
            this.Driver_name.HeaderText = "Driver_name";
            this.Driver_name.MinimumWidth = 6;
            this.Driver_name.Name = "Driver_name";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Desciption
            // 
            this.Desciption.DataPropertyName = "Desciption";
            this.Desciption.FillWeight = 150F;
            this.Desciption.HeaderText = "Desciption";
            this.Desciption.MinimumWidth = 6;
            this.Desciption.Name = "Desciption";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(723, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 17);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 17);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCT2);
            this.panel3.Controls.Add(this.textBoxCT3);
            this.panel3.Controls.Add(this.textBoxCT2);
            this.panel3.Controls.Add(this.textBoxCT1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.buttonCT1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(723, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 558);
            this.panel3.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Biển Số";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(305, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mô Tả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trạng Thái";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(305, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tài Xế";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(305, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Sinh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(13, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID Tài Xế";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCT3
            // 
            this.textBoxCT3.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCT3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxCT3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxCT3.BorderSize = 2;
            this.textBoxCT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCT3.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCT3.Location = new System.Drawing.Point(106, 82);
            this.textBoxCT3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCT3.Multiline = false;
            this.textBoxCT3.Name = "textBoxCT3";
            this.textBoxCT3.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxCT3.PasswordChar = false;
            this.textBoxCT3.Size = new System.Drawing.Size(173, 31);
            this.textBoxCT3.TabIndex = 11;
            this.textBoxCT3.Texts = "";
            this.textBoxCT3.UnderlinedStyle = false;
            // 
            // textBoxCT2
            // 
            this.textBoxCT2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCT2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxCT2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxCT2.BorderSize = 2;
            this.textBoxCT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCT2.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCT2.Location = new System.Drawing.Point(106, 43);
            this.textBoxCT2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCT2.Multiline = false;
            this.textBoxCT2.Name = "textBoxCT2";
            this.textBoxCT2.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxCT2.PasswordChar = false;
            this.textBoxCT2.Size = new System.Drawing.Size(173, 31);
            this.textBoxCT2.TabIndex = 10;
            this.textBoxCT2.Texts = "";
            this.textBoxCT2.UnderlinedStyle = false;
            // 
            // textBoxCT1
            // 
            this.textBoxCT1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCT1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxCT1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxCT1.BorderSize = 2;
            this.textBoxCT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCT1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCT1.Location = new System.Drawing.Point(106, 4);
            this.textBoxCT1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCT1.Multiline = false;
            this.textBoxCT1.Name = "textBoxCT1";
            this.textBoxCT1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxCT1.PasswordChar = false;
            this.textBoxCT1.Size = new System.Drawing.Size(173, 31);
            this.textBoxCT1.TabIndex = 9;
            this.textBoxCT1.Texts = "";
            this.textBoxCT1.UnderlinedStyle = false;
            // 
            // buttonCT1
            // 
            this.buttonCT1.BackColor = System.Drawing.Color.Gray;
            this.buttonCT1.BackgroundColor = System.Drawing.Color.Gray;
            this.buttonCT1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCT1.BorderRadius = 3;
            this.buttonCT1.BorderSize = 0;
            this.buttonCT1.FlatAppearance.BorderSize = 0;
            this.buttonCT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCT1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCT1.ForeColor = System.Drawing.Color.White;
            this.buttonCT1.Location = new System.Drawing.Point(17, 306);
            this.buttonCT1.Name = "buttonCT1";
            this.buttonCT1.Size = new System.Drawing.Size(547, 40);
            this.buttonCT1.TabIndex = 0;
            this.buttonCT1.Text = "Thêm Xe";
            this.buttonCT1.TextColor = System.Drawing.Color.White;
            this.buttonCT1.UseVisualStyleBackColor = false;
            this.buttonCT1.Click += new System.EventHandler(this.buttonCT1_Click);
            // 
            // buttonCT2
            // 
            this.buttonCT2.BackColor = System.Drawing.Color.Gray;
            this.buttonCT2.BackgroundColor = System.Drawing.Color.Gray;
            this.buttonCT2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCT2.BorderRadius = 3;
            this.buttonCT2.BorderSize = 0;
            this.buttonCT2.FlatAppearance.BorderSize = 0;
            this.buttonCT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCT2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCT2.ForeColor = System.Drawing.Color.White;
            this.buttonCT2.Location = new System.Drawing.Point(17, 363);
            this.buttonCT2.Name = "buttonCT2";
            this.buttonCT2.Size = new System.Drawing.Size(547, 40);
            this.buttonCT2.TabIndex = 12;
            this.buttonCT2.Text = "Thêm Xe";
            this.buttonCT2.TextColor = System.Drawing.Color.White;
            this.buttonCT2.UseVisualStyleBackColor = false;
            this.buttonCT2.Click += new System.EventHandler(this.buttonCT2_Click);
            // 
            // Xe_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Xe_Control";
            this.Size = new System.Drawing.Size(1310, 587);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desciption;
        private System.Windows.Forms.Panel panel3;
        private Custom_Toolbox.ButtonCT buttonCT1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Custom_Toolbox.TextBoxCT textBoxCT2;
        private Custom_Toolbox.TextBoxCT textBoxCT1;
        private Custom_Toolbox.TextBoxCT textBoxCT3;
        private Custom_Toolbox.ButtonCT buttonCT2;
    }
}
