using Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin
{
    public partial class ListPage : ContentPage
    {
        public IList<AssemblyInfo> Monkeys { get; private set; }

        public ListPage()
        {
            InitializeComponent();
            Monkeys = new List<AssemblyInfo>();
            Monkeys.Add(new AssemblyInfo
            {
                Name = "好友1",
                Location = "你好",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });
            Monkeys.Add(new AssemblyInfo
            {
                Name = "好友2",
                Location = "你好",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });
            Monkeys.Add(new AssemblyInfo
            {
                Name = "好友3",
                Location = "你好",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });
            Monkeys.Add(new AssemblyInfo
            {
                Name = "好友4",
                Location = "你好",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });
            Monkeys.Add(new AssemblyInfo
            {
                Name = "好友5",
                Location = "你好",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });
            Monkeys.Add(new AssemblyInfo
            {
                Name = "好友6",
                Location = "你好",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });
            Monkeys.Add(new AssemblyInfo
            {
                Name = "好友7",
                Location = "你好",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });
            Monkeys.Add(new AssemblyInfo
            {
                Name = "好友8",
                Location = "你好",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });
            BindingContext = this;
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            AssemblyInfo selectedItem = e.SelectedItem as AssemblyInfo;
            Console.WriteLine("触发selected" + selectedItem + "跳转页面");
            await Navigation.PushAsync(new MainPage());
            
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            AssemblyInfo tappedItem = e.Item as AssemblyInfo;
            Console.WriteLine("触发tapped" + tappedItem + "跳转页面");
        }
        async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }

}       