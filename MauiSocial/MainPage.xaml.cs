using MauiSocial.Views;

namespace MauiSocial
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void Btn_ProfilePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void Btn_PostPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PostPage());
        }

        private async void Btn_CommentPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlexLayoutPage());
        }
    }

}
