using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using IDC_rack_photo_library;
using System.ComponentModel;
using Binding = System.Windows.Data.Binding;
using MessageBox = System.Windows.Forms.MessageBox;

namespace IDC_Manager_Login
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        //MyTextshow LoginInfor = new MyTextshow();
        ViewModel vm =  new ViewModel();
        public LoginWindow()
        {
            InitializeComponent();
            System.Windows.Forms.Application.EnableVisualStyles();
            this.DataContext = vm; 
            //Binding bindingUser = new Binding();
            //bindingUser.Source = LoginInfor;
            //bindingUser.Path = new PropertyPath("UserName");
            //BindingOperations.SetBinding(this.Username, System.Windows.Controls.TextBox.TextProperty, bindingUser);

            //Binding bindingPass = new Binding();
            //bindingPass.Source = LoginInfor;
            //bindingPass.Path = new PropertyPath("PassWord");
            //BindingOperations.SetBinding(this.Password, System.Windows.Controls.TextBox.TextProperty, bindingPass);
        }

        //class MyTextshow : INotifyPropertyChanged //绑定对象  
        //{
        //    private string username;
        //    private string password;
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    public string UserName
        //    {
        //        get { return username; }
        //        set
        //        {
        //            username = value;
        //            PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
        //        }
        //    }
        //    public string PassWord
        //    {
        //        get { return password; }
        //        set
        //        {
        //            password = value;
        //            PropertyChanged(this, new PropertyChangedEventArgs("PassWord"));
        //        }
        //    }
        //}
            
        
        
        
        //获取密码
        //public RelayCommand<PasswordBox> LoginCommand
        //{
        //    get
        //    {
        //        return _loginCommand
        //                ?? (_loginCommand = new RelayCommand<PasswordBox>(ExecuteLoginCommand, (s) =>
        //                {
        //                    return (!string.IsNullOrEmpty(Account) && !string.IsNullOrEmpty(s.Password));
        //                }));
        //    }
        //}



        //private void ExecuteLoginCommand(PasswordBox box)
        //{
        //    Debug.WriteLine(box.Password);
        //    LoginAction();
        //}

        private void LoginButton_click222(object sender, RoutedEventArgs e)
        {
            this.vm.UserName= "222";
            //MessageBox.Show(LoginInfor.UserName);
            //System.Windows.Forms.Application.Run(new Form1());
        }
        private void RegisterButton_click(object sender, RoutedEventArgs e)
        {
            //this.LoginInfor.PassWord = "333";
            //MessageBox.Show(LoginInfor.PassWord);
        }
        private void Close_Click(object sender, RoutedEventArgs e)
            {
                this.Close();
            }

        private void Min_Click(object sender, RoutedEventArgs e)
            {
                WindowState = WindowState.Minimized;
            }

            private void DragMoveWindow(object sender, System.Windows.Input.MouseEventArgs e)
            {

                this.DragMove();
            }

            private void QQ_Click(object sender, RoutedEventArgs e)
            {

            }

            private void Wechat_Click(object sender, RoutedEventArgs e)
            {

            }

            private void SinaWeibo_Click(object sender, RoutedEventArgs e)
            {

            }

    }
    }
