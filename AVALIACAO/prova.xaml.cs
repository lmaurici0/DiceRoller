namespace AVALIACAO
{
    public partial class prova : ContentPage
    {

        public prova()
        {
            InitializeComponent();
            SideNumberPicker.SelectedIndex = 0;
        }

        private void RollDice_Clicked(object sender, EventArgs e)
        {
            int max = Convert.ToInt16(SideNumberPicker.SelectedItem);
            int drawnNumber = new Random().Next(1, max + 1);
            DiceResult.Text = drawnNumber.ToString();
        }
    }

}