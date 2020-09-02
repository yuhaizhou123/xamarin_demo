using System;
using System.IO;
using Xamarin.Forms;
using xamarin;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();

            if (File.Exists(_fileName))
            {
                //editor.Text = File.ReadAllText(_fileName);
            }
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
          //  File.WriteAllText(_fileName, editor.Text);
        }
        
        async void Login_do(object sender, EventArgs e)
        {
            
            //接值
            string username = editor.Text;
             string pwd = password.Text;
            if(username == "user" && pwd == "111")
            {
                // await DisplayAlert("温馨提示", "登录成功但是我们还没有下一页...", "OK");
                await Navigation.PushAsync(new ListPage());
            }
            else
            {
                await DisplayAlert("温馨提示", "账号或密码错误", "OK");
            }
        }
        async void Gengduo_do(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("选项", null, "取消" , "忘记密码？", "我要反馈");
            Console.WriteLine("我选择的是：" + action);
        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
          //  editor.Text = string.Empty;
        }
    }
}