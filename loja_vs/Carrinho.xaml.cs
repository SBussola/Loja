public partial class Carrinho : ContentPage
{
    public Carrinho()
    {
        InitializeComponent();
    }

    public void BuscarOn(object sender, EventArgs e)
    {
        DisplayAlert("Compra", "Item adicionado ao carrinho!", "OK");
    }
}

