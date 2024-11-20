
namespace WydsanApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        internal void Run(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
