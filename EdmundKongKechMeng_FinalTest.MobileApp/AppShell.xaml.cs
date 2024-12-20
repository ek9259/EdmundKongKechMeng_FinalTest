using EdmundKongKechMeng_FinalTest.MobileApp.Views;

namespace EdmundKongKechMeng_FinalTest.MobileApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("MainPage", typeof(MainPage));
            Routing.RegisterRoute("Question1Page", typeof(Question1Page));
            Routing.RegisterRoute("Question2Page", typeof(Question2Page));
            Routing.RegisterRoute("Question3Page", typeof(Question3Page));
            Routing.RegisterRoute("AddPostPage", typeof(AddPostPage));
        }
    }
}
