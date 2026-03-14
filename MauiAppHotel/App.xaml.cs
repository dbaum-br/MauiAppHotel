
namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

		protected override Window CreateWindow(IActivationState? activationState)
		{
            // Redimensionar janela principal
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 600;
			return window;
		}
    }
}
