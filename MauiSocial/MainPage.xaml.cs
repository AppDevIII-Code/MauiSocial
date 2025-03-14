using MauiSocial.Models;
using MauiSocial.Views;

namespace MauiSocial
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
 
  
        private void Btn_Like_Clicked(object sender, EventArgs e)
        {
            Post post = (Post)((ImageButton)sender).CommandParameter;
            post.Likes++;
        }
        private void Btn_Comments_Clicked(object sender, EventArgs e)
        {
            //var comment = await DisplayPromptAsync("Comment", "", "Send", "", "Add a comment");
            //if (string.IsNullOrEmpty(comment))
            //    return;
            //Post.Comments.Add(new Comment("DotNet Bot", comment));
        }
        private void Btn_Share_Clicked(object sender, EventArgs e)
        {
            //var result = await DisplayActionSheet("Share on...", "Cancel", null, ["iChat", "MSN Messenger", "Windows Live Messenger"]);
            //if (result != null)
            //{
            //    await DisplayAlert($"Shared on {result}", "gee, you're so old!", "Ok");
            //}
        }
    }

}
