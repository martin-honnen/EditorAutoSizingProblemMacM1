namespace EditorAutoSizingProblemMacM1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}


    private void Test_Clicked(object sender, EventArgs e)
    {
		Editor1.Text += $"New lined added {DateTime.Now}{Environment.NewLine}";
	}
}

