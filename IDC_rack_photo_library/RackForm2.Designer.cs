namespace IDC_rack_photo_library
{
    partial class RackForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RackForm2));
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.devPanel = new System.Windows.Forms.TableLayoutPanel();
            this.row_col_label = new System.Windows.Forms.Label();
            this.adddev_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.changeImageDown = new System.Windows.Forms.Button();
            this.rackpicture_down = new System.Windows.Forms.PictureBox();
            this.changeImageUp = new System.Windows.Forms.Button();
            this.rackpicture_up = new System.Windows.Forms.PictureBox();
            this.dev_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rackpicture_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rackpicture_up)).BeginInit();
            this.dev_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.devPanel);
            this.panel1.Controls.Add(this.row_col_label);
            this.panel1.Controls.Add(this.adddev_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 725);
            this.panel1.TabIndex = 1;
            // 
            // devPanel
            // 
            this.devPanel.ColumnCount = 1;
            this.devPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.devPanel.Location = new System.Drawing.Point(12, 51);
            this.devPanel.Name = "devPanel";
            this.devPanel.RowCount = 1;
            this.devPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.devPanel.Size = new System.Drawing.Size(303, 630);
            this.devPanel.TabIndex = 4;
            // 
            // row_col_label
            // 
            this.row_col_label.AutoSize = true;
            this.row_col_label.Location = new System.Drawing.Point(94, 33);
            this.row_col_label.Name = "row_col_label";
            this.row_col_label.Size = new System.Drawing.Size(0, 15);
            this.row_col_label.TabIndex = 2;
            // 
            // adddev_button
            // 
            this.adddev_button.Location = new System.Drawing.Point(119, 687);
            this.adddev_button.Name = "adddev_button";
            this.adddev_button.Size = new System.Drawing.Size(75, 23);
            this.adddev_button.TabIndex = 1;
            this.adddev_button.Text = "添加设备";
            this.adddev_button.UseVisualStyleBackColor = true;
            this.adddev_button.Click += new System.EventHandler(this.adddev_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(339, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 725);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.changeImageDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rackpicture_down, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.changeImageUp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rackpicture_up, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1043, 725);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // changeImageDown
            // 
            this.changeImageDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.changeImageDown.Location = new System.Drawing.Point(710, 691);
            this.changeImageDown.Name = "changeImageDown";
            this.changeImageDown.Size = new System.Drawing.Size(143, 31);
            this.changeImageDown.TabIndex = 5;
            this.changeImageDown.Tag = "rackpicture_down";
            this.changeImageDown.Text = "更新照片";
            this.changeImageDown.UseVisualStyleBackColor = true;
            this.changeImageDown.Click += new System.EventHandler(this.changeImage_Click);
            // 
            // rackpicture_down
            // 
            this.rackpicture_down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rackpicture_down.Image = ((System.Drawing.Image)(resources.GetObject("rackpicture_down.Image")));
            this.rackpicture_down.Location = new System.Drawing.Point(524, 3);
            this.rackpicture_down.MinimumSize = new System.Drawing.Size(38, 50);
            this.rackpicture_down.Name = "rackpicture_down";
            this.rackpicture_down.Size = new System.Drawing.Size(516, 682);
            this.rackpicture_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rackpicture_down.TabIndex = 4;
            this.rackpicture_down.TabStop = false;
            this.rackpicture_down.DoubleClick += new System.EventHandler(this.rackpicture_Click);
            this.rackpicture_down.MouseHover += new System.EventHandler(this.rackpicture_MouseHover);
            // 
            // changeImageUp
            // 
            this.changeImageUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.changeImageUp.Location = new System.Drawing.Point(189, 691);
            this.changeImageUp.Name = "changeImageUp";
            this.changeImageUp.Size = new System.Drawing.Size(143, 31);
            this.changeImageUp.TabIndex = 4;
            this.changeImageUp.Tag = "rackpicture_up";
            this.changeImageUp.Text = "更新照片";
            this.changeImageUp.UseVisualStyleBackColor = true;
            this.changeImageUp.Click += new System.EventHandler(this.changeImage_Click);
            // 
            // rackpicture_up
            // 
            this.rackpicture_up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rackpicture_up.Image = ((System.Drawing.Image)(resources.GetObject("rackpicture_up.Image")));
            this.rackpicture_up.Location = new System.Drawing.Point(3, 3);
            this.rackpicture_up.MinimumSize = new System.Drawing.Size(38, 50);
            this.rackpicture_up.Name = "rackpicture_up";
            this.rackpicture_up.Size = new System.Drawing.Size(515, 682);
            this.rackpicture_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rackpicture_up.TabIndex = 3;
            this.rackpicture_up.TabStop = false;
            this.rackpicture_up.DoubleClick += new System.EventHandler(this.rackpicture_Click);
            this.rackpicture_up.MouseHover += new System.EventHandler(this.rackpicture_MouseHover);
            // 
            // dev_contextMenuStrip
            // 
            this.dev_contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dev_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.dev_contextMenuStrip.Name = "dev_contextMenuStrip";
            this.dev_contextMenuStrip.Size = new System.Drawing.Size(109, 76);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.查看ToolStripMenuItem.Text = "查看";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // form2_toolTip
            // 
            this.form2_toolTip.AutomaticDelay = 1000;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "机架详情";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rackpicture_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rackpicture_up)).EndInit();
            this.dev_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox rackpicture_down;
        private System.Windows.Forms.PictureBox rackpicture_up;
        public System.Windows.Forms.Button adddev_button;
        private System.Windows.Forms.Label row_col_label;
        private System.Windows.Forms.TableLayoutPanel devPanel;
        private System.Windows.Forms.ContextMenuStrip dev_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button changeImageUp;
        private System.Windows.Forms.Button changeImageDown;
        private System.Windows.Forms.ToolTip form2_toolTip;
    }
}