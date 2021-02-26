using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDC_rack_photo_library
{
    public partial class RackForm2 : Form
    {
        private DataTable list_dev;
        private Button[] btnarray;
        private string rackimagePath;
        private class devButton : Button
        {
            public devButton(int id)
            {
                devid = id;
            }
            public int devid { get; set; }
        }
        public RackForm2(string row_col, string imagepath)
        {
            InitializeComponent();
            row_col_label.Text = GetRowcol(row_col);
            GetRacksDev();
            AddDevForm3.Fresh_dev += new AddDevForm3.Form2Handle(this.GetRacksDev);
            int row = Convert.ToInt32(row_col_label.Text.Split('-')[0]);
            int col = Convert.ToInt32(row_col_label.Text.Split('-')[1]);
            rackimagePath = imagepath + "\\4楼IDC机房\\" + row_col.Substring(0, row_col.IndexOf('-')) + @"行\" + row.ToString("00") + '-' + col.ToString("00") + '-';
            ShowRackImage(rackimagePath);
            
        }
        private string GetRowcol(string original_row_col)
        {
            string[] lines = original_row_col.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            return lines[0];
            //List<char> a = new List<char>();
            //int i = 0;
            //while(original_row_col[i]!='\r'&&i<original_row_col.Length)
            //{
            //    a[i] = original_row_col[i];
            //    i++;
            //}
            //return a.ToString();
        }
        private void GetRacksDev()
        {
            devPanel.Controls.Clear();
            list_dev = MainForm1.Mysql.Mysql_Search(row_col_label.Text);
            if (list_dev.Rows.Count != 0)
            {
                btnarray = new Button[list_dev.Rows.Count];
                for (int i = 0; i < btnarray.Length; i++)
                {
                    devButton btn = new devButton(Convert.ToInt32(list_dev.Rows[i][2]));
                    btn.Size = new Size(75, 23);
                    btn.Tag = list_dev.Rows[i][6];
                    btn.Text = list_dev.Rows[i][1].ToString() + "\r\n" + list_dev.Rows[i][3].ToString();
                    btn.Click += Btn_Click;
                    btn.MouseHover += devBtn_MouseHover;
                    btn.ContextMenuStrip = dev_contextMenuStrip;
                    //devPanel.RowCount++;
                    this.devPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    this.devPanel.Controls.Add(btn, 0, i);
                    btn.Dock = DockStyle.Fill;
                    btnarray[i] = btn;
                }
            }
        }
        private void ShowRackImage(string rackimagePath)
        {
            //Image img = Image.FromFile(rackimagePath + "1.JPG");
            //Image bmp = new Bitmap(img);
            //img.Dispose();
            try
            {
                //this.rackpicture_up.Image = bmp;
                this.rackpicture_up.Load(rackimagePath + "1.JPG");
                this.rackpicture_down.Load(rackimagePath + "2.JPG");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //点击设备按钮
        private void Btn_Click(object sender, EventArgs e)
        {
            //int devid = Convert.ToInt32((list_dev.Rows[Convert.ToInt32((((Button)sender).Tag))][2]));
            int devid = ((devButton)sender).devid;
            AddDevForm3 form_viewdetails = new AddDevForm3(devid, true);
            //form_viewdetails.Fresh_dev += new Form3.Form2Handle(this.GetRacksDev);
            //MessageBox.Show(sender.ToString());
            form_viewdetails.ShowDialog();
            form_viewdetails.Dispose();
        }

        //增加设备按钮事件
        private void adddev_button_Click(object sender, EventArgs e)
        {
            AddDevForm3 form_keydata = new AddDevForm3(this.row_col_label.Text);
            form_keydata.ShowDialog();
            form_keydata.Dispose();
        }


        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Button)dev_contextMenuStrip.SourceControl).PerformClick();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button right_click_dev = (Button)dev_contextMenuStrip.SourceControl;
            AddDevForm3 form_alterdetails = new AddDevForm3(Convert.ToInt32((right_click_dev as devButton).devid));
            form_alterdetails.ShowDialog();
            form_alterdetails.Dispose();
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button right_click_dev = (Button)dev_contextMenuStrip.SourceControl; ;
            if (MessageBox.Show("确认删除该设备？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                MainForm1.Mysql.Mysql_Delete(Convert.ToInt32((list_dev.Rows[Convert.ToInt32((right_click_dev.Tag))][2])));
                GetRacksDev();
            }

        }

        //悬停在设备按钮
        private void devBtn_MouseHover(object sender, EventArgs e)
        {
            form2_toolTip.SetToolTip(sender as Button, (sender as Button).Tag.ToString());
        }

        //悬停在机架图片
        private void rackpicture_MouseHover(object sender, EventArgs e)
        {
            form2_toolTip.SetToolTip(sender as PictureBox, "双击图片查看大图");
        }

        //双击图片打开图片浏览器
        private void rackpicture_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(((PictureBox)sender).ImageLocation);
            System.Diagnostics.Process.Start("explorer.exe", ((PictureBox)sender).ImageLocation);
        }

        //机架图片更新
        private void changeImage_Click(object sender,EventArgs e)
        {
            string ImagePath;
            string newImagePath;
            string defaultImage = @"C:\Users\ASINGLE\Desktop\WinForms学习\ZZ_IDC_Server_Room_Manager\机房机架设备台账照片\default.png";
            //选择文件
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择新的机架图";
            dialog.Filter = "图片文件(*.jpg,*.jpeg)|*.jpg;*.jpeg|图片文件(*.png)|*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("确认替换图片？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            newImagePath = dialog.FileName;
                            if (((Button)sender).Tag.ToString() == rackpicture_up.Name)
                            {
                                ImagePath = rackpicture_up.ImageLocation;
                                rackpicture_up.Load(defaultImage);
                                File.Copy(newImagePath, ImagePath, true);
                                rackpicture_up.Load(ImagePath);
                            }
                            else if(((Button)sender).Tag.ToString() == rackpicture_down.Name)
                            {
                                ImagePath = rackpicture_down.ImageLocation;
                                rackpicture_down.Load(defaultImage);
                                File.Copy(newImagePath, ImagePath, true);
                                rackpicture_down.Load(ImagePath);
                            }
                            break;
                        }
                    case DialogResult.No:
                        {
                            ((Button)sender).PerformClick();
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                }
                
            }


        }
    }
}
