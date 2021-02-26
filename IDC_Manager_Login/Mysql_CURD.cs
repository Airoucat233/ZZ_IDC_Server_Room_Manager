using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace IDC_Manager_Login
{
    public class Mysql_CURD
    {
        public MySqlConnection conntoDB;
        private MySqlCommand MysqlAddCmd;
        private MySqlCommand MysqlDeleteCmd;
        private MySqlCommand MysqlSearchCmd;
        private MySqlCommand MysqlUpdateCmd;
        
        public Mysql_CURD(string connstr)
        {
            conntoDB = new MySqlConnection(connstr);
            try
            {
                conntoDB.Open();   
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK);     //显示错误信息
            }
            
        }
        public int GetNewID()
        {
            int newid = 0;
            string s = "select devid from dev_information where devid>885 order by devid;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(s, conntoDB);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.Dispose();
            if (dt.Rows.Count == 0)
            { newid = 886; }
            else
            {
                for (int i = 886; i <886 + dt.Rows.Count; i++)
                {
                    if (i < Convert.ToInt32(dt.Rows[i - 886][0]))
                    {newid = i;break;}
                    else
                    { newid = i + 1; }
                }
            }
            return newid;
        }
        public void Mysql_Add(string rack,string clientname,int devid,string devtype,string devmodel,string devip)
        {
            string addstr = "insert into dev_information (`rack`, `clientname`, `devid`,`devtype`,`devmodel`,`devip`) values ('" + rack+"','"+ clientname + "',"+devid+",'"+devtype+"','"+ devmodel + "','"+devip+"');";
            MysqlDeleteCmd = new MySqlCommand(addstr, conntoDB);
            MysqlDeleteCmd.ExecuteNonQuery();

        }
        public void Mysql_Delete(int devid)
        {
            string deletestr = "delete from dev_information where devid = "+devid+";";
            MysqlAddCmd = new MySqlCommand(deletestr, conntoDB);
            MysqlAddCmd.ExecuteNonQuery();
        }
        public DataTable Mysql_Search(string rack_num)
        {
            string searchstr = "select * from dev_information where rack like '" + rack_num + "';";
            //MysqlSearchCmd = new MySqlCommand(searchstr, conntoDB);
            //List<object> list = new List<object>();
            //MySqlDataReader reader = MysqlSearchCmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    list.Add(reader[0]);
            //}
            //reader.Close();
            //return list;

            MySqlDataAdapter adapter = new MySqlDataAdapter(searchstr, conntoDB);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.Dispose();
            return dt;
        }
        public List<object> Mysql_Search(int devid)
        {
            List<object> matched_dev = new List<object>();
            string searchstr = "select * from dev_information where devid = " + devid + ";";
            MysqlSearchCmd = new MySqlCommand(searchstr, conntoDB);
            MySqlDataReader read_a_dev = MysqlSearchCmd.ExecuteReader();
            while (read_a_dev.Read())
            {
                for (int i = 0; i < read_a_dev.FieldCount; i++)
                {
                    matched_dev.Add(new object());
                    matched_dev[i] = read_a_dev[i]; 
                } 
            }
            read_a_dev.Close();
            return matched_dev;
        }
        public List<string> Mysql_userSearch(string account)
        {
            List<string> user = new List<string>();
            string searchstr = "select * from user_information where UserName = '" +account+"';";
            MysqlSearchCmd = new MySqlCommand(searchstr, conntoDB);
            MySqlDataReader read_a_account = MysqlSearchCmd.ExecuteReader();
            if (read_a_account != null)
            {
                while (read_a_account.Read())
                {
                    for (int i = 0; i < 3; i++)
                    {
                        user.Add(read_a_account[i].ToString());
                    }
                }
                read_a_account.Close();
            }
                return user;
        }
        public void Mysql_Update(string rack, string clientname, int devid, string devtype, string devmodel, string devip)
        {
            string updatestr = "update dev_information set rack = '"+ rack + "', clientname = '"+ clientname + "', " +
                "devtype = '"+ devtype + "', devmodel = '"+ devmodel + "', devip = '"+ devip + "' WHERE devid = "+ devid + ";";
            MysqlUpdateCmd = new MySqlCommand(updatestr, conntoDB);
            MysqlUpdateCmd.ExecuteNonQuery();
        }
    }
}
