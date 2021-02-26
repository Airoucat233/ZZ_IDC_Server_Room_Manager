using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace IDC_rack_photo_library
{
    public class Json_RW
    {

        public Json_RW()
        {
            
        }
        public static List<MyJsonData> ReadRackDescJson()
        {
            {
                string json;
                // 创建一个 StreamReader 的实例来读取文件 ,using 语句也能关闭 StreamReader
                using (StreamReader r = new StreamReader(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "rack_dev.json"))
                {
                    json = r.ReadToEnd();
                }
                List<MyJsonData> jsonData = JsonConvert.DeserializeObject<List<MyJsonData>>(json);
                return jsonData;

            }
        }
        public static void TestJson()
        {
            List<ConfigData> savejson = new List<ConfigData>();
            ConfigData savedata = new ConfigData();
            savejson.Add(savedata);
            savedata.UserimagePath = "C:\\Users\\ASINGLE\\Desktop\\WinForms学习\\ZZ_IDC_Server_Room_Manager\\机房机架设备台账照片\\";
            using (StreamWriter w = new StreamWriter(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "config.json"))
            {
                w.Write(JsonConvert.SerializeObject(savejson, Formatting.Indented));
            }
        }
        public static ConfigData ReadConfigJson()
        {
            {
                string json;
                // 创建一个 StreamReader 的实例来读取文件 ,using 语句也能关闭 StreamReader
                using (StreamReader r = new StreamReader(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "config.json"))
                {
                    json = r.ReadToEnd();
                }
                ConfigData configdata = JsonConvert.DeserializeObject<ConfigData>(json);
                return configdata;

            }
        }
        public static void UpdateJson(List<MyJsonData> Buttons,int i)
        {
            List<MyJsonData> jsonData = ReadRackDescJson();
            jsonData[i] = Buttons[i];
            using (StreamWriter w = new StreamWriter(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "rack_dev.json"))
            {
                w.Write(JsonConvert.SerializeObject(jsonData, Formatting.Indented));
            }
        }
        public static void UpdateJson(ConfigData configs)
        {
            ConfigData jsonData = ReadConfigJson();
            jsonData = configs;
            using (StreamWriter w = new StreamWriter(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "config.json"))
            {
                w.Write(JsonConvert.SerializeObject(jsonData, Formatting.Indented));
            }
        }

        public static void FirstWriteJson(List<MyJsonData> firstdatas)
        {
            using (StreamWriter w = new StreamWriter(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "rack_dev.json"))
            {
                w.Write(JsonConvert.SerializeObject(firstdatas,Formatting.Indented));
            }
        }
        //public static void WriteJson(string rack,string description)
        //{
            
        //    MyJsonData jsonData = JsonConvert.SerializeObject(json);
        //}
    }
        //private static string strjson = @"{
        //                    'description': '这是第一个描述' 
        //                  }
        //                    {
        //                    'description': '这是第二个描述' 
        //                  }";
        //MyJsonData jsonData = JsonConvert.DeserializeObject<MyJsonData>(strjson);
        public class MyJsonData
        {
            public string rack { get; set; }
            public string description { get; set; }
        }

    public class ConfigData
    {
        public string UserimagePath { get; set; }
    }



}
