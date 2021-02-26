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
    public partial class TestForm4 : Form
    {
        public TestForm4()
        {
            InitializeComponent();
            MysqlConn();
        }
        private void MysqlConn()
        {
            
            MySqlConnection conntoDB = new MySqlConnection("server=localhost;user id=root;password=529401274;database=winform");
            
            try
            {
                conntoDB.Open();
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK);     //显示错误信息
            }
        }
    }
}
