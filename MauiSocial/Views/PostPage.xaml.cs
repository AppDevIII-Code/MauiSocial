namespace MauiSocial.Views;

public partial class PostPage : ContentPage
{
    int likes = 0;
    public PostPage()
	{
		InitializeComponent();
	}
    private void Btn_Like_Clicked(object sender, EventArgs e)
    {
        likes += 1;
        LikesLabel.Text = $"{++likes} Likes";
    }

    private async void Btn_Comment_Clicked(object sender, EventArgs e)
    {
        await DisplayPromptAsync("Comment", "", "Send", "", "Add a comment");
    }

    private async void Btn_Share_Clicked(object sender, EventArgs e)
    {
        var result = await DisplayActionSheet("Share on...", "Cancel", null, ["iChat", "MSN Messenger", "Windows Live Messenger"]);
        if (result != null)
        {
            await DisplayAlert($"Shared on {result}", "gee, you're so old!", "Ok");
        }
    }
}