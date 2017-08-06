using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elog
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string parameter)
        {
            InitializeComponent();
            this.Title = "Hi" + " " + parameter;
            Send_Data_Defi.IsVisible = false;
            Map_View_Defi.IsVisible = false;
            Logs_Defi.IsVisible = true;
            D_Logs.BackgroundColor = Color.FromHex("#0d47a1");
            D_Map_View.BackgroundColor = Color.FromHex("#3E88F2");
            D_Send_Data.BackgroundColor = Color.FromHex("#3E88F2");
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            bool isTogged = e.Value;
        }

        private void Switch_Toggled_1(object sender, ToggledEventArgs e)
        {
            bool isTogged_1 = e.Value;
        }

        private void D_Logs_Clicked(object sender, EventArgs e)
        {
            Send_Data_Defi.IsVisible = false;
            Map_View_Defi.IsVisible = false;
            Logs_Defi.IsVisible = true;
            D_Logs.BackgroundColor = Color.FromHex("#0d47a1");
            D_Map_View.BackgroundColor = Color.FromHex("#3E88F2");
            D_Send_Data.BackgroundColor = Color.FromHex("#3E88F2");
        }

        private void D_Send_Data_Clicked(object sender, EventArgs e)
        {
            Map_View_Defi.IsVisible = false;
            Logs_Defi.IsVisible = false;
            Send_Data_Defi.IsVisible = true;
            D_Send_Data.BackgroundColor = Color.FromHex("#0d47a1");
            D_Map_View.BackgroundColor = Color.FromHex("#3E88F2");
            D_Logs.BackgroundColor = Color.FromHex("#3E88F2");
        }

        private void D_Map_View_Clicked(object sender, EventArgs e)
        {
            Send_Data_Defi.IsVisible = false;
            Logs_Defi.IsVisible = false;
            Map_View_Defi.IsVisible = true;
            D_Map_View.BackgroundColor = Color.FromHex("#0d47a1");
            D_Logs.BackgroundColor = Color.FromHex("#3E88F2");
            D_Send_Data.BackgroundColor = Color.FromHex("#3E88F2");
        }
    }
}