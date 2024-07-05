namespace Programas3716370
{
    public partial class App : Application
    {
        /// <summary>
        /// Constructor que permite el inicio y funcion de la app
        /// </summary>
        public App()
        {
            InitializeComponent();
            //permite la navegacion entre varios programas
            MainPage = new NavigationPage(new Menu());
        }
    }
}
