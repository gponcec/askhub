namespace AskHub
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /*
        private async void OnEnterClicked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SeekerPage));
        }*/

        private async void OnEnterClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            try
            {
                // 1. Autenticar con Firebase (ejemplo conceptual del plugin)
                // var user = await CrossFirebaseAuth.Current.SignAuthProvider.SignInWithEmailAndPasswordAsync(email, password);

                // 2. Guardar un indicador de sesión de forma segura en el dispositivo
                await SecureStorage.Default.SetAsync("auth_session", email);

                // 3. Navegar a la pantalla principal de la app (SeekerPage)
                // Usamos navegación absoluta para evitar que vuelva al login con el botón 'Atras'
                await Shell.Current.GoToAsync($"///SeekerPage");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error de acceso", "Credenciales incorrectas o error de red.", "OK");
            }
        }
    }
}
