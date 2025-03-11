namespace loja_vs
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateTo (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//page1");
        }

 
    }

}
