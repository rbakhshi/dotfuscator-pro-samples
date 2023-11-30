using ClassLibrary1;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            Console.WriteLine(new Class1().GetValue());
            
            MainPage = new AppShell();
        }
    }
}