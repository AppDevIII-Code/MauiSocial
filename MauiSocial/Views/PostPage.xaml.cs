using MauiSocial.Models;
using System.Collections.ObjectModel;

namespace MauiSocial.Views;

public partial class PostPage : ContentPage
{
    public Post Post {get;set;}

    public PostPage(Post post)
	{
		InitializeComponent();
        Post = post;
        BindingContext = Post;

	}
    private void Btn_Like_Clicked(object sender, EventArgs e)
    {
        Post.Likes++;
    }

    private async void Btn_Comment_Clicked(object sender, EventArgs e)
    {
        var comment = await DisplayPromptAsync("Comment", "", "Send", "", "Add a comment");
        if (string.IsNullOrEmpty(comment))
            return;
        Post.Comments.Add(new Comment("DotNet Bot",comment));

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