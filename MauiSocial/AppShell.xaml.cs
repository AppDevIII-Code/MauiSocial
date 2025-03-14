namespace MauiSocial
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        private void Btn_SwitchTheme_Clicked(object sender, EventArgs e)
        {

            switch (App.Current.UserAppTheme)
            {
                default:
                case AppTheme.Light:
                    App.Current.UserAppTheme = AppTheme.Dark;
                    break;
                case AppTheme.Dark:
                    App.Current.UserAppTheme = AppTheme.Light;
                    break;

            }
        }


    }
}
