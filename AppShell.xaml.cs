namespace AskHub
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SeekerPage), typeof(SeekerPage));
        }
    }
}
