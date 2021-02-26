using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using IDC_rack_photo_library;

namespace IDC_Manager_Login
{
    public class ViewModel : ViewModelBase
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        public ViewModel()
        {
            //loginCommand = new RelayCommand(LoginButton_click);
        }
        private string username;
        //public RelayCommand loginCommand { get; private set; }
        public string UserName
        {
            get { return username; }
            set
            { username = value;
                RaisePropertyChanged();
                //OnPropertyChanged("UserName");
            }
        }
        private string password;
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
        private string accountmatchedresult;
        public string accountMatchedResult
        {
            get { return accountmatchedresult; }
            set { accountmatchedresult = value;
                RaisePropertyChanged();
            }
        }
        private string passwordmatchedresult;
        public string passwordMatchedResult
        {
            get { return passwordmatchedresult; }
            set
            {
                passwordmatchedresult = value;
                RaisePropertyChanged();
            }
        }
        //protected void OnPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //}
        private static class MatchText
        {
            public const string accountPattern = @"^[A-Za-z][A-Za-z0-9]{6,15}$";
            public const string passwordPattern = @"^[A-Za-z][A-Za-z0-9_.]{8,15}$";
        }
        public void LoginButton_click(PasswordBox password)
        {
            //UserName = "no"; 
            this.accountMatchedResult = string.Empty;
            this.passwordMatchedResult = string.Empty;
            if (UserName == null)
            { accountMatchedResult = "账号不能为空！"; }
            else if (Regex.IsMatch(UserName, MatchText.accountPattern))
            {
                if (PassWord == null)
                { accountMatchedResult = "密码不能为空！"; }
                else if (Regex.IsMatch(PassWord, MatchText.passwordPattern))
                {
                    Console.WriteLine($"{UserName},{PassWord}");
                    string connstr = "server=localhost;user id=root;password=529401274;database=winform";
                    Mysql_CURD Mysql = new Mysql_CURD(connstr);
                    List<string> userinfor = Mysql.Mysql_userSearch(UserName);
                    if (userinfor[1] == PassWord)
                    {
                        System.Windows.Forms.Application.Run(new MainForm1());
                    }
                    else
                    {
                        Console.WriteLine("密码错误！");
                        passwordMatchedResult = "密码错误！";
                    }
                }
                else
                {
                    passwordMatchedResult = "密码以字母开头，由字母、数字组成，8-15位";
                }
            }
            else
            {
                accountMatchedResult = "账号以字母开头，由字母、数字组成，6-15位";
            }

            //MessageBox.Show(LoginInfor.UserName);
            //System.Windows.Forms.Application.Run(new Form1());
        }
        private void RegisterButton_click()
        {
            Console.WriteLine(UserName);
            this.UserName = "2333333";
            //this.LoginInfor.PassWord = "333";
            //MessageBox.Show(LoginInfor.PassWord);
        }

        private RelayCommand<PasswordBox> logincommand;
        public RelayCommand<PasswordBox> LoginCommand
        {
            get
            {
                return logincommand
                ?? (logincommand = new RelayCommand<PasswordBox>(LoginButton_click));
                //(s) =>
                //{
                //    return (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(s.Password));
                //})
            }
        }
        private RelayCommand registerCommand;

        public RelayCommand RegisterCommand
        {
            get
            {
                return registerCommand
                ?? (registerCommand = new RelayCommand(RegisterButton_click));
                //(s) =>
                //{
                //    return (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(s.Password));
                //})
            }
        }


    }
}
