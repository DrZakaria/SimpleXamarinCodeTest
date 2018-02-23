using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Simple.Views;
using Simple.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Simple
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetail, MasterDetailViewModel>();
            containerRegistry.RegisterForNavigation<MDChild, MDChildViewModel>();
            containerRegistry.RegisterForNavigation<MDChild1, MDChild1ViewModel>();
            containerRegistry.RegisterForNavigation<MDChild2, MDChild2ViewModel>();
            containerRegistry.RegisterForNavigation<PageName, PageNameViewModel>();
        }
    }
}
