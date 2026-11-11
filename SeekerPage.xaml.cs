namespace AskHub;

public partial class SeekerPage : ContentPage
{
    public SeekerPage()
    {
        InitializeComponent();

        // Asegura que la barra de navegación de Shell esté oculta
        Shell.SetNavBarIsVisible(this, false);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

#if ANDROID
        // Oculta la barra de estado superior de Android
        Microsoft.Maui.ApplicationModel.Platform.CurrentActivity?.Window?.AddFlags(Android.Views.WindowManagerFlags.Fullscreen);
        Microsoft.Maui.ApplicationModel.Platform.CurrentActivity?.Window?.ClearFlags(Android.Views.WindowManagerFlags.ForceNotFullscreen);
#endif
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

#if ANDROID
        // Restaura la barra de estado al salir de esta página (opcional)
        Microsoft.Maui.ApplicationModel.Platform.CurrentActivity?.Window?.ClearFlags(Android.Views.WindowManagerFlags.Fullscreen);
        Microsoft.Maui.ApplicationModel.Platform.CurrentActivity?.Window?.AddFlags(Android.Views.WindowManagerFlags.ForceNotFullscreen);
#endif
    }
}