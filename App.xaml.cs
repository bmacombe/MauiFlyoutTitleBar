namespace MauiFlyoutTitleBar;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TestFlyoutPage();
	}
}

public class TestFlyoutPage : FlyoutPage
{
	public TestFlyoutPage()
	{
		FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover;

		Flyout = new ContentPage
		{
			Title = "Flyout",
			BackgroundColor = Colors.Red,
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Flyout" }
				}
			}
		};

		var contentPage = new ContentPage
		{
			BackgroundColor = Colors.Green,
			Title = "Detail",
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Detail" }
				}
			}
		};

		Detail = new NavigationPage(contentPage);
		var button = new Button() { Text = "Menu" };
		button.Clicked += (s, e) => IsPresented = true;
		NavigationPage.SetTitleView(contentPage, button);
	}

	public override bool ShouldShowToolbarButton()
	{
		return false;
	}
}
