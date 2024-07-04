namespace Programas3716370
{
    public partial class App : Application
    {
        /// <summary>
        /// 
        /// </summary>
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Menu());
        }
    }
}
