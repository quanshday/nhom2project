using Nhom2Project.Model;
using Nhom2Project.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nhom2Project
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenOrder(object sender, EventArgs e)
        {
            if (OrderView.TranslationX >= 150)
            {
                Action<double> callback = input => OrderView.TranslationX = input;
                OrderView.Animate("anim", callback, 150, 0, 16, 300, Easing.CubicInOut);
            }
        }

        private void CloseOrder(object sender, EventArgs e)
        {
            if (OrderView.TranslationX == 0)
            {
                Action<double> callback = input => OrderView.TranslationX = input;
                OrderView.Animate("anim", callback, 0, 150, 16, 300, Easing.CubicOut);
            }
        }

        private void AddOrder(object sender, EventArgs e)
        {
            var item = (sender as Button).BindingContext as Food;
            vm.AddOrder(item);
        }

        private bool _IsBusy;
        public Command PayOrderCommand { get; set; }

        private async Task PayOrderCommandAsync(object sender, EventArgs e)
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Loi", ex.Message, "OK");
            }

            finally
            {
                IsBusy = false;
            }
        }
    }

}

//private async Task LoginCommandAsync()
//{
//    if (IsBusy)
//        return;
//    try
//    {
//        IsBusy = true;
//        var userService = new UserService();
//        Result = await userService.LoginUser(Username, Password);
//        if (Result)
//        {
//            Preferences.Set("Username", Username);
//            await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
//        }
//        else
//        {
//            await Application.Current.MainPage.DisplayAlert("Lỗi", "Tên đăng nhập hoặc mật khẩu không hợp lê", "Đồng ý");
//        }
//    }
//    catch (Exception ex)
//    {
//        await Application.Current.MainPage.DisplayAlert("Lỗi", ex.Message, "Đồng ý");

//    }
//    finally
//    {
//        IsBusy = false;
//    }