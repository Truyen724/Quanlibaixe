
namespace Quanlibaixe
{
    partial class Form_camera
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíTàiXếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíDữLiệuToolStripMenuItem,
            this.quảnLíXeToolStripMenuItem,
            this.quảnLíTàiXếToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíXeToolStripMenuItem
            // 
            this.quảnLíXeToolStripMenuItem.Name = "quảnLíXeToolStripMenuItem";
            this.quảnLíXeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.quảnLíXeToolStripMenuItem.Text = "Quản lí xe";
            this.quảnLíXeToolStripMenuItem.Click += new System.EventHandler(this.quảnLíXeToolStripMenuItem_Click);
            // 
            // quảnLíTàiXếToolStripMenuItem
            // 
            this.quảnLíTàiXếToolStripMenuItem.Name = "quảnLíTàiXếToolStripMenuItem";
            this.quảnLíTàiXếToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.quảnLíTàiXếToolStripMenuItem.Text = "Quản lí tài xế";
            this.quảnLíTàiXếToolStripMenuItem.Click += new System.EventHandler(this.quảnLíTàiXếToolStripMenuItem_Click);
            // 
            // quảnLíDữLiệuToolStripMenuItem
            // 
            this.quảnLíDữLiệuToolStripMenuItem.Name = "quảnLíDữLiệuToolStripMenuItem";
            this.quảnLíDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.quảnLíDữLiệuToolStripMenuItem.Text = "Quản lí dữ liệu";
            this.quảnLíDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.quảnLíDữLiệuToolStripMenuItem_Click);
            // 
            // Form_camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 772);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_camera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_camera";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíTàiXếToolStripMenuItem;
    }
}