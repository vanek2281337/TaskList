namespace TaskList;

public partial class CreateTaskPage : ContentPage
{
    public CreateTaskPage()
    {
        InitializeComponent();

    }
     public async void Send__Click(object s, EventArgs e)
    {
        if (Title.Text == "" || Description.Text == "")
        {
            await DisplayAlert( "error",  "error2",  "error3" );
           
        }

        if (Title.Text.Length > 0 && Description.Text.Length > 0)
        {
            
            await Navigation.PushAsync(new MainPage());
            
        }
    }

}