namespace IDC_rack_photo_library
{
    partial class AddDevForm3
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
            this.devmodel = new System.Windows.Forms.TextBox();
            this.devip = new System.Windows.Forms.TextBox();
            this.label_devmodel = new System.Windows.Forms.Label();
            this.label_devtype = new System.Windows.Forms.Label();
            this.label_devip = new System.Windows.Forms.Label();
            this.label_clientname = new System.Windows.Forms.Label();
            this.clientname = new System.Windows.Forms.TextBox();
            this.devtype = new System.Windows.Forms.ComboBox();
            this.form3_confirm = new System.Windows.Forms.Button();
            this.form3_cancel = new System.Windows.Forms.Button();
            this.devid = new System.Windows.Forms.TextBox();
            this.label_devid = new System.Windows.Forms.Label();
            this.devtype_textBox = new System.Windows.Forms.TextBox();
            this.form3_delete = new System.Windows.Forms.Button();
            this.move_checkBox = new System.Windows.Forms.CheckBox();
            this.label_rack = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.rack_comboBox = new System.Windows.Forms.ComboBox();
            this.note = new System.Windows.Forms.TextBox();
            this.rack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // devmodel
            // 
            this.devmodel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.devmodel.Location = new System.Drawing.Point(213, 170);
            this.devmodel.MaxLength = 25;
            this.devmodel.Name = "devmodel";
            this.devmodel.Size = new System.Drawing.Size(195, 25);
            this.devmodel.TabIndex = 3;
            // 
            // devip
            // 
            this.devip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.devip.Location = new System.Drawing.Point(213, 207);
            this.devip.MaxLength = 31;
            this.devip.Name = "devip";
            this.devip.Size = new System.Drawing.Size(195, 25);
            this.devip.TabIndex = 4;
            // 
            // label_devmodel
            // 
            this.label_devmodel.AutoSize = true;
            this.label_devmodel.Location = new System.Drawing.Point(115, 170);
            this.label_devmodel.Name = "label_devmodel";
            this.label_devmodel.Size = new System.Drawing.Size(82, 15);
            this.label_devmodel.TabIndex = 8;
            this.label_devmodel.Text = "设备型号：";
            // 
            // label_devtype
            // 
            this.label_devtype.AutoSize = true;
            this.label_devtype.Location = new System.Drawing.Point(115, 129);
            this.label_devtype.Name = "label_devtype";
            this.label_devtype.Size = new System.Drawing.Size(82, 15);
            this.label_devtype.TabIndex = 7;
            this.label_devtype.Text = "设备类型：";
            // 
            // label_devip
            // 
            this.label_devip.AutoSize = true;
            this.label_devip.Location = new System.Drawing.Point(129, 207);
            this.label_devip.Name = "label_devip";
            this.label_devip.Size = new System.Drawing.Size(68, 15);
            this.label_devip.TabIndex = 9;
            this.label_devip.Text = "设备IP：";
            // 
            // label_clientname
            // 
            this.label_clientname.AutoSize = true;
            this.label_clientname.Location = new System.Drawing.Point(115, 89);
            this.label_clientname.Name = "label_clientname";
            this.label_clientname.Size = new System.Drawing.Size(82, 15);
            this.label_clientname.TabIndex = 0;
            this.label_clientname.Text = "客户名称：";
            // 
            // clientname
            // 
            this.clientname.BackColor = System.Drawing.SystemColors.Window;
            this.clientname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clientname.Location = new System.Drawing.Point(213, 89);
            this.clientname.MaxLength = 25;
            this.clientname.Name = "clientname";
            this.clientname.Size = new System.Drawing.Size(195, 25);
            this.clientname.TabIndex = 1;
            // 
            // devtype
            // 
            this.devtype.FormattingEnabled = true;
            this.devtype.Items.AddRange(new object[] {
            "服务器",
            "交换机",
            "防火墙",
            "其它"});
            this.devtype.Location = new System.Drawing.Point(213, 129);
            this.devtype.Name = "devtype";
            this.devtype.Size = new System.Drawing.Size(100, 23);
            this.devtype.TabIndex = 2;
            // 
            // form3_confirm
            // 
            this.form3_confirm.Location = new System.Drawing.Point(292, 382);
            this.form3_confirm.Name = "form3_confirm";
            this.form3_confirm.Size = new System.Drawing.Size(90, 34);
            this.form3_confirm.TabIndex = 6;
            this.form3_confirm.Text = "确认";
            this.form3_confirm.UseVisualStyleBackColor = true;
            this.form3_confirm.Click += new System.EventHandler(this.form3_confirm_Click);
            // 
            // form3_cancel
            // 
            this.form3_cancel.Location = new System.Drawing.Point(413, 382);
            this.form3_cancel.Name = "form3_cancel";
            this.form3_cancel.Size = new System.Drawing.Size(90, 34);
            this.form3_cancel.TabIndex = 0;
            this.form3_cancel.Text = "取消";
            this.form3_cancel.UseVisualStyleBackColor = true;
            this.form3_cancel.Click += new System.EventHandler(this.form3_cancel_Click);
            // 
            // devid
            // 
            this.devid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.devid.Location = new System.Drawing.Point(213, 246);
            this.devid.MaxLength = 7;
            this.devid.Name = "devid";
            this.devid.Size = new System.Drawing.Size(100, 25);
            this.devid.TabIndex = 5;
            // 
            // label_devid
            // 
            this.label_devid.AutoSize = true;
            this.label_devid.Location = new System.Drawing.Point(129, 246);
            this.label_devid.Name = "label_devid";
            this.label_devid.Size = new System.Drawing.Size(68, 15);
            this.label_devid.TabIndex = 11;
            this.label_devid.Text = "设备ID：";
            // 
            // devtype_textBox
            // 
            this.devtype_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.devtype_textBox.Location = new System.Drawing.Point(213, 129);
            this.devtype_textBox.Name = "devtype_textBox";
            this.devtype_textBox.ReadOnly = true;
            this.devtype_textBox.Size = new System.Drawing.Size(100, 25);
            this.devtype_textBox.TabIndex = 2;
            this.devtype_textBox.Visible = false;
            // 
            // form3_delete
            // 
            this.form3_delete.Location = new System.Drawing.Point(82, 382);
            this.form3_delete.Name = "form3_delete";
            this.form3_delete.Size = new System.Drawing.Size(115, 34);
            this.form3_delete.TabIndex = 12;
            this.form3_delete.Text = "删除设备";
            this.form3_delete.UseVisualStyleBackColor = true;
            this.form3_delete.Visible = false;
            this.form3_delete.Click += new System.EventHandler(this.form3_delete_Click);
            // 
            // move_checkBox
            // 
            this.move_checkBox.AutoSize = true;
            this.move_checkBox.Location = new System.Drawing.Point(304, 51);
            this.move_checkBox.Name = "move_checkBox";
            this.move_checkBox.Size = new System.Drawing.Size(104, 19);
            this.move_checkBox.TabIndex = 13;
            this.move_checkBox.Text = "移动设备至";
            this.move_checkBox.UseVisualStyleBackColor = true;
            this.move_checkBox.Visible = false;
            this.move_checkBox.CheckedChanged += new System.EventHandler(this.move_checkBox_CheckedChanged);
            // 
            // label_rack
            // 
            this.label_rack.AutoSize = true;
            this.label_rack.Location = new System.Drawing.Point(115, 54);
            this.label_rack.Name = "label_rack";
            this.label_rack.Size = new System.Drawing.Size(82, 15);
            this.label_rack.TabIndex = 14;
            this.label_rack.Text = "所属机架：";
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Location = new System.Drawing.Point(145, 286);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(52, 15);
            this.label_note.TabIndex = 15;
            this.label_note.Text = "备注：";
            // 
            // rack_comboBox
            // 
            this.rack_comboBox.Enabled = false;
            this.rack_comboBox.FormattingEnabled = true;
            this.rack_comboBox.Items.AddRange(new object[] {
            "1-1",
            "1-2",
            "1-3",
            "1-4",
            "1-5",
            "1-6",
            "1-7",
            "1-8",
            "1-9",
            "2-1",
            "2-2",
            "2-3",
            "2-4",
            "2-5",
            "2-6",
            "2-7",
            "2-8",
            "3-1",
            "3-2",
            "3-3",
            "3-4",
            "3-5",
            "3-6",
            "3-7",
            "3-8",
            "4-1",
            "4-2",
            "4-3",
            "4-4",
            "4-5",
            "4-6",
            "4-7",
            "4-8",
            "5-1",
            "5-2",
            "5-3",
            "5-4",
            "5-5",
            "5-6",
            "5-7",
            "5-8",
            "5-9",
            "6-1",
            "6-2",
            "6-3",
            "6-4",
            "6-5",
            "6-6",
            "6-7",
            "6-8",
            "7-1",
            "7-2",
            "7-3",
            "7-4",
            "7-5",
            "7-6",
            "8-1",
            "8-2",
            "8-3",
            "8-4",
            "8-5",
            "8-6",
            "8-7",
            "8-8",
            "8-9",
            "9-1",
            "9-2",
            "9-3",
            "9-4",
            "9-5",
            "9-6",
            "9-7",
            "9-8",
            "10-1",
            "10-2",
            "10-3",
            "10-4",
            "10-5",
            "10-6",
            "10-7",
            "10-8",
            "10-9",
            "11-1",
            "11-2",
            "11-3",
            "11-4",
            "11-5",
            "11-6",
            "11-7",
            "11-8",
            "11-9",
            "12-1",
            "12-2",
            "12-3",
            "12-4",
            "12-5",
            "12-6",
            "12-7",
            "12-8",
            "12-9",
            "12-10"});
            this.rack_comboBox.Location = new System.Drawing.Point(426, 49);
            this.rack_comboBox.Name = "rack_comboBox";
            this.rack_comboBox.Size = new System.Drawing.Size(69, 23);
            this.rack_comboBox.TabIndex = 16;
            this.rack_comboBox.Visible = false;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(213, 286);
            this.note.MaxLength = 100;
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(242, 76);
            this.note.TabIndex = 17;
            // 
            // rack
            // 
            this.rack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rack.Location = new System.Drawing.Point(213, 51);
            this.rack.Name = "rack";
            this.rack.ReadOnly = true;
            this.rack.Size = new System.Drawing.Size(69, 18);
            this.rack.TabIndex = 18;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 465);
            this.Controls.Add(this.rack);
            this.Controls.Add(this.note);
            this.Controls.Add(this.rack_comboBox);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.label_rack);
            this.Controls.Add(this.move_checkBox);
            this.Controls.Add(this.form3_delete);
            this.Controls.Add(this.devtype_textBox);
            this.Controls.Add(this.label_devid);
            this.Controls.Add(this.devid);
            this.Controls.Add(this.form3_cancel);
            this.Controls.Add(this.form3_confirm);
            this.Controls.Add(this.devtype);
            this.Controls.Add(this.label_clientname);
            this.Controls.Add(this.clientname);
            this.Controls.Add(this.label_devip);
            this.Controls.Add(this.label_devtype);
            this.Controls.Add(this.label_devmodel);
            this.Controls.Add(this.devip);
            this.Controls.Add(this.devmodel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增设备";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox devmodel;
        private System.Windows.Forms.TextBox devip;
        private System.Windows.Forms.Label label_devmodel;
        private System.Windows.Forms.Label label_devtype;
        private System.Windows.Forms.Label label_devip;
        private System.Windows.Forms.Label label_clientname;
        private System.Windows.Forms.TextBox clientname;
        private System.Windows.Forms.ComboBox devtype;
        private System.Windows.Forms.Button form3_confirm;
        private System.Windows.Forms.Button form3_cancel;
        private System.Windows.Forms.TextBox devid;
        private System.Windows.Forms.Label label_devid;
        private System.Windows.Forms.TextBox devtype_textBox;
        public System.Windows.Forms.Button form3_delete;
        private System.Windows.Forms.CheckBox move_checkBox;
        private System.Windows.Forms.Label label_rack;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.ComboBox rack_comboBox;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.TextBox rack;
    }
}