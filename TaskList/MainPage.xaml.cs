using System.Security.AccessControl;

namespace TaskList
{
   

        public partial class MainPage : ContentPage
        {
        public MainPage()
        {
            InitializeComponent();

        } 
            private async void ToCreateTaskPage(object? sender, EventArgs e)
            {
                await Navigation.PushAsync(new CreateTaskPage());
            }
        }
    }
