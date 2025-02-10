using System.Collections.ObjectModel;

namespace MauiSocial.Views;

public partial class FlexLayoutPage : ContentPage
{
	string IMG_BASE_URI = "https://picsum.photos/";
	string IMG_EXT = ".jpg";
	int MIN_IMG_SIZE = 200;
	int MAX_IMG_SIZE = 220;
	Random rand = new Random();

	public ObservableCollection<string> ImgUrls { get; set; }
	public FlexLayoutPage()
	{
		InitializeComponent();
		ImgUrls = new ObservableCollection<string>();
		BindingContext = this;
	}

    private void Btn_AddImage_Clicked(object sender, EventArgs e)
    {
		var randImgUrl = GenerateRandomImgUrl();
		ImgUrls.Add(randImgUrl);
    }
	private string GenerateRandomImgUrl()
	{
		int randomSize = rand.Next(MIN_IMG_SIZE, MAX_IMG_SIZE);
		string imgUrl = $"{IMG_BASE_URI}/{randomSize}/{randomSize}{IMG_EXT}";

		return imgUrl;
	}
}