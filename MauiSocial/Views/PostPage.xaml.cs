using System.Collections.ObjectModel;

namespace MauiSocial.Views;

public partial class PostPage : ContentPage
{
    int likes = 0;
    public int Likes
    {
        get => likes;
        set
        {
            if (likes != value)
            {
                likes = value;
                OnPropertyChanged();
            }

        }
    }
    public ObservableCollection<string> Comments { get; set; } = new ObservableCollection<string>() { "Cool car", "haha", "lool" } ;
    //List<string> comments = new List<string>() { "Cool car", "haha", "lool"};

    //public List<string> Comments
    //{
    //    get => comments;
    //    set
    //    {
    //        if (comments != value)
    //        {
    //            comments = value;
    //            OnPropertyChanged();
    //        }
    //    }
    //}
    public PostPage()
	{
		InitializeComponent();
        BindingContext = this;

	}
    private void Btn_Like_Clicked(object sender, EventArgs e)
    {
        Likes++;
        //LikesLabel.Text = $"{++likes} Likes";
    }

    private async void Btn_Comment_Clicked(object sender, EventArgs e)
    {
        var comment = await DisplayPromptAsync("Comment", "", "Send", "", "Add a comment");
        Comments.Add(comment);

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