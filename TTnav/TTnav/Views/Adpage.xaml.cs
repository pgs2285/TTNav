using CommunityToolkit.Maui.Views;

namespace TTnav.Views;

public partial class Adpage : Popup
{
	public Adpage()
	{
		InitializeComponent();
	}
    private void OnCloseClicked(object sender, EventArgs e)
    {
        Close(); // ¡ç ÆË¾÷ ´Ý±â
    }
}