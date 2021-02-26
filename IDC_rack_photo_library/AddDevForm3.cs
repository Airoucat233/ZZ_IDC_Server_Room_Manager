using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IDC_rack_photo_library
{
    public partial class AddDevForm3 : Form
    {
        public delegate void Form2Handle();
        public static event Form2Handle Fresh_dev;
        public AddDevForm3(string row_col)
        {
            InitializeComponent();
            this.rack.Text = row_col;
            devid.Text = MainForm1.Mysql.GetNewID().ToString("0000000");
        }
        public AddDevForm3(int _devid)   //修改
        {
            InitializeComponent();
            List<object> clicked_dev = MainForm1.Mysql.Mysql_Search(_devid);
            //MessageBox.Show(devid.ToString("0000000"));
            this.Text = clicked_dev[1].ToString() + '@' + clicked_dev[3].ToString() + ' ' + ((Convert.ToInt32(clicked_dev[2])).ToString("0000000"));
            this.rack.Text = clicked_dev[0].ToString();
            this.move_checkBox.Visible = true;
            this.rack_comboBox.Visible = true;

            this.clientname.Text = clicked_dev[1].ToString();
            this.devid.Text = _devid.ToString("0000000");
            this.devtype.Text = clicked_dev[3].ToString();
            this.devtype.DropDownStyle = ComboBoxStyle.DropDownList;
            this.devtype.SelectedIndex = 0;
            this.devmodel.Text = clicked_dev[4].ToString();
            this.devip.Text = clicked_dev[5].ToString();
            this.note.Text = clicked_dev[6].ToString();
            this.form3_delete.Visible = true;
            this.form3_confirm.Click -= new System.EventHandler(this.form3_confirm_Click);
            this.form3_confirm.Click += new System.EventHandler(this.form3_confirm1_Click);
        }
        public AddDevForm3(int devid,bool ViewOnly)   //查看
        {
            InitializeComponent();
            List<object> clicked_dev = MainForm1.Mysql.Mysql_Search(devid);
            this.Text = clicked_dev[1].ToString() + '@' + clicked_dev[3].ToString() + ' ' + ((Convert.ToInt32(clicked_dev[2])).ToString("0000000"));

            this.rack.Text = clicked_dev[0].ToString();

            this.clientname.Text = clicked_dev[1].ToString();
            this.clientname.ReadOnly = true;
            this.clientname.BorderStyle = BorderStyle.None;
            this.clientname.BackColor = SystemColors.Control;
            this.clientname.Cursor = System.Windows.Forms.Cursors.Arrow;

            this.devid.Text = devid.ToString("0000000");
            this.devid.BorderStyle = BorderStyle.None;
            this.devid.BackColor = SystemColors.Control;
            this.devid.Cursor = System.Windows.Forms.Cursors.Arrow;

            this.devtype.Visible = false;
            this.devtype_textBox.Visible = true;
            this.devtype_textBox.Text = clicked_dev[3].ToString();
            this.devtype_textBox.ReadOnly = true;
            this.devtype_textBox.BorderStyle = BorderStyle.None;
            this.devtype_textBox.BackColor = SystemColors.Control;
            this.devtype_textBox.Cursor = System.Windows.Forms.Cursors.Arrow;

            this.devmodel.Text = clicked_dev[4].ToString();
            this.devmodel.ReadOnly = true;
            this.devmodel.BorderStyle = BorderStyle.None;
            this.devmodel.BackColor = SystemColors.Control;
            this.devmodel.Cursor = System.Windows.Forms.Cursors.Arrow;

            this.devip.Text = clicked_dev[5].ToString();
            this.devip.ReadOnly = true;
            this.devip.BorderStyle = BorderStyle.None;
            this.devip.BackColor = SystemColors.Control;
            this.devip.Cursor = System.Windows.Forms.Cursors.Arrow;

            this.note.Text = clicked_dev[6].ToString();
            this.note.ReadOnly = true;
            this.note.BorderStyle = BorderStyle.None;
            this.note.BackColor = SystemColors.Control;
            this.note.Cursor = System.Windows.Forms.Cursors.Arrow;

            this.form3_confirm.Click -= new System.EventHandler(this.form3_confirm_Click);
            this.form3_confirm.Click += new System.EventHandler(this.form3_cancel_Click);
            
            this.form3_confirm.Visible = false;
            this.form3_cancel.Text = "确认";
        }
        private void form3_cancel_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void form3_confirm_Click(object sender, EventArgs e)
        {
            MainForm1.Mysql.Mysql_Add(this.rack.Text, this.clientname.Text,MainForm1.Mysql.GetNewID(),this.devtype.Text, this.devmodel.Text, this.devip.Text);
            Fresh_dev();
            this.Close();
        }
        private void form3_confirm1_Click(object sender, EventArgs e)
        {
            if (move_checkBox.Checked)
            {
                MainForm1.Mysql.Mysql_Update(this.rack_comboBox.Text,this.clientname.Text, Convert.ToInt32(this.devid.Text), this.devtype.Text, this.devmodel.Text, this.devip.Text);
            }
            else 
            {
                MainForm1.Mysql.Mysql_Update(this.rack.Text, this.clientname.Text, Convert.ToInt32(this.devid.Text), this.devtype.Text, this.devmodel.Text, this.devip.Text);
            }
            Fresh_dev();
            this.Close();
        }

        private void form3_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除该设备？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                MainForm1.Mysql.Mysql_Delete(Convert.ToInt32(this.devid.Text));
            }
            Fresh_dev();
        }

        private void move_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(move_checkBox.Checked)
                this.rack_comboBox.Enabled = true;
            else
                this.rack_comboBox.Enabled = false;
        }
    }
}
