using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elog
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public async Task SaveTodoItemAsync(string Username, string Password)
        {            
            var json = JsonConvert.SerializeObject(new { email = Username, password = Password });
            string data = json.ToString();
            HttpClient client = new HttpClient()
            {
                MaxResponseContentBufferSize = 256000
            };
            var RestUrl = "https://reqres.in/api/login";
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var request = await client.PostAsync(RestUrl, content);
            var response = await request.Content.ReadAsStringAsync();
            Test.Text = response;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await SaveTodoItemAsync(Username.Text, Password.Text);            
            //await Navigation.PushAsync(new Page1(Username.Text));            
        }
    }
}