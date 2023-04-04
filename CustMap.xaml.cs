using Map = Microsoft.Maui.Controls.Maps.Map;

namespace SalesPro;

public partial class CustMap : ContentPage
{
	public CustMap()
		{
			Map map = new Map();
			Content = map;		
		}   
}