using EdmundKongKechMeng_FinalTest.MobileApp.ViewModels;

namespace EdmundKongKechMeng_FinalTest.MobileApp.Views;

public partial class Question3Page : ContentPage
{
	public Question3Page(Question3PageViewModel question3PageViewModel)
	{
		InitializeComponent();
        BindingContext = question3PageViewModel;
    }
}