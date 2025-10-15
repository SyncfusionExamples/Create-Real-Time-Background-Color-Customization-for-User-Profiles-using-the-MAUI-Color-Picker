namespace ColorPickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PaletteColorChanged(object sender, Syncfusion.Maui.Inputs.ColorChangedEventArgs e)
        {
            avatar.Background = e.NewColor;
        }
    }
}
