using System.Security.AccessControl;

namespace TaskList
{
   

        public partial class MainPage : ContentPage
        {
        public MainPage()
        {
            InitializeComponent();


            //toCreateTask.Clicked += ToCreateTaskPage;

            //Content = new StackLayout { Children = { toCreateTask } };
            

        } 
            private async void ToCreateTaskPage(object? sender, EventArgs e)
            {
                await Navigation.PushAsync(new CreateTaskPage());
            }
        }
    }
