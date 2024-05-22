using AVALIACAO.Models;

namespace AVALIACAO.View;

public partial class NewContent1 : ContentView
{
	public NewContent1()
	{
		InitializeComponent();
	}

	 private void RollDice_Clicked(object sender, EventArgs e)
    {
        int qunatidadeDeLados = Convert.ToInt32(SideNumberPicker.SelectedItem);
		Dado dado = new Dado(qunatidadeDeLados);
		dado.Rolar();
        DiceResult.Text = dado.NumeroSorteado.ToString();
    }
}