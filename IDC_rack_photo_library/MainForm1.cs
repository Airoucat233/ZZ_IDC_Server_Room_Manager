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
    public partial class MainForm1 : Form
    {
        private static readonly string connstr = "server=localhost;user id=root;password=529401274;database=winform";
        public static Mysql_CURD Mysql;
        private TableLayoutControlCollection controls;
        private List<MyJsonData> Buttonslist = Json_RW.ReadRackDescJson();
        public string UserimagePath ="";
        public MainForm1()
        {
            InitializeComponent();
            Mysql = new Mysql_CURD(connstr);
            Mysql_conn_status.Text = "连接数据库成功";
            this.FormClosing += Form1_FormClosing;
            this.controls = RoomPlan.Controls;
            InitButtonClickEvent();
            //this.Buttonslist = GetButtonList();
            InitButtonText();     //从文件初始化机架描述
            //FirstGenerateConfig();//首次生成json文件(初始化json)

        }
        //private void BulkEdit(TableLayoutControlCollection controls)
        //{
        //    for (int i = 0; i < controls.Count; i++)
        //    {
        //        if (controls[i] is Button)
        //        {
        //            controls[i].Name = controls[i].Text.Replace('-','_');
        //        }
        //    }

        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("loaded");
            this.UserimagePath = Json_RW.ReadConfigJson().UserimagePath;
            //Json_RW.TestJson();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigData savejson = new ConfigData();
            savejson.UserimagePath = this.UserimagePath;
            Json_RW.UpdateJson(savejson);
            Mysql.conntoDB.Close();
        }


        //protected override void OnLayout(LayoutEventArgs levent)
        //{
        //    base.OnLayout(levent);
        //    int w = this.ClientSize.Width;
        //    int h = this.ClientSize.Height;

        //    showtimebutton.Location = new Point(800 + w - 965, showtimebutton.Location.Y);
        //    TimeBox.Size = new Size(w - (965 - 721), TimeBox.Height);
        //    pictureBox1.Size = new Size(pictureBox1.Width, h - (711 - 576));
        //}

        
        private void FirstGenerateConfig()
        {
            //ButtonList Buttonlist = new ButtonList(controls);
            //List<MyJsonData> firstdatas = new List<MyJsonData>(Buttonlist.num);
            //for(int i=0;i<Buttonlist.num; i++)
            //{
            //    firstdatas.Add(new MyJsonData());
            //    firstdatas[i] = Buttonlist.Buttons[i];
            //}
            //Json_RW.FirstWriteJson(firstdatas);
            
            List<MyJsonData> firstdatas = new List<MyJsonData>();
            for (int i = 0, j = 0; i < controls.Count; i++)
            {
                if (controls[i] is Button)
                {
                    firstdatas.Add(new MyJsonData());
                    firstdatas[j].rack = controls[i].Name;
                    firstdatas[j].description = "nihao";//可用其他方式初始化
                    j++;
                }
            }
            Json_RW.FirstWriteJson(firstdatas);
        }
        private void InitButtonClickEvent()
        {
            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i] is Button)
                {
                    ((Button)controls[i]).Click += new System.EventHandler(this.RackButton_Click);
                    ((Button)controls[i]).MouseHover += new System.EventHandler(this.RackButton_MouseHover);

                }
            }
        }
        private void InitButtonText() 
        {
            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i] is Button)
                {
                    foreach(MyJsonData d in Buttonslist)
                    {
                        if (d.rack == controls[i].Name)
                        { controls[i].Text 
                                = controls[i].Name.Remove(0, 6).Replace('_', '-') + "\r\n" + d.description; }
                    }
                }
            }
        }
        //private void AlterButtonText(Button UpdateingButton)
        //{
        //    int i = 0;
        //    for (;i<Buttons.Count;i++)
        //    {
        //        if (UpdateingButton.Name == Buttons[i].rack)
        //            break;
        //    }
        //    Json_RW.UpdateJson(Buttons, i);
        //}
        //private List<MyJsonData> GetButtonList()
        //{
        //    List<MyJsonData> Buttons = new List<MyJsonData>();
        //    for (int i = 0, j = 0; i < controls.Count; i++)
        //    {
        //        if (controls[i] is Button)
        //        {
        //            Buttons.Add(new MyJsonData());
        //            Buttons[j].rack = controls[i].Name;
        //            Buttons[j].description = "haha";
        //            j++;
        //        }
        //    }
        //    return Buttons;
        // }

        //public class ButtonList
        //{
        //    public List<MyJsonData> Buttons;

        //    public int num = 0;
        //    public ButtonList(TableLayoutControlCollection controls)
        //    {
        //        Buttons = new List<MyJsonData>();
        //        GetButtonList(controls);
        //    }


        //}
        private void onTest(object sender, EventArgs e)
        {
            MessageBox.Show("你好呀");
            
        }
        
        //悬停在机架按钮
        private void RackButton_MouseHover(object sender, EventArgs e)
        {
            form1_toolTip.SetToolTip(sender as Button, (sender as Button).Text.Remove(0, (sender as Button).Text.IndexOf("\r\n")));
        }

        private void RackButton_Click(object sender, EventArgs e)
        {
            RackForm2 form_rack = new RackForm2(((Button)sender).Text,this.UserimagePath);
            form_rack.Show();
        }
        //private void button128_Click(object sender, EventArgs e)
        //{
        //    Form2 form_rack = new Form2(((Button)sender).Text);
        //    form_rack.Show();
        //}

        //private void button139_Click(object sender, EventArgs e)
        //{
        //    Form2 form_rack = new Form2(((Button)sender).Text);
        //    form_rack.Show();

        //}

        //private void button119_Click(object sender, EventArgs e)
        //{
        //    Form4 form_mysql = new Form4();
        //    form_mysql.Show();
        //}

    private void testbutton_Click(object sender, EventArgs e)
        {
            Json_RW jsontest = new Json_RW();
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Button)rack_contextMenuStrip.SourceControl).PerformClick();
        }

        private void 修改描述ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button right_click_rack = (Button)rack_contextMenuStrip.SourceControl;
            DescForm5 form_UpdateDescription = new DescForm5(right_click_rack.Text.Substring(right_click_rack.Text.IndexOf("\r\n")+1));
            form_UpdateDescription.ShowDialog();
            if (form_UpdateDescription.isChange)
            {
                string s = form_UpdateDescription.Tag.ToString();
                int i = 0;
                for (; i < Buttonslist.Count; i++)
                {
                    if (right_click_rack.Name == Buttonslist[i].rack)
                    {
                        Buttonslist[i].description = s;
                        break;
                    }
                        
                }
                Json_RW.UpdateJson(Buttonslist, i);
            }
            form_UpdateDescription.Dispose();//释放资源，调用ShowDialog后方法关闭不会自动释放资源，Show会释放
            InitButtonText();//可重载具体某一个机架
        }

        private void 添加设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button right_click_rack = (Button)rack_contextMenuStrip.SourceControl;
            AddDevForm3 form_Add_dev = new AddDevForm3(right_click_rack.Text.Substring(0, right_click_rack.Text.IndexOf("\r\n")));
            form_Add_dev.ShowDialog();
            form_Add_dev.Dispose();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) //菜单-选择文件路径
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.UserimagePath = dialog.SelectedPath;
                MessageBox.Show("已选择文件夹:" + UserimagePath, "设置图片路径成功", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)//重置图片路径
        {
            UserimagePath = Properties.Settings.Default.imagePath;
            MessageBox.Show("图片路径已恢复默认！", "重置图片路径", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //ContextMenuStrip rack_rightclickmenu = new ContextMenuStrip();
        //private void button6_1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if(e.Button == MouseButtons.Right)
        //    {
        //        rack_rightclickmenu.Items.Clear();
        //        rack_rightclickmenu.ItemClicked += new ToolStripItemClickedEventHandler(rack_rightclickmenu_ItemClicked);
        //        rack_rightclickmenu.Items.Add("chakan");
        //        rack_rightclickmenu.Items.Add("剪切");
        //        rack_rightclickmenu.Items.Add("删除");
        //        rack_rightclickmenu.Items.Add("粘贴");
        //        rack_rightclickmenu.Show(MousePosition);
        //    }
        //}
        //void rack_rightclickmenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //    rack_rightclickmenu.ItemClicked -= new ToolStripItemClickedEventHandler(rack_rightclickmenu_ItemClicked);

        //    switch (e.ClickedItem.Text)
        //    {
        //        case "chakan":
        //            MessageBox.Show(sender.ToString());
        //            break;
        //        case "剪切":
        //            MessageBox.Show(e.ClickedItem.Text);
        //            break;
        //        case "删除":
        //            MessageBox.Show(e.ClickedItem.Text);
        //            break;
        //        case "粘贴":
        //            MessageBox.Show(e.ClickedItem.Text);
        //            break;

        //        default:
        //            break;
        //    }
        //}
    }
}