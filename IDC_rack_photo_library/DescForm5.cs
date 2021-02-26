using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDC_rack_photo_library
{
    public partial class DescForm5 : Form
    {
        public bool isChange;
        public DescForm5(string pres)
        {
            InitializeComponent();
            textBox1.Text = pres;
            isChange = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isChange = true;
            this.Tag = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isChange = false;
            this.Close();
        }
    }
}
