namespace loja_vs;

public partial class page1 : ContentPage
{
	public page1()
	{
		InitializeComponent();
	}
    private async void OnBuyButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Adicionado ao carrinho", "O produto foi adicionado ao carrinho.", "OK");
    }
}