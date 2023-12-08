namespace MAUIBlazorCamera
{
    public partial class App:Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }

    public interface IAppInfoService
    {
        string GetApplicationName();
    }

    public class AppInfoService:IAppInfoService
    {
        public string GetApplicationName()
        {
            return "YourApp"; // Replace with your actual application name
        }
    }
}
